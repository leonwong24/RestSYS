using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestSYS
{
    class Staff
    {
        //Instance variables
        private int staffId;
        private string staffName;
        private string status;

        //no argument constructor\
        public Staff()
        {
            staffId = -1;
            staffName = "empty";
            status = "W";//working
        }

        //argument constructor
        public Staff(int staffId, string staffName,string status)
        {
            this.staffId = staffId;
            this.staffName = staffName;
            this.status = status;
        }

        //Define setters
        public void setStaffId(int staffId)
        {
            this.staffId = staffId;
        }

        public void setStaffName(string staffName)
        {
            this.staffName = staffName;
        }

        public void setStaffStatus(string status)
        {
            this.status = status;
        }

        //Define getters
        public int getStaffId()
        {
            return staffId;
        }

        public string getStaffStatus()
        {
            return status;
        }

        //define a static method to get all staff
        public static DataSet getAllStaff(DataSet DS)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //connection name conn.open()
            conn.Open();
            String strSQL = "SELECT * FROM STAFF";
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //cmd.commandtype = CommandType.Text
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.Fill(DS, "All Staff");

            conn.Close();

            return DS;
        }

        //define a static method to get all available staff
        public static DataSet getAllWorkingStaff(DataSet DS)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //connection name conn.open()
            String strSQL = "SELECT * FROM STAFF WHERE STATUS = 'W' ";
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //cmd.commandtype = CommandType.Text
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.Fill(DS, "All Working Staff");

            conn.Close();

            return DS;

        }

        public static DataSet getSelectedStaff(DataSet DS, int staffId)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //conneciton name conn.open()
            conn.Open();
            String strSQl = "SELECT * FROM STAFF WHERE StaffId LIKE " + staffId;
            OracleCommand cmd = new OracleCommand(strSQl, conn);

            //cmd.commandtype = commandType.text
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.Fill(DS, "Selected Staff");

            conn.Close();

            return DS;
        }

        //define a method that add new staff
        public void addNewStaff()
        {
            //connect to database
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            //Define SQL query to insert new staff
            String strSQL = "INSERT INTO STAFF VALUES(" + this.staffId + ",'" + this.staffName + "','"+this.status+"')";

            //execute the insert command
            OracleCommand cmd = new OracleCommand(strSQL, conn);
            cmd.ExecuteNonQuery();

            //close DB connection
            conn.Close();
        }

        //define a method that update staff details
        public void updateStaff()
        {
            //connect to database
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            //Define SQL query to update new staff
            String strSQL = "UPDATE STAFF SET staffName = '" + this.staffName + "',status = '"+this.status+"' WHERE staffId =" + this.staffId;

            //execute the update command
            OracleCommand cmd = new OracleCommand(strSQL, conn);
            cmd.ExecuteNonQuery();

            //close DB connection
            conn.Close();
        }

        //define a method that return next staff id
        public static int nextStaffId()
        {
            //variable to hold next return staff id
            int intNextStaffId = 1;

            //Connect to the DB
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            //Define SQL query to get maxStaffId used
            String strSQL = "SELECT MAX(staffID) FROM STAFF";

            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //execute the SQL query and put result in OracleDataReader object
            OracleDataReader dr = cmd.ExecuteReader();

            //read the first (only) value returned by query
            //If first itemId, assign value 1, otherwise add 1 to MAX value
            dr.Read();
            if (!dr.IsDBNull(0))
            {
                //intNextStaffId = dr.GetInt32(0) + 1;
                intNextStaffId = Convert.ToInt32(dr.GetValue(0)) + 1;
            }

            //close db connection
            conn.Close();

            //return next StaffId
            return intNextStaffId;
        }
    }
}
