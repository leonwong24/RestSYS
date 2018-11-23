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
    public partial class frmFoodOrder : Form
    {
        String numberAsString;
        String foodItemAsString;
        public frmFoodOrder()
        {
            InitializeComponent();
            numberAsString = "";
        }

        private void btnTableInterface_Click(object sender, EventArgs e)
        {
            this.Close();
            frmTableInterface frmTableInterface = new frmTableInterface();
            frmTableInterface.Show();
        }

        private void btnNum2_Click(object sender, EventArgs e)
        {
            //Number 2 
            numberAsString += "2";
        }
    }
}
