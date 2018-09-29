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

        public void setDatabase(Database db)
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

        private void UpdateData()
        {
            int theMonth = month.SelectedIndex;
            int theYear = (int)year.Value;

            // TODO fetch and update datatable
            // get data from database

            // clear the datatable
            DataTable dt = reportGrid.DataSource as DataTable;
            dt.Clear();

            /* TODO finish this:
             foreach (db_row : database.rows) {
                dt.Rows.Add(db_row.ItemNo, db_row.Description, db_row.NoSales);
             }
             */
        }
    }
}
