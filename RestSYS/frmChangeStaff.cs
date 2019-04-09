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
            //if user doesn't select a staff 
            if(cboStaffName.SelectedItem == null)
            {
                MessageBox.Show("A staff must be selected to change", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DataSet ds = new DataSet();
                //MessageBox.Show(cboStaffName.Text.Substring(0, 2));
                ds = Staff.getSelectedStaff(ds, Convert.ToInt32(cboStaffName.Text.Substring(0,2)));
                //set the staff name text box from the combo box 
                txtStaffName.Text = ds.Tables["Selected Staff"].Rows[0][1].ToString().Trim();

                //load the appropriate staff status .
                if(ds.Tables["Selected Staff"].Rows[0][2].ToString() == "W")
                {
                    cboStaffStatus.SelectedIndex = 0;
                }
                else
                {
                    cboStaffStatus.SelectedIndex = 1;
                }
                
                //display group box 
                grpSelectStaff.Visible = false; //Hide select staff group box
                grpChangeStaff.Visible = true;  //Show select staff group box
            }

        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            //Staff name must contain only alphabetic character
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
                //Show success message
                MessageBox.Show("Staff details changed!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Save staff details into new staff
                Staff changedStaff = new Staff(Convert.ToInt32(cboStaffName.Text.Trim().Substring(0,2)),txtStaffName.Text,cboStaffStatus.Text.Trim().Substring(0,1));

                //Update staff details;
                changedStaff.updateStaff();

                //Clears the UI
                txtStaffName.Clear();
                grpChangeStaff.Visible = false;
                grpSelectStaff.Visible = true;
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

        private void mnuItmChangeFoodItm_Click(object sender, EventArgs e)
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

        private void mnuItmAddStaff_Click(object sender, EventArgs e)
        {
            this.Close();
            frmAddStaff frmAddStaff = new frmAddStaff();
            frmAddStaff.Show();
        }

        private void mnuItmRemoveStaff_Click(object sender, EventArgs e)
        {
            this.Close();
            frmRemoveStaff frmRemoveStaff = new frmRemoveStaff();
            frmRemoveStaff.Show();
        }

        private void frmChangeStaff_Load(object sender, EventArgs e)
        {
            //load all staff into the dataset and display in the combo box
            DataSet DS = new DataSet();
            DS = Staff.getAllStaff(DS);

            for(int i = 0; i < DS.Tables["All Staff"].Rows.Count; i++)
            {
                cboStaffName.Items.Add(DS.Tables[0].Rows[i][0].ToString().PadLeft(2,'0') + " : " + DS.Tables[0].Rows[i][1].ToString());
            }
        }

        //Define a method that will extract the staff details and store inside the staff
        private void cboStaffName_SelectedIndexChange(object sender, EventArgs e)
        {
            //if resetting combo, ignore...
            if (cboStaffName.SelectedIndex == -1)
            {
                return;
            }

            //find food type details , create a new fooditems and store the food type details into food item
            Staff staff = new Staff();
            staff.setStaffId(Convert.ToInt32(cboStaffName.Text.Trim().Substring(0, 2)));
           // MessageBox.Show(cboStaffName.Text.Substring(0, 2));

            //Validation to prevent the staffId is empty
            if (staff.getStaffId() == -1)
            {
                MessageBox.Show("No staff selected", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

    }
}
