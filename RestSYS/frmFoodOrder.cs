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
        //int row = -1; //order data grid row
        int number;
        int totalQty = 0;
        int qtyToDeduct;
        double totalPrice = 0;
        double valuetoDeduct;
        public frmFoodOrder()
        {
            InitializeComponent();
            numberAsString = "";
            System.Windows.Forms.Timer MyTimer = new System.Windows.Forms.Timer(); //timer that will display on the UI, which record when the order taken
            MyTimer.Interval = 1000; //set it to 1 sec
            MyTimer.Tick += new EventHandler(MyTimer_Tick);
            MyTimer.Start();

            //DataGridRow that displays the total price and total qty of the order
            DataGridViewRow gridViewRow = (DataGridViewRow)grdOrder.Rows[0].Clone();
            gridViewRow.Cells[0].Value = "Total";
            gridViewRow.Cells[1].Value = totalQty;
            gridViewRow.Cells[3].Value = totalPrice;
            grdOrder.Rows.Add(gridViewRow);
            grdOrder.Enabled = false;
            grdOrder.Enabled = true;
        }


        private void MyTimer_Tick(object sender, EventArgs e)
        {
            this.lblTime.Text = DateTime.Now.ToString("hh:mm:ss"); //set the time to current system time
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

        private void btnNum1_Click(object sender, EventArgs e)
        {
            //Number 1
            numberAsString += "1";
        }

        private void btnNum3_Click(object sender, EventArgs e)
        {
            //Number 3 
            numberAsString += "3";
        }

        //Assume it retrieve all the avaliable food item from food items file

        private void btnFoodItem1_Click(object sender, EventArgs e) //Fish and Chips
        {
            //row++; //move to next datagrid row
            foodItemAsString = btnFoodItem1.Text;
            if (numberAsString == "")
            {
                number = 1;
            }
            else
            {
                Int32.TryParse(numberAsString, out number); //parse number as string to int to number
            }

            DataGridViewRow gridRow = (DataGridViewRow)grdOrder.Rows[0].Clone();
            gridRow.Cells[0].Value = foodItemAsString; //Set the food name column to selected food name
            gridRow.Cells[1].Value = number;   //Set the number of food ordered column to number value
            gridRow.Cells[2].Value = 20.50;    //Set the food price column to food unit price
            gridRow.Cells[3].Value = 20.50 * number;    //Set the total price of the food

            grdOrder.Rows.Add(gridRow);
            grdOrder.Enabled = false;
            grdOrder.Enabled = true;
            numberAsString = "";
            totalQty += number;
            totalPrice += 20.50 * number;
            grdOrder.Rows[0].Cells[1].Value = totalQty;
            grdOrder.Rows[0].Cells[3].Value = totalPrice;
        }

        private void btnFoodItem2_Click(object sender, EventArgs e) //Beef Steak
        {
            //row++; //move to next datagrid row
            foodItemAsString = btnFoodItem2.Text;
            if (numberAsString == "")
            {
                number = 1;
            }
            else
            {
                Int32.TryParse(numberAsString, out number); //parse number as string to int to number
            }

            DataGridViewRow gridRow = (DataGridViewRow)grdOrder.Rows[0].Clone();
            gridRow.Cells[0].Value = foodItemAsString; //Set the food name column to selected food name
            gridRow.Cells[1].Value = number;   //Set the number of food ordered column to number value
            gridRow.Cells[2].Value = 10.00;    //Set the food price column to food unit price
            gridRow.Cells[3].Value = 10.00 * number;    //Set the total price of the food

            grdOrder.Rows.Add(gridRow);
            grdOrder.Enabled = false;
            grdOrder.Enabled = true;
            numberAsString = "";
            totalQty += number;
            totalPrice += 10.00 * number;
            grdOrder.Rows[0].Cells[1].Value = totalQty;
            grdOrder.Rows[0].Cells[3].Value = totalPrice;
        }

        private void btnFoodItem3_Click(object sender, EventArgs e)//Chicken burger
        {
            //row++; //move to next datagrid row
            foodItemAsString = btnFoodItem3.Text;
            if (numberAsString == "")
            {
                number = 1;
            }
            else
            {
                Int32.TryParse(numberAsString, out number); //parse number as string to int to number
            }

            DataGridViewRow gridRow = (DataGridViewRow)grdOrder.Rows[0].Clone();
            gridRow.Cells[0].Value = foodItemAsString; //Set the food name column to selected food name
            gridRow.Cells[1].Value = number;   //Set the number of food ordered column to number value
            gridRow.Cells[2].Value = 8.00;    //Set the food price column to food unit price
            gridRow.Cells[3].Value = 8.00 * number;    //Set the total price of the food

            grdOrder.Rows.Add(gridRow);
            grdOrder.Enabled = false;
            grdOrder.Enabled = true;
            numberAsString = "";
            totalQty += number;
            totalPrice += 8.00 * number;
            grdOrder.Rows[0].Cells[1].Value = totalQty;
            grdOrder.Rows[0].Cells[3].Value = totalPrice;
        }

        private void btnFoodItem4_Click(object sender, EventArgs e)//Salad bowl
        {
            //row++; //move to next datagrid row
            foodItemAsString = btnFoodItem4.Text;
            if (numberAsString == "")
            {
                number = 1;
            }
            else
            {
                Int32.TryParse(numberAsString, out number); //parse number as string to int to number
            }

            DataGridViewRow gridRow = (DataGridViewRow)grdOrder.Rows[0].Clone();
            gridRow.Cells[0].Value = foodItemAsString; //Set the food name column to selected food name
            gridRow.Cells[1].Value = number;   //Set the number of food ordered column to number value
            gridRow.Cells[2].Value = 10.00;    //Set the food price column to food unit price
            gridRow.Cells[3].Value = 10.00 * number;    //Set the total price of the food

            grdOrder.Rows.Add(gridRow);
            grdOrder.Enabled = false;
            grdOrder.Enabled = true;
            numberAsString = "";
            totalQty += number;
            totalPrice += 10.00 * number;
            grdOrder.Rows[0].Cells[1].Value = totalQty;
            grdOrder.Rows[0].Cells[3].Value = totalPrice;
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            frmHomeInterface frmHomeInterface = new frmHomeInterface();
            frmHomeInterface.Show();
        }

        private void btnDeleteFoodRow_Click(object sender, EventArgs e)
        {   
            int rowToDelete = grdOrder.CurrentCell.RowIndex;

            //recalculate the total cost of the table
            String valueToDeductAsString = grdOrder.Rows[rowToDelete].Cells[3].Value.ToString();
            double.TryParse(valueToDeductAsString,out valuetoDeduct);
            totalPrice -= valuetoDeduct;

            //recalculate the total food item quantity of the table
            String qtyToDeductAsString = grdOrder.Rows[rowToDelete].Cells[1].Value.ToString();
            int.TryParse(qtyToDeductAsString, out qtyToDeduct);
            totalQty -= qtyToDeduct;

            //display updated row
            grdOrder.Rows[0].Cells[1].Value = totalQty;
            grdOrder.Rows[0].Cells[3].Value = totalPrice;

            //delete selected row
            grdOrder.Rows.RemoveAt(rowToDelete);
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            grdOrder.Rows[0].Cells[1].Value = totalQty;
            grdOrder.Rows[0].Cells[3].Value = totalPrice;
            MessageBox.Show("Order placed successfully!");
        }

        private void btnPrintBill_Click(object sender, EventArgs e)
        {
            if(totalQty == 0 && totalPrice == 0)
            {
                MessageBox.Show("This table has no any order yet!");
            }
            else
            {
                MessageBox.Show("Bill printed!");
            }
            
        }

        private void btnPayBill_Click(object sender, EventArgs e)
        {
            if(totalQty == 0 && totalPrice == 0)
            {
                MessageBox.Show("This table has no any order yet!");
            }
            else
            {
                MessageBox.Show("Table pay.");
            }
            
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            lblStaffName.Text = cboStaffSignIn.Text;
            grpStaffSign.Hide();
        }

        private void btnPromptSignIn_Click(object sender, EventArgs e)
        {
            grpStaffSign.Show();
        }

        private void frmFoodOrder_Load(object sender, EventArgs e)
        {

        }
    }
}
