using System;
using System.Collections.Generic;

namespace SalesApp
{
    public class Sale
    {
		public readonly int saleId;
		public IList<SaleItem> Items = new List<SaleItem>();
		public double amountPaidCash, amountPaidEftpos;

		public Sale()
		{
			this.saleId = -1;
		}

        public Sale(int saleId)
        {
			this.saleId = saleId;
        }

		public Sale Add(SaleItem item)
		{
			Items.Add(item);

			return this;
		}

		public double subTotal(Database db)
		{
			double subTotal = 0;
			foreach (SaleItem item in Items)
			{
				subTotal += item.SubPrice(db);            
			}
			return subTotal;
		}

		public double Tax(Database db)
		{
			return Math.Floor(subTotal(db) * 100 * 0.1) / 100; // assume 10% tax
		}

		public double TotalPrice(Database db)
		{
			return subTotal(db) + Tax(db);
		}
    }
}
