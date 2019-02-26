using Oracle.DataAccess.Client;
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
            DataSet ds = new DataSet();

            this.Hide();
            frmFoodOrder frmFoodOrder = new frmFoodOrder();
            frmFoodOrder.Show();
            frmFoodOrder.lblTableNumber.Text = "1";
        }

        private void btnTable2_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmFoodOrder frmFoodOrder = new frmFoodOrder();
            frmFoodOrder.Show();
            frmFoodOrder.lblTableNumber.Text = "2";
        }

        private void frmTableInterface_Load(object sender, EventArgs e)
        {
            List<Button> tableButtons = new List<Button>();
            tableButtons.Add(btnTable1);
            tableButtons.Add(btnTable2);
            tableButtons.Add(btnTable3);
            tableButtons.Add(btnTable4);
            tableButtons.Add(btnTable5);
            tableButtons.Add(btnTable6);

            //tableButtons[4].Text += "\n something on table ";


            //Define a method that will display all the table price on the table interface
            //if a table has an order, it will display the price, if not if just skip through it
            //int tableIndex = 1;
            DataSet ds = new DataSet();
            for (int tableIndex = 1; tableIndex < 7; tableIndex++)
            {
                //get selected table order with status U
                ds = Table.getUnpaidSelectedTableOrder(ds, tableIndex);

                //check if DS has zero record
                if (ds == null)
                {
                    return;
                }

                //display price below the table number
                else if (ds.Tables["Table Order"].Rows.Count == 1)
                {
                    tableButtons[tableIndex - 1].Text += ("\n" + ds.Tables["Table Order"].Rows[0][4]);
                }
               ds.Clear();

            }
        }
    }
}
