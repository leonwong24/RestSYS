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
    public partial class frmFoodAnalysis : Form
    {
        private static String yearSelected = null;
        private static String monthSelected = null;
        private static List<String> selectedFoodType = new List<string>();
        public frmFoodAnalysis()
        {
            InitializeComponent();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            MessageBox.Show("A food analysis report is sending to the printer");
        }

        private void mnuItemAddFoodType_Click(object sender, EventArgs e)
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
            this.Hide();
            frmRevenueAnalysis frmRevenueAnalysis = new frmRevenueAnalysis();
            frmRevenueAnalysis.Show();
        }

        private void addStaffToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void frmFoodAnalysis_Load(object sender, EventArgs e)
        {
            //load the year combo box with the year
            DataSet ds = new DataSet();
            ds = Revenue.loadYear(ds);

            //load year
            for (int i = 0; i < ds.Tables["year"].Rows.Count; i++)
            {
                cboYear.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }

            //load month
            ds = Revenue.loadMonth(ds, yearSelected);
            for (int i = 0; i < ds.Tables["month"].Rows.Count; i++)
            {
                cboMonth.Items.Add(ds.Tables["month"].Rows[i][0].ToString());
            }

            //display analysis
            displayAnalysis(grdFdAnlys);
        }

        private void cboYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if resetting combo, ignore...
            if (cboYear.SelectedIndex == -1)
            {
                return;
            }

            else
            {
                //reset the month combo box
                cboMonth.Items.Clear();

                monthSelected = null;

                yearSelected = cboYear.Text.Trim();

                //display or reload the month combo box
                DataSet ds = new DataSet();
                ds = Revenue.loadMonth(ds, yearSelected);
                //load month combo box
                for (int i = 0; i < ds.Tables["month"].Rows.Count; i++)
                {
                    cboMonth.Items.Add(ds.Tables[0].Rows[i][0].ToString());
                }

                //display on the gridbox
                displayAnalysis(grdFdAnlys);
            }
        }

        private void chkMain_CheckedChanged(object sender, EventArgs e)
        {
            if (selectedFoodType.Contains("M"))
            {
                selectedFoodType.Remove("M");
            }
            else
            {
                selectedFoodType.Add("M");
            }

            displayAnalysis(grdFdAnlys);
        }

        private void chkBeverage_CheckedChanged(object sender, EventArgs e)
        {
            if (selectedFoodType.Contains("B"))
            {
                selectedFoodType.Remove("B");
            }
            else
            {
                selectedFoodType.Add("B");
            }

            displayAnalysis(grdFdAnlys);
        }

        private void chkDessert_CheckedChanged(object sender, EventArgs e)
        {
            if (selectedFoodType.Contains("D"))
            {
                selectedFoodType.Remove("D");
            }
            else
            {
                selectedFoodType.Add("D");
            }

            displayAnalysis(grdFdAnlys);
        }

        private void chkStarter_CheckedChanged(object sender, EventArgs e)
        {
            if (selectedFoodType.Contains("S"))
            {
                selectedFoodType.Remove("S");
            }
            else
            {
                selectedFoodType.Add("S");
            }

            displayAnalysis(grdFdAnlys);
        }

        private static void displayAnalysis(DataGridView grdView)
        {
            grdView.Rows.Clear();
            DataSet ds = new DataSet();
            ds = FoodAnalysis.loadFdAnalysis(ds, yearSelected, monthSelected, selectedFoodType);
            for (int i = 0; i < ds.Tables["foodAnalysis"].Rows.Count; i++)
            {
                DataGridViewRow row = (DataGridViewRow)grdView.Rows[0].Clone();
                row.Cells[0].Value = ds.Tables["foodAnalysis"].Rows[i][0].ToString();
                row.Cells[1].Value = ds.Tables["foodAnalysis"].Rows[i][1].ToString();
                row.Cells[2].Value = ds.Tables["foodAnalysis"].Rows[i][2].ToString();
                row.Cells[3].Value = ds.Tables["foodAnalysis"].Rows[i][3].ToString();
                row.Cells[4].Value = ds.Tables["foodAnalysis"].Rows[i][4].ToString();
                grdView.Rows.Add(row);
            }
        }

        private void cboMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if resetting combo, ignore...
            if (cboYear.SelectedIndex == -1)
            {
                return;
            }
            else
            {
                monthSelected = cboMonth.Text.Trim();
            }

            displayAnalysis(grdFdAnlys);
        }
    }
}
