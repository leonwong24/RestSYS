using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestSYS
{
    class FoodTypes
    {
        //Instance variables
        private string foodType;
        private string description;

        //no argument constructor
        public FoodTypes()
        {
            foodType = "N";
            description = "Null description";
        }

        //argument constructor
        public FoodTypes(string foodType , string description)
        {
            this.foodType = foodType;
            this.description = description;
        }

        //Define setters
        public void setFoodType(string foodType)
        {
            this.foodType = foodType;
        }

        public void setDescription(string description)
        {
            this.description = description;
        }

        //define a static method to get all foodtype
        public static DataSet getAllFoodType(DataSet DS)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //connection name conn.open()
            String strSQL = "SELECT * FROM FOODTYPES";
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //cmd.CommandType = CommandType.Text;
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.Fill(DS, "ss");

            conn.Close();

            return DS;
        }

        //method that register new food type
        public void addNewFoodType()
        {
            //connect to database
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            //Define SQL Query to insert new food type
            String strSQL = "INSERT INTO FoodTypes VALUES( '" + this.foodType + "' , '" + this.description + "')";

            //execute the insert command
            OracleCommand cmd = new OracleCommand(strSQL, conn);
            cmd.ExecuteNonQuery();

            //close DB connection
            conn.Close();
        }


        //define a method to determine if inserting foodtypes exist in the database
        public static Boolean isFoodTypeExist(String foodtype)
        {
            //connect to database
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            //Define SQL Query to search the food type like the inserting one
            String strSQL = "SELECT COUNT(FoodType) FROM FoodTypes WHERE FoodType LIKE '"+foodtype+"%'";
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //execute the select command
            int count = Convert.ToInt32(cmd.ExecuteScalar());

            //check if the count is larger than 1
            if (count >= 1)
                return true;
            else
                return false;
        }

    }
}
