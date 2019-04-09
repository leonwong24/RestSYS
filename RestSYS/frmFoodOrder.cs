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
        private static String numberAsString;
        private static String foodItemAsString;
        //int row = -1; //order data grid row
        private static int number;
        public static int totalQty;
        public static decimal totalPrice;
        public static List<Button> menuButton = new List<Button> ();
        private Orders order = new Orders();

        internal Orders Order { get => order; set => order = value; }

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
            //clear all the static variable in the order class
            Orders.orderItems.Clear();
            grdOrder.Rows.Clear();
            totalPrice = 0;
            totalQty = 0;

            menuButton.Clear();
            this.Close();
            frmTableInterface frmTableInterface = new frmTableInterface();
            frmTableInterface.Show();
        }

        private void btnNum2_Click(object sender, EventArgs e)
        {
            //Number 2 
            if (Orders.state == 1)
            {
                numberAsString += "2";
            }
        }

        private void btnNum1_Click(object sender, EventArgs e)
        {
            //Number 1
            if(Orders.state == 1)
            {
                numberAsString += "1";
            }
        }

        private void btnNum3_Click(object sender, EventArgs e)
        {
            if (Orders.state == 1)
            {
                numberAsString += "3";
            }
        }

        //A method that set the gridview data from the given orderNo store in Orders.foodOrder
        private void setGrdOrderDataFromOrderItems(DataSet ds)
        {
            //not done yet
            grdOrder.DataSource = ds.Tables[0];
        }

        //Assume it retrieve all the avaliable food item from food items file

        private void btnFoodItem1_Click(object sender, EventArgs e) 
        {
            clickOnBtn(1,menuButton[0],grdOrder);
        }

        private void btnFoodItem2_Click(object sender, EventArgs e) 
        {
            clickOnBtn(2, menuButton[1], grdOrder);
        }

        private void btnFoodItem3_Click(object sender, EventArgs e)
        {
            clickOnBtn(3, menuButton[2], grdOrder);
        }

        private void btnFoodItem4_Click(object sender, EventArgs e)
        {
            clickOnBtn(4, menuButton[3], grdOrder);
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //clear all the static variable in the order class
            Orders.orderItems.Clear();
            grdOrder.Rows.Clear();

            //reset the totalPrice and totalQty
            totalPrice = 0;
            totalQty = 0;

            //remove the button from the list
            menuButton.Clear();
            this.Close();
            frmTableInterface frmTableInterface = new frmTableInterface();
            frmTableInterface.Show();

        }

        private void btnDeleteFoodRow_Click(object sender, EventArgs e)
        {   
            int rowToDelete = grdOrder.CurrentCell.RowIndex;
            MessageBox.Show(Convert.ToString(rowToDelete));
            Boolean isEmpty = false;
            //check if the selected row is empty
            for(int i = 0; i < grdOrder.Columns.Count; i++)
            {
                if(Convert.ToString(grdOrder.Rows[rowToDelete].Cells[i].Value).Equals(""))
                {
                    isEmpty = true;
                    break;
                }
            }

           if (!isEmpty)
            {
                MessageBox.Show("HALO");
                //remove the selected fooditem from the gridview

                //recalculate the total cost of the table
                totalPrice -= Convert.ToDecimal(grdOrder.Rows[rowToDelete].Cells[3].Value);

                //recalculate the total food item quantity of the table
                totalQty -= Convert.ToInt32(grdOrder.Rows[rowToDelete].Cells[1].Value);

                //display updated row
                grdOrder.Rows[0].Cells[1].Value = totalQty;
                grdOrder.Rows[0].Cells[3].Value = totalPrice;
                order.Value = totalPrice;

                //delete selected row
                grdOrder.Rows.RemoveAt(rowToDelete);

                //remove the food from the Orders.orderItems
                Orders.orderItems.RemoveAt(rowToDelete - 1);
            }

            else if(rowToDelete == 0)
            {
                MessageBox.Show("You can't remove the first row");
            }
            else
            {
                MessageBox.Show("You can't remove this empty row");
            }
            
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            if(Orders.orderItems.Count == 0)
            {
                MessageBox.Show("This table doesn't have any order yet!");
            }

            else if (order.StaffId == 0)
            {
                MessageBox.Show("Staff haven't sign in");
            }
            else
            {
                MessageBox.Show("totalPrice is " + totalPrice);
                MessageBox.Show("total Qty is" + totalQty);
                String printoutmsg = "";
                foreach(int[] order in Orders.orderItems)
                {
                    for(int i = 0; i < order.Length; i++)
                    {
                        printoutmsg += order[i] + "\t";
                    }
                    printoutmsg += "\n";
                }
                MessageBox.Show(printoutmsg);
               

                if(Table.tableList[Convert.ToInt32(lblTableNumber.Text)] == 0) //if table has no order yet
                {
                    MessageBox.Show("new order!");
                    //insert sql command into OrderItems Table
                    String sql = "INSERT ALL ";
                    foreach(int[] order in Orders.orderItems)
                    {
                        sql += "INTO OrderItems(OrderNo,ItemId,Qty,Price) VALUES ";
                        sql += "("+lbl_OrderNo.Text +","; //orderNo
                        sql += order[0] +","; //itemId
                        sql += order[1] + ","; //qty
                        FoodItems fooditem = FoodItems.getFood(order[0]);
                        sql += fooditem.getPrice() * order[1] +")";

                    }
                    sql += "SELECT 1 FROM DUAL";
                    MessageBox.Show(sql);
                    Orders.runSQL(sql);

                    //insert sql command into Orders Table
                    Orders.insertOrders(order);

                    MessageBox.Show("Order placed successfully!");
                    Table.tableList[Convert.ToInt32(lblTableNumber.Text.Trim())] = Convert.ToInt32(lbl_OrderNo.Text.Trim());
                }
                else {  //table already has order
                    MessageBox.Show("Table already has order");
                    //delete all the order with its orderNo and reload with the new one
                    String deleteSql = "DELETE FROM OrderItems WHERE OrderNo = " + Convert.ToString(lbl_OrderNo.Text.Trim());
                    Orders.runSQL(deleteSql);
                    MessageBox.Show("Orders Item deleted");
                    //insert sql command into OrderItems Table
                    //Orders orderTable = new Orders(Convert.ToInt32(lbl_OrderNo.Text.Trim()), Convert.ToInt32(lblTableNumber.Text.Trim()), totalPrice, Convert.ToInt32(lblStaffName.Text.Trim().Substring(0,3)), "U");
                    String sql = "INSERT ALL ";
                    foreach (int[] order in Orders.orderItems)
                    {
                        sql += "INTO OrderItems(OrderNo,ItemId,Qty,Price) VALUES ";
                        sql += "(" + lbl_OrderNo.Text + ","; //orderNo
                        sql += order[0] + ","; //itemId
                        sql += order[1] + ","; //qty
                        FoodItems fooditem = FoodItems.getFood(order[0]);
                        sql += fooditem.getPrice() * order[1] + ")";

                    }
                    sql += "SELECT 1 FROM DUAL";
                    MessageBox.Show(sql);
                    //Insert into Orders Item Table
                    Orders.runSQL(sql);

                    //update Orders Table
                    order.Value = totalPrice;
                    Orders.updateOrder(Order);
                    MessageBox.Show("update order");
                }
            }
            
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
            if(Orders.orderItems.Count == 0)
            {
                MessageBox.Show("This table has no any order yet!");
            }
            else
            {
                //set the order status = 'P'
                Orders.payOrder(Convert.ToInt32(lbl_OrderNo.Text.Trim()));

                Table.tableList[Convert.ToInt32(lblTableNumber.Text.Trim())] = 0;
                MessageBox.Show("Table pay.");
            }
            
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            lblStaffName.Text = cboStaffSignIn.Text;
            order.StaffId = Convert.ToInt32(lblStaffName.Text.Trim().Substring(0, 2));
            grpStaffSign.Hide();
            grdOrder.Visible = true;
            //set state to order
            Orders.state = 1;
        }

        private void btnPromptSignIn_Click(object sender, EventArgs e)
        {
            //set state to sign in
            Orders.state = 2;
            grpStaffSign.Show();
            grdOrder.Visible = false;
        }

        private void frmFoodOrder_Load(object sender, EventArgs e)
        {
            MessageBox.Show(Convert.ToString(Orders.nextOrderNo()));
            menuButton.Add(btnFoodItem1);
            menuButton.Add(btnFoodItem2);
            menuButton.Add(btnFoodItem3);
            menuButton.Add(btnFoodItem4);
            menuButton.Add(btnFoodItem5);
            menuButton.Add(btnFoodItem6);
            menuButton.Add(btnFoodItem7);
            menuButton.Add(btnFoodItem8);
            menuButton.Add(btnFoodItem9);
            menuButton.Add(btnFoodItem10);
            menuButton.Add(btnFoodItem11);
            menuButton.Add(btnFoodItem12);
            displayMenuBtn();

            //load all available staff into the dataset and display in the combo box
            DataSet DS = new DataSet();
            DS = Staff.getAllWorkingStaff(DS);

            for (int i = 0; i < DS.Tables["All Working Staff"].Rows.Count; i++)
            {
                cboStaffSignIn.Items.Add(DS.Tables[0].Rows[i][0].ToString().PadLeft(2, '0') + " : " + DS.Tables[0].Rows[i][1].ToString());
            }
        }

        private void btnChangeMenu_Click(object sender, EventArgs e)
        {
            if (grpChgFdMnu.Visible)
            {
                //set state to order
                Orders.state = 1;

                //hide change menu group box
                grpChgFdMnu.Visible = false;
                grdOrder.Visible = true;

            }
            else
            {
                //Set state to change menu
                Orders.state = 3;
                grdOrder.Visible = false;
                cboSelectFdItm.Items.Clear();
                //display the change menu group box 
                grpChgFdMnu.Visible = true;
                //update the combo box
                updateCboSelectFrdItm();
            }

            
            
        }

        private void btnStarterMenu_Click(object sender, EventArgs e)
        {
            if (!Orders.getCurrentPage().Equals("S"))
            {
                //Set the current page to starter
                Orders.setCurrentPage("S");
                if (Orders.state == 3 )
                {
                    //clear the combo box 
                    cboSelectFdItm.Items.Clear();
                    //update the combo box
                    updateCboSelectFrdItm();
                }


                //change the menu
                displayMenuBtn();
            }

        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            if (!Orders.getCurrentPage().Equals("M"))
            {
                //Set the current page to main
                Orders.setCurrentPage("M");
                
                if (Orders.state == 3)
                {
                    //clear the combo box 
                    cboSelectFdItm.Items.Clear();
                    //update the combo box
                    updateCboSelectFrdItm();
                }
                //change the menu
                displayMenuBtn();
            }
        }

        private void btnBeverageMenu_Click(object sender, EventArgs e)
        {
            if (!Orders.getCurrentPage().Equals("B"))
            {
                //Set the current page to beverage
                Orders.setCurrentPage("B");
                
                if (Orders.state == 3)
                {
                    //clear the combo box 
                    cboSelectFdItm.Items.Clear();
                    //update the combo box
                    updateCboSelectFrdItm();
                }
                //change the menu
                displayMenuBtn();
            }
        }

        private void btnDessert_Click(object sender, EventArgs e)
        {
            if (!Orders.getCurrentPage().Equals("D"))
            {
                //Set the current page to dessert
                Orders.setCurrentPage("D");
                displayMenuBtn();
                if (Orders.state == 3)
                {
                    //clear the combo box 
                    cboSelectFdItm.Items.Clear();
                    //update the combo box
                    updateCboSelectFrdItm();
                }
                //change the menu
            }
        }

        private void updateCboSelectFrdItm()
        {
            DataSet ds = new DataSet();
            ds = FoodItems.getAvailableFoodItem(ds, Orders.getCurrentPage());
            for (int i = 0; i < ds.Tables["FoodItems"].Rows.Count; i++)
            {
                cboSelectFdItm.Items.Add(ds.Tables[0].Rows[i][0].ToString().PadLeft(2) + " : " + ds.Tables[0].Rows[i][1].ToString());
            }
        }

        private void btnNum8_Click(object sender, EventArgs e)
        {
            //number 8
            if (Orders.state == 1)
            {
                numberAsString += "8";
            }
        }

        private void btnNum4_Click(object sender, EventArgs e)
        {
            //number 4
            if (Orders.state == 1)
            {
                numberAsString += "4";
            }
        }

        private void btnNum6_Click(object sender, EventArgs e)
        {
            //number 6
            if (Orders.state == 1)
            {
                numberAsString += "5";
            }
        }

        private void btnNum5_Click(object sender, EventArgs e)
        {
            if (Orders.state == 1)
            {
                numberAsString += "5";
            }
        }

        private void btnNum7_Click(object sender, EventArgs e)
        {
            //number 7
            if (Orders.state == 1)
            {
                numberAsString += "1";
            }
        }

        private void btnNum9_Click(object sender, EventArgs e)
        {
            //number 9
            if (Orders.state == 1)
            {
                numberAsString += "9";
            }
        }

        private void cboSelectFdItm_SelectedIndexChange(object sender,EventArgs e)
        {
            //if resetting combo, ignore
            if (cboSelectFdItm.SelectedIndex == -1){
                return;
            }
            else{
                //store that changeFoodItemId so can assign to button later on
                Orders.changeFoodItemId = Convert.ToInt16(cboSelectFdItm.Text.Substring(0, 2));         
            }
        }

        private void btnFoodItem5_Click(object sender, EventArgs e)
        {
            clickOnBtn(5, menuButton[4], grdOrder);
        }

        private static void clickOnBtn(int buttonNum,Button btn,DataGridView grdOrder)
        {
            if(Orders.state == 3)   //change food state
            {
                if(Orders.changeFoodItemId!= 0)
                {
                    Orders.menu[Orders.getCurrentPageAsInt(), buttonNum] = Orders.changeFoodItemId;
                    displayMenuBtn();
                    Orders.changeFoodItemId = 0;
                }
                else
                {
                    MessageBox.Show("You must select a food item first");
                }   

            }
            else if(Orders.state == 1)  //order state
            {              
                if(Orders.menu[Orders.getCurrentPageAsInt(),buttonNum] != 0)
                {
                    FoodItems fooditem = FoodItems.getFood(Orders.menu[Orders.getCurrentPageAsInt(), buttonNum]);
                     //process on the datagridview
                     //row++; //move to next datagrid row
                     foodItemAsString = btn.Text;    //get the food item name to the variable and display to the grid
                     if (numberAsString == "")
                     {
                         number = 1;
                     }
                     else
                     {
                         Int32.TryParse(numberAsString, out number); //parse number as string to int to number
                     }

                    //process on the orders list
                    int[] order = new int[2];   //[foodid,quantity]
                    order[0] = Orders.menu[Orders.getCurrentPageAsInt(), buttonNum];   //foodid
                    order[1] = number;  //food qty
                    Boolean existed = false;
                    foreach(int[] orderitem in Orders.orderItems)
                    {
                        if (orderitem[0] == order[0])
                        {   //if found this food already exist in the order(food id co-exist)
                            //add the extra qty to the current qty                            
                            orderitem[1] += number;
                            MessageBox.Show("Food Existed!!");
                            //working on the gridview order
                            int storeIndex = Orders.orderItems.IndexOf(orderitem);
                            int currentNum = Convert.ToInt32(grdOrder.Rows[storeIndex + 1].Cells[1].Value);
                            grdOrder.Rows[storeIndex + 1].Cells[1].Value = currentNum + number;
                            grdOrder.Rows[storeIndex + 1].Cells[3].Value = fooditem.getPrice() * Convert.ToInt32(grdOrder.Rows[storeIndex + 1].Cells[1].Value);
                            existed = true;
                            break;
                        }
                    }

                    if (!existed)
                    {
                        MessageBox.Show("Adding new food!");
                        Orders.orderItems.Add(order);
                        DataGridViewRow gridRow = (DataGridViewRow)grdOrder.Rows[0].Clone();
                        gridRow.Cells[0].Value = foodItemAsString; //Set the food name column to selected food name
                        gridRow.Cells[1].Value = number;   //Set the number of food ordered column to number value
                        gridRow.Cells[2].Value = fooditem.getPrice();    //Set the food price column to food unit price
                        gridRow.Cells[3].Value = fooditem.getPrice() * number;    //Set the total price of the food
                        grdOrder.Rows.Add(gridRow);
                    }
                 
                     //grdOrder.Enabled = false;
                     grdOrder.Enabled = true;
                     numberAsString = "";
                     totalQty += number;
                     totalPrice += fooditem.getPrice() * number;
                     grdOrder.Rows[0].Cells[1].Value = totalQty;
                     grdOrder.Rows[0].Cells[3].Value = totalPrice;
                }
                else
                {
                    MessageBox.Show("Button hasn't applied to any food yet");
                }
                
            }

        }

        //define a method that display the menuButton text as the food name
        public static void displayMenuBtn()
        {
            for(int i = 0; i < menuButton.Count; i++)
            {
                if(Orders.menu[Orders.getCurrentPageAsInt(), i + 1] != 0)   //this check if the button has corresponding food
                {
                    menuButton[i].Text = FoodItems.getFoodName(Orders.menu[Orders.getCurrentPageAsInt(), i + 1]);
                }
                else if(Orders.menu[Orders.getCurrentPageAsInt(), i + 1] == 0)
                {
                    menuButton[i].Text = "Unassigned";
                }
            }
        }

        private void btnNum0_Click(object sender, EventArgs e)
        {
            //number 0
            if (Orders.state == 1)
            {
                numberAsString += "0";
            }
        }

        private void btnFoodItem6_Click(object sender, EventArgs e)
        {
            clickOnBtn(6, menuButton[5], grdOrder);
        }

        private void btnFoodItem7_Click(object sender, EventArgs e)
        {
            clickOnBtn(7, menuButton[6], grdOrder);
        }

        private void btnFoodItem8_Click(object sender, EventArgs e)
        {
            clickOnBtn(8, menuButton[7], grdOrder);
        }

        private void btnFoodItem9_Click(object sender, EventArgs e)
        {
            clickOnBtn(9, menuButton[8], grdOrder);
        }

        private void btnFoodItem10_Click(object sender, EventArgs e)
        {
            clickOnBtn(10, menuButton[9], grdOrder);
        }

        private void btnFoodItem11_Click(object sender, EventArgs e)
        {
            clickOnBtn(11, menuButton[10], grdOrder);
        }

        private void btnFoodItem12_Click(object sender, EventArgs e)
        {
            clickOnBtn(12, menuButton[11], grdOrder);
        }
    }
}
