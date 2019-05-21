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
            this.btnDessert = new System.Windows.Forms.Button();
            this.btnBeverageMenu = new System.Windows.Forms.Button();
            this.btnMainMenu = new System.Windows.Forms.Button();
            this.btnStarterMenu = new System.Windows.Forms.Button();
            this.btnTableInterface = new System.Windows.Forms.Button();
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            this.btnDeleteFoodRow = new System.Windows.Forms.Button();
            this.btnPrintBill = new System.Windows.Forms.Button();
            this.btnPayBill = new System.Windows.Forms.Button();
            this.grdOrder = new System.Windows.Forms.DataGridView();
            this.Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.cboSelectFdItm = new System.Windows.Forms.ComboBox();
            this.grpOrder = new System.Windows.Forms.GroupBox();
            this.cboQty = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOrder = new System.Windows.Forms.Button();
            this.lblChgFdItm = new System.Windows.Forms.Label();
            this.lbl_OrderNo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdOrder)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.grpStaffSign.SuspendLayout();
            this.grpOrder.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDessert
            // 
            this.btnDessert.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDessert.Location = new System.Drawing.Point(1030, 29);
            this.btnDessert.Name = "btnDessert";
            this.btnDessert.Size = new System.Drawing.Size(224, 84);
            this.btnDessert.TabIndex = 0;
            this.btnDessert.Text = "DESSERT";
            this.btnDessert.UseVisualStyleBackColor = true;
            this.btnDessert.Click += new System.EventHandler(this.btnDessert_Click);
            // 
            // btnBeverageMenu
            // 
            this.btnBeverageMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBeverageMenu.Location = new System.Drawing.Point(737, 29);
            this.btnBeverageMenu.Name = "btnBeverageMenu";
            this.btnBeverageMenu.Size = new System.Drawing.Size(224, 84);
            this.btnBeverageMenu.TabIndex = 1;
            this.btnBeverageMenu.Text = "BEVERAGE";
            this.btnBeverageMenu.UseVisualStyleBackColor = true;
            this.btnBeverageMenu.Click += new System.EventHandler(this.btnBeverageMenu_Click);
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainMenu.Location = new System.Drawing.Point(420, 30);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(224, 82);
            this.btnMainMenu.TabIndex = 2;
            this.btnMainMenu.Text = "MAIN ";
            this.btnMainMenu.UseVisualStyleBackColor = true;
            this.btnMainMenu.Click += new System.EventHandler(this.btnMainMenu_Click);
            // 
            // btnStarterMenu
            // 
            this.btnStarterMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStarterMenu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnStarterMenu.Location = new System.Drawing.Point(88, 27);
            this.btnStarterMenu.Name = "btnStarterMenu";
            this.btnStarterMenu.Size = new System.Drawing.Size(224, 82);
            this.btnStarterMenu.TabIndex = 3;
            this.btnStarterMenu.Text = "STARTER";
            this.btnStarterMenu.UseVisualStyleBackColor = true;
            this.btnStarterMenu.Click += new System.EventHandler(this.btnStarterMenu_Click);
            // 
            // btnTableInterface
            // 
            this.btnTableInterface.Location = new System.Drawing.Point(12, 115);
            this.btnTableInterface.Name = "btnTableInterface";
            this.btnTableInterface.Size = new System.Drawing.Size(85, 69);
            this.btnTableInterface.TabIndex = 4;
            this.btnTableInterface.Text = "TABLE";
            this.btnTableInterface.UseVisualStyleBackColor = true;
            this.btnTableInterface.Click += new System.EventHandler(this.btnTableInterface_Click);
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.Location = new System.Drawing.Point(1146, 349);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(108, 87);
            this.btnPlaceOrder.TabIndex = 5;
            this.btnPlaceOrder.Text = "PLACE ORDER";
            this.btnPlaceOrder.UseVisualStyleBackColor = true;
            this.btnPlaceOrder.Click += new System.EventHandler(this.btnPlaceOrder_Click);
            // 
            // btnDeleteFoodRow
            // 
            this.btnDeleteFoodRow.Location = new System.Drawing.Point(1140, 207);
            this.btnDeleteFoodRow.Name = "btnDeleteFoodRow";
            this.btnDeleteFoodRow.Size = new System.Drawing.Size(114, 54);
            this.btnDeleteFoodRow.TabIndex = 6;
            this.btnDeleteFoodRow.Text = "DELETE ";
            this.btnDeleteFoodRow.UseVisualStyleBackColor = true;
            this.btnDeleteFoodRow.Click += new System.EventHandler(this.btnDeleteFoodRow_Click);
            // 
            // btnPrintBill
            // 
            this.btnPrintBill.Location = new System.Drawing.Point(693, 500);
            this.btnPrintBill.Name = "btnPrintBill";
            this.btnPrintBill.Size = new System.Drawing.Size(133, 62);
            this.btnPrintBill.TabIndex = 7;
            this.btnPrintBill.Text = "PRINT BILL";
            this.btnPrintBill.UseVisualStyleBackColor = true;
            this.btnPrintBill.Click += new System.EventHandler(this.btnPrintBill_Click);
            // 
            // btnPayBill
            // 
            this.btnPayBill.Location = new System.Drawing.Point(945, 500);
            this.btnPayBill.Name = "btnPayBill";
            this.btnPayBill.Size = new System.Drawing.Size(133, 62);
            this.btnPayBill.TabIndex = 8;
            this.btnPayBill.Text = "PAY";
            this.btnPayBill.UseVisualStyleBackColor = true;
            this.btnPayBill.Click += new System.EventHandler(this.btnPayBill_Click);
            // 
            // grdOrder
            // 
            this.grdOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Item,
            this.Quantity,
            this.Price,
            this.Cost});
            this.grdOrder.Location = new System.Drawing.Point(640, 161);
            this.grdOrder.Name = "grdOrder";
            this.grdOrder.Size = new System.Drawing.Size(473, 324);
            this.grdOrder.TabIndex = 20;
            // 
            // Item
            // 
            this.Item.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Item.HeaderText = "Food Item";
            this.Item.MaxInputLength = 50;
            this.Item.Name = "Item";
            this.Item.Width = 230;
            // 
            // Quantity
            // 
            this.Quantity.FillWeight = 5F;
            this.Quantity.HeaderText = "Qty";
            this.Quantity.MaxInputLength = 2;
            this.Quantity.Name = "Quantity";
            this.Quantity.Width = 50;
            // 
            // Price
            // 
            this.Price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Price.FillWeight = 10F;
            this.Price.HeaderText = "Price";
            this.Price.MaxInputLength = 5;
            this.Price.Name = "Price";
            this.Price.Width = 80;
            // 
            // Cost
            // 
            this.Cost.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Cost.FillWeight = 50F;
            this.Cost.HeaderText = "Cost";
            this.Cost.MaxInputLength = 5;
            this.Cost.Name = "Cost";
            this.Cost.Width = 80;
            // 
            // lblTableNumber
            // 
            this.lblTableNumber.AutoSize = true;
            this.lblTableNumber.Location = new System.Drawing.Point(25, 200);
            this.lblTableNumber.Name = "lblTableNumber";
            this.lblTableNumber.Size = new System.Drawing.Size(72, 13);
            this.lblTableNumber.TabIndex = 25;
            this.lblTableNumber.Text = "Table number";
            // 
            // lblStaffName
            // 
            this.lblStaffName.AutoSize = true;
            this.lblStaffName.Location = new System.Drawing.Point(25, 245);
            this.lblStaffName.Name = "lblStaffName";
            this.lblStaffName.Size = new System.Drawing.Size(60, 13);
            this.lblStaffName.TabIndex = 26;
            this.lblStaffName.Text = "Staff Name";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(25, 290);
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
            this.menuStrip1.Size = new System.Drawing.Size(1266, 24);
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
            this.grpStaffSign.Location = new System.Drawing.Point(122, 152);
            this.grpStaffSign.Name = "grpStaffSign";
            this.grpStaffSign.Size = new System.Drawing.Size(448, 270);
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
            this.cboStaffSignIn.Location = new System.Drawing.Point(27, 64);
            this.cboStaffSignIn.Name = "cboStaffSignIn";
            this.cboStaffSignIn.Size = new System.Drawing.Size(179, 21);
            this.cboStaffSignIn.TabIndex = 0;
            this.cboStaffSignIn.Text = "Sign in";
            // 
            // btnPromptSignIn
            // 
            this.btnPromptSignIn.Location = new System.Drawing.Point(12, 398);
            this.btnPromptSignIn.Name = "btnPromptSignIn";
            this.btnPromptSignIn.Size = new System.Drawing.Size(85, 69);
            this.btnPromptSignIn.TabIndex = 30;
            this.btnPromptSignIn.Text = "Sign In";
            this.btnPromptSignIn.UseVisualStyleBackColor = true;
            this.btnPromptSignIn.Click += new System.EventHandler(this.btnPromptSignIn_Click);
            // 
            // cboSelectFdItm
            // 
            this.cboSelectFdItm.FormattingEnabled = true;
            this.cboSelectFdItm.Location = new System.Drawing.Point(110, 84);
            this.cboSelectFdItm.Name = "cboSelectFdItm";
            this.cboSelectFdItm.Size = new System.Drawing.Size(206, 32);
            this.cboSelectFdItm.TabIndex = 40;
            this.cboSelectFdItm.SelectedIndexChanged += new System.EventHandler(this.cboSelectFdItm_SelectedIndexChange);
            // 
            // grpOrder
            // 
            this.grpOrder.Controls.Add(this.cboQty);
            this.grpOrder.Controls.Add(this.label1);
            this.grpOrder.Controls.Add(this.btnOrder);
            this.grpOrder.Controls.Add(this.lblChgFdItm);
            this.grpOrder.Controls.Add(this.cboSelectFdItm);
            this.grpOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpOrder.Location = new System.Drawing.Point(112, 143);
            this.grpOrder.Name = "grpOrder";
            this.grpOrder.Size = new System.Drawing.Size(467, 324);
            this.grpOrder.TabIndex = 41;
            this.grpOrder.TabStop = false;
            this.grpOrder.Text = "Order";
            // 
            // cboQty
            // 
            this.cboQty.FormattingEnabled = true;
            this.cboQty.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.cboQty.Location = new System.Drawing.Point(110, 188);
            this.cboQty.Name = "cboQty";
            this.cboQty.Size = new System.Drawing.Size(210, 32);
            this.cboQty.TabIndex = 44;
            this.cboQty.SelectedIndexChanged += new System.EventHandler(this.cboQty_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(168, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 18);
            this.label1.TabIndex = 43;
            this.label1.Text = "Select Quantity";
            // 
            // btnOrder
            // 
            this.btnOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.Location = new System.Drawing.Point(154, 248);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(127, 43);
            this.btnOrder.TabIndex = 42;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // lblChgFdItm
            // 
            this.lblChgFdItm.AutoSize = true;
            this.lblChgFdItm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChgFdItm.Location = new System.Drawing.Point(155, 46);
            this.lblChgFdItm.Name = "lblChgFdItm";
            this.lblChgFdItm.Size = new System.Drawing.Size(120, 18);
            this.lblChgFdItm.TabIndex = 41;
            this.lblChgFdItm.Text = "Select Food Item";
            // 
            // lbl_OrderNo
            // 
            this.lbl_OrderNo.AutoSize = true;
            this.lbl_OrderNo.Location = new System.Drawing.Point(25, 334);
            this.lbl_OrderNo.Name = "lbl_OrderNo";
            this.lbl_OrderNo.Size = new System.Drawing.Size(47, 13);
            this.lbl_OrderNo.TabIndex = 43;
            this.lbl_OrderNo.Text = "OrderNo";
            // 
            // frmFoodOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1266, 574);
            this.Controls.Add(this.lbl_OrderNo);
            this.Controls.Add(this.grpOrder);
            this.Controls.Add(this.btnPromptSignIn);
            this.Controls.Add(this.grpStaffSign);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblStaffName);
            this.Controls.Add(this.lblTableNumber);
            this.Controls.Add(this.grdOrder);
            this.Controls.Add(this.btnPayBill);
            this.Controls.Add(this.btnPrintBill);
            this.Controls.Add(this.btnDeleteFoodRow);
            this.Controls.Add(this.btnPlaceOrder);
            this.Controls.Add(this.btnTableInterface);
            this.Controls.Add(this.btnStarterMenu);
            this.Controls.Add(this.btnMainMenu);
            this.Controls.Add(this.btnBeverageMenu);
            this.Controls.Add(this.btnDessert);
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
            this.grpOrder.ResumeLayout(false);
            this.grpOrder.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDessert;
        private System.Windows.Forms.Button btnBeverageMenu;
        private System.Windows.Forms.Button btnMainMenu;
        private System.Windows.Forms.Button btnStarterMenu;
        private System.Windows.Forms.Button btnTableInterface;
        private System.Windows.Forms.Button btnPlaceOrder;
        private System.Windows.Forms.Button btnDeleteFoodRow;
        private System.Windows.Forms.Button btnPrintBill;
        private System.Windows.Forms.Button btnPayBill;
        public System.Windows.Forms.DataGridView grdOrder;
        public System.Windows.Forms.Label lblTableNumber;
        public System.Windows.Forms.Label lblStaffName;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.GroupBox grpStaffSign;
        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.Label lblStaffSignInName;
        private System.Windows.Forms.ComboBox cboStaffSignIn;
        private System.Windows.Forms.Button btnPromptSignIn;
        private System.Windows.Forms.ComboBox cboSelectFdItm;
        private System.Windows.Forms.GroupBox grpOrder;
        private System.Windows.Forms.Label lblChgFdItm;
        public System.Windows.Forms.Label lbl_OrderNo;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.ComboBox cboQty;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cost;
    }
}