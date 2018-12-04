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
    public partial class frmHomeInterface: Form
    {
       
        public frmHomeInterface()
        {
            InitializeComponent();
        }

        private void btnHomeToManager_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAddFoodItem frmAddFoodItem = new frmAddFoodItem(this);
            frmAddFoodItem.Show();
        }

        private void btnHomeToOrder_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmTableInterface frmTableInterface = new frmTableInterface();
            frmTableInterface.Show();
        }
    
    }
}
