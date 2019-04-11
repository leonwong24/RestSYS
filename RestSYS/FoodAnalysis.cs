using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestSYS
{
    class FoodAnalysis
    {

        //define a method that returns the analysis dataset
        public static DataSet loadFdAnalysis(DataSet ds,String yearSelected, String monthSelected , List<String> selectedFood)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //connection name conn.open()
            String strSQL = "SELECT to_Char(OrderDate,'YYYY'), to_char(OrderDate,'MM'),fi.ItemName AS foodItem, fi.FoodType AS Type, SUM(QTY) AS Quantity " +
                            "FROM OrderItems oi " +
                            "INNER JOIN FoodItems fi ON " +
                            "fi.itemid = oi.itemid " +
                            "LEFT JOIN Orders o ON " +
                            "oi.orderNo = o.orderNo " +
                            "WHERE fi.ItemId = oi.ItemId ";

            if(yearSelected != null)
            {
                strSQL += "AND to_Char(OrderDate,'YYYY') = "+yearSelected;
            }

            if(monthSelected != null)
            {
                strSQL += "AND to_Char(OrderDate,'MM') = " + monthSelected;
            }

            if(selectedFood.Count != 0)
            {
                strSQL += "AND (";
                for(int i =0; i < selectedFood.Count; i++)
                {
                    if(i == 0)  //first
                    {
                        strSQL += "fi.foodtype = '" + selectedFood[0] + "'";
                    }

                    else
                    {
                        strSQL += "OR fi.foodType ='" + selectedFood[i] + "'";
                    }
                }

                strSQL += ") ";
            }

            strSQL += "GROUP BY to_Char(OrderDate,'YYYY'), to_char(OrderDate,'MM') ,fi.ItemName , fi.FoodType " +
                      "ORDER BY SUM(QTY) DESC ";
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //cmd.CommandType = CommandType.Text;
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.Fill(ds, "foodAnalysis");

            conn.Close();

            return ds;
        }

    }
}
