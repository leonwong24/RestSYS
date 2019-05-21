using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
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
        public static Boolean OrderPlaced = false;
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
            updateCboSelectFrdItm();
            activeBtnColor();

        }

        public static void setOrderPlaced(Boolean boolean)
        {
            OrderPlaced = boolean;
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

        //A method that set the gridview data from the given orderNo store in Orders.foodOrder
        private void setGrdOrderDataFromOrderItems(DataSet ds)
        {
            //not done yet
            grdOrder.DataSource = ds.Tables[0];
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
            //MessageBox.Show(Convert.ToString(rowToDelete));
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
                //MessageBox.Show("HALO");
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

            else if(Orders.state == 2)
            {
                MessageBox.Show("You are only allowed to order when you quit change staff state");
            }

            else if (Orders.state == 3)
            {
                MessageBox.Show("You are only allowed to order when you quit change menu state");
            }
            else
            {
                /*MessageBox.Show("totalPrice is " + totalPrice);
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
                MessageBox.Show(printoutmsg);*/
               

                if(Table.tableList[Convert.ToInt32(lblTableNumber.Text)] == 0) //if table has no order yet
                {
                    //MessageBox.Show("new order!");
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
                    //MessageBox.Show(sql);
                    Orders.runSQL(sql);

                    //insert sql command into Orders Table
                    Orders.insertOrders(order);

                    MessageBox.Show("Order placed successfully!");
                    Table.tableList[Convert.ToInt32(lblTableNumber.Text.Trim())] = Convert.ToInt32(lbl_OrderNo.Text.Trim());

                    OrderPlaced = true;
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
                    //MessageBox.Show(sql);
                    //Insert into Orders Item Table
                    Orders.runSQL(sql);

                    //update Orders Table
                    order.Value = totalPrice;
                    Orders.updateOrder(Order);
                    MessageBox.Show("update order");
                    OrderPlaced = true;
                }
            }
            
        }

        private void btnPrintBill_Click(object sender, EventArgs e)
        {
            if(!OrderPlaced)
            {
                MessageBox.Show("This table has no any order yet or hasn't hold the order");
            }
            else
            {
                //MessageBox.Show("Bill printed!");
                printBill();
            }   
        }

        private void printBill()
        {
            
            PrintDialog printDialog= new PrintDialog();

            PrintDocument printDoc = new PrintDocument();

            printDialog.Document = printDoc;

            printDoc.PrintPage += PrintDoc_PrintPage;

            DialogResult result = printDialog.ShowDialog();

            if(result == DialogResult.OK)
            {
                printDoc.Print();
            }
        }

        private void PrintDoc_PrintPage(object sender, PrintPageEventArgs e)
        {
            DataSet ds = new DataSet();
            ds = Orders.getSelectedOrder(ds, Convert.ToInt32(lbl_OrderNo.Text.Trim()));
            Orders order1 = new Orders();

            for (int i = 0; i < ds.Tables["Selected Order"].Rows.Count; i++)
            {
                order1.OrderNo = Convert.ToInt32(ds.Tables[0].Rows[i][0].ToString());
                order1.OrderDate = ds.Tables[0].Rows[i][1].ToString();
                order1.OrderTime = ds.Tables[0].Rows[i][2].ToString();
                order1.TableNo = Convert.ToInt32(ds.Tables[0].Rows[i][3].ToString());
                order1.Value = Convert.ToDecimal(ds.Tables[0].Rows[i][4].ToString());
                order1.StaffId = Convert.ToInt32(ds.Tables[0].Rows[i][5].ToString());
                order1.Status = ds.Tables[0].Rows[i][6].ToString();

            }

            Graphics graphics = e.Graphics;

            Font font = new Font("Courier New", 12);

            float fontHeight = font.GetHeight();

            int startX = 50;
            int startY = 40;
            int offSet = 40;

            graphics.DrawString("Thanks for coming to the restaurant", new Font("Courier New", 20), new SolidBrush(Color.Black), startX + 100, startY);

            startY += offSet;

            graphics.DrawString(("Table Num: " + order1.TableNo).PadRight(20), font, new SolidBrush(Color.Black), startX, startY);
            graphics.DrawString(("Order No: " + order1.OrderNo).PadRight(20), font, new SolidBrush(Color.Black), startX + 300, startY);

            startY += offSet;

            graphics.DrawString(("Staff Name: " + Staff.getStaffName(order1.StaffId)).PadRight(20), font, new SolidBrush(Color.Black), startX, startY);
            graphics.DrawString(("Order Time:" + order1.OrderTime).PadRight(20), font, new SolidBrush(Color.Black), startX + 300, startY);

            startY += offSet;

            graphics.DrawString(("Order Item       Qty        Price        Cost").PadRight(20), font, new SolidBrush(Color.Black), startX, startY);


            for(int i = 1; i < grdOrder.Rows.Count-1; i++)
            {
                String fooditem = grdOrder.Rows[i].Cells[0].Value.ToString();
                String qty = grdOrder.Rows[i].Cells[1].Value.ToString().PadRight(8);
                String price= grdOrder.Rows[i].Cells[2].Value.ToString().PadRight(10);
                String cost= grdOrder.Rows[i].Cells[3].Value.ToString().PadRight(5);

                String productLine = fooditem + "  " + qty + "   " + price + "   " + cost;

                graphics.DrawString(productLine, font, new SolidBrush(Color.Black), startX, startY + offSet);

                offSet = offSet + (int)fontHeight + 5;
            }

            offSet += 30;

            graphics.DrawString("Total to pay ".PadRight(20) + order1.Value.ToString("#.##"), font, new SolidBrush(Color.Black), startX, startY+offSet);

        }

        private void btnPayBill_Click(object sender, EventArgs e)
        {
            if(Orders.orderItems.Count == 0)
            {
                MessageBox.Show("This table has no any order yet!");
            }
            else
            {
                if (Orders.checkOrderNo(order.OrderNo))   //havent have order yet
                {
                    MessageBox.Show("new order!");
                    //insert sql command into OrderItems Table
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
                    //MessageBox.Show(sql);
                    Orders.runSQL(sql);

                    Orders.payNewOrder(order);
                }
                else
                {
                    //set the order status = 'P'
                    Orders.payOrder(Convert.ToInt32(lbl_OrderNo.Text.Trim()));

                    Table.tableList[Convert.ToInt32(lblTableNumber.Text.Trim())] = 0;
                    MessageBox.Show("Table pay.");                  
                }

                //clear everything
                grdOrder.Rows.Clear();
                Orders.orderItems.Clear();
                lbl_OrderNo.Text = Convert.ToString(Orders.nextOrderNo());
                totalPrice = 0;
                totalQty = 0;
                order.OrderNo = Orders.nextOrderNo();
                order.Value = totalPrice;
                order.Status = "U";

            }
            
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            if(cboStaffSignIn.SelectedIndex != -1)
            {
                lblStaffName.Text = cboStaffSignIn.Text;
                order.StaffId = Convert.ToInt32(lblStaffName.Text.Trim().Substring(0, 2));
                Orders.staff = lblStaffName.Text;
                grpStaffSign.Hide();
                grpOrder.Visible = true;
                //set state to order
                Orders.state = 1;
            }
            
        }

        private void btnPromptSignIn_Click(object sender, EventArgs e)
        {
            if(Orders.state == 1)
            {
                //set state to sign in
                Orders.state = 2;
                grpStaffSign.Show();
                grpOrder.Visible = false;

            }

            else if(Orders.state == 3)
            {
                MessageBox.Show("You cannot sign in when changing food menu");
            }

            else
            {
                MessageBox.Show("You haven't change sign in staff");
            }
        }

        private void frmFoodOrder_Load(object sender, EventArgs e)
        {
            MessageBox.Show(Convert.ToString(Orders.nextOrderNo()));
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
            if (Orders.state == 3)
            {
                //set state to order
                Orders.state = 1;

                //hide change menu group box
                grpOrder.Visible = false;
                grdOrder.Visible = true;

            }

            else if (Orders.state == 2)
            {
                MessageBox.Show("Please quit change staff state before you want to change menu");
            }
            else
            {
                //Set state to change menu
                Orders.state = 3;
                grdOrder.Visible = false;
                cboSelectFdItm.Items.Clear();
                //display the change menu group box 
                grpOrder.Visible = true;
                //update the combo box
                updateCboSelectFrdItm();
            }

            
            
        }

        private void btnStarterMenu_Click(object sender, EventArgs e)
        {
            if(Orders.state == 2)
            {
                MessageBox.Show("Please quit change staff state before you do this");
            }

            else //order state == 1
            {
                if (!Orders.getCurrentPage().Equals("S"))
                {
                    //Set the current page to starter
                    Orders.setCurrentPage("S");
                    activeBtnColor();
                    //clear the combo box 
                    cboSelectFdItm.Items.Clear();

                    //clear the combo box text
                    cboSelectFdItm.Text = "";
                    cboSelectFdItm.SelectedIndex = -1;
                    //update the combo box
                    updateCboSelectFrdItm();

                    //change the menu
                    displayMenuBtn();
                }
            }

            

        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            if (Orders.state == 2)
            {
                MessageBox.Show("Please quit change staff state before you do this");
            }
            else
            {
                if (!Orders.getCurrentPage().Equals("M"))
                {
                   //Set the current page to main
                   Orders.setCurrentPage("M");
                    activeBtnColor();
                    //clear the combo box 
                    cboSelectFdItm.Items.Clear();
                    cboSelectFdItm.Text = "";
                    cboSelectFdItm.SelectedIndex = -1;
                    //update the combo box
                    updateCboSelectFrdItm();
                    //change the menu
                    displayMenuBtn();
                }
            }
            
        }

        private void activeBtnColor()
        {
            String page = Orders.getCurrentPage();
            switch (page)
            {
                case "S":
                    btnStarterMenu.ForeColor = Color.Red;
                    btnMainMenu.ForeColor = Color.Black;
                    btnDessert.ForeColor = Color.Black;
                    btnBeverageMenu.ForeColor = Color.Black;
                    break;

                case "M":
                    btnStarterMenu.ForeColor = Color.Black;
                    btnMainMenu.ForeColor = Color.Red;
                    btnDessert.ForeColor = Color.Black;
                    btnBeverageMenu.ForeColor = Color.Black;
                    break;

                case "D":
                    btnStarterMenu.ForeColor = Color.Black;
                    btnMainMenu.ForeColor = Color.Black;
                    btnDessert.ForeColor = Color.Red;
                    btnBeverageMenu.ForeColor = Color.Black;
                    break;

                case "B":
                    btnStarterMenu.ForeColor = Color.Black;
                    btnMainMenu.ForeColor = Color.Black;
                    btnDessert.ForeColor = Color.Black;
                    btnBeverageMenu.ForeColor = Color.Red;
                    break;
            }
        }

        private void btnBeverageMenu_Click(object sender, EventArgs e)
        {
            if (Orders.state == 2)
            {
                MessageBox.Show("Please quit change staff state before you do this");
            }

            else
            {
                if (!Orders.getCurrentPage().Equals("B"))
                 {
                    //Set the current page to beverage
                    Orders.setCurrentPage("B");
                    activeBtnColor();
                    //clear the combo box 
                    cboSelectFdItm.Items.Clear();
                    cboSelectFdItm.Text = "";
                    cboSelectFdItm.SelectedIndex = -1;
                    //update the combo box
                    updateCboSelectFrdItm();
                    //change the menu
                     displayMenuBtn();
                 }
            }
            
        }

        private void btnDessert_Click(object sender, EventArgs e)
        {
            if (Orders.state == 2)
            {
                MessageBox.Show("Please quit change staff state before you do this");
            }

            else
            {
                if (!Orders.getCurrentPage().Equals("D"))
                 {
                   //Set the current page to dessert
                    Orders.setCurrentPage("D");
                    displayMenuBtn();
                    activeBtnColor();
                    //clear the combo box 
                    cboSelectFdItm.Items.Clear();
                    cboSelectFdItm.Text = "";
                    cboSelectFdItm.SelectedIndex = -1;
                    //update the combo box
                    updateCboSelectFrdItm();
                    //change the menu
                    displayMenuBtn();
                }

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

        private void cboSelectFdItm_SelectedIndexChange(object sender,EventArgs e)
        {
            //if resetting combo, ignore
            if (cboSelectFdItm.SelectedIndex == -1){
                return;
            }
            else{
                //store that changeFoodItemId so can assign to button later on
                Orders.FoodItemId = Convert.ToInt32(cboSelectFdItm.Text.Substring(0, 2));
                foodItemAsString = FoodItems.getFoodName(Convert.ToInt32(cboSelectFdItm.Text.Substring(0, 2)));
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
                            //MessageBox.Show("Food Existed!!");
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

            else
            {
                MessageBox.Show("Please quit change staff state before you want to order");
            }

        }

        //define a method that display the all the available food item 
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

        private void btnOrder_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(foodItemAsString))
            {
                MessageBox.Show("Please select the food before ordering");
            }

            else if (String.IsNullOrEmpty(numberAsString))
            {
                MessageBox.Show("Please select the quantity before ordering");
            }


            else
            {
                //get food item name
                foodItemAsString = FoodItems.getFoodName(Convert.ToInt32(cboSelectFdItm.Text.Substring(0, 2)));
                numberAsString = Convert.ToString(cboQty.Text);

                FoodItems fooditem = FoodItems.getFood(Convert.ToInt32(cboSelectFdItm.Text.Substring(0, 2)));

                //process on the orders list
                int[] order = new int[2];   //[foodid,quantity]
                order[0] = Convert.ToInt32(cboSelectFdItm.Text.Substring(0, 2));   //foodid
                order[1] = number;  //food qty
                Boolean existed = false;
                foreach (int[] orderitem in Orders.orderItems)
                {
                    if (orderitem[0] == order[0])
                    {   //if found this food already exist in the order(food id co-exist)
                        //add the extra qty to the current qty                            
                        orderitem[1] += number;
                        //MessageBox.Show("Food Existed!!");
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

                //reset the combo box
                cboSelectFdItm.SelectedIndex = -1;
                cboSelectFdItm.Text = "";

                cboQty.SelectedIndex = -1;
                cboQty.Text = "";
                foodItemAsString = "";
                numberAsString = "";
            }
            
        }

        private void cboQty_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if resetting combo, ignore
            if (cboSelectFdItm.SelectedIndex == -1)
            {
                return;
            }
            else
            {
                number = Convert.ToInt32(cboQty.Text.Substring(0));
                numberAsString = Convert.ToString(cboQty.Text);
            }
            
        }
    }
}
