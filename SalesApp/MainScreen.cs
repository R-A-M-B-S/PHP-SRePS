using System.Windows.Forms;
using System;
using System.Text;

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
        }

        private void addSaleControl_Load(object sender, System.EventArgs e)
        {

        }

        private void tabControlMain_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            displaySales1.resetDataTables();
            displaySales1.updateSales();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {

        }
    }
}
