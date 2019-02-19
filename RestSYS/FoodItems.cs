using Oracle.ManagedDataAccess.Client;
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
        public FoodItems(int itemId,string itemName,string description,string foodType,decimal price, string status)
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
            return itemId;
        }

        public string getFoodType()
        {
            return foodType;
        }

        //define a static method to get all food item data

        public static DataSet getAllStock(DataSet DS)
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

        public static int nextItemId()
        {
            //variable to hold value to be returned
            int intNextItemId = 1;

            //Connect to the DB
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            //Define SQL Query to get MAX itemId used
            String strSQL = "SELECT Count(ItemId) FROM FoodItems";

            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            //exceute the SQL Query and put result in OracleDataReader object
            OracleDataReader dr = cmd.ExecuteReader();

            //read the first (only) value returned by query
            //If first itemId, assign value 1, otherwise add 1 to MAX value
            dr.Read();
            MessageBox.Show(Convert.ToString(dr.GetValue(0)));
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
    }
}
