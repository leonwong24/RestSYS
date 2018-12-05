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
    public partial class frmAddFoodItem : Form
    {
        frmHomeInterface parent;

        public frmAddFoodItem()
        {
            InitializeComponent();
        }
        public frmAddFoodItem(frmHomeInterface Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void btnAddFoodItemSubmit_Click(object sender, EventArgs e)
        {
            bool allCorrect = true;
            //validate data
            if (txtAddFoodItem.Text.Equals(""))
            {
                MessageBox.Show("Food Item name must be entered", "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                allCorrect = false;
            }

            else if (txtAddFoodItemDesc.Text.Equals(""))
            {
                MessageBox.Show("Food item description must be entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                allCorrect = false;
            }

            else if (cboAddFoodItemType.SelectedItem == null)
            {
                MessageBox.Show("Food item type must be entered","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                allCorrect = false;
            }

            else if (txtAddFoodItemPrice.Text.Equals(""))
            {
                MessageBox.Show("Food item price must be entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                allCorrect = false;
            }

            else if (cboAddFoodItemStatus.SelectedItem == null)
            {
                MessageBox.Show("Food item status must be entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                allCorrect = false;
            }

            else
            {

                 //Price value must be greater than 0
                    if (txtAddFoodItemPrice.Text.All(Char.IsDigit))
                    {
                        if (double.Parse(txtAddFoodItemPrice.Text) < 0.0)
                        {
                            MessageBox.Show("Food item price must greater than 0");
                            allCorrect = false;
                        }
                    }

                    else
                    {
                        MessageBox.Show("Food item price must be in decimal form");
                        allCorrect = false;             
                    }
            }

            if(allCorrect == true)
            {
                MessageBox.Show("Food item added successfully!");
                txtAddFoodItem.Clear();
                txtAddFoodItemDesc.Clear();
                txtAddFoodItemPrice.Clear();
                cboAddFoodItemStatus.SelectedIndex = -1;
                cboAddFoodItemType.SelectedIndex = -1;
            }
          
            

            //display confirmation message 

                //save food item details 

                //clear the ui
        }

        private void addFoodTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtAddFoodItem.Clear();
            txtAddFoodItemDesc.Clear();
            txtAddFoodItemPrice.Clear();
            cboAddFoodItemStatus.SelectedIndex = -1;
            cboAddFoodItemType.SelectedIndex = -1;
            this.Hide();
            frmAddFoodType frmAddFoodType = new frmAddFoodType();
            frmAddFoodType.Show();
        }

        private void changeFoodItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtAddFoodItem.Clear();
            txtAddFoodItemDesc.Clear();
            txtAddFoodItemPrice.Clear();
            cboAddFoodItemStatus.SelectedIndex = -1;
            cboAddFoodItemType.SelectedIndex = -1;
            this.Hide();
            frmChangeFoodItem frmChangeFoodItem = new frmChangeFoodItem();
            frmChangeFoodItem.Show();
        }



        private void mnuBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void frmAddFoodItem_Load(object sender, EventArgs e)
        {

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
