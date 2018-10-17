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
    public partial class predictionControl1 : UserControl
    {
        private Database db;

        public predictionControl1()
        {
            InitializeComponent();
        }

        public void SetDatabase(Database db)
        {
            Console.WriteLine("the database " + db);
            this.db = db;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("the database " + db);

            int prevMonths = 4;
            string Month = "";
            List<int> Predicted_List = new List<int>();

            Predicted_List = Prediction.GetSalesProjection(db, prevMonths);

            int currentMonth = DateTime.Now.Month;
            foreach (int Predicted in Predicted_List)
            {

                if (currentMonth < 0) currentMonth = 11;

                switch (currentMonth)
                {
                    case 0:
                        Month = "JAN";
                        break;
                    case 1:
                        Month = "FEB";
                        break;
                    case 2:
                        Month = "MAR";
                        break;
                    case 3:
                        Month = "APR";
                        break;
                    case 4:
                        Month = "MAY";
                        break;
                    case 5:
                        Month = "JUN";
                        break;
                    case 6:
                        Month = "JUL";
                        break;
                    case 7:
                        Month = "AUG";
                        break;
                    case 8:
                        Month = "SEP";
                        break;
                    case 9:
                        Month = "OCT";
                        break;
                    case 10:
                        Month = "NOV";
                        break;
                    case 11:
                        Month = "DEC";
                        break;
                    default:
                        Month = "No Month of that number";
                        break;
                }
                currentMonth -= 1;
                chart_Prediction.Series["Sales"].Points.AddXY(Month, Predicted);
            }
        }
    }
}
