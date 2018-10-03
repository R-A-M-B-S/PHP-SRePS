using System.IO;
using Mono.Data.Sqlite;
using System.Collections.Generic;
using System;
using System.Data;

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

        public void AddSale(Sale sale)
        {
			string sql = "insert into SalesRecord (AmountPaidCash, AmountPaidEftpos) VALUES (" + sale.amountPaidCash + ", " + sale.amountPaidEftpos + "); SELECT last_insert_rowid()";
            SqliteCommand command = new SqliteCommand(sql, dbConn);
            string row_id = command.ExecuteScalar().ToString();
   
			foreach (SaleItem item in sale.Items)
            {
                sql = "INSERT INTO SalesAssets(SaleId, AssetId, Qty) VALUES ("+ row_id +", "+item.Asset+", "+item.Qty+")";
                command = new SqliteCommand(sql, dbConn);
                command.ExecuteNonQuery();
            }
        }

		public Asset GetAsset(int assetId)
		{
			string sql = "SELECT AssetId, Name, Description, Price from Asset WHERE AssetID = " + assetId;
            SqliteCommand command = new SqliteCommand(sql, dbConn);
			SqliteDataReader reader = command.ExecuteReader();
			if (reader.HasRows)
            {
				while (reader.Read())
				{
					int id = reader.GetInt32(0);
					string name = reader.GetString(1);
					string desc = reader.GetString(2);
					double price = reader.GetDouble(3);

					return new Asset(id, name, desc, price);
				}
            }
			return new NullAsset();
		}

        /// <summary>
        /// Gets a list of Sale IDs for the List of Sales in Display Sales
        /// </summary>
        /// <returns></returns>
        public List<int> getListSaleIDs()
        {
            List<int> result = new List<int>();
            string sql = "SELECT SaleID from SalesRecord";
            SqliteCommand command = new SqliteCommand(sql, dbConn);
            SqliteDataReader o_saleRecord = command.ExecuteReader();
            if (o_saleRecord.HasRows)
            {
                while (o_saleRecord.Read())
                {
                    result.Add(o_saleRecord.GetInt16(0));
                 
                }
            }
            return result;
        }

		public IDictionary<int, int> CountAssetSales(int year, int month)
		{
			string sql = @"
                SELECT sa.AssetId,            
                Sum(sa.Qty) as qty
                FROM SalesAssets sa
                INNER JOIN SalesRecord s
                ON s.SaleId = sa.SaleId
                WHERE strftime('%Y', s.TimeStamp) = '" + year + @"'
                AND strftime('%m', s.TimeStamp) = '" + month + @"'
                GROUP BY sa.AssetId";

			SqliteCommand command = new SqliteCommand(sql, dbConn);
			SqliteDataReader reader = command.ExecuteReader();

			Dictionary<int, int> sales = new Dictionary<int, int>();
			if (reader.HasRows)
			{
				while (reader.Read())
				{
					int id = reader.GetInt16(0);
					int qty = reader.GetInt16(1);
					sales.Add(id, qty);
				}
			}
			return sales;
		}

		public Sale getSaleRecord(int saleID)
        {
            string sql = "SELECT * from SalesAssets WHERE SaleID = " + saleID;
            SqliteCommand command = new SqliteCommand(sql, dbConn);
            SqliteDataReader o_AssetRecord = command.ExecuteReader();

			Sale sale = new Sale(saleID);
			if (o_AssetRecord.HasRows)
            {
                while (o_AssetRecord.Read())
                {
					int assetID = o_AssetRecord.GetInt16(0);
                    int qty = o_AssetRecord.GetInt16(1);
					SaleItem item = new SaleItem(assetID, qty);
					sale.Add(item);
                }
            }
            
            return sale;
        }
    }
}
