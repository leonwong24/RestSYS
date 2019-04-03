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
    class Orders
    {

        //static attribute
        public static DataSet foodOrder;
        public static int[,] menu = new int[4, 13];
        private static string currentPage = "S";
        public static int state;    //1 = order 2 = staff 3 = changeFood
        public static int changeFoodItemId = 0;
        public static List<int[]> orderItems = new List<int[]>();

        //attribute that stores temporary data
        public static int orderNoStore;
        //public static decimal valueStore;
        //public static String statusStore;

        //instance class
        public int orderNo;
        public String orderDate;
        public String orderTime;
        public int tableNo;
        public int staffId;
        public String status;

        public Orders(int OrderNo, int tableNo, decimal value, int staffId, String status){
            this.orderNo = OrderNo;
            this.orderDate = "";
            this.orderTime = "";
            this.tableNo = tableNo;
            this.staffId = staffId;
            this.status = status;
        }

        public Orders()
        {
        }

        public static DataSet getSelectedFoodOrder(DataSet ds,int orderNo)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //connetion name conn.open()
            String strSQL = "SELECT * FROM OrderItems WHERE OrderNo = " + orderNo;
            OracleCommand cmd = new OracleCommand(strSQL,conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.Fill(ds, "FoodOrder");

            conn.Close();

            return ds;
        }

        public static void setCurrentPage(string page)
        {
            currentPage = page;
        }

        public static int getCurrentPageAsInt()
        {
            int foodType = -1;
            if (currentPage.Equals("S"))
            {
                foodType = 0;
            }
            else if (currentPage.Equals("M"))
            {
                foodType = 1;
            }
            else if (currentPage.Equals("B"))
            {
                foodType = 2;
            }
            else if(currentPage.Equals("D")) //dessert
            {
                foodType = 3;
            }
            return foodType;
        }

        public static String getCurrentPage()
        {
            return currentPage;
        }

        //generate next orderNo
        public static int NextOrderNo()
        {
            //variable to hold value to be returned
            int intNextOrderNo = 1;

            //Connect to the DB
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            //Define SQL Query to get MAX orderNo used
            String strSQL = "SELECT MAX(OrderNo) FROM Orders";

            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            //exceute the SQL Query and put result in OracleDataReader object
            OracleDataReader dr = cmd.ExecuteReader();

            //read the first (only) value returned by query
            //If first OrderNo, assign value 1, otherwise add 1 to MAX value
            dr.Read();
            if (!dr.IsDBNull(0))
            {
                //intNextItemId = dr.GetInt32(0) + 1;
                intNextOrderNo = Convert.ToInt32(dr.GetValue(0)) + 1;
            }

            //close db connection
            myConn.Close();

            //return next ItemId
            return intNextOrderNo;
        }

        //update a new row of order
        public static void updateOrderItems()
        {

        }
    }
}
