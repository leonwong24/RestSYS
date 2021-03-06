﻿using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestSYS
{
    class FoodItems
    {
        //instace variables
        private int itemId;
        private string itemName;
        private string description;
        private string foodType;
        private decimal price;
        private string status;

        //no argument constructor
        public FoodItems()
        {
            itemId = 0;
            itemName = "no name";
            description = "no description";
            foodType = "N";
            price = 0;
            status = "U";
        }

        //argument constructor
        public FoodItems(int itemId,string itemName,string description,string foodType, decimal price, string status)
        {
            this.itemId = itemId;
            this.itemName = itemName;
            this.description = description;
            this.foodType = foodType;
            this.price = price;
            this.status = status;
        }

        //define setters
        public void setItemId(int itemId)
        {
            this.itemId = itemId;
        }

        public void setItemName(String itemName)
        {
            this.itemName = itemName;
        }

        public void setDescription(String description)
        {
            this.description = description;
        }

        public void setFoodType(string foodType)
        {
            this.foodType = foodType;
        }

        public void setPrice(decimal price)
        {
            this.price = price;
        }

        public void setStatus(string status)
        {
            this.status = status;
        }

        //define getters



        public int getItemId()
        {
            return this.itemId;
        }

        public string getItemName()
        {
            return this.itemName;
        }

        public string getDescription()
        {
            return this.description;
        }

        public decimal getPrice()
        {
            return this.price;
        }

        public string getStatus()
        {
            return this.status;
        }

        public string getFoodType()
        {
            return this.foodType;
        }

        //define a static method to get all food item data

        public static DataSet getAllFoodItem(DataSet DS)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //connection name conn.open()
            String strSQL = "SELECT * FROM FoodItems";
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //cmd.CommandType = CommandType.text;
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.Fill(DS, "ss");

            conn.Close();

            return DS;
        }

        public static DataSet getSelectedFoodItem(DataSet DS,string foodType)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //connection name conn.open()
            String strSQL = "SELECT * FROM FoodItems WHERE FoodType LIKE '"+foodType+"' Order By ItemName";
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //cmd.CommandType = CommandType.text;
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.Fill(DS, "FoodItems");

            conn.Close();

            return DS;
        }


        //define a method that return next food item id
        public static int nextItemId()
        {
            //variable to hold value to be returned
            int intNextItemId = 1;

            //Connect to the DB
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            //Define SQL Query to get MAX itemId used
            String strSQL = "SELECT MAX(ItemId) FROM FoodItems";

            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            //exceute the SQL Query and put result in OracleDataReader object
            OracleDataReader dr = cmd.ExecuteReader();

            //read the first (only) value returned by query
            //If first itemId, assign value 1, otherwise add 1 to MAX value
            dr.Read();
            if (!dr.IsDBNull(0))
            {
                //intNextItemId = dr.GetInt32(0) + 1;
                intNextItemId = Convert.ToInt32(dr.GetValue(0)) + 1;
            }

            //close db connection
            myConn.Close();

            //return next ItemId
            return intNextItemId;
        }

        public void addFoodItem()
        {
            //connect to database
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            //Define SQL query to INSERT foodItem database
            String strSQL = "INSERT INTO FoodItems VALUES(" +this.itemId +",'"+this.itemName+"','"+this.description+"','"+this.foodType+"',"+this.price+",'"+this.status+"')";

            //Execute the command 
            OracleCommand cmd = new OracleCommand(strSQL, conn);
            cmd.ExecuteNonQuery();

            //close DBConnection
            conn.Close();
        }

        //define a method that update the food item
        public void updateFoodItem()
        {
            //Connecto to database
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            //Define SQL query to UPDATE fooditem database
            String strSQL = "UPDATE FoodItems SET itemName= '" + this.getItemName() + "',itemDescription = '" + this.getDescription() + "',foodType = '" + this.getFoodType() + "',price = " + this.getPrice()+", status = '" + this.getStatus() + "' WHERE itemId = " + this.getItemId();

            //Execute the command
            OracleCommand cmd = new OracleCommand(strSQL, conn);
            cmd.ExecuteNonQuery();

            //close DBConnection
            conn.Close();
        }

        public static String getFoodName(int foodId)
        {
            String foodName="";
            //Connect to database
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            //Define SQL query to get food name
            String strSQL = "SELECT ITEMNAME FROM FOODITEMS WHERE ITEMID = " + foodId;
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //exceute the SQL Query and put result in OracleDataReader object
            OracleDataReader dr = cmd.ExecuteReader();

            //read the first (only) value returned by query
            dr.Read();
            //if (!dr.IsDBNull(0))
            //{
                foodName = Convert.ToString(dr.GetValue(0));
            //}

            //close db connection
            conn.Close();

            //return next foodName
            return foodName;
        }

        public static DataSet getAvailableFoodItem(DataSet ds,String foodType)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //connection name conn.open()
            String strSQL = "SELECT * FROM FoodItems WHERE FoodType LIKE '" + foodType + "' AND STATUS ='A'";
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //cmd.CommandType = CommandType.text;
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.Fill(ds, "FoodItems");

            conn.Close();

            return ds;
        }


        public static FoodItems getFood(int ItemId)
        {
            FoodItems fooditem = new FoodItems();

            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();
            //connection name conn.open()
            String strSQL = "SELECT * FROM FoodItems WHERE ItemId = " + ItemId;
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //exceute the SQL Query and put result in OracleDataReader object
            OracleDataReader dr = cmd.ExecuteReader();

            //read the first (only) value returned by query
            //If first itemId, assign value 1, otherwise add 1 to MAX value
            dr.Read();
            if (!dr.IsDBNull(0))
            {
                
                fooditem.setItemId(ItemId);
                fooditem.setItemName(dr.GetString(1));
                fooditem.setDescription(dr.GetString(2));
                fooditem.setFoodType(dr.GetString(3));
                fooditem.setPrice(dr.GetDecimal(4));
                fooditem.setStatus(dr.GetString(5));
            }

            //close db connection
            conn.Close();

            //return next ItemId
            return fooditem;

        }

    }
}
