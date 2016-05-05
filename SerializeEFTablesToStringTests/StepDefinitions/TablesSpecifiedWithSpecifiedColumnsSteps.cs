using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using ApprovalTests;
using ApprovalTests.Reporters;
using ApprovalUtilities.SimpleLogger;
using FluentAssertions;
using NUnit.Framework;
using NUnit.Framework.Constraints;
using SerializeEFTablesToString;
using SerializeEFTablesToString.Tests.Models;
using SerializeEFTablesToStringTests.Models;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace SerializeEFTablesToStringTests.StepDefinitions
{
    [Binding]
    public class TablesSpecifiedWithSpecifiedColumnsSteps
    {
        private string parameterString;
        private IEnumerable<ResultsTableEntry> expectedResults;
        private CoreDB coreDb =new CoreDB();
        private IEnumerable<Policy_Option> policyOptions;
        private IEnumerable<PolicyDetail> policyDetails;

        [Given(@"the core DB is cleared")]
        public void GivenTheCoreDBIsCleared()
        {
            ClearCoreDb(coreDb);
        }

        [Given(@"a set of policies have been created")]
        public void GivenASetOfPoliciesHaveBeenCreated(Table table)
        {
            policyDetails = table.CreateSet<PolicyDetail>();
            foreach (var policyDetail in policyDetails)
            {
                CreateTestPolicy(policyDetail.policy_number, coreDb);
            }
        }

        [Given(@"a parameter string ""(.*)""")]
        public void GivenAParameterString(string p0)
        {
            parameterString = p0;
        }

        [Then(@"the required table and Columns should be output")]
        public void ThenTheRequiredTableAndColumnsShouldBeOutput(Table table)
        {
            expectedResults = table.CreateSet<ResultsTableEntry>();
            var actualResults = Formatter.ParseParameterString(parameterString);
            foreach (var tableDefinition in actualResults.TableDefinitions)
            {
                string parsedColumnList = tableDefinition.Columns.Aggregate((a, b) => a + "," + b);
                bool isExcluded = tableDefinition.IsExcluded;
                string expectedColumnList = expectedResults.Single(er => er.Table == tableDefinition.TableName).Columns;
                isExcluded.Should().Be(tableDefinition.IsExcluded);
                if (isExcluded)
                {
                    parsedColumnList.Should().NotContain(expectedColumnList);
                }
                else
                {
                    parsedColumnList.Should().Be(expectedColumnList);
                }
            }

        }
        

        [Given(@"data is provided for the Policy Option")]
        public void GivenDataIsProvidedForThePolicyOption(Table table)
        {
            policyOptions = table.CreateSet<Policy_Option>();
            foreach (var policyOption in policyOptions)
            {
                coreDb.Policies.Add(new Policy() {policy_number = "1"});
                coreDb.Policy_Component.Add(new Policy_Component() {policy_number = "1"});
                //coreDb.Policy_Option.Add(policyOption);
                coreDb.SaveChanges();
            }
        }
#if (NCRUNCH)
    [UseReporter(typeof(NCrunchReporter))]
#else
        [UseReporter(typeof(DiffReporter))]
#endif
        
        [Then(@"the output should be correct")]
        public void ThenTheOuputShouldBeCorrect()
        {

            Formatter formatter = new Formatter();
            Approvals.Verify(formatter.FormatEntities(coreDb, parameterString));


        }
        public static void ClearCoreDb(CoreDB coreDb)
        {
            
                coreDb.Database.ExecuteSqlCommand(@"DELETE FROM [dbo].[Triggers]
                                                    DELETE FROM [dbo].[PolicyComponentStatusHistory] 
                                                    DELETE FROM [dbo].[Underwriting_Decision_Evidence_Code]
                                                    DELETE FROM [dbo].[Policy_Option] 
                                                    DELETE FROM [dbo].[Party_Role] 
                                                    DELETE FROM [dbo].[Policy_Component]
                                                    DELETE FROM [dbo].[Policy] 
                                                    DELETE FROM [dbo].[Saved_Quote] 
                                                    DELETE FROM [dbo].[User_Saved_Item]   
                                                    DELETE FROM [dbo].[User] 
                                                    DELETE FROM [dbo].[Underwriting_Decision]  
                                                    DELETE FROM [dbo].[Party]
                                                    --DELETE FROM [dbo].[Expectations]
                                                    --DELETE FROM [dbo].[AllocationTokens]
                                                    --DELETE FROM [dbo].[AllocationRequests]
                                                    DELETE FROM [dbo].[WorkflowInitiationRequests]
                                                    SET IDENTITY_INSERT [dbo].[User] ON 
                                                    INSERT INTO [dbo].[User] 
                                                    ([user_id], [user_name], [email], [password], [bio], [language_code], [user_hierarchy_level], [party_unique_ref], [site_code], [email_verified], [status])
                                                     VALUES
                                                    (1, N'WEBUSER',N'webuser@internal.system',N'WEBUSER',NULL,N'GERMAN',1,N'SYSTEM:WEBUSER',N'CL_CUSTOMER',NULL,N'ACTIVE'),
                                                    (2, N'ADMIN',N'admin@internal.system',N'ADMIN',NULL,N'GERMAN',4,NULL,N'CL_ADMINISTRATION',1,N'ACTIVE'),
                                                    (4,N'Agent1',N'agent1@clccs.de',N'Apfelstrudel1',N'NULL',N'GERMAN',N'4',N'NULL',N'CL_ADMINISTRATION',N'1',N'ACTIVE'),
                                                    (5,N'Agent2',N'agent2@clccs.de',N'Apfelstrudel2',N'NULL',N'GERMAN',N'4',N'NULL',N'CL_ADMINISTRATION',N'1',N'ACTIVE'),
                                                    (6,N'Agent3',N'agent3@clccs.de',N'Apfelstrudel3',N'NULL',N'GERMAN',N'4',N'NULL',N'CL_ADMINISTRATION',N'1',N'ACTIVE'),
                                                    (7,N'Agent4',N'agent4@clccs.de',N'Apfelstrudel4',N'NULL',N'GERMAN',N'4',N'NULL',N'CL_ADMINISTRATION',N'1',N'ACTIVE'),
                                                    (8,N'Underwriter1',N'underwriter1@clccs.de',N'Apfelstrudel5',N'NULL',N'GERMAN',N'8',N'NULL',N'CL_ADMINISTRATION',N'1',N'ACTIVE'),
                                                    (9,N'Manager1',N'manager1@clccs.de',N'Apfelstrudel6',N'NULL',N'GERMAN',N'4',N'NULL',N'CL_ADMINISTRATION',N'1',N'ACTIVE')");
            
            
        }
        public void CreateTestPolicy(string policyNumber, CoreDB coreDb)
        {
            PolicyDetail policyDetail = policyDetails.First(p => p.policy_number == policyNumber);
                var return_value =
                    coreDb.Database.ExecuteSqlCommand(
                        @"[dbo].[AllInOneInsert] @p0, @p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8, @p9, @p10, @p11, @p12, @p13, @p14, @p15, @p16, @p17, @p18, @p19, @p20, @p21, @p22, @p23, @p24, @p25",
                        policyDetail.policy_number,
                        policyDetail.party_unique_ref,
                        policyDetail.party_row_id,
                        policyDetail.firstname,
                        policyDetail.surname,
                        policyDetail.gender,
                        policyDetail.date_of_birth,
                        policyDetail.product_component_code,
                        policyDetail.policy_component_id,
                        policyDetail.product_code,
                        policyDetail.uw_decision_id,
                        policyDetail.user_id,
                        policyDetail.user_name,
                        policyDetail.email,
                        policyDetail.password,
                        policyDetail.sum_assurmed,
                        policyDetail.insured_term,
                        policyDetail.quoted_amount,
                        policyDetail.requested_start_date,
                        policyDetail.calculated_total_premium,
                        policyDetail.calculated_base_premium,
                        policyDetail.payment_frequency,
                        policyDetail.risk_type_code,
                        policyDetail.entry_age,
                        policyDetail.last_usi_id,
                        policyDetail.last_usi);
                
            
        }
        private class ResultsTableEntry
        {
            public string Table { get; set; }
            public string Columns { get; set; }
            public bool IsExcluded { get; set; }
        }
    }

}
