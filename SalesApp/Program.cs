using System;
using System.Windows.Forms;

namespace SalesApp
{
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Create (and reformat) the database
			Database db = new Database("salesapp.db").Reset().Connect().Execute(Properties.Resources.TestData);

            // start the application
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainScreen(db));
        }

        // A hack unitl I can figure out how to access the test data directly from the Test project
		public static String GetTestData()
        {         
            return Properties.Resources.TestData;
        }
    }   
}
