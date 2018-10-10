using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SalesApp
{
    public partial class EditAssets : UserControl
    {
        private Database db;
        private DataTable dt;
        private DataTable focused_dt;
        private bool saleListUpdated;

       
        public EditAssets()
        {
            InitializeComponent();
            resetDataTables();
      
        }

        public void resetDataTables()
        {
            //Reused from AddSale TODO Simplify
            if (db != null)
            {
                updateAssets();

                SalesData.Columns["AssetID"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                SalesData.Columns["ItemNo"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                SalesData.Columns["Description"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                SalesData.Columns["Item Price"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                SalesData.Columns["Qty"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }

        public void setDatabase(Database db)
        {
            this.db = db;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            int qty = 0;
            int id = 0;
            double price = 0;
            string name = textBox1.Text;
            string desc = textBox2.Text;
            try
            {
                qty = int.Parse(textBox3.Text);
            }
            catch (FormatException ex)
            {
                try
                {
                    qty = int.Parse(textBox6.Text);
                }
                catch (FormatException exc)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            try
            {
                id = int.Parse(textBox4.Text);
            }
            catch (FormatException f)
            {
                Console.WriteLine(f.Message);
            }
            try
            {
                price = int.Parse(textBox5.Text);
            }
            catch (FormatException exception)
            {
                Console.WriteLine(exception.Message);
            }
            db.ChangeAsset(name, desc, qty, id, price);
            label6.Text = "Information: " + name + " " + desc + " " + qty + " " + price;
            updateAssets();
            //Reset textboxs
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";           
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
        }

        public void updateAssets()
        {
            DataTable dt = db.getAllAssetRecord();

            SalesData.DataSource = dt;
            this.dt = dt;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void EditAssets_Load(object sender, EventArgs e)
        {

        }

        private void SalesDataFocused_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1_Click(sender, e);
        }
    }
}
