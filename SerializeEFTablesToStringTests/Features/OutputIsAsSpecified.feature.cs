﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.0.0.0
//      SpecFlow Generator Version:2.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace SerializeEFTablesToStringTests.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.0.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("OutputIsAsSpecified")]
    public partial class OutputIsAsSpecifiedFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "OutputIsAsSpecified.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "OutputIsAsSpecified", "\tTo ensure that entities are rendered as specified \r\n\tby the paramters ", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Set up")]
        public virtual void SetUp()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Set up", ((string[])(null)));
#line 7
this.ScenarioSetup(scenarioInfo);
#line 8
 testRunner.Given("the core DB is cleared", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Number",
                        "policy_number",
                        "party_unique_ref",
                        "party_row_id",
                        "firstname",
                        "surname",
                        "gender",
                        "date_of_birth",
                        "product_component_code",
                        "PolicyComponentSequence",
                        "policy_component_id",
                        "product_code",
                        "uw_decision_id",
                        "user_id",
                        "user_name",
                        "email",
                        "password",
                        "sum_assured",
                        "insured_term",
                        "quoted_amount",
                        "requested_start_date",
                        "calculated_total_premium",
                        "calculated_base_premium",
                        "payment_frequency",
                        "IBAN",
                        "risk_type_code",
                        "entry_age",
                        "last_usi_id",
                        "last_usi"});
            table1.AddRow(new string[] {
                        "1",
                        "100000001B",
                        "ANNETTMÜLLER19961119001",
                        "1",
                        "Annett",
                        "Müller",
                        "Frau",
                        "1996-11-19",
                        "TERM_LIFE_01",
                        "1",
                        "1",
                        "CL01",
                        "1",
                        "100001",
                        "AnnettMüller",
                        "AnnettMüller@a.b",
                        "password0001",
                        "10000",
                        "35",
                        "100",
                        "2016/10/31 12:00:00 AM",
                        "100",
                        "100",
                        "12",
                        "DE39473544398981200114",
                        "NONE",
                        "19",
                        "1",
                        "1"});
            table1.AddRow(new string[] {
                        "2",
                        "100000002C",
                        "ANTJESCHMIDT19951120001",
                        "2",
                        "Antje",
                        "Schmidt",
                        "Frau",
                        "1995-11-20",
                        "TERM_LIFE_01",
                        "1",
                        "2",
                        "CL01",
                        "2",
                        "100002",
                        "AntjeSchmidt",
                        "AntjeSchmidt@a.b",
                        "password0001",
                        "20000",
                        "35",
                        "200",
                        "2016/04/09 12:00:00 AM",
                        "200",
                        "200",
                        "4",
                        "DE59504743126299026145",
                        "NONE",
                        "20",
                        "2",
                        "2"});
            table1.AddRow(new string[] {
                        "3",
                        "100000003D",
                        "BARBARASCHNEIDER19941120001",
                        "3",
                        "Barbara",
                        "Schneider",
                        "Frau",
                        "1994-11-20",
                        "TERM_LIFE_01",
                        "1",
                        "3",
                        "CL01",
                        "3",
                        "100003",
                        "BarbaraSchneider",
                        "BarbaraSchneider@a.b",
                        "password0001",
                        "30000",
                        "35",
                        "300",
                        "2016/03/28 12:00:00 AM",
                        "300",
                        "300",
                        "2",
                        "DE51370717347636311886",
                        "NONE",
                        "21",
                        "3",
                        "3"});
            table1.AddRow(new string[] {
                        "4",
                        "100000004E",
                        "BIRGITFISCHER19931120001",
                        "4",
                        "Birgit",
                        "Fischer",
                        "Frau",
                        "1993-11-20",
                        "TERM_LIFE_01",
                        "1",
                        "4",
                        "CL01",
                        "4",
                        "100004",
                        "BirgitFischer",
                        "BirgitFischer@a.b",
                        "password0001",
                        "40000",
                        "35",
                        "400",
                        "2016/10/07 12:00:00 AM",
                        "400",
                        "400",
                        "1",
                        "DE55412159066008472295",
                        "NONE",
                        "22",
                        "4",
                        "4"});
            table1.AddRow(new string[] {
                        "5",
                        "100000005F",
                        "BRIGITTEWEBER19921120001",
                        "5",
                        "Brigitte",
                        "Weber",
                        "Frau",
                        "1992-11-20",
                        "TERM_LIFE_01",
                        "1",
                        "5",
                        "CL01",
                        "5",
                        "100005",
                        "BrigitteWeber",
                        "BrigitteWeber@a.b",
                        "password0001",
                        "50000",
                        "35",
                        "500",
                        "2016/01/31 12:00:00 AM",
                        "500",
                        "500",
                        "12",
                        "DE50214683394118609559",
                        "NONE",
                        "23",
                        "5",
                        "5"});
#line 9
 testRunner.And("a set of policies have been created", ((string)(null)), table1, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Policy_Option is rendered correctly")]
        public virtual void Policy_OptionIsRenderedCorrectly()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Policy_Option is rendered correctly", ((string[])(null)));
#line 17
this.ScenarioSetup(scenarioInfo);
#line 18
 testRunner.Given("a parameter string \"Policy_Option[!policy_option_id]\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 19
 testRunner.Then("the output should be correct", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute(": Policy_Component and  Policy Option Rendered Correctly")]
        public virtual void Policy_ComponentAndPolicyOptionRenderedCorrectly()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo(": Policy_Component and  Policy Option Rendered Correctly", ((string[])(null)));
#line 21
this.ScenarioSetup(scenarioInfo);
#line 22
 testRunner.Given("a parameter string \"Policy_Component[!policy_component_id;last_usi_id],Policy_Opt" +
                    "ion[policy_number;product_component_code]\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 23
 testRunner.Then("the output should be correct", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
