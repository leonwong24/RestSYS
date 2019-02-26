using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestSYS
{
    class Table
    {
        //Instance Variables
        private int tableNum;
        private int orderNo;

        //Define a method that return a dataset when certain table number is input
        //public Boolean isClear()
        //{

        //}

        //define a method that get all the selected table order
        public static DataSet getSelectedTableOrder(DataSet DS, int tableNo)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //connection name conn.open()
            String strSQL = "SELECT * FROM ORDERS WHERE TABLENO = " + tableNo;
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //cmd.CommandType = CommandType.text;
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.Fill(DS, "Table Order");

            conn.Close();

            return DS;
        }

        //define a method that return a set of unpaid order dataset  with give table No
        public static DataSet getUnpaidSelectedTableOrder(DataSet DS, int tableNo)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //connection name conn.open()
            String strSQL = "SELECT * FROM ORDERS WHERE TABLENO = " + tableNo + "AND STATUS = 'U'";
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //cmd.CommandType = CommandType.text;
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.Fill(DS, "Table Order");

            conn.Close();

            return DS;
        }
    }
}
