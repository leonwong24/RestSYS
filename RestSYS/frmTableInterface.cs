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
    public partial class frmTableInterface : Form
    {
        public frmTableInterface()
        {
            InitializeComponent();
        }

        private void btnTable1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmFoodOrder frmFoodOrder = new frmFoodOrder();
            frmFoodOrder.Show();
            frmFoodOrder.lblTableNumber.Text = "1";
        }
    }
}
