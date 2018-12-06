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
        public frmRevenueAnalysis()
        {
            InitializeComponent();
            this.grdRevnAnalys.Rows.Add("2018", "1", "1", "800.30");
            this.grdRevnAnalys.Rows.Add("2018", "1", "2", "500.10");
            this.grdRevnAnalys.Rows.Add("2018", "1", "3", "1300.40");
            this.grdRevnAnalys.Rows.Add("2018", "1", "4", "1500.20");

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
    }
}
