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
        public static DataSet foodOrder = new DataSet();
        public static int[,] menu = new int[4, 13];
        private static string currentPage = "S";
        public static int state;    //1 = order 2 = staff 3 = changeFood
        public static int changeFoodItemId = 0;
        public static List<int[]> orderItems = new List<int[]>();
        public static String staff;

        //attribute that stores temporary data
        //public static int orderNoStore;
        //public static decimal valueStore;
        //public static String statusStore;

        //instance class
        private int orderNo;
        private String orderDate;
        private String orderTime;
        private int tableNo;
        private int staffId;
        private String status;
        private decimal value;

        public int OrderNo { get => orderNo; set => orderNo = value; }
        public string OrderDate { get => orderDate; set => orderDate = value; }
        public string OrderTime { get => orderTime; set => orderTime = value; }
        public int TableNo { get => tableNo; set => tableNo = value; }
        public int StaffId { get => staffId; set => staffId = value; }
        public string Status { get => status; set => status = value; }
        public decimal Value { get => value; set => this.value = value; }

        public Orders(int OrderNo, int tableNo, decimal value, int staffId, String status){
            this.OrderNo = OrderNo;
            this.OrderDate = "";
            this.OrderTime = "";
            this.TableNo = tableNo;
            this.StaffId = staffId;
            this.Status = status;
            this.Value = value;
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

            da.Fill(ds,"Selected Food Order");

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
        public static int nextOrderNo()
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
                intNextOrderNo = dr.GetInt32(0)+1;
            }

            //close db connection
            myConn.Close();

            //return next ItemId
            return intNextOrderNo;
        }

        public static void runSQL(String sql)
        {
            //Connect to the database
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            //execute the command
            OracleCommand cmd = new OracleCommand(sql, conn);

            cmd.ExecuteNonQuery();

            //close DBConnection
            conn.Close();

        }

        //update the order
        public static void updateOrder(Orders order)
        {
            //Connect to the databse
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            String sql = "UPDATE Orders SET VALUE = " + order.value + " WHERE OrderNo = " + order.orderNo;
            //execute the command
            OracleCommand cmd = new OracleCommand(sql, conn);

            cmd.ExecuteNonQuery();

            //close DBConnection
            conn.Close();
        }

        //Method to pay the order
        public static void payOrder(int orderNo)
        {
            //Connect to the database
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            String sql = "UPDATE Orders SET STATUS = 'P' WHERE OrderNo = " + orderNo;
            //execute the command
            OracleCommand cmd = new OracleCommand(sql, conn);

            cmd.ExecuteNonQuery();

            //close DBConnection
            conn.Close();
        }

        //Method to pay non existing order
        public static void payNewOrder(Orders order)
        {
            //Connect to the database
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            //insert order
            insertOrders(order);

            String sql = "UPDATE Orders SET STATUS = 'P' WHERE OrderNo = " + order.OrderNo;
            //execute the command
            OracleCommand cmd = new OracleCommand(sql, conn);

            cmd.ExecuteNonQuery();

            //close DBConnection
            conn.Close();
        }

        public static void insertOrders(Orders order)
        {
            //insert sql command into Orders Table
            String sql = "INSERT INTO Orders (OrderNo,OrderDate,OrderTime,TableNo,Value,StaffId,Status) VALUES(";
            sql += order.orderNo + ", "; //orderNo
            sql += "CURRENT_DATE,"; //current date
            sql += "CURRENT_TIMESTAMP,";    //current time
            sql += order.tableNo + ",";   //tableNo
            sql += "(SELECT SUM(PRICE) FROM OrderItems WHERE OrderItems.OrderNo = " + order.orderNo + "),"; //total table value
            sql += Convert.ToInt32(order.staffId) + ","; //staff id
            sql += "'U')"; //status , unpaid

            //Connect to the database
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            //execute the command
            OracleCommand cmd = new OracleCommand(sql, conn);

            cmd.ExecuteNonQuery();

            //close DBConnection
            conn.Close();


            MessageBox.Show("Order inserted");
            Table.tableList[order.tableNo] = order.tableNo;
        }

        public static Boolean checkOrderNo(int OrderNo)
        {
            DataSet ds = new DataSet();
            String sql = "Select OrderNo FROM ORDERS WHERE OrderNo = " + OrderNo;

            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            //execute the command
            OracleCommand cmd = new OracleCommand(sql, conn);

            //cmd.CommandType = CommandType.text;
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.Fill(ds, "checkOrderNo");

            conn.Close();

            if(ds.Tables["checkOrderNo"].Rows.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
