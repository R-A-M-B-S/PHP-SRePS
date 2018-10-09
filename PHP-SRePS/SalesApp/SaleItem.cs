using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesApp
{
    public class SaleItem
    {
        public int Asset { get; }
        public int Qty { get; }

        public SaleItem(int assetId, int qty)
        {
            Asset = assetId;
            Qty = qty;
        }

        public double SubPrice(Database db) {
            Asset asset = db.GetAsset(Asset);
            return asset.price * Qty;
        }
    }
}
