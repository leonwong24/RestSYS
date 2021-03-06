﻿using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
                    //set the orderno to 0 in the tableList array
                    Table.tableList[tableIndex] = 0;
                }

                
                else if (ds.Tables["Table Order"].Rows.Count == 1)
                {
                    //display price below the table number
                    tableButtons[tableIndex - 1].Text += ("\n" + ds.Tables["Table Order"].Rows[0][4]);

                    //set the orderno to the corresponding orderno in the tableList array
                    Table.tableList[tableIndex] = Convert.ToInt32(ds.Tables["Table Order"].Rows[0][0]);
                }
               ds.Clear();

            }
        }

        private void btnTable1_Click(object sender, EventArgs e)
        {
            buttonClicked(1);
        }

        private void btnTable2_Click(object sender, EventArgs e)
        {
            buttonClicked(2);
        }

        private void btnTable3_Click(object sender, EventArgs e)
        {
            buttonClicked(3);
        }

        private void btnTable4_Click(object sender, EventArgs e)
        {
            buttonClicked(4);
        }

        private void btnTable5_Click(object sender, EventArgs e)
        {
            buttonClicked(5);
        }

        private void btnTable6_Click(object sender, EventArgs e)
        {
            buttonClicked(6);
        }

        //method that prompt everything a table button is clicked.
        private void buttonClicked(int tableNo)
        {
            frmFoodOrder frmFoodOrder = new frmFoodOrder();
            //check the tableList if the table is not empty
            if (Table.tableList[tableNo] != 0)
            {
                int orderNo = Table.tableList[tableNo];
                //retrieve all the order with the given orderNo, fill the order inside the grdOrder
                Orders.foodOrder = Orders.getSelectedFoodOrder(Orders.foodOrder,orderNo);
                //Add all the order into the orderItems list
                for(int i = 0; i < Orders.foodOrder.Tables[0].Rows.Count; i++)
                {
                    int[] order = new int[2];
                    order[0] = Convert.ToInt32(Orders.foodOrder.Tables[0].Rows[i][1]);
                    order[1] = Convert.ToInt32(Orders.foodOrder.Tables[0].Rows[i][2]);
                    Orders.orderItems.Add(order);
                }
                //Orders.valueStore = Convert.ToDecimal(Orders.foodOrder.Tables[0].Rows[0]["Value"]);
                frmFoodOrder.lbl_OrderNo.Text = Convert.ToString(orderNo);
                frmFoodOrder.Order.OrderNo = orderNo;
                frmFoodOrder.setOrderPlaced(true);

                Orders.foodOrder.Clear();
            }
            else
            {
                frmFoodOrder.lbl_OrderNo.Text = Convert.ToString(Orders.nextOrderNo());
                frmFoodOrder.Order.OrderNo = Orders.nextOrderNo();
            }

            if (Orders.staff != null)//if theres staff signed in
            {
                frmFoodOrder.lblStaffName.Text = Convert.ToString(Orders.staff);
                frmFoodOrder.Order.StaffId = Convert.ToInt32(frmFoodOrder.lblStaffName.Text.Trim().Substring(0, 2));

            }

            //display all the order on the gridview 
            foreach(int[] orderitem in Orders.orderItems)
            {
                DataGridViewRow gridViewRow = (DataGridViewRow)frmFoodOrder.grdOrder.Rows[0].Clone();
                FoodItems fooditem = FoodItems.getFood(orderitem[0]);
                gridViewRow.Cells[0].Value = fooditem.getItemName() ; //Set the food name column to selected food name
                gridViewRow.Cells[1].Value = orderitem[1];   //Set the number of food ordered column to number value
                gridViewRow.Cells[2].Value = fooditem.getPrice();    //Set the food price column to food unit price
                gridViewRow.Cells[3].Value = fooditem.getPrice() * orderitem[1];    //Set the total price of the food
                frmFoodOrder.grdOrder.Rows.Add(gridViewRow);
                frmFoodOrder.totalPrice += Convert.ToDecimal(gridViewRow.Cells[3].Value);
                frmFoodOrder.totalQty += Convert.ToInt32(gridViewRow.Cells[1].Value);
            }
            frmFoodOrder.lblTableNumber.Text = Convert.ToString(tableNo);
            frmFoodOrder.Order.TableNo = tableNo;
            frmFoodOrder.grdOrder.Rows[0].Cells[1].Value = frmFoodOrder.totalQty;
            frmFoodOrder.grdOrder.Rows[0].Cells[3].Value = frmFoodOrder.totalPrice;
            Orders.setCurrentPage("S");
            Orders.state = 1;
            
            frmFoodOrder.Show();

            //close the table interface
            this.Close();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            frmHomeInterface frmHome = new frmHomeInterface();
            frmHome.Show();

            this.Close();
        }
    }
}
