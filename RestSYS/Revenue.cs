using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestSYS
{
    class Revenue
    {
        //define a static method that return the year in the record of orders table2
        public static DataSet loadYear(DataSet ds)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //connection name conn.open()
            String strSQL = "SELECT to_Char(OrderDate,'YYYY') " +
                            "FROM Orders " +
                            "GROUP BY to_Char(OrderDate,'YYYY') " +
                            "ORDER BY to_Char(OrderDate,'YYYY')";
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //cmd.CommandType = CommandType.Text;
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.Fill(ds, "year");

            conn.Close();

            return ds;
        }

        public static DataSet loadMonth(DataSet ds,String selectedYear)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //connection name conn.open()
            String strSQL = "SELECT to_Char(OrderDate,'MM') " +
                            "FROM Orders ";

            if (selectedYear != null)
            {
                strSQL += "WHERE to_Char(OrderDate,'YYYY') = " + selectedYear;
            }
            strSQL += "GROUP BY to_Char(OrderDate,'MM') " +
                      "ORDER BY to_Char(OrderDate,'MM')";
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //cmd.CommandType = CommandType.Text;
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.Fill(ds, "month");

            conn.Close();

            return ds;
        }

        public static DataSet loadWeek(DataSet ds, String selectedYear,String selectedMonth)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //connection name conn.open()
            String strSQL = "SELECT to_Char(OrderDate,'W') " +
                            "FROM Orders " +
                             "WHERE to_Char(OrderDate,'YYYY-MM') LIKE '" + selectedYear + "-" + selectedMonth + "%'" +
                             "GROUP BY to_Char(OrderDate,'W') " +
                            "ORDER BY to_Char(OrderDate,'W')";
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //cmd.CommandType = CommandType.Text;
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.Fill(ds, "week");

            conn.Close();

            return ds;
        }

        public static DataSet displayAnnualRecord(DataSet ds)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //connection name conn.open()
            String strSQL = "SELECT to_Char(OrderDate,'YYYY') AS YEAR , SUM(VALUE) AS COST " +
                                "FROM ORDERS " +
                                "GROUP BY to_Char(OrderDate, 'YYYY') " +
                                "ORDER BY to_Char(OrderDate, 'YYYY') ";
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //cmd.CommandType = CommandType.Text;
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.Fill(ds, "annual");

            conn.Close();

            return ds;
        }

        public static DataSet displayMonthlyRecord(DataSet ds,String selectedYear)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //connection name conn.open()
            String strSQL = "SELECT to_Char(OrderDate,'MM') AS MONTH , SUM(VALUE) AS COST " +
                                "FROM ORDERS " +
                                "WHERE to_Char(OrderDate,'YYYY') = " + selectedYear +
                                "GROUP BY to_Char(OrderDate, 'MM') " +
                                "ORDER BY to_Char(OrderDate, 'MM') ";
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //cmd.CommandType = CommandType.Text;
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.Fill(ds, "monthly");

            conn.Close();

            return ds;
        }

        public static DataSet displayWeeklyRecord(DataSet ds, String selectedYear , String selectedMonth)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //connection name conn.open()
            String strSQL = "SELECT to_Char(OrderDate,'W') AS week , SUM(VALUE) AS COST " +
                                "FROM ORDERS " +
                                "WHERE to_Char(OrderDate,'YYYY') = " + selectedYear + 
                                "AND to_Char(OrderDate,'MM') = " + selectedMonth +
                                "GROUP BY to_Char(OrderDate, 'W') " +
                                "ORDER BY to_Char(OrderDate, 'W') ";
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //cmd.CommandType = CommandType.Text;
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.Fill(ds, "weekly");

            conn.Close();

            return ds;
        }

        public static DataSet displayDailyRecord(DataSet ds, String selectedYear, String selectedMonth , String selectedWeek)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //connection name conn.open()
            String strSQL = "SELECT to_Char(OrderDate,'DD') , SUM(VALUE) AS COST " +
                                "FROM ORDERS " +
                                "WHERE to_Char(OrderDate,'YYYY') = " + selectedYear +
                                "AND to_Char(OrderDate,'MM') = " + selectedMonth +
                                "AND to_Char(OrderDate,'W') = " +selectedWeek +
                                "GROUP BY to_Char(OrderDate, 'DD') " +
                                "ORDER BY to_Char(OrderDate, 'DD') ";
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //cmd.CommandType = CommandType.Text;
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.Fill(ds, "daily");

            conn.Close();

            return ds;
        }
    }
}
