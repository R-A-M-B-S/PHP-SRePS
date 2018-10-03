using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            string name = db.GetAssetName(itemno);
            double price = db.GetAssetPrice(itemno);

            int qty = (int)qtyValue.Value;
            double subPrice = price * qty;  

            // Make sure the params here match the order of the datatable
            //If value exists, update it
            for(int i = 1; i <= dt.Rows.Count; i++)
            {
                if (dt.Rows[i-1]["ItemNo"].ToString().Equals(itemno.ToString()))
                {
                    double newQty = double.Parse(dt.Rows[i-1]["Qty"].ToString()) + qty;
                    dt.Rows[i - 1]["Qty"] = newQty;
                    dt.Rows[i - 1]["SubPrice"] = newQty * price;
                    added = true;
                }
               
            }

            if (!added) { dt.Rows.Add(itemno, name, price, qty, subPrice); }
        
            update_totals_info(dt);
        }

        private void update_totals_info(DataTable dt)
        {
            double sum = 0.0;
            foreach (DataRow row in dt.Rows)
            {
                String s_value = row["SubPrice"].ToString();
                double value = Double.TryParse(s_value, out value) ? value : 0;
                sum += value;
            }

            // TODO refractor these calcs into a new function and unit test it.
            // Make sure that it's not possible to be sub-cents in the calcs
            // Also, unit test that the sum is calculated right
            double tax = Math.Floor(sum * 100 * 0.1) / 100; // assume tax is 10%
            double total = tax + sum;

            SubTotalValue.Text = sum.ToString();
            TaxValue.Text = tax.ToString();
            TotalValue.Text = total.ToString();

            UpdateFinaliseStatus();
        }

        private void finalise_sale(object sender, MouseEventArgs e)
        {
            DataTable dt = SalesData.DataSource as DataTable;

            List<SaleItem> items = new List<SaleItem>();
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

                    items.Add(new SaleItem(item, qty));
                }
                catch (FormatException) { };
            }

            double amountPaid = (double)(CashValue.Value + EftposValue.Value);
            db.AddSale(items, (double)CashValue.Value, (double)EftposValue.Value);

            dt.Clear();
        }
    }
}
