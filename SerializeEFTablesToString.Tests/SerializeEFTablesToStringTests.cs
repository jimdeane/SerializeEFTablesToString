using System.Collections.Generic;
using ApprovalTests;
using ApprovalTests.Reporters;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SerializeEFTablesToString.Tests.Models;
using TestAsp.NetMvcFluentModelBinding.Models;

namespace SerializeEFTablesToString.Tests
{
    [TestClass]
    public class ComplexObjectsToUseWithApprovalTests
    {
        CoreDB coreDb = new CoreDB();
        MoneyDB moneyDb = new MoneyDB();
        
        [TestMethod]
       [UseReporter(typeof(WinMergeReporter))]
        public void TestIteratingOverCoreDbContext()
        {
            List<string> moneyTables = new List<string>()
            { "Mandates","MoneyInTokens"};
            Formatter formatter = new Formatter();   
            
            string result = formatter.FormatEntities(moneyDb, moneyTables);
            Approvals.Verify(result);

        }
        [TestMethod]
        [UseReporter(typeof(WinMergeReporter))]
        public void TestIteratingOverMoneyDbContext()
        {
            List<string> coreTables = new List<string>()
            { "Policy", "Party", "Policy_Component", "Policy_Option"};
            Formatter formatter = new Formatter();
            string result = formatter.FormatEntities(coreDb, coreTables);
            Approvals.Verify(result);
        }
        
    }
}