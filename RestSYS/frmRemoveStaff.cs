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
    public partial class frmRemoveStaff : Form
    {
        public frmRemoveStaff()
        {
            InitializeComponent();
        }

        private void btnRemoveStaff_Click(object sender, EventArgs e)
        {
            //if staff name left blank
            if (cboStaff.Text.Equals("")){
                MessageBox.Show("Error , pleaes select a staff to remove");
            }
            else
            {
                MessageBox.Show(cboStaff.Text + " has removed form the system");
            }
            
        }

        private void mnuItmAddFoodType_Click(object sender, EventArgs e)
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
            this.Close();
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
            this.Close();
            frmRevenueAnalysis frmRevenueAnalysis = new frmRevenueAnalysis();
            frmRevenueAnalysis.Show();
        }

        private void mnuItmFoodAnalysis_Click(object sender, EventArgs e)
        {
            this.Close();
            frmFoodAnalysis frmFoodAnalysis = new frmFoodAnalysis();
            frmFoodAnalysis.Show();
        }

        private void mnuItmAddStaff_Click(object sender, EventArgs e)
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
    }
}
