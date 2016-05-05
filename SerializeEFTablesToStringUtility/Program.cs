using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Data.Entity;
using System.Reflection;

namespace SerializeEFTablesToStringUtility
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> arguments = args.ToList();
            var assembly = Assembly.LoadFile(@"C:\VS\CIFF\Main\DEV\Source\SerializeEFTablesToString\SerializeEFTablesToStringTests\bin\Debug\SerializeEFTablesToStringTests.dll");
            DbContext context = (DbContext)assembly.CreateInstance("SerializeEFTablesToString.Tests.Models.CoreDB");
            
            var results = context.Database.SqlQuery<string>("select policy_number from Policy").ToList();
            results.ForEach(Console.WriteLine);
            Console.ReadLine();
        }
    }
}
