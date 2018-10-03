using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace SalesApp
{

    public partial class MonthlyReport : UserControl
    {
        private Database db;

        public MonthlyReport()
        {
            InitializeComponent();

            DataTable dt = new DataTable();
            reportGrid.DataSource = dt;

            dt.Columns.Add("ItemNo");
            dt.Columns.Add("Description");
            dt.Columns.Add("No. Sales");
                     
			try
			{
				reportGrid.Columns["ItemNo"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
				reportGrid.Columns["Description"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
				reportGrid.Columns["No. Sales"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			}
			catch (NullReferenceException)
			{
				// for some reason, on mono environments, the above columns havn't generated yet.
                // Since we're only targeting, windows, I'll just let it crash.
			}

            month.SelectedIndex = DateTime.Now.Month - 1;
            year.Value = DateTime.Now.Year;
        }

        public void SetDatabase(Database db)
        {
            this.db = db;
        }

        private void month_change(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void year_changed(object sender, EventArgs e)
        {
            UpdateData();
        }
       

        public void UpdateData()
        {
			if (db == null)
				return;

            int theMonth = month.SelectedIndex + 1;
			int theYear = (int)year.Value;

			// clear the datatable
			DataTable dt = reportGrid.DataSource as DataTable;
			dt.Clear();

			IDictionary<int, int> sales = db.CountAssetSales(theYear, theMonth);

			foreach (int assetID in sales.Keys)
			{
				int qty = sales[assetID];
				Asset asset = db.GetAsset(assetID);
				string desc = asset.name;
				dt.Rows.Add(asset.id, desc, qty);
			}
        }
        
    }
}
