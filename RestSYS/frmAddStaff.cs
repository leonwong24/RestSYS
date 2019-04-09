using System;
using Oracle.ManagedDataAccess.Client;
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
    public partial class frmAddStaff : Form
    {
        public frmAddStaff()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //Staff Name must contain only alphabetic character
            System.Text.RegularExpressions.Regex regex = new System.Text.RegularExpressions.Regex("^[a-zA-z]*$");
            System.Text.RegularExpressions.Match match = regex.Match(txtStaffName.Text);

            if (txtStaffName.Text.Equals(""))
            {
                MessageBox.Show("All field must be entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!match.Success) {
                MessageBox.Show("Staff name must contained alphabetical characters only", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if(cboStaffStatus.SelectedIndex == -1)
            {
                MessageBox.Show("Staff Status must be choose", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //Save staff details into staff
                Staff newStaff = new Staff(Convert.ToInt32(txtStaffId.Text), txtStaffName.Text.Trim(),cboStaffStatus.Text.Trim().Substring(0,1));

                //Execute Insert command
                newStaff.addNewStaff();

                MessageBox.Show("Staff Added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Clear the textbox and update the staffId
                txtStaffId.Text = Convert.ToString(Staff.nextStaffId());
                txtStaffName.Clear();
            
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
            frmAddFoodItem frmaAddFoodItem = new frmAddFoodItem();
            frmaAddFoodItem.Show();
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

        private void mnuItmChangeStaff_Click(object sender, EventArgs e)
        {
            this.Close();
            frmChangeStaff frmChangeStaff = new frmChangeStaff();
            frmChangeStaff.Show();
        }

        private void frmAddStaff_Load(object sender, EventArgs e)
        {
            this.txtStaffId.Text = Convert.ToString(Staff.nextStaffId());
            this.cboStaffStatus.SelectedIndex = 0;
        }

    }
}
