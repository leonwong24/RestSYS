using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace RestSYS
{
    public partial class frmChangeFoodItem : Form
    {
        public frmChangeFoodItem()
        {
            InitializeComponent();
            //Generate GridBox row data
            this.grdChangeFoodItemSelectFoodItem.Rows.Add("Fish & Chips", "Fried battered fish and hot potato chips served with tartare sauce", 15.50, 'A', 'M');

            //Generate change food 
            txtChangeFoodItem.Text = "Fish & Chips";
            txtChangeFoodItemDesc.Text = "Fried battered fish and hot potato chips served with tartare sauce";
            txtChgFoodItemPrice.Text = "15.50";
            cboChangeFoodItemFoodType.SelectedIndex = 0;
            cboChangeFoodItemFoodStatus.SelectedIndex = 0;

        }

        private void btnChgFoodItemSubmit_Click(object sender, EventArgs e)
        {
            bool allCorrect = true;
            //validate data
            if (txtChangeFoodItem.Text.Equals(""))
            {
                MessageBox.Show("Food Item name must be entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                allCorrect = false;
            }

            else if (txtChangeFoodItemDesc.Text.Equals(""))
            {
                MessageBox.Show("Food item description must be entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                allCorrect = false;
            }

            else if (cboChangeFoodItemFoodType.SelectedItem == null)
            {
                MessageBox.Show("Food item type must be entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                allCorrect = false;
            }

            else if (txtChgFoodItemPrice.Text.Equals(""))
            {
                MessageBox.Show("Food item price must be entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                allCorrect = false;
            }

            else if (cboChangeFoodItemFoodStatus.SelectedItem == null)
            {
                MessageBox.Show("Food item status must be entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                allCorrect = false;
            }

            else
            {
                //Price value must be greater than 0
                Match validPrice1 = Regex.Match(txtChgFoodItemPrice.Text, @"\d\d\.\d\d");
                Match validPrice2 = Regex.Match(txtChgFoodItemPrice.Text, @"\d");
                Match validPrice3 = Regex.Match(txtChgFoodItemPrice.Text, @"\d\d");
                Match validPrice4 = Regex.Match(txtChgFoodItemPrice.Text, @"\d.\d\d");
                if(!validPrice1.Success && !validPrice2.Success && !validPrice3.Success && !validPrice4.Success)
                {
                    MessageBox.Show("Food item price must be in decimal form and greater than 0");
                    allCorrect = false;
                }
            }

            if (allCorrect == true)
            {
                MessageBox.Show("Food item changed successfully!");
                txtChangeFoodItem.Clear();
                txtChangeFoodItemDesc.Clear();
                txtChgFoodItemPrice.Clear();
                cboChangeFoodItemFoodStatus.SelectedIndex = -1;
                cboChangeFoodItemFoodType.SelectedIndex = -1;
                grpChangeFoodItemSelectFood.Visible = true;
                grpChangeFoodItemChangeFood.Visible = false;
            }
        }

        private void btnChangeFoodItemSelectFoodItemButton_Click(object sender, EventArgs e)
        {
            if(grdChangeFoodItemSelectFoodItem.SelectedRows.Count < 0)
            {
                MessageBox.Show("Please select the food item to change");
            }
            else if(grdChangeFoodItemSelectFoodItem.SelectedRows.Count > 1)
            {
                MessageBox.Show("Please select one food item to change only");
            }

            else
            {
                grpChangeFoodItemSelectFood.Visible = false;
                grpChangeFoodItemChangeFood.Visible = true;
            }
        }

        private void addFoodTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            frmAddFoodType frmAddFoodType = new frmAddFoodType();
            frmAddFoodType.Show();
        }

        private void addFoodItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            frmAddFoodItem frmAddFoodItem = new frmAddFoodItem();
            frmAddFoodItem.Show();
        }

        private void mnuBack_Click(object sender, EventArgs e)
        {
            this.Close();
            frmHomeInterface frmHomeInterface = new frmHomeInterface();
            frmHomeInterface.Show();
        }

        private void revenueAnalysisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRevenueAnalysis frmRevenueAnalysis = new frmRevenueAnalysis();
            frmRevenueAnalysis.Show();
        }

        private void foodAnalysisToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void mnuItmChangeStaff_Click(object sender, EventArgs e)
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
