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
        public frmAddFoodItem()
        {
            InitializeComponent();
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

            else if (txtAddFoodItemType.Text.Equals(""))
            {
                MessageBox.Show("Food item type must be entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                allCorrect = false;
            }

            else if (txtAddFoodItemPrice.Text.Equals(""))
            {
                MessageBox.Show("Food item price must be entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                allCorrect = false;
            }

            else if (txtAddFoodItemStatus.Text.Equals(""))
            {
                MessageBox.Show("Food item status must be entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                allCorrect = false;
            }

            //food type must be one alphabetic character and must exist in Food type
            if (!txtAddFoodItemType.Text.All(Char.IsLetter))
            {
                MessageBox.Show("Food item type must be one alphabetic character only");
                allCorrect = false;
            }

            else if (!txtAddFoodItemType.Text.Equals("m"))
            {
                MessageBox.Show("Food item type must be exist in food item table");
                allCorrect = false;
            }

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
            

            //Status must be one alphabetic character , and must only be A and U
            if (!txtAddFoodItemStatus.Text.All(Char.IsLetter))
            {
                MessageBox.Show("Food item status must be one alphabetic character only");
                allCorrect = false;
            }

            else if(!txtAddFoodItemStatus.Text.Equals("A") && !txtAddFoodItemStatus.Text.Equals("U"))
            {
                MessageBox.Show("Food item status must only be 'A' or 'U'");
                allCorrect = false;
            }


            if(allCorrect == true)
            {
                MessageBox.Show("Food item added successfully!");
                txtAddFoodItem.Clear();
                txtAddFoodItemDesc.Clear();
                txtAddFoodItemPrice.Clear();
                txtAddFoodItemStatus.Clear();
                txtAddFoodItemType.Clear();
            }
          
            

            //display confirmation message 

                //save food item details 

                //clear the ui
        }
    }
}
