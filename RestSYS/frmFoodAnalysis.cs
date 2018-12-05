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
            this.Hide();
            frmAddFoodType frmAddFoodType = new frmAddFoodType();
            frmAddFoodType.Show();
        }

        private void mnuItmAddFoodItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAddFoodItem frmAddFoodItem = new frmAddFoodItem();
            frmAddFoodItem.Show();
        }

        private void mnuItmChangeFoodItem_Click(object sender, EventArgs e)
        {
            this.Hide();
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
            this.Hide();
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
            this.Hide();
            frmAddStaff frmAddStaff = new frmAddStaff();
            frmAddStaff.Show();
        }

        private void mnuItmModifyStaff_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmChangeStaff frmChangeStaff = new frmChangeStaff();
            frmChangeStaff.Show();
        }

        private void mnuItmRemoveStaff_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRemoveStaff frmRemoveStaff = new frmRemoveStaff();
            frmRemoveStaff.Show();
        }
    }
}
