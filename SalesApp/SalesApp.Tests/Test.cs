using NUnit.Framework;
using System;

namespace SalesApp.Tests
{
    [TestFixture()]
    public class Test
    {
        [Test()]
        public void TestCase()
        {
			Sale sale = new Sale(1);
			Assert.AreEqual(sale.saleId, 1);
        }
    }
}
