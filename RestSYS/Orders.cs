using Oracle.DataAccess.Client;
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

        public static DataSet foodOrder;
        private static Staff staffSignedIn;
        public static int[,] menu = new int[4, 13];
        private static string currentPage ="S";
        public static int state;    //1 = order 2 = staff 3 = changeFood
        public static int changeFoodItemId = 0;
        public static List<int[,]> orderItems = new List<int[,]>();
        

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
    }
}
