using NUnit.Framework;
using System;
namespace SalesApp.Tests
{
    [TestFixture()]
    public class SaleTest
    {
        [Test()]
        public void SaleCanBeCreated()
        {
			Sale sale = new Sale(2);

			Assert.AreEqual(2, sale.saleId);
        }

		[Test()]
		public void UnknownSaleIdIsMinusOne()
		{
			Sale sale = new Sale();

			Assert.AreEqual(-1, sale.saleId);
		}

		[Test()]
		public void SaleCalculatesSum()
		{
			// Asset 1: $1.50
			// Asset 2: $150
			// Asset 3: $10.40
			Database db = new Database("test.db").Reset().Connect().Execute(Program.GetTestData());

			Sale sale = new Sale();
			SaleItem item_1 = new SaleItem(1, 10);
			SaleItem item_2 = new SaleItem(2, 30);
			SaleItem item_3 = new SaleItem(3, 40);

			sale.Add(item_1).Add(item_2).Add(item_3);

			double subTotal = sale.subTotal(db);
			double tax = sale.Tax(db);
			double total = sale.TotalPrice(db);

			double subTotalExpected = 10 * 1.50 + 30 * 150 + 40 * 10.40;
			double taxExpected = subTotalExpected / 10;
			double totalExpected = subTotalExpected + taxExpected;

			Assert.AreEqual(subTotalExpected, subTotal);
			Assert.AreEqual(taxExpected, tax);
			Assert.AreEqual(totalExpected, total);
		}
    }
}
