namespace RestSYS
{
    partial class frmFoodOrder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnBarMenu = new System.Windows.Forms.Button();
            this.btnCoffeeMenu = new System.Windows.Forms.Button();
            this.btnMainMenu = new System.Windows.Forms.Button();
            this.btnStarterMenu = new System.Windows.Forms.Button();
            this.btnTableInterface = new System.Windows.Forms.Button();
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            this.btnDeleteFoodRow = new System.Windows.Forms.Button();
            this.btnPrintBill = new System.Windows.Forms.Button();
            this.btnPayBill = new System.Windows.Forms.Button();
            this.btnNum0 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnNum1 = new System.Windows.Forms.Button();
            this.btnNum2 = new System.Windows.Forms.Button();
            this.btnNum3 = new System.Windows.Forms.Button();
            this.btnNum4 = new System.Windows.Forms.Button();
            this.btnNum5 = new System.Windows.Forms.Button();
            this.btnNum6 = new System.Windows.Forms.Button();
            this.btnNum7 = new System.Windows.Forms.Button();
            this.btnNum8 = new System.Windows.Forms.Button();
            this.btnNum9 = new System.Windows.Forms.Button();
            this.grdOrder = new System.Windows.Forms.DataGridView();
            this.Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnFoodItem1 = new System.Windows.Forms.Button();
            this.btnFoodItem2 = new System.Windows.Forms.Button();
            this.btnFoodItem3 = new System.Windows.Forms.Button();
            this.btnFoodItem4 = new System.Windows.Forms.Button();
            this.lblTableNumber = new System.Windows.Forms.Label();
            this.lblStaffName = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpStaffSign = new System.Windows.Forms.GroupBox();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.lblStaffSignInName = new System.Windows.Forms.Label();
            this.cboStaffSignIn = new System.Windows.Forms.ComboBox();
            this.btnPromptSignIn = new System.Windows.Forms.Button();
            this.btnFoodItem5 = new System.Windows.Forms.Button();
            this.btnFoodItem6 = new System.Windows.Forms.Button();
            this.btnFoodItem7 = new System.Windows.Forms.Button();
            this.btnFoodItem8 = new System.Windows.Forms.Button();
            this.btnFoodItem9 = new System.Windows.Forms.Button();
            this.btnFoodItem10 = new System.Windows.Forms.Button();
            this.btnFoodItem11 = new System.Windows.Forms.Button();
            this.btnFoodItem12 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdOrder)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.grpStaffSign.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBarMenu
            // 
            this.btnBarMenu.Location = new System.Drawing.Point(722, 27);
            this.btnBarMenu.Name = "btnBarMenu";
            this.btnBarMenu.Size = new System.Drawing.Size(75, 56);
            this.btnBarMenu.TabIndex = 0;
            this.btnBarMenu.Text = "BAR";
            this.btnBarMenu.UseVisualStyleBackColor = true;
            // 
            // btnCoffeeMenu
            // 
            this.btnCoffeeMenu.Location = new System.Drawing.Point(641, 27);
            this.btnCoffeeMenu.Name = "btnCoffeeMenu";
            this.btnCoffeeMenu.Size = new System.Drawing.Size(75, 56);
            this.btnCoffeeMenu.TabIndex = 1;
            this.btnCoffeeMenu.Text = "COFFEE";
            this.btnCoffeeMenu.UseVisualStyleBackColor = true;
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.Location = new System.Drawing.Point(560, 27);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(75, 56);
            this.btnMainMenu.TabIndex = 2;
            this.btnMainMenu.Text = "MAIN ";
            this.btnMainMenu.UseVisualStyleBackColor = true;
            // 
            // btnStarterMenu
            // 
            this.btnStarterMenu.Location = new System.Drawing.Point(479, 27);
            this.btnStarterMenu.Name = "btnStarterMenu";
            this.btnStarterMenu.Size = new System.Drawing.Size(75, 56);
            this.btnStarterMenu.TabIndex = 3;
            this.btnStarterMenu.Text = "STARTER";
            this.btnStarterMenu.UseVisualStyleBackColor = true;
            // 
            // btnTableInterface
            // 
            this.btnTableInterface.Location = new System.Drawing.Point(398, 27);
            this.btnTableInterface.Name = "btnTableInterface";
            this.btnTableInterface.Size = new System.Drawing.Size(75, 56);
            this.btnTableInterface.TabIndex = 4;
            this.btnTableInterface.Text = "TABLE";
            this.btnTableInterface.UseVisualStyleBackColor = true;
            this.btnTableInterface.Click += new System.EventHandler(this.btnTableInterface_Click);
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.Location = new System.Drawing.Point(686, 94);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(111, 84);
            this.btnPlaceOrder.TabIndex = 5;
            this.btnPlaceOrder.Text = "PLACE ORDER";
            this.btnPlaceOrder.UseVisualStyleBackColor = true;
            this.btnPlaceOrder.Click += new System.EventHandler(this.btnPlaceOrder_Click);
            // 
            // btnDeleteFoodRow
            // 
            this.btnDeleteFoodRow.Location = new System.Drawing.Point(685, 184);
            this.btnDeleteFoodRow.Name = "btnDeleteFoodRow";
            this.btnDeleteFoodRow.Size = new System.Drawing.Size(111, 84);
            this.btnDeleteFoodRow.TabIndex = 6;
            this.btnDeleteFoodRow.Text = "DELETE ";
            this.btnDeleteFoodRow.UseVisualStyleBackColor = true;
            this.btnDeleteFoodRow.Click += new System.EventHandler(this.btnDeleteFoodRow_Click);
            // 
            // btnPrintBill
            // 
            this.btnPrintBill.Location = new System.Drawing.Point(685, 274);
            this.btnPrintBill.Name = "btnPrintBill";
            this.btnPrintBill.Size = new System.Drawing.Size(111, 84);
            this.btnPrintBill.TabIndex = 7;
            this.btnPrintBill.Text = "PRINT BILL";
            this.btnPrintBill.UseVisualStyleBackColor = true;
            this.btnPrintBill.Click += new System.EventHandler(this.btnPrintBill_Click);
            // 
            // btnPayBill
            // 
            this.btnPayBill.Location = new System.Drawing.Point(685, 364);
            this.btnPayBill.Name = "btnPayBill";
            this.btnPayBill.Size = new System.Drawing.Size(111, 74);
            this.btnPayBill.TabIndex = 8;
            this.btnPayBill.Text = "PAY";
            this.btnPayBill.UseVisualStyleBackColor = true;
            this.btnPayBill.Click += new System.EventHandler(this.btnPayBill_Click);
            // 
            // btnNum0
            // 
            this.btnNum0.Location = new System.Drawing.Point(135, 407);
            this.btnNum0.Name = "btnNum0";
            this.btnNum0.Size = new System.Drawing.Size(81, 43);
            this.btnNum0.TabIndex = 9;
            this.btnNum0.Text = "0";
            this.btnNum0.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(231, 407);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 43);
            this.button1.TabIndex = 10;
            this.button1.Text = ".";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnNum1
            // 
            this.btnNum1.Location = new System.Drawing.Point(36, 364);
            this.btnNum1.Name = "btnNum1";
            this.btnNum1.Size = new System.Drawing.Size(81, 43);
            this.btnNum1.TabIndex = 11;
            this.btnNum1.Text = "1";
            this.btnNum1.UseVisualStyleBackColor = true;
            this.btnNum1.Click += new System.EventHandler(this.btnNum1_Click);
            // 
            // btnNum2
            // 
            this.btnNum2.Location = new System.Drawing.Point(135, 364);
            this.btnNum2.Name = "btnNum2";
            this.btnNum2.Size = new System.Drawing.Size(81, 43);
            this.btnNum2.TabIndex = 12;
            this.btnNum2.Text = "2";
            this.btnNum2.UseVisualStyleBackColor = true;
            this.btnNum2.Click += new System.EventHandler(this.btnNum2_Click);
            // 
            // btnNum3
            // 
            this.btnNum3.Location = new System.Drawing.Point(231, 364);
            this.btnNum3.Name = "btnNum3";
            this.btnNum3.Size = new System.Drawing.Size(81, 43);
            this.btnNum3.TabIndex = 13;
            this.btnNum3.Text = "3";
            this.btnNum3.UseVisualStyleBackColor = true;
            this.btnNum3.Click += new System.EventHandler(this.btnNum3_Click);
            // 
            // btnNum4
            // 
            this.btnNum4.Location = new System.Drawing.Point(36, 324);
            this.btnNum4.Name = "btnNum4";
            this.btnNum4.Size = new System.Drawing.Size(81, 43);
            this.btnNum4.TabIndex = 14;
            this.btnNum4.Text = "4";
            this.btnNum4.UseVisualStyleBackColor = true;
            // 
            // btnNum5
            // 
            this.btnNum5.Location = new System.Drawing.Point(135, 324);
            this.btnNum5.Name = "btnNum5";
            this.btnNum5.Size = new System.Drawing.Size(81, 43);
            this.btnNum5.TabIndex = 15;
            this.btnNum5.Text = "5";
            this.btnNum5.UseVisualStyleBackColor = true;
            // 
            // btnNum6
            // 
            this.btnNum6.Location = new System.Drawing.Point(231, 324);
            this.btnNum6.Name = "btnNum6";
            this.btnNum6.Size = new System.Drawing.Size(81, 43);
            this.btnNum6.TabIndex = 16;
            this.btnNum6.Text = "6";
            this.btnNum6.UseVisualStyleBackColor = true;
            // 
            // btnNum7
            // 
            this.btnNum7.Location = new System.Drawing.Point(36, 284);
            this.btnNum7.Name = "btnNum7";
            this.btnNum7.Size = new System.Drawing.Size(81, 43);
            this.btnNum7.TabIndex = 17;
            this.btnNum7.Text = "7";
            this.btnNum7.UseVisualStyleBackColor = true;
            // 
            // btnNum8
            // 
            this.btnNum8.Location = new System.Drawing.Point(135, 284);
            this.btnNum8.Name = "btnNum8";
            this.btnNum8.Size = new System.Drawing.Size(81, 43);
            this.btnNum8.TabIndex = 18;
            this.btnNum8.Text = "8";
            this.btnNum8.UseVisualStyleBackColor = true;
            // 
            // btnNum9
            // 
            this.btnNum9.Location = new System.Drawing.Point(231, 284);
            this.btnNum9.Name = "btnNum9";
            this.btnNum9.Size = new System.Drawing.Size(81, 43);
            this.btnNum9.TabIndex = 19;
            this.btnNum9.Text = "9";
            this.btnNum9.UseVisualStyleBackColor = true;
            // 
            // grdOrder
            // 
            this.grdOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Item,
            this.Quantity,
            this.Price,
            this.Cost});
            this.grdOrder.Location = new System.Drawing.Point(4, 27);
            this.grdOrder.Name = "grdOrder";
            this.grdOrder.Size = new System.Drawing.Size(335, 254);
            this.grdOrder.TabIndex = 20;
            // 
            // Item
            // 
            this.Item.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Item.HeaderText = "Food Item";
            this.Item.MaxInputLength = 50;
            this.Item.Name = "Item";
            this.Item.Width = 155;
            // 
            // Quantity
            // 
            this.Quantity.FillWeight = 5F;
            this.Quantity.HeaderText = "Qty";
            this.Quantity.MaxInputLength = 2;
            this.Quantity.Name = "Quantity";
            this.Quantity.Width = 30;
            // 
            // Price
            // 
            this.Price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Price.FillWeight = 10F;
            this.Price.HeaderText = "Price";
            this.Price.MaxInputLength = 5;
            this.Price.Name = "Price";
            this.Price.Width = 50;
            // 
            // Cost
            // 
            this.Cost.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Cost.FillWeight = 50F;
            this.Cost.HeaderText = "Cost";
            this.Cost.MaxInputLength = 5;
            this.Cost.Name = "Cost";
            this.Cost.Width = 50;
            // 
            // btnFoodItem1
            // 
            this.btnFoodItem1.Location = new System.Drawing.Point(413, 124);
            this.btnFoodItem1.Name = "btnFoodItem1";
            this.btnFoodItem1.Size = new System.Drawing.Size(76, 69);
            this.btnFoodItem1.TabIndex = 21;
            this.btnFoodItem1.Text = "Fish and Chips";
            this.btnFoodItem1.UseVisualStyleBackColor = true;
            this.btnFoodItem1.Click += new System.EventHandler(this.btnFoodItem1_Click);
            // 
            // btnFoodItem2
            // 
            this.btnFoodItem2.Location = new System.Drawing.Point(413, 199);
            this.btnFoodItem2.Name = "btnFoodItem2";
            this.btnFoodItem2.Size = new System.Drawing.Size(76, 69);
            this.btnFoodItem2.TabIndex = 22;
            this.btnFoodItem2.Text = "Beef Steak";
            this.btnFoodItem2.UseVisualStyleBackColor = true;
            this.btnFoodItem2.Click += new System.EventHandler(this.btnFoodItem2_Click);
            // 
            // btnFoodItem3
            // 
            this.btnFoodItem3.Location = new System.Drawing.Point(413, 274);
            this.btnFoodItem3.Name = "btnFoodItem3";
            this.btnFoodItem3.Size = new System.Drawing.Size(76, 69);
            this.btnFoodItem3.TabIndex = 23;
            this.btnFoodItem3.Text = "Chicken Burger";
            this.btnFoodItem3.UseVisualStyleBackColor = true;
            this.btnFoodItem3.Click += new System.EventHandler(this.btnFoodItem3_Click);
            // 
            // btnFoodItem4
            // 
            this.btnFoodItem4.Location = new System.Drawing.Point(413, 351);
            this.btnFoodItem4.Name = "btnFoodItem4";
            this.btnFoodItem4.Size = new System.Drawing.Size(76, 69);
            this.btnFoodItem4.TabIndex = 24;
            this.btnFoodItem4.Text = "Salad Bowl";
            this.btnFoodItem4.UseVisualStyleBackColor = true;
            this.btnFoodItem4.Click += new System.EventHandler(this.btnFoodItem4_Click);
            // 
            // lblTableNumber
            // 
            this.lblTableNumber.AutoSize = true;
            this.lblTableNumber.Location = new System.Drawing.Point(328, 310);
            this.lblTableNumber.Name = "lblTableNumber";
            this.lblTableNumber.Size = new System.Drawing.Size(72, 13);
            this.lblTableNumber.TabIndex = 25;
            this.lblTableNumber.Text = "Table number";
            // 
            // lblStaffName
            // 
            this.lblStaffName.AutoSize = true;
            this.lblStaffName.Location = new System.Drawing.Point(328, 345);
            this.lblStaffName.Name = "lblStaffName";
            this.lblStaffName.Size = new System.Drawing.Size(60, 13);
            this.lblStaffName.TabIndex = 26;
            this.lblStaffName.Text = "Staff Name";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(328, 379);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(68, 13);
            this.lblTime.TabIndex = 27;
            this.lblTime.Text = "Update Time";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 28;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.backToolStripMenuItem.Text = "Back";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
            // 
            // grpStaffSign
            // 
            this.grpStaffSign.Controls.Add(this.btnSignIn);
            this.grpStaffSign.Controls.Add(this.lblStaffSignInName);
            this.grpStaffSign.Controls.Add(this.cboStaffSignIn);
            this.grpStaffSign.Location = new System.Drawing.Point(0, 27);
            this.grpStaffSign.Name = "grpStaffSign";
            this.grpStaffSign.Size = new System.Drawing.Size(342, 254);
            this.grpStaffSign.TabIndex = 29;
            this.grpStaffSign.TabStop = false;
            this.grpStaffSign.Text = "Staff Sign In";
            this.grpStaffSign.Visible = false;
            // 
            // btnSignIn
            // 
            this.btnSignIn.Location = new System.Drawing.Point(41, 122);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(80, 28);
            this.btnSignIn.TabIndex = 2;
            this.btnSignIn.Text = "Sign In";
            this.btnSignIn.UseVisualStyleBackColor = true;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // lblStaffSignInName
            // 
            this.lblStaffSignInName.AutoSize = true;
            this.lblStaffSignInName.Location = new System.Drawing.Point(24, 40);
            this.lblStaffSignInName.Name = "lblStaffSignInName";
            this.lblStaffSignInName.Size = new System.Drawing.Size(64, 13);
            this.lblStaffSignInName.TabIndex = 1;
            this.lblStaffSignInName.Text = "Staff Sign in";
            // 
            // cboStaffSignIn
            // 
            this.cboStaffSignIn.FormattingEnabled = true;
            this.cboStaffSignIn.Items.AddRange(new object[] {
            "Brian",
            "Colin",
            "George",
            "Jonathon"});
            this.cboStaffSignIn.Location = new System.Drawing.Point(27, 64);
            this.cboStaffSignIn.Name = "cboStaffSignIn";
            this.cboStaffSignIn.Size = new System.Drawing.Size(179, 21);
            this.cboStaffSignIn.TabIndex = 0;
            this.cboStaffSignIn.Text = "Sign in";
            // 
            // btnPromptSignIn
            // 
            this.btnPromptSignIn.Location = new System.Drawing.Point(345, 27);
            this.btnPromptSignIn.Name = "btnPromptSignIn";
            this.btnPromptSignIn.Size = new System.Drawing.Size(46, 58);
            this.btnPromptSignIn.TabIndex = 30;
            this.btnPromptSignIn.Text = "Sign In";
            this.btnPromptSignIn.UseVisualStyleBackColor = true;
            this.btnPromptSignIn.Click += new System.EventHandler(this.btnPromptSignIn_Click);
            // 
            // btnFoodItem5
            // 
            this.btnFoodItem5.Location = new System.Drawing.Point(506, 124);
            this.btnFoodItem5.Name = "btnFoodItem5";
            this.btnFoodItem5.Size = new System.Drawing.Size(76, 69);
            this.btnFoodItem5.TabIndex = 31;
            this.btnFoodItem5.Text = "Button 5";
            this.btnFoodItem5.UseVisualStyleBackColor = true;
            // 
            // btnFoodItem6
            // 
            this.btnFoodItem6.Location = new System.Drawing.Point(506, 199);
            this.btnFoodItem6.Name = "btnFoodItem6";
            this.btnFoodItem6.Size = new System.Drawing.Size(76, 69);
            this.btnFoodItem6.TabIndex = 32;
            this.btnFoodItem6.Text = "Button 6";
            this.btnFoodItem6.UseVisualStyleBackColor = true;
            // 
            // btnFoodItem7
            // 
            this.btnFoodItem7.Location = new System.Drawing.Point(506, 274);
            this.btnFoodItem7.Name = "btnFoodItem7";
            this.btnFoodItem7.Size = new System.Drawing.Size(76, 69);
            this.btnFoodItem7.TabIndex = 33;
            this.btnFoodItem7.Text = "Button 7";
            this.btnFoodItem7.UseVisualStyleBackColor = true;
            // 
            // btnFoodItem8
            // 
            this.btnFoodItem8.Location = new System.Drawing.Point(506, 351);
            this.btnFoodItem8.Name = "btnFoodItem8";
            this.btnFoodItem8.Size = new System.Drawing.Size(76, 69);
            this.btnFoodItem8.TabIndex = 34;
            this.btnFoodItem8.Text = "Button 8";
            this.btnFoodItem8.UseVisualStyleBackColor = true;
            // 
            // btnFoodItem9
            // 
            this.btnFoodItem9.Location = new System.Drawing.Point(600, 124);
            this.btnFoodItem9.Name = "btnFoodItem9";
            this.btnFoodItem9.Size = new System.Drawing.Size(76, 69);
            this.btnFoodItem9.TabIndex = 35;
            this.btnFoodItem9.Text = "Button 9";
            this.btnFoodItem9.UseVisualStyleBackColor = true;
            // 
            // btnFoodItem10
            // 
            this.btnFoodItem10.Location = new System.Drawing.Point(600, 199);
            this.btnFoodItem10.Name = "btnFoodItem10";
            this.btnFoodItem10.Size = new System.Drawing.Size(76, 69);
            this.btnFoodItem10.TabIndex = 36;
            this.btnFoodItem10.Text = "Button 10";
            this.btnFoodItem10.UseVisualStyleBackColor = true;
            // 
            // btnFoodItem11
            // 
            this.btnFoodItem11.Location = new System.Drawing.Point(600, 274);
            this.btnFoodItem11.Name = "btnFoodItem11";
            this.btnFoodItem11.Size = new System.Drawing.Size(76, 69);
            this.btnFoodItem11.TabIndex = 37;
            this.btnFoodItem11.Text = "Button 11";
            this.btnFoodItem11.UseVisualStyleBackColor = true;
            // 
            // btnFoodItem12
            // 
            this.btnFoodItem12.Location = new System.Drawing.Point(600, 351);
            this.btnFoodItem12.Name = "btnFoodItem12";
            this.btnFoodItem12.Size = new System.Drawing.Size(76, 69);
            this.btnFoodItem12.TabIndex = 38;
            this.btnFoodItem12.Text = "Button 12";
            this.btnFoodItem12.UseVisualStyleBackColor = true;
            // 
            // frmFoodOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFoodItem12);
            this.Controls.Add(this.btnFoodItem11);
            this.Controls.Add(this.btnFoodItem10);
            this.Controls.Add(this.btnFoodItem9);
            this.Controls.Add(this.btnFoodItem8);
            this.Controls.Add(this.btnFoodItem7);
            this.Controls.Add(this.btnFoodItem6);
            this.Controls.Add(this.btnFoodItem5);
            this.Controls.Add(this.btnPromptSignIn);
            this.Controls.Add(this.grpStaffSign);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblStaffName);
            this.Controls.Add(this.lblTableNumber);
            this.Controls.Add(this.btnFoodItem4);
            this.Controls.Add(this.btnFoodItem3);
            this.Controls.Add(this.btnFoodItem2);
            this.Controls.Add(this.btnFoodItem1);
            this.Controls.Add(this.grdOrder);
            this.Controls.Add(this.btnNum9);
            this.Controls.Add(this.btnNum8);
            this.Controls.Add(this.btnNum7);
            this.Controls.Add(this.btnNum6);
            this.Controls.Add(this.btnNum5);
            this.Controls.Add(this.btnNum4);
            this.Controls.Add(this.btnNum3);
            this.Controls.Add(this.btnNum2);
            this.Controls.Add(this.btnNum1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnNum0);
            this.Controls.Add(this.btnPayBill);
            this.Controls.Add(this.btnPrintBill);
            this.Controls.Add(this.btnDeleteFoodRow);
            this.Controls.Add(this.btnPlaceOrder);
            this.Controls.Add(this.btnTableInterface);
            this.Controls.Add(this.btnStarterMenu);
            this.Controls.Add(this.btnMainMenu);
            this.Controls.Add(this.btnCoffeeMenu);
            this.Controls.Add(this.btnBarMenu);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmFoodOrder";
            this.Text = "Order Food";
            this.Load += new System.EventHandler(this.frmFoodOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdOrder)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpStaffSign.ResumeLayout(false);
            this.grpStaffSign.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBarMenu;
        private System.Windows.Forms.Button btnCoffeeMenu;
        private System.Windows.Forms.Button btnMainMenu;
        private System.Windows.Forms.Button btnStarterMenu;
        private System.Windows.Forms.Button btnTableInterface;
        private System.Windows.Forms.Button btnPlaceOrder;
        private System.Windows.Forms.Button btnDeleteFoodRow;
        private System.Windows.Forms.Button btnPrintBill;
        private System.Windows.Forms.Button btnPayBill;
        private System.Windows.Forms.Button btnNum0;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnNum1;
        private System.Windows.Forms.Button btnNum2;
        private System.Windows.Forms.Button btnNum3;
        private System.Windows.Forms.Button btnNum4;
        private System.Windows.Forms.Button btnNum5;
        private System.Windows.Forms.Button btnNum6;
        private System.Windows.Forms.Button btnNum7;
        private System.Windows.Forms.Button btnNum8;
        private System.Windows.Forms.Button btnNum9;
        private System.Windows.Forms.DataGridView grdOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cost;
        private System.Windows.Forms.Button btnFoodItem1;
        private System.Windows.Forms.Button btnFoodItem2;
        private System.Windows.Forms.Button btnFoodItem3;
        private System.Windows.Forms.Button btnFoodItem4;
        public System.Windows.Forms.Label lblTableNumber;
        private System.Windows.Forms.Label lblStaffName;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.GroupBox grpStaffSign;
        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.Label lblStaffSignInName;
        private System.Windows.Forms.ComboBox cboStaffSignIn;
        private System.Windows.Forms.Button btnPromptSignIn;
        private System.Windows.Forms.Button btnFoodItem5;
        private System.Windows.Forms.Button btnFoodItem6;
        private System.Windows.Forms.Button btnFoodItem7;
        private System.Windows.Forms.Button btnFoodItem8;
        private System.Windows.Forms.Button btnFoodItem9;
        private System.Windows.Forms.Button btnFoodItem10;
        private System.Windows.Forms.Button btnFoodItem11;
        private System.Windows.Forms.Button btnFoodItem12;
    }
}