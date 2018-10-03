using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace SalesApp
{
    public partial class AddSale : UserControl
    {
        private Database db;
        private DataTable dt;

        public AddSale()
        {
            InitializeComponent();

            DataTable dt = new DataTable();
            SalesData.DataSource = dt;
            this.dt = dt;

            dt.Columns.Add("ItemNo");
            dt.Columns.Add("Description");
            dt.Columns.Add("Item Price");
            dt.Columns.Add("Qty");
            dt.Columns.Add("SubPrice");

			try
			{
				SalesData.Columns["ItemNo"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
				SalesData.Columns["Description"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
				SalesData.Columns["Item Price"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
				SalesData.Columns["Qty"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
				SalesData.Columns["SubPrice"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			}
			catch (NullReferenceException)
			{
			}
        }

        public void setDatabase(Database db)
        {
            this.db = db;
        }

        // Called from changing the value in the Eftpos box
        private void EftposChanged(object sender, EventArgs e)
        {
            CashValue.Value = 0;
            UpdateFinaliseStatus();
        }

        // Called from changing the value in the cash box
        private void CashChanged(object sender, EventArgs e)
        {
            EftposValue.Value = 0;
            UpdateFinaliseStatus();
        }

        private void UpdateFinaliseStatus()
        {
            decimal total = Decimal.TryParse(TotalValue.Text, out total) ? total : 0;
            FinaliseButton.Enabled = CashValue.Value + EftposValue.Value >= total;
        }

        // Called from clicking on the AddItem button
        private void AddItem(object sender, EventArgs e)
        {
            bool added = false;
            int itemno = (int)assetValue.Value;
            int qty = (int)qtyValue.Value;
                     
            Asset asset = db.GetAsset(itemno);

            // If value exists, update it
			foreach (DataRow row in dt.Rows)
            {
                if (row["ItemNo"].ToString().Equals(itemno.ToString()))
                {
                    int newQty = int.Parse(row["Qty"].ToString()) + qty;
					SaleItem item = new SaleItem(asset.id, newQty);
					row["Qty"] = newQty;
					row["SubPrice"] = item.SubPrice(db);
                    added = true;
                }
            }

			if (!added)
			{
				SaleItem item = new SaleItem(asset.id, qty);
				// Make sure the params here match the order of the datatable
				dt.Rows.Add(itemno, asset.name, asset.price, qty, item.SubPrice(db));
			}
        
            update_totals_info();
        }

        private void update_totals_info()
        {
			Sale sale = makeSale();

			SubTotalValue.Text = sale.subTotal(db).ToString();
			TaxValue.Text = sale.Tax(db).ToString();
			TotalValue.Text = sale.TotalPrice(db).ToString();

            UpdateFinaliseStatus();
        }

		private Sale makeSale()
		{
			Sale sale = new Sale();
            foreach (DataRow row in dt.Rows)
            {
                string s_item = row["ItemNo"].ToString();
                string s_qty = row["Qty"].ToString();

                int item = -1, qty = 1;
                try
                {
                    // if either the item or qty are improperlly formatted, ignore the row
                    item = int.Parse(s_item);
                    qty = int.Parse(s_qty);

                    sale.Add(new SaleItem(item, qty));
                }
                catch (FormatException) { };
            }

            sale.amountPaidCash = (double)CashValue.Value;
            sale.amountPaidEftpos = (double)EftposValue.Value;

			return sale;
		}

        private void finalise_sale(object sender, MouseEventArgs e)
        {         
			Sale sale = makeSale();
			db.AddSale(sale);
            dt.Clear();
            update_totals_info();
            CashValue.Value = 0;
            EftposValue.Value = 0;
        }
    }
}
