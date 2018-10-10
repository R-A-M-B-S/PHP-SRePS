using System.IO;
using System.Data.SQLite;
using System.Collections.Generic;
using System;
using System.Data;
using System.Text;

namespace SalesApp
{
    public class Database
    {

        private SQLiteConnection dbConn;
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

        public Database Execute(string SQL)
        {
            new SQLiteCommand(SQL, dbConn).ExecuteNonQuery();
            return this;
        }

        public Database Connect()
        {
            if (!File.Exists(filename))
                SQLiteConnection.CreateFile(filename);
            dbConn = new SQLiteConnection("Data Source=" + filename + ";Version=3");
            dbConn.Open();
            return this;
        }

        public void AddSale(Sale sale)
        {
            string SQL = "insert into SalesRecord (AmountPaidCash, AmountPaidEftpos) VALUES (" + sale.amountPaidCash + ", " + sale.amountPaidEftpos + "); SELECT last_insert_rowid()";
            SQLiteCommand command = new SQLiteCommand(SQL, dbConn);
            string row_id = command.ExecuteScalar().ToString();
   
            foreach (SaleItem item in sale.Items)
            {
                SQL = "INSERT INTO SalesAssets(SaleId, AssetId, Qty) VALUES ("+ row_id +", "+item.Asset+", "+item.Qty+")";
                command = new SQLiteCommand(SQL, dbConn);
                command.ExecuteNonQuery();
            }
        }

        public Asset GetAsset(int assetId)
        {
            string SQL = "SELECT AssetId, Name, Description, Price from Asset WHERE AssetID = " + assetId;
            SQLiteCommand command = new SQLiteCommand(SQL, dbConn);
            SQLiteDataReader reader = command.ExecuteReader();
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
            string SQL = "SELECT SaleID from SalesRecord";
            SQLiteCommand command = new SQLiteCommand(SQL, dbConn);
            SQLiteDataReader o_saleRecord = command.ExecuteReader();
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
            string SQL = @"
                SELECT sa.AssetId,            
                Sum(sa.Qty) as qty
                FROM SalesAssets sa
                INNER JOIN SalesRecord s
                ON s.SaleId = sa.SaleId
                WHERE strftime('%Y', s.TimeStamp) = '" + year + @"'
                AND strftime('%m', s.TimeStamp) = '" + month + @"'
                GROUP BY sa.AssetId";

            SQLiteCommand command = new SQLiteCommand(SQL, dbConn);
            SQLiteDataReader reader = command.ExecuteReader();

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

            // Get individual items
            string SQL = "SELECT AssetID, Qty from SalesAssets WHERE SaleID = " + saleID;
            SQLiteCommand command = new SQLiteCommand(SQL, dbConn);
            SQLiteDataReader o_AssetRecord = command.ExecuteReader();

            Sale sale = new Sale(saleID);
            if (o_AssetRecord.HasRows)
            {
                while (o_AssetRecord.Read())
                {
                    int assetID = o_AssetRecord.GetInt32(0);
                    int qty = o_AssetRecord.GetInt32(1);
                    SaleItem item = new SaleItem(assetID, qty);
                    sale.Add(item);
                }
            }

            // Get sale data
            SQL = "SELECT AmountPaidCash, AmountPaidEftpos FROM SalesRecord WHERE SaleID = " + saleID;
            command = new SQLiteCommand(SQL, dbConn);
            SQLiteDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    sale.amountPaidCash = reader.GetDouble(0);
                    sale.amountPaidEftpos = reader.GetDouble(1);
                }
            }
            return sale;
        }

        public DataTable getAllAssetRecord()
        {
            DataTable result = new DataTable();
            result.Columns.Add("AssetID");
            result.Columns.Add("Name");
            result.Columns.Add("Description");
            result.Columns.Add("Qty");
            result.Columns.Add("Item Price");

            string sql = "SELECT * from Asset ";
            SQLiteCommand command = new SQLiteCommand(sql, dbConn);
            SQLiteDataReader o_AssetRecord = command.ExecuteReader();
            if (o_AssetRecord.HasRows)
            {
                while (o_AssetRecord.Read())
                {
                    int assetID = o_AssetRecord.GetInt16(0);
                    string name =  o_AssetRecord.GetString(1);
                    string desc = o_AssetRecord.GetString(2);
                    double price = o_AssetRecord.GetDouble(3);
                    int qty = o_AssetRecord.GetInt32(4);
                    result.Rows.Add(assetID, name, desc, qty, price);
                }
            }
            return result;

        }

        public void ChangeAsset(string name, string desc, int qty, int id, double price)
        {
           
            if (id==0){
                string sql = "INSERT INTO Asset (Name, Description, Price, StockAmount) VALUES (" +"\""+ name + "\",\"" + desc + "\"," + price + "," + qty + ")";
                SQLiteCommand command = new SQLiteCommand(sql, dbConn);
                command.ExecuteNonQuery();
            } else {
                string sql = "UPDATE Asset Set StockAmount = " + qty + " WHERE AssetID =" + id;
                if (name.Length>=0 || desc.Length == 0 || price == 0)
                {
                    if (price > 0 && qty < 0)
                    {

                    }
                } 
               
                SQLiteCommand command = new SQLiteCommand(sql, dbConn);
                command.ExecuteNonQuery();
            }
        }

		public string export_csv()
		{
			string query = "Select SaleID, Timestamp, AmountPaidCash, AmountPaidEftpos from SalesRecord";
			SQLiteCommand cmd = new SQLiteCommand(query, dbConn);
			SQLiteDataReader reader = cmd.ExecuteReader();
			string strDelimiter = ", ";
            
            StringBuilder sb = new StringBuilder();
            Object[] items = new Object[reader.FieldCount];

			if (reader.HasRows)
			{
				while (reader.Read())
				{
					sb.Append(reader.GetInt32(0)); // id               
					sb.Append(strDelimiter);
					sb.Append(reader.GetString(1)); // time
					sb.Append(strDelimiter);
					sb.Append(reader.GetDouble(2)); // eftpos
					sb.Append(strDelimiter);
					sb.Append(reader.GetDouble(3)); // cash
					sb.Append("\n");
				}
			}

			return sb.ToString();
		}
    }
}
