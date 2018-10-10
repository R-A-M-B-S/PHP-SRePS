﻿using System.IO;
using System.Data.SQLite;
using System.Collections.Generic;
using System;
using System.Data;

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

        public Database Execute(string sql)
        {
            new SQLiteCommand(sql, dbConn).ExecuteNonQuery();
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

        public void AddSale(List<SaleItem> items, double amountPaidCash, double amountPaidEftpos)
        {
            string sql = "insert into SalesRecord (AmountPaidCash, AmountPaidEftpos) VALUES (" + amountPaidCash + ", " + amountPaidEftpos + "); SELECT last_insert_rowid()";
            SQLiteCommand command = new SQLiteCommand(sql, dbConn);
            string row_id = command.ExecuteScalar().ToString();

            foreach (SaleItem item in items)
            {
                sql = "INSERT INTO SalesAssets(SaleId, AssetId, Qty) VALUES ("+ row_id +", "+item.Asset+", "+item.Qty+")";
                command = new SQLiteCommand(sql, dbConn);
                command.ExecuteNonQuery();
            }
        }

        public string GetAssetName(int assetID)
        {
            string sql = "SELECT Name from Asset WHERE AssetID = " + assetID;
            SQLiteCommand command = new SQLiteCommand(sql, dbConn);
            object o_name = command.ExecuteScalar();
            if (o_name != null)
                return o_name.ToString();
            return "";
        }

        public double GetAssetPrice(int assetID)
        {
            string sql = "SELECT Price from Asset WHERE AssetID = " + assetID;
            SQLiteCommand command = new SQLiteCommand(sql, dbConn);
            object o_price = command.ExecuteScalar();
            if (o_price != null)
            {
                double price = Double.TryParse(o_price.ToString(), out price) ? price : 0;
                return price;
            }
            return 0;
        }

        /// <summary>
        /// Gets a list of Sale IDs for the List of Sales in Display Sales
        /// </summary>
        /// <returns></returns>
        public List<int> getListSaleIDs()
        {
            List<int> result = new List<int>();
            string sql = "SELECT SaleID from SalesRecord";
            SQLiteCommand command = new SQLiteCommand(sql, dbConn);
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

        public DataTable getSaleRecord(int saleID)
        {
            DataTable result = new DataTable();
            result.Columns.Add("ItemNo");
            result.Columns.Add("Description");
            result.Columns.Add("Item Price");
            result.Columns.Add("Qty");
            result.Columns.Add("SubPrice");
            
            string sql = "SELECT * from SalesAssets WHERE SaleID = " + saleID;
            SQLiteCommand command = new SQLiteCommand(sql, dbConn);
            SQLiteDataReader o_AssetRecord = command.ExecuteReader();
            if (o_AssetRecord.HasRows)
            {
                while (o_AssetRecord.Read())
                {
                    int assetID = o_AssetRecord.GetInt16(1);
                    string desc = GetAssetName(assetID);
                    double price = GetAssetPrice(assetID);
                    int qty = o_AssetRecord.GetInt16(2);
                    result.Rows.Add(assetID, desc, price, qty, qty * price);
                }
            }
            
           

            return result;
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
    }
}
