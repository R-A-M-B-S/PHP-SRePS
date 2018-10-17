using System.Windows.Forms;

namespace SalesApp
{
    public partial class MainScreen : Form
    {
        public MainScreen(Database db)
        {
            InitializeComponent();
            addSaleControl.SetDatabase(db);
            monthlyReportControl.SetDatabase(db);
            displaySales1.SetDatabase(db);
            predictionControl.SetDatabase(db);
        }

        private void tabControlMain_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            displaySales1.updateSales();
            monthlyReportControl.UpdateData();
        }
    }
}
