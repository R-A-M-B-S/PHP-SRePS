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

        public DisplaySales()
        {
            InitializeComponent();

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
            Sale sale = db.getSaleRecord(saleID);
            DataTable dt = SalesDataFocused.DataSource as DataTable;
            dt.Clear();

            foreach (SaleItem item in sale.Items)
            {
                Asset asset = db.GetAsset(item.Asset);
                dt.Rows.Add(item.Asset, asset.name, asset.price, item.Qty, item.SubPrice(db));
            }

            update_totals_info(sale);
            nowShowingLabel.Text = "Now Showing Sale: " + saleID;
        }

        public void updateSales()
        {
            DataTable dt = SalesData.DataSource as DataTable;
            dt.Clear();

            List<int> salesID = db.getListSaleIDs();
            foreach (int id in salesID)
            {
                dt.Rows.Add(id);
            }
        }


        private void update_totals_info(Sale sale)
        {
            SubTotalValue.Text = sale.subTotal(db).ToString();
            TaxValue.Text = sale.Tax(db).ToString();
            TotalValue.Text = sale.TotalPrice(db).ToString();

            EftposValue.Text = sale.amountPaidEftpos.ToString();
            CashValue.Text = sale.amountPaidCash.ToString();
        }

        private void searchItemButton_Click(object sender, EventArgs e)
        {
            int searchID = int.Parse(saleIDValue.Value.ToString());
            updateSalesData(searchID);
        }
    }
}
