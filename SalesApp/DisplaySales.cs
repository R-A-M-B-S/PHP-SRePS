using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SalesApp
{
    public partial class DisplaySales : UserControl
    {
        private Database db;
        private DataTable dt;
        private DataTable focused_dt;
        private bool saleListUpdated;

        public DisplaySales()
        {
			InitializeComponent();

            resetDataTables();
        }

        public void setSaleListUpdated()
        {
            this.saleListUpdated = false;
        }

        public void setDatabase(Database db)
        {
            this.db = db;
        }

        private void SalesData_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex; //get row identified
            int saleID = int.Parse(this.dt.Rows[rowindex]["SaleID"].ToString());
            updateSalesData(saleID);
        }

        private void updateSalesData(int saleID)
        {
            DataTable dt = db.getSaleRecord(saleID);
            SalesDataFocused.DataSource = dt;
            update_totals_info(dt);
            nowShowingLabel.Text = "Now Showing Sale: " + saleID;
        }

        public void resetDataTables()
        {
            //Reused from AddSale TODO Simplify
            DataTable dt = new DataTable();
            DataTable focused_dt = new DataTable();
            SalesData.DataSource = dt;
            SalesDataFocused.DataSource = focused_dt;
            this.dt = dt;
            this.focused_dt = focused_dt;

            dt.Columns.Add("SaleID");
            focused_dt.Columns.Add("ItemNo");
            focused_dt.Columns.Add("Description");
            focused_dt.Columns.Add("Item Price");
            focused_dt.Columns.Add("Qty");
            focused_dt.Columns.Add("SubPrice");

			try
			{
				SalesData.Columns["SaleID"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
				SalesDataFocused.Columns["ItemNo"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
				SalesDataFocused.Columns["Description"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
				SalesDataFocused.Columns["Item Price"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
				SalesDataFocused.Columns["Qty"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
				SalesDataFocused.Columns["SubPrice"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			}
			catch (NullReferenceException)
			{
			}
        }

        public void updateSales()
        {
            DataTable dt = SalesData.DataSource as DataTable;
            List<int> salesID = db.getListSaleIDs();
            if (salesID != null)
            {
                for (int i = 1; i <= salesID.Count; i++)
                {
                    dt.Rows.Add(salesID[i-1]);
                }
            }
        }


        private void update_totals_info(DataTable dt)
        {
            double sum = 0.0;
            foreach (DataRow row in dt.Rows)
            {
                string s_value = row["SubPrice"].ToString();
                double value = double.TryParse(s_value, out value) ? value : 0;
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

            //Get Paid Items

            
        }

        private void searchItemButton_Click(object sender, EventArgs e)
        {
            int searchID = int.Parse(saleIDValue.Value.ToString());
            updateSalesData(searchID);

        }


    }
}
