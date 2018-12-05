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
    public partial class frmChangeStaff : Form
    {
        public frmChangeStaff()
        {
            InitializeComponent();
        }

        private void btnSelectStaff_Click(object sender, EventArgs e)
        {
            grpSelectStaff.Visible = false; //Hide select staff group box
            grpChangeStaff.Visible = true;  //Show select staff group box

            txtStaffName.Text = cboStaffName.Text;
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            System.Text.RegularExpressions.Regex regex = new System.Text.RegularExpressions.Regex("^[a-zA-z]*$");
            System.Text.RegularExpressions.Match match = regex.Match(txtStaffName.Text);

            if (txtStaffName.Text.Equals(""))
            {
                MessageBox.Show("All field must be entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!match.Success)
            {
                MessageBox.Show("Staff name must contained alphabetical characters only", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Staff details changed!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            grpChangeStaff.Visible = false;

            grpSelectStaff.Visible = true;
        }

        private void mnuItmAddFoodType_Click(object sender, EventArgs e)
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

        private void mnuItmChangeFoodItm_Click(object sender, EventArgs e)
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

        private void mnuItmFoodAnalysis_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmFoodAnalysis frmFoodAnalysis = new frmFoodAnalysis();
            frmFoodAnalysis.Show();
        }

        private void mnuItmAddStaff_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAddStaff frmAddStaff = new frmAddStaff();
            frmAddStaff.Show();
        }

        private void mnuItmRemoveStaff_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRemoveStaff frmRemoveStaff = new frmRemoveStaff();
            frmRemoveStaff.Show();
        }
    }
}
