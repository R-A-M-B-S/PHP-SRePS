using System;
using System.Collections.Generic;

namespace SalesApp
{
    public class Sale
    {
		public readonly int saleId;
		public IList<SaleItem> Items = new List<SaleItem>();

        public Sale(int saleId)
        {
			this.saleId = saleId;
        }

		public Sale Add(SaleItem item)
		{
			Items.Add(item);

			return this;
		}
    }
}
