using System.IO;
using Mono.Data.Sqlite;
using System.Collections.Generic;
using System;

namespace SalesApp
{
    public class Database
    {

		private SqliteConnection dbConn;
        private readonly string filename;

        public Database(string filename)
        {
            this.filename = filename;
        }

        public Database Reset()
        {
            File.Delete(filename);
            return this;
        }

        public Database Execute(string sql)
        {
            new SqliteCommand(sql, dbConn).ExecuteNonQuery();
            return this;
        }

        public Database Connect()
        {
            if (!File.Exists(filename))
                SqliteConnection.CreateFile(filename);
            dbConn = new SqliteConnection("Data Source=" + filename + ";Version=3");
            dbConn.Open();
            return this;
        }

        public void AddSale(List<SaleItem> items, double amountPaid)
        {
            string sql = "insert into SalesRecord (AmountPaid) VALUES ("+ amountPaid + "); SELECT last_insert_rowid()";
            SqliteCommand command = new SqliteCommand(sql, dbConn);
            string row_id = command.ExecuteScalar().ToString();

            foreach (SaleItem item in items)
            {
                sql = "INSERT INTO SalesAssets(SaleId, AssetId, Qty) VALUES ("+ row_id +", "+item.Asset+", "+item.Qty+")";
                command = new SqliteCommand(sql, dbConn);
                command.ExecuteNonQuery();
            }
        }

        public string GetAssetName(int assetID)
        {
            string sql = "SELECT Name from Asset WHERE AssetID = " + assetID;
            SqliteCommand command = new SqliteCommand(sql, dbConn);
            object o_name = command.ExecuteScalar();
            if (o_name != null)
                return o_name.ToString();
            return "";
        }

        public double GetAssetPrice(int assetID)
        {
            string sql = "SELECT Price from Asset WHERE AssetID = " + assetID;
            SqliteCommand command = new SqliteCommand(sql, dbConn);
            object o_price = command.ExecuteScalar();
            if (o_price != null)
            {
                double price = Double.TryParse(o_price.ToString(), out price) ? price : 0;
                return price;
            }
            return 0;
        }
    }
}
