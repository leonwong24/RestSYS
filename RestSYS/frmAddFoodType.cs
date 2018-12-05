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
    public partial class frmAddFoodType : Form
    {
        public frmAddFoodType()
        {
            InitializeComponent();
        }

        private void btnFdTypeSubmit_Click(object sender, EventArgs e)
        {
            //validate input
            if (txtFoodType.Text.Equals(""))
            {
                MessageBox.Show("Food Type must be entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else if (txtFdTypeDesc.Text.Equals(""))
            {
                MessageBox.Show("Food Description must be entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else if (txtFoodType.Text.Equals("M"))
            {
                MessageBox.Show("Food Type already added", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else if (!txtFoodType.Text.All(Char.IsLetter))
            {
                MessageBox.Show("Food Type must only be alphabetic character", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //display confirmation message
            else {MessageBox.Show("Valid Food Type! Food type has been inputed","Food Type input success",MessageBoxButtons.OK,MessageBoxIcon.Information); }

            //save food type detail in food type files
            txtFoodType.Text.ToUpper();
            //reset user interface
            txtFoodType.Clear();
            txtFdTypeDesc.Clear();
            txtFoodType.Focus();
        }

        private void addFoodItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            frmAddFoodItem formAddFoodItem = new frmAddFoodItem();
            formAddFoodItem.Show();
        }

        private void changeFoodItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            frmChangeFoodItem frmChangeFoodItem = new frmChangeFoodItem();
            frmChangeFoodItem.Show();
        }

        private void mnuBack_Click(object sender, EventArgs e)
        {
            this.Close();
            frmHomeInterface frmHomeInterface = new frmHomeInterface();
            frmHomeInterface.Show();
        }

        private void revenueAnalysisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRevenueAnalysis frmRevenueAnalysis = new frmRevenueAnalysis();
            frmRevenueAnalysis.Show();
        }

        private void foodAnalysisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFoodAnalysis frmFoodAnalysis = new frmFoodAnalysis();
            frmFoodAnalysis.Show();
        }

        private void mnuItmAddStaff_Click(object sender, EventArgs e)
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
