using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace SerializeEFTablesToString
{
    public class Formatter
    {
        /// <summary>
        /// Given an Entity framework DbContext this utility formats all rows from
        /// the list of tables given in the 'includedTables' parameter (a List of string )
        /// containing a list of the TABLE names required and outputs a header row and 
        /// data rows with each column name and value pipe delimited ("|").
        /// </summary>
        /// <param name="context">An Entity Framework DbContext pointing to the 
        /// tables to be formatted and output in the returned string</param>
        /// <param name="parameterString"> lists the tables
        /// to be included or excluded using the Table names NOT the Entity names..</param>
        /// <returns>string containing one line per row including headers </returns>
        public string FormatEntities(DbContext context, string parameterString)
        {
            var parsedTablesAndColumns = ParseParameterString(parameterString);
            List<string> formattedOutput = new List<string>();
            List<string> tablesToOutput = new List<string>();
            using (var db = context)
            {
                foreach (var table in parsedTablesAndColumns.TableDefinitions)
                {
                    var columns = db.Database
                        .SqlQuery<string>(
                            $"SELECT column_name FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = N'{table.TableName}'")
                        .ToList();
                    columns = columns.Select(c => "["+c+"]").ToList();
                    
                   
                    if(table.Columns[0] != "*" &&  !columns.Intersect(table.Columns).Any())
                        throw new ArgumentException("One or more specified columns do not exist in the table");
                    if (table.Columns[0] != "*")
                    {
                        columns = table.IsInclude ? table.Columns : columns.Except(table.Columns).ToList();
                    }
                    
                     
                    string columnList = String.Empty;
                    string commandColumns = String.Empty;
                    columns.ForEach(c => columnList = columnList + ",'|'," + c );
                    columnList = columnList.Substring(1);
                    columns.ForEach(c => commandColumns = commandColumns + ",'|'," +"+ coalesce(convert(varchar," + c + "),'NULL')");
                    commandColumns = commandColumns.Substring(1);

                    formattedOutput.Add(Environment.NewLine+parameterString);
                    string header = columnList.Replace("'", "").Replace(",", "") + "|";
                  
                    string sqlCommand = $"select concat({commandColumns + ",'|'"}) from {table.TableName}";
                    List<string> results = new List<string>(); 
                    results.Add(header);
                    results.AddRange(db.Database.SqlQuery<string>(sqlCommand).ToList());
                    
                    formattedOutput.AddRange(ReformatLines(results));
                    
                }
                string resultString = string.Empty;
                
                foreach (var reformattedLine in formattedOutput)
                {
                    resultString = resultString + reformattedLine+Environment.NewLine;
                }
                return resultString ;//= reformatted.ForEach(r=> reformatted = reformatted + r);
            }
        }

        private static string RemoveWikiJunk(string data)
        {
            data = data.Trim();
            data =
                data.Replace(@"\\", String.Empty)
                    .Replace(@"&nbsp;", @" ")
                    .Replace(@"\#", @"#")
                    .Replace(@"\!", @"!")
                    .Replace(@"||", @"|")
                    .Replace(@"/|", @"|");

            var pattern = @"\{color:#\w*\}|\{color\}";
            var rgx = new Regex(pattern);
            data = rgx.Replace(data, String.Empty);

            pattern = "^/-.*/-$";
            rgx = new Regex(pattern);
            data = rgx.Replace(data, String.Empty);

            return data;
        }

        private static List<string> ReformatLines(List<string> featureFileLines)
        {
            try
            {
                var input = featureFileLines.Select(s => RemoveWikiJunk(s)).ToList();
                for (var i = 0; i < input.Count; i++)
                {
                    if (input[i].Trim().StartsWith("|"))
                    {
                        for (var j = i + 1; j <= input.Count; j++)
                        {
                            if (j == input.Count || input[j].Trim().StartsWith("|") == false)
                            {
                                var pipeTable = new List<string>();
                                for (int k = i; k < j; k++)
                                {
                                    var escapedBarLine = input[k].Trim().Replace(@"\|", @"~~");
                                    pipeTable.Add(escapedBarLine);
                                }

                                pipeTable = ReformatPipeTable(pipeTable, i + 1);

                                for (int k = i; k < j; k++)
                                {
                                    input[k] = pipeTable[0].Replace(@"~~", @"\|");
                                    pipeTable.RemoveAt(0);
                                }

                                i = j;
                                j = input.Count;
                            }
                        }
                    }
                }
                input = AddBlankLineAfterTable(input);
                var inputText = new StringBuilder(String.Empty);
                for (int ndx = 0; ndx <= input.Count - 1; ndx++)
                {
                    if (ndx < input.Count - 1)
                    {
                        inputText.AppendLine(input[ndx]);
                    }
                    else
                    {
                        inputText.Append(input[ndx]);
                    }
                }
                return input;
            }
            catch (Exception ex)
            {
                throw new Exception("FORMATTING EXCEPTION:\n\n{0}\n-----\nPress OK to continue " + ex.ToString() +
                                    @"Reformatting Error");
            }
        }
        private static List<string> AddBlankLineAfterTable(List<string> input)
        {
            var ret = new List<string>();
            var lineIsTable = false;
            foreach (string inputLine in input)
            {
                if (inputLine.Trim().StartsWith(@"|"))
                {
                    lineIsTable = true;
                }
                else if (lineIsTable)
                {
                    if (!String.IsNullOrWhiteSpace(inputLine.Trim()))
                    {
                        if (input.Count != ret.Count)
                        {
                            ret.Add(String.Empty);
                        }
                    }

                    lineIsTable = false;
                }

                ret.Add(inputLine);
            }

            return ret;
        }
        public static List<string> ReformatPipeTable(List<string> pipeTable, int startingLineFromMainFile = 0)
        {
            var output = new List<string>();
            var data = new Dictionary<int, string>();
            var maxWidth = new Dictionary<int, int>();

            if (pipeTable.Any(row => row.StartsWith("|") == false || row.EndsWith("|") == false))
            {
                Console.WriteLine(@"All table rows must begin and end with a |pipe| character.");
                return pipeTable;
            }

            var pipeCount = 0;
            foreach (string lne in pipeTable)
            {
                var lclCnt = lne.Count(f => f == '|');
                if ((lclCnt != pipeCount) && (pipeCount > 0))
                {
                    return pipeTable;
                }
                else
                {
                    pipeCount = lclCnt;
                }
            }

            // Number of "columns" is pipeCount - 1
            var colCount = pipeCount - 1;
            for (var i = 0; i < colCount; i++)
            {
                maxWidth.Add(i, 0);
            }

            // Iterate through all "row"s
            foreach (var s in pipeTable)
            {
                // Process:
                for (var i = 0; i < colCount; i++)
                {
                    // List<int> to store maximum field lengths for each "column" (using .Trim()'d data)
                    var value = s.Trim('|').Split('|')[i].Trim();
                    maxWidth[i] = Math.Max(maxWidth[i], value.Length);
                }
            }

            // Rewrite each "row" with all data padded to the max field length of that column with leading and trailing space for legibility
            foreach (var s in pipeTable)
            {
                var values = s.Trim('|').Split('|');

                if (values.Length == colCount)
                {
                    for (var i = 0; i < colCount; i++)
                    {
                        var temp = values[i].Trim() + new string(' ', maxWidth[i]);
                        values[i] = temp.Substring(0, maxWidth[i]);
                    }

                    output.Add(String.Format("| {0} |", String.Join(" | ", values)));
                }
                else
                {
                    output.Add(s);
                }
            }

            return output;
        }

        public static ParsedTablesAndColumns ParseParameterString(string parameterString)
        {
            Regex parameterValidationRegex = new Regex(@"(.*(\[|\[\!)((.*,)|(.*))*\](,|)|(.*))*");
            if (!parameterValidationRegex.IsMatch(parameterString))
            {
                throw new ArgumentException("Parameter not in correct format, must be of the form, eg. 'tableName1, tableName2[], tableName3[column1,column2], tableName4[!column1,column2] ");
            }
            if (string.IsNullOrEmpty(parameterString))
                throw new ArgumentException("No tables requested");
            string[] requestedTables = parameterString.Split(',');
            if (requestedTables.Length == 0)
                throw new ArgumentException("Parameter string must contain a Table name");
            var parsedTablesAndColumns = new ParsedTablesAndColumns();
            foreach (var tableDefinition in requestedTables)
            {
                var modifiedTableDefinition = tableDefinition;
                var parsedTableDefinition = new ParsedTablesAndColumns.TableDefinition();
                if (string.IsNullOrEmpty(tableDefinition))
                    throw new ArgumentException("Table Definition Empty");
                int indexOfExclamation = tableDefinition.IndexOf("!");
                if (tableDefinition.Contains("!")) //  now look for the next character being '['
                    if (tableDefinition[indexOfExclamation - 1] != '[')
                        throw new ArgumentException("Invalid Syntax");
                    else
                    {
                        parsedTableDefinition.IsExcluded = true;
                        modifiedTableDefinition = tableDefinition.Replace("!", "");
                    }
                string[] tableDefinitionComponent = modifiedTableDefinition.Split('[');
                if (string.IsNullOrEmpty(tableDefinitionComponent[0]))
                    throw new ArgumentException("Table name not supplied");
                if (tableDefinitionComponent.Length > 2)
                    throw new ArgumentException("Columns parameter incorrect");
                parsedTableDefinition.TableName = tableDefinitionComponent[0];

                if (tableDefinitionComponent.Length == 1)
                    parsedTableDefinition.Columns.Add("*");
                else
                {
                    if (tableDefinitionComponent[1].EndsWith("]"))
                    {
                        tableDefinitionComponent[1] = tableDefinitionComponent[1].Replace("]", "");
                    }
                    parsedTableDefinition.Columns = ParseColumnsString(tableDefinitionComponent[1]);
                }
                parsedTablesAndColumns.TableDefinitions.Add(parsedTableDefinition);
            }

            return parsedTablesAndColumns;
        }

        private static List<string> ParseColumnsString(string columnsString)
        {
            if (columnsString.Length == 0)
                return new List<string>() { "*" };
            List<string> columns = columnsString.Split(';').ToList();
            columns = columns.Select(c => "[" + c + "]").ToList();
            return columns;
        }
       
        public class ParsedTablesAndColumns
        {
            public ParsedTablesAndColumns()
            {
                TableDefinitions = new List<TableDefinition>();
            }

            public List<TableDefinition> TableDefinitions { get; set; }

            public class TableDefinition
            {
                public TableDefinition()
                {
                    Columns = new List<string>();
                }

                public string TableName { get; set; }
                public bool IsExcluded { get; set; }
                public bool IsInclude => !IsExcluded;
                public List<string> Columns { get; set; }
            }

        }
    }
}
