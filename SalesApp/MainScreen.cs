﻿using System.Windows.Forms;

namespace SalesApp
{
    public partial class MainScreen : Form
    {
        public MainScreen(Database db)
        {
            InitializeComponent();
            addSaleControl.setDatabase(db);
            monthlyReportControl.setDatabase(db);
            displaySales1.setDatabase(db);
            editAssets1.setDatabase(db);
        }

        private void addSaleControl_Load(object sender, System.EventArgs e)
        {

        }

        private void tabControlMain_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            displaySales1.resetDataTables();
            displaySales1.updateSales();
            editAssets1.updateAssets();
        }

       
    }
}
