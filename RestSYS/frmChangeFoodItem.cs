﻿using System;
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
    public partial class frmChangeFoodItem : Form
    {
        public frmChangeFoodItem()
        {
            InitializeComponent();
        }

        private void btnChgFoodItemSubmit_Click(object sender, EventArgs e)
        {
            bool allCorrect = true;
            //validate data
            if (txtChangeFoodItem.Text.Equals(""))
            {
                MessageBox.Show("Food Item name must be entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                allCorrect = false;
            }

            else if (txtChangeFoodItemDesc.Text.Equals(""))
            {
                MessageBox.Show("Food item description must be entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                allCorrect = false;
            }

            else if (txtChgFoodItemType.Text.Equals(""))
            {
                MessageBox.Show("Food item type must be entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                allCorrect = false;
            }

            else if (txtChgFoodItemPrice.Text.Equals(""))
            {
                MessageBox.Show("Food item price must be entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                allCorrect = false;
            }

            else if (txtChgFoodItemStatus.Text.Equals(""))
            {
                MessageBox.Show("Food item status must be entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                allCorrect = false;
            }

            else
            {
                //food type must be one alphabetic character and must exist in Food type
                if (!txtChgFoodItemType.Text.All(Char.IsLetter))
                {
                    MessageBox.Show("Food item type must be one alphabetic character only");
                    allCorrect = false;
                }

                else if (!txtChgFoodItemType.Text.Equals("m"))
                {
                    MessageBox.Show("Food item type must be exist in food item table");
                    allCorrect = false;
                }

                //Price value must be greater than 0
                if (txtChgFoodItemPrice.Text.All(Char.IsDigit))
                {
                    if (double.Parse(txtChgFoodItemPrice.Text) < 0.0)
                    {
                        MessageBox.Show("Food item price must greater than 0");
                        allCorrect = false;
                    }
                }

                else
                {
                    MessageBox.Show("Food item price must be in decimal form");
                    allCorrect = false;
                }
            }

            //Status must be one alphabetic character , and must only be A and U
            if (!txtChgFoodItemStatus.Text.All(Char.IsLetter))
            {
                MessageBox.Show("Food item status must be one alphabetic character only");
                allCorrect = false;
            }

            else if (!txtChgFoodItemStatus.Text.Equals("A") && !txtChgFoodItemStatus.Text.Equals("U"))
            {
                MessageBox.Show("Food item status must only be 'A' or 'U'");
                allCorrect = false;
            }


            if (allCorrect == true)
            {
                MessageBox.Show("Food item added successfully!");
                txtChangeFoodItem.Clear();
                txtChangeFoodItemDesc.Clear();
                txtChgFoodItemPrice.Clear();
                txtChgFoodItemStatus.Clear();
                txtChgFoodItemType.Clear();
            }
        }
    }
}