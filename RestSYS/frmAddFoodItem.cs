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
            //validate data
            if (txtAddFoodItem.Text.Equals(""))
            {
                MessageBox.Show("Food Item name must be entered", "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (txtAddFoodItemDesc.Text.Equals(""))
            {
                MessageBox.Show("Food item description must be entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (txtAddFoodItemType.Text.Equals(""))
            {
                MessageBox.Show("Food item type must be entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (txtAddFoodItemPrice.Text.Equals(""))
            {
                MessageBox.Show("Food item price must be entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (txtAddFoodItemStatus.Text.Equals(""))
            {
                MessageBox.Show("Food item status must be entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //display confirmation message 

                //save food item details 

                //clear the ui
        }
    }
}
