using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestSYS
{
    public partial class frmFoodAnalysis : Form
    {
        public frmFoodAnalysis()
        {
            InitializeComponent();
            //Assume it retrieve data from the Order Items file and Food Items File
            this.grdFdAnlys.Rows.Add("2018", "1", "M", "Fish and Chips", "20");
            this.grdFdAnlys.Rows.Add("2018", "1", "M", "Chicken Burger", "18");
            this.grdFdAnlys.Rows.Add("2018", "1", "M", "Beef Steak", "15");
            this.grdFdAnlys.Rows.Add("2018", "1", "M", "Salad Bowl", "7");
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            MessageBox.Show("A food analysis report is sending to the printer");
        }

        private void mnuItemAddFoodType_Click(object sender, EventArgs e)
        {
            this.Close();
            frmAddFoodType frmAddFoodType = new frmAddFoodType();
            frmAddFoodType.Show();
        }

        private void mnuItmAddFoodItem_Click(object sender, EventArgs e)
        {
            this.Close();
            frmAddFoodItem frmAddFoodItem = new frmAddFoodItem();
            frmAddFoodItem.Show();
        }

        private void mnuItmChangeFoodItem_Click(object sender, EventArgs e)
        {
            this.Close();
            frmChangeFoodItem frmChangeFoodItem = new frmChangeFoodItem();
            frmChangeFoodItem.Show();
        }

        private void mnuOrder_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmTableInterface frmTableInterface = new frmTableInterface();
            frmTableInterface.Show();
        }

        private void mnuBack_Click(object sender, EventArgs e)
        {
            this.Close();
            frmHomeInterface frmHomeInterface = new frmHomeInterface();
            frmHomeInterface.Show();
        }

        private void mnuItmRevenueAnalysis_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRevenueAnalysis frmRevenueAnalysis = new frmRevenueAnalysis();
            frmRevenueAnalysis.Show();
        }

        private void addStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            frmAddStaff frmAddStaff = new frmAddStaff();
            frmAddStaff.Show();
        }

        private void mnuItmModifyStaff_Click(object sender, EventArgs e)
        {
            this.Close();
            frmChangeStaff frmChangeStaff = new frmChangeStaff();
            frmChangeStaff.Show();
        }

        private void mnuItmRemoveStaff_Click(object sender, EventArgs e)
        {
            this.Close();
            frmRemoveStaff frmRemoveStaff = new frmRemoveStaff();
            frmRemoveStaff.Show();
        }

        private void frmFoodAnalysis_Load(object sender, EventArgs e)
        {
            //load the year combo box with the year
            DataSet ds = new DataSet();
            ds = Revenue.loadYear(ds);

            //load year
            for (int i = 0; i < ds.Tables["year"].Rows.Count; i++)
            {
                cboYear.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
        }

        private void cboYear_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void chkMain_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
