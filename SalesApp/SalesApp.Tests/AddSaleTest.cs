using NUnit.Framework;
using System.Collections.Generic;
using System;
namespace SalesApp.Tests
{
    [TestFixture()]
    public class AddSaleTest
    {
        [Test()]
		public void SaleIsAddedWithCorrectData()
        {
            // Do not initialise with test data so we know what sales we have
			Database database = new Database("testSalesAddedCorrectData.db").Reset().Connect();

			Sale sale = new Sale();
			sale
				.Add(new SaleItem(1, 10))
				.Add(new SaleItem(2, 4));

			database.AddSale(sale);
   
			List<int> ids = database.getListSaleIDs();

            // We did not insert any test data, so this should be the only sale
			Assert.AreEqual(1, ids.Count);

			Sale result = database.getSaleRecord(ids[0]);

            // Check the Sale data is copied correct
			Assert.AreEqual(sale.amountPaidCash, result.amountPaidCash);
			Assert.AreEqual(sale.amountPaidEftpos, result.amountPaidEftpos);

            // Check each item is copied correct
			for (int i = 0; i < sale.Items.Count; i++)
			{
				SaleItem expected = sale.Items[i];
				SaleItem actual = result.Items[i];

				Assert.AreEqual(expected.Asset, actual.Asset);
				Assert.AreEqual(expected.Qty, actual.Qty);
			}
        }

		[Test()]
		public void TestSalesDoNoOverwrite()
		{
			Database database = new Database("testSalesNoOverwrite.db").Reset().Connect();

			Sale sale_1 = new Sale().Add(new SaleItem(1, 5));
			Sale sale_2 = new Sale().Add(new SaleItem(2, 4));

			database.AddSale(sale_1);
			database.AddSale(sale_2);

			List<int> ids = database.getListSaleIDs();

			Assert.AreEqual(2, ids.Count);
		}
    }
}
