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
            //input validation
            
            //foodtype is empty
            if (txtFoodType.Text.Equals(""))
            {
                MessageBox.Show("Food Type must be entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //foodtype is all char letter
            else if (!txtFoodType.Text.All(Char.IsLetter))
            {
                MessageBox.Show("Food Type must only be alphabetic character", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //foodtype description is empty
            else if (txtFdTypeDesc.Text.Equals(""))
            {
                MessageBox.Show("Food Description must be entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //foodtype exist in the database
            else if (FoodTypes.isFoodTypeExist(txtFoodType.Text))
            {
                MessageBox.Show("Food Type already existed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //valid input! 
            //display confirmation message
            else {MessageBox.Show("Valid Food Type! Food type has been inputed","Food Type input success",MessageBoxButtons.OK,MessageBoxIcon.Information); }

            //save food type detail in food type files
            txtFoodType.Text.ToUpper();
            FoodTypes foodtype = new FoodTypes(Convert.ToString(txtFoodType.Text[0]), txtFdTypeDesc.Text);

            //insert new foodtype into FoodTypes table in the database;
            foodtype.addNewFoodType();

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
            this.Close();
            frmRevenueAnalysis frmRevenueAnalysis = new frmRevenueAnalysis();
            frmRevenueAnalysis.Show();
        }

        private void foodAnalysisToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void mnuItmRemoveStaff_Click(object sender, EventArgs e)
        {
            this.Close();
            frmRemoveStaff frmRemoveStaff = new frmRemoveStaff();
            frmRemoveStaff.Show();
        }

        private void orderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            frmTableInterface frmTableInterface = new frmTableInterface();
            frmTableInterface.Show();
        }
    }
}
