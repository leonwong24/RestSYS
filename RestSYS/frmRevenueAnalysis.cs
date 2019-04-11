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
    public partial class frmRevenueAnalysis : Form
    {
        private String yearSelected;
        private String monthSelected;
        private String weekSelected;
        public frmRevenueAnalysis()
        {
            InitializeComponent();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            MessageBox.Show("A revenue analysis report has send to printer");
        }

        private void foodAnalysisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmFoodAnalysis frmFoodAnalysis = new frmFoodAnalysis();
            frmFoodAnalysis.Show();
        }

        private void addFoodTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAddFoodType frmAddFoodType = new frmAddFoodType();
            frmAddFoodType.Show();

        }

        private void mnuItmChangeFoodItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmChangeFoodItem frmChangeFoodItem = new frmChangeFoodItem();
            frmChangeFoodItem.Show();
        }

        private void mnuItmAddFoodItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAddFoodItem frmAddFoodItem = new frmAddFoodItem();
            frmAddFoodItem.Show();
        }

        private void mnuOrder_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmTableInterface frmTableInterface = new frmTableInterface();
            frmTableInterface.Show();
        }

        private void mnuBck_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmHomeInterface frmHomeInterface = new frmHomeInterface();
            frmHomeInterface.Show();
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

        private void frmRevenueAnalysis_Load(object sender, EventArgs e)
        {
            //load the year combo box with the year
            DataSet ds = new DataSet();
            ds = Revenue.loadYear(ds);

            //load year
            for (int i = 0; i < ds.Tables["year"].Rows.Count; i++)
            {
                cboYear.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }

            //display on the gridbox
            ds = Revenue.displayAnnualRecord(ds);
            for (int i = 0; i < ds.Tables["annual"].Rows.Count; i++)
            {
                DataGridViewRow row = (DataGridViewRow)grdRevnAnalys.Rows[0].Clone();
                row.Cells[0].Value = ds.Tables["annual"].Rows[i][0].ToString();
                row.Cells[1].Value = "";
                row.Cells[2].Value = "";
                row.Cells[3].Value = "";
                row.Cells[4].Value = ds.Tables["annual"].Rows[i][1].ToString();
                grdRevnAnalys.Rows.Add(row);
            }
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
                //reset the grdview
                grdRevnAnalys.Rows.Clear();

                //reset other combo
                cboMonth.Items.Clear();
                cboWeek.Items.Clear();

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
                ds = Revenue.displayMonthlyRecord(ds, yearSelected);
                for (int i = 0; i < ds.Tables["monthly"].Rows.Count; i++)
                {
                    DataGridViewRow row = (DataGridViewRow)grdRevnAnalys.Rows[0].Clone();
                    row.Cells[0].Value = yearSelected;
                    row.Cells[1].Value = ds.Tables["monthly"].Rows[i][0].ToString();
                    row.Cells[2].Value = "";
                    row.Cells[3].Value = "";
                    row.Cells[4].Value = ds.Tables["monthly"].Rows[i][1].ToString();
                    grdRevnAnalys.Rows.Add(row);
                }
            }
        }

        private void cboMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            //reset the grdView
            grdRevnAnalys.Rows.Clear();

            //reset the comboBox
            cboWeek.Items.Clear();
            monthSelected = cboMonth.Text.Trim();

            //display on the gridbox
            DataSet ds = new DataSet();
            ds = Revenue.displayWeeklyRecord(ds, yearSelected, monthSelected);
            for (int i = 0; i < ds.Tables["weekly"].Rows.Count; i++)
            {
                DataGridViewRow row = (DataGridViewRow)grdRevnAnalys.Rows[0].Clone();
                row.Cells[0].Value = yearSelected;
                row.Cells[1].Value = monthSelected;
                row.Cells[2].Value = ds.Tables["weekly"].Rows[i][0].ToString();
                row.Cells[3].Value = "";
                row.Cells[4].Value = ds.Tables["weekly"].Rows[i][1].ToString();
                grdRevnAnalys.Rows.Add(row);
            }

            //display or reload the week combo box
            ds = new DataSet();
            ds = Revenue.loadWeek(ds, yearSelected,monthSelected);
            //load month combo box
            for (int i = 0; i < ds.Tables["week"].Rows.Count; i++)
            {
                cboWeek.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
        }

        private void cboWeek_SelectedIndexChanged(object sender, EventArgs e)
        {
            //reset the grdView
            grdRevnAnalys.Rows.Clear();

            //reset the comboBox

            weekSelected = cboWeek.Text.Trim();

            //display on the gridbox
            DataSet ds = new DataSet();
            ds = Revenue.displayDailyRecord(ds, yearSelected, monthSelected,weekSelected);
            for (int i = 0; i < ds.Tables["daily"].Rows.Count; i++)
            {
                DataGridViewRow row = (DataGridViewRow)grdRevnAnalys.Rows[0].Clone();
                row.Cells[0].Value = yearSelected;
                row.Cells[1].Value = monthSelected;
                row.Cells[2].Value = weekSelected;
                row.Cells[3].Value = ds.Tables["daily"].Rows[i][0].ToString();
                row.Cells[4].Value = ds.Tables["daily"].Rows[i][1].ToString();
                grdRevnAnalys.Rows.Add(row);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            yearSelected = null;
            monthSelected = null;
            weekSelected = null;

            //reset other combo
            cboMonth.Items.Clear();
            cboWeek.Items.Clear();
            cboYear.Items.Clear();

            //load the year combo box with the year
            DataSet ds = new DataSet();
            ds = Revenue.loadYear(ds);

            //load year
            for (int i = 0; i < ds.Tables["year"].Rows.Count; i++)
            {
                cboYear.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }

            grdRevnAnalys.Rows.Clear();
            //display on the gridbox
            ds = Revenue.displayAnnualRecord(ds);
            for (int i = 0; i < ds.Tables["annual"].Rows.Count; i++)
            {
                DataGridViewRow row = (DataGridViewRow)grdRevnAnalys.Rows[0].Clone();
                row.Cells[0].Value = ds.Tables["annual"].Rows[i][0].ToString();
                row.Cells[1].Value = "";
                row.Cells[2].Value = "";
                row.Cells[3].Value = "";
                row.Cells[4].Value = ds.Tables["annual"].Rows[i][1].ToString();
                grdRevnAnalys.Rows.Add(row);
            }
        }
    }
}
