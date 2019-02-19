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
                txtChgFoodItemPrice.ResetText();
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
                //save the selected row into a food item object
                //first we have to get the row index from datagridview to retrieve the row
                int rowIndex = grdChangeFoodItemSelectFoodItem.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = grdChangeFoodItemSelectFoodItem.Rows[rowIndex];

                //create fooditem object based on the selected row
                FoodItems selectedItem = new FoodItems(Convert.ToInt32(selectedRow.Cells[0].Value), Convert.ToString(selectedRow.Cells[1].Value), Convert.ToString(selectedRow.Cells[2].Value), Convert.ToString(selectedRow.Cells[3].Value), Convert.ToDecimal(selectedRow.Cells[4].Value), Convert.ToString(selectedRow.Cells[5].Value));

                //set all the text to the corresponding food items variable
                this.txtChangeFoodItem.Text = selectedItem.getItemName();
                this.txtChangeFoodItemDesc.Text = selectedItem.getDescription();
                DataSet DS = new DataSet();
                DS = FoodTypes.getAllFoodType(DS);
                for (int i = 0; i < DS.Tables["ss"].Rows.Count; i++)
                {
                    this.cboChangeFoodItemFoodType.Items.Add(DS.Tables[0].Rows[i][0].ToString().PadLeft(0) + " : " + DS.Tables[0].Rows[i][1].ToString());
                }
                this.cboChangeFoodItemType.Text = selectedItem.getFoodType();
                this.txtChgFoodItemPrice.Value = selectedItem.getPrice();
                this.cboChangeFoodItemFoodStatus.Text = selectedItem.getStatus();


                //display change food item group
                grpChangeFoodItemSelectFood.Visible = false;
                grpChangeFoodItemChangeFood.Visible = true;
            }
        }

        //define a method that load the combo box with the existing food types
        private void frmChangeFoodItem_Load(object sender, EventArgs e)
        {
            //load food type combo box with food types and description
            DataSet ds = new DataSet();
            ds = FoodTypes.getAllFoodType(ds);

            for (int i = 0; i < ds.Tables["ss"].Rows.Count; i++)
            {
                cboChangeFoodItemType.Items.Add(ds.Tables[0].Rows[i][0].ToString().PadLeft(0) + " : " + ds.Tables[0].Rows[i][1].ToString());
            }
        }

        //Define a method that detect change in fooditemtype combo box and display all the food with that food type on the grid box
        private void cboChangeFoodItemType_SelectedIndexChange(object sender,EventArgs e)
        {
            //if resetting combo, ignore...
            if(cboChangeFoodItemType.SelectedIndex == -1)
            {
                return;
            }

            //Retrieve the food type and store the food type inside a variable and pass into the SQL
            MessageBox.Show("Change Detected!");
            string foodType = cboChangeFoodItemType.Text.Substring(0, 1);

            //Get the dataset by passing the foodtype as parameter to retrieve selectedFoodItem dataset
            DataSet DS = new DataSet();

            DS = FoodItems.getSelectedFoodItem(DS, foodType);

            //remove previous item in the gridview
            //for(int r = 0 ;  r <  this.grdChangeFoodItemSelectFoodItem.Rows.Count ; r++)
            //{
               // grd
            //}

            //load data from ds to grpChangeFoodItemSelectFood
            if (DS != null)
            {
                if (DS.Tables[0].Rows.Count != 0)
                {
                    //grdChangeFoodItemSelectFoodItem.AutoGenerateColumns = true;
                    //grdChangeFoodItemSelectFoodItem.DataSource = DS;
                    grdChangeFoodItemSelectFoodItem.DataSource = DS.Tables["FoodItems"];
                    /*int row = DS.Tables["FoodItems"].Rows.Count - 1;
                    for(int r = 0; r <= row; r++)
                    {
                        grdChangeFoodItemSelectFoodItem.Rows.Add();
                        grdChangeFoodItemSelectFoodItem.Rows[r].Cells[0].Value = DS.Tables["FoodItems"].Rows[r].ItemArray[0];
                        grdChangeFoodItemSelectFoodItem.Rows[r].Cells[1].Value = DS.Tables["FoodItems"].Rows[r].ItemArray[1];
                        grdChangeFoodItemSelectFoodItem.Rows[r].Cells[2].Value = DS.Tables["FoodItems"].Rows[r].ItemArray[2];
                        grdChangeFoodItemSelectFoodItem.Rows[r].Cells[3].Value = DS.Tables["FoodItems"].Rows[r].ItemArray[3];
                        grdChangeFoodItemSelectFoodItem.Rows[r].Cells[4].Value = DS.Tables["FoodItems"].Rows[r].ItemArray[4];
                    }*/
                }
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

        private void orderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmTableInterface frmTableInterface = new frmTableInterface();
            frmTableInterface.Show();
        }
    }
}
