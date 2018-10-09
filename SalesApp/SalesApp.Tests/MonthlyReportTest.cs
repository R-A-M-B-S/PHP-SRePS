using NUnit.Framework;
using System.Collections.Generic;
using System;
namespace SalesApp.Tests
{
    [TestFixture()]
    public class MonthlyReportTest
    {
        [Test()]
        public void TestMonthlyCountIsCorrect()
        {
			// Test data has:
			//   Asset 1 x14
            //   Asset 2 x12
            //   Asset 3 x15
            //   Asset 4 x3
			Database db = new Database("test.db").Reset().Connect().Execute(Program.GetTestData());
            
			IDictionary<int, int> count = db.CountAssetSales(DateTime.Now.Year, DateTime.Now.Month);

			Assert.AreEqual(14, count[1]);
			Assert.AreEqual(12, count[2]);
			Assert.AreEqual(15, count[3]);
			Assert.AreEqual(3,  count[4]);
        }
    }
}
