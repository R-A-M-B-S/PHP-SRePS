using System;
using System.Windows.Forms;
using System.Data.SQLite;

namespace SalesApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Create (and reformat) the database
            Database db = new Database("salesapp.db").Reset().Connect().Execute(Properties.Resources.SalesAppDatabaseInit);

            // start the application
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainScreen(db));
        }
    }
}
