using System.Windows.Forms;

namespace SalesApp
{
    public partial class MainScreen : Form
    {
        public MainScreen(Database db)
        {
            InitializeComponent();
            addSaleControl.setDatabase(db);
            monthlyReportControl.SetDatabase(db);
            displaySales1.setDatabase(db);
        }

        private void tabControlMain_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            displaySales1.updateSales();
            monthlyReportControl.UpdateData();
        }
    }
}
