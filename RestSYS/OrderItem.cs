using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestSYS
{
    class OrderItem
    {
        private int orderNo;
        private int itemId;
        private int qty;
        private decimal price;

        public int OrderNo { get => orderNo; set => orderNo = value; }
        public int ItemId { get => itemId; set => itemId = value; }
        public int Qty { get => qty; set => qty = value; }
        public decimal Price { get => price; set => price = value; }

        public void insertOrderItems()
        {
            //connect to database
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            //Define SQL query to INSERT foodItem database
            String strSQL = "INSERT INTO orderItems VALUES( " + this.orderNo + "," + this.itemId + "," + this.qty + "," + this.price + ")";

            //Execute the command 
            OracleCommand cmd = new OracleCommand(strSQL, conn);
            cmd.ExecuteNonQuery();

            //close DBConnection
            conn.Close();
        }
    }
}
