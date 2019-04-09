namespace RestSYS
{
    partial class frmFoodAnalysis
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
            this.grdFdAnlys = new System.Windows.Forms.DataGridView();
            this.Year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Month = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FoodType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FoodItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoldQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpFilter = new System.Windows.Forms.GroupBox();
            this.chkStarter = new System.Windows.Forms.CheckBox();
            this.chkBeverage = new System.Windows.Forms.CheckBox();
            this.chkDessert = new System.Windows.Forms.CheckBox();
            this.chkMain = new System.Windows.Forms.CheckBox();
            this.cboMonth = new System.Windows.Forms.ComboBox();
            this.cboYear = new System.Windows.Forms.ComboBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.mnuFdAnlys = new System.Windows.Forms.MenuStrip();
            this.mnuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemAddFoodType = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItmAddFoodItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItmChangeFoodItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBack = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItmRevenueAnalysis = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemFoodAnalysis = new System.Windows.Forms.ToolStripMenuItem();
            this.addStaffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItmModifyStaff = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItmRemoveStaff = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.grdFdAnlys)).BeginInit();
            this.grpFilter.SuspendLayout();
            this.mnuFdAnlys.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdFdAnlys
            // 
            this.grdFdAnlys.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdFdAnlys.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Year,
            this.Month,
            this.FoodType,
            this.FoodItem,
            this.SoldQty});
            this.grdFdAnlys.Location = new System.Drawing.Point(0, 112);
            this.grdFdAnlys.Name = "grdFdAnlys";
            this.grdFdAnlys.Size = new System.Drawing.Size(626, 326);
            this.grdFdAnlys.TabIndex = 0;
            // 
            // Year
            // 
            this.Year.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Year.HeaderText = "Year";
            this.Year.Name = "Year";
            // 
            // Month
            // 
            this.Month.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Month.HeaderText = "Month";
            this.Month.Name = "Month";
            // 
            // FoodType
            // 
            this.FoodType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FoodType.HeaderText = "Food Type";
            this.FoodType.MinimumWidth = 3;
            this.FoodType.Name = "FoodType";
            // 
            // FoodItem
            // 
            this.FoodItem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FoodItem.HeaderText = "Food Item";
            this.FoodItem.Name = "FoodItem";
            // 
            // SoldQty
            // 
            this.SoldQty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SoldQty.HeaderText = "Sold Quantity";
            this.SoldQty.Name = "SoldQty";
            // 
            // grpFilter
            // 
            this.grpFilter.Controls.Add(this.chkStarter);
            this.grpFilter.Controls.Add(this.chkBeverage);
            this.grpFilter.Controls.Add(this.chkDessert);
            this.grpFilter.Controls.Add(this.chkMain);
            this.grpFilter.Controls.Add(this.cboMonth);
            this.grpFilter.Controls.Add(this.cboYear);
            this.grpFilter.Location = new System.Drawing.Point(12, 28);
            this.grpFilter.Name = "grpFilter";
            this.grpFilter.Size = new System.Drawing.Size(442, 78);
            this.grpFilter.TabIndex = 1;
            this.grpFilter.TabStop = false;
            this.grpFilter.Text = "Filter Option";
            // 
            // chkStarter
            // 
            this.chkStarter.AutoSize = true;
            this.chkStarter.Location = new System.Drawing.Point(340, 51);
            this.chkStarter.Name = "chkStarter";
            this.chkStarter.Size = new System.Drawing.Size(57, 17);
            this.chkStarter.TabIndex = 5;
            this.chkStarter.Text = "Starter";
            this.chkStarter.UseVisualStyleBackColor = true;
            // 
            // chkBeverage
            // 
            this.chkBeverage.AutoSize = true;
            this.chkBeverage.Location = new System.Drawing.Point(342, 17);
            this.chkBeverage.Name = "chkBeverage";
            this.chkBeverage.Size = new System.Drawing.Size(72, 17);
            this.chkBeverage.TabIndex = 4;
            this.chkBeverage.Text = "Beverage";
            this.chkBeverage.UseVisualStyleBackColor = true;
            // 
            // chkDessert
            // 
            this.chkDessert.AutoSize = true;
            this.chkDessert.Location = new System.Drawing.Point(249, 53);
            this.chkDessert.Name = "chkDessert";
            this.chkDessert.Size = new System.Drawing.Size(62, 17);
            this.chkDessert.TabIndex = 3;
            this.chkDessert.Text = "Dessert";
            this.chkDessert.UseVisualStyleBackColor = true;
            // 
            // chkMain
            // 
            this.chkMain.AutoSize = true;
            this.chkMain.Checked = true;
            this.chkMain.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkMain.Location = new System.Drawing.Point(251, 17);
            this.chkMain.Name = "chkMain";
            this.chkMain.Size = new System.Drawing.Size(49, 17);
            this.chkMain.TabIndex = 2;
            this.chkMain.Text = "Main";
            this.chkMain.UseVisualStyleBackColor = true;
            this.chkMain.CheckedChanged += new System.EventHandler(this.chkMain_CheckedChanged);
            // 
            // cboMonth
            // 
            this.cboMonth.FormattingEnabled = true;
            this.cboMonth.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cboMonth.Location = new System.Drawing.Point(116, 29);
            this.cboMonth.MaxDropDownItems = 12;
            this.cboMonth.Name = "cboMonth";
            this.cboMonth.Size = new System.Drawing.Size(90, 21);
            this.cboMonth.TabIndex = 1;
            this.cboMonth.Text = "Month";
            // 
            // cboYear
            // 
            this.cboYear.FormattingEnabled = true;
            this.cboYear.Items.AddRange(new object[] {
            "2018",
            "2017",
            "2016"});
            this.cboYear.Location = new System.Drawing.Point(9, 28);
            this.cboYear.Name = "cboYear";
            this.cboYear.Size = new System.Drawing.Size(97, 21);
            this.cboYear.TabIndex = 0;
            this.cboYear.Text = "Year";
            this.cboYear.SelectedIndexChanged += new System.EventHandler(this.cboYear_SelectedIndexChanged);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(632, 395);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(139, 43);
            this.btnPrint.TabIndex = 2;
            this.btnPrint.Text = "Print ";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // mnuFdAnlys
            // 
            this.mnuFdAnlys.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuEdit,
            this.mnuOrder,
            this.mnuBack,
            this.mnuAdmin});
            this.mnuFdAnlys.Location = new System.Drawing.Point(0, 0);
            this.mnuFdAnlys.Name = "mnuFdAnlys";
            this.mnuFdAnlys.Size = new System.Drawing.Size(800, 24);
            this.mnuFdAnlys.TabIndex = 3;
            this.mnuFdAnlys.Text = "menuStrip1";
            // 
            // mnuEdit
            // 
            this.mnuEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItemAddFoodType,
            this.mnuItmAddFoodItem,
            this.mnuItmChangeFoodItem});
            this.mnuEdit.Name = "mnuEdit";
            this.mnuEdit.Size = new System.Drawing.Size(39, 20);
            this.mnuEdit.Text = "Edit";
            // 
            // mnuItemAddFoodType
            // 
            this.mnuItemAddFoodType.Name = "mnuItemAddFoodType";
            this.mnuItemAddFoodType.Size = new System.Drawing.Size(172, 22);
            this.mnuItemAddFoodType.Text = "Add Food Type";
            this.mnuItemAddFoodType.Click += new System.EventHandler(this.mnuItemAddFoodType_Click);
            // 
            // mnuItmAddFoodItem
            // 
            this.mnuItmAddFoodItem.Name = "mnuItmAddFoodItem";
            this.mnuItmAddFoodItem.Size = new System.Drawing.Size(172, 22);
            this.mnuItmAddFoodItem.Text = "Add Food Item";
            this.mnuItmAddFoodItem.Click += new System.EventHandler(this.mnuItmAddFoodItem_Click);
            // 
            // mnuItmChangeFoodItem
            // 
            this.mnuItmChangeFoodItem.Name = "mnuItmChangeFoodItem";
            this.mnuItmChangeFoodItem.Size = new System.Drawing.Size(172, 22);
            this.mnuItmChangeFoodItem.Text = "Change Food Item";
            this.mnuItmChangeFoodItem.Click += new System.EventHandler(this.mnuItmChangeFoodItem_Click);
            // 
            // mnuOrder
            // 
            this.mnuOrder.Name = "mnuOrder";
            this.mnuOrder.Size = new System.Drawing.Size(49, 20);
            this.mnuOrder.Text = "Order";
            this.mnuOrder.Click += new System.EventHandler(this.mnuOrder_Click);
            // 
            // mnuBack
            // 
            this.mnuBack.Name = "mnuBack";
            this.mnuBack.Size = new System.Drawing.Size(44, 20);
            this.mnuBack.Text = "Back";
            this.mnuBack.Click += new System.EventHandler(this.mnuBack_Click);
            // 
            // mnuAdmin
            // 
            this.mnuAdmin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItmRevenueAnalysis,
            this.mnuItemFoodAnalysis,
            this.addStaffToolStripMenuItem,
            this.mnuItmModifyStaff,
            this.mnuItmRemoveStaff});
            this.mnuAdmin.Name = "mnuAdmin";
            this.mnuAdmin.Size = new System.Drawing.Size(55, 20);
            this.mnuAdmin.Text = "Admin";
            // 
            // mnuItmRevenueAnalysis
            // 
            this.mnuItmRevenueAnalysis.Name = "mnuItmRevenueAnalysis";
            this.mnuItmRevenueAnalysis.Size = new System.Drawing.Size(165, 22);
            this.mnuItmRevenueAnalysis.Text = "Revenue Analysis";
            this.mnuItmRevenueAnalysis.Click += new System.EventHandler(this.mnuItmRevenueAnalysis_Click);
            // 
            // mnuItemFoodAnalysis
            // 
            this.mnuItemFoodAnalysis.Name = "mnuItemFoodAnalysis";
            this.mnuItemFoodAnalysis.Size = new System.Drawing.Size(165, 22);
            this.mnuItemFoodAnalysis.Text = "Food Analysis";
            // 
            // addStaffToolStripMenuItem
            // 
            this.addStaffToolStripMenuItem.Name = "addStaffToolStripMenuItem";
            this.addStaffToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.addStaffToolStripMenuItem.Text = "Add Staff";
            this.addStaffToolStripMenuItem.Click += new System.EventHandler(this.addStaffToolStripMenuItem_Click);
            // 
            // mnuItmModifyStaff
            // 
            this.mnuItmModifyStaff.Name = "mnuItmModifyStaff";
            this.mnuItmModifyStaff.Size = new System.Drawing.Size(165, 22);
            this.mnuItmModifyStaff.Text = "Modify Staff";
            this.mnuItmModifyStaff.Click += new System.EventHandler(this.mnuItmModifyStaff_Click);
            // 
            // mnuItmRemoveStaff
            // 
            this.mnuItmRemoveStaff.Name = "mnuItmRemoveStaff";
            this.mnuItmRemoveStaff.Size = new System.Drawing.Size(165, 22);
            this.mnuItmRemoveStaff.Text = "Remove Staff";
            this.mnuItmRemoveStaff.Click += new System.EventHandler(this.mnuItmRemoveStaff_Click);
            // 
            // frmFoodAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.grpFilter);
            this.Controls.Add(this.grdFdAnlys);
            this.Controls.Add(this.mnuFdAnlys);
            this.MainMenuStrip = this.mnuFdAnlys;
            this.Name = "frmFoodAnalysis";
            this.Text = "frmFoodAnalysis";
            this.Load += new System.EventHandler(this.frmFoodAnalysis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdFdAnlys)).EndInit();
            this.grpFilter.ResumeLayout(false);
            this.grpFilter.PerformLayout();
            this.mnuFdAnlys.ResumeLayout(false);
            this.mnuFdAnlys.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdFdAnlys;
        private System.Windows.Forms.GroupBox grpFilter;
        private System.Windows.Forms.ComboBox cboMonth;
        private System.Windows.Forms.ComboBox cboYear;
        private System.Windows.Forms.CheckBox chkStarter;
        private System.Windows.Forms.CheckBox chkBeverage;
        private System.Windows.Forms.CheckBox chkDessert;
        private System.Windows.Forms.CheckBox chkMain;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.MenuStrip mnuFdAnlys;
        private System.Windows.Forms.ToolStripMenuItem mnuEdit;
        private System.Windows.Forms.ToolStripMenuItem mnuOrder;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.ToolStripMenuItem mnuAdmin;
        private System.Windows.Forms.ToolStripMenuItem mnuItmRevenueAnalysis;
        private System.Windows.Forms.ToolStripMenuItem mnuItemFoodAnalysis;
        private System.Windows.Forms.ToolStripMenuItem mnuItemAddFoodType;
        private System.Windows.Forms.ToolStripMenuItem mnuItmAddFoodItem;
        private System.Windows.Forms.ToolStripMenuItem mnuItmChangeFoodItem;
        private System.Windows.Forms.ToolStripMenuItem addStaffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuItmModifyStaff;
        private System.Windows.Forms.ToolStripMenuItem mnuItmRemoveStaff;
        private System.Windows.Forms.DataGridViewTextBoxColumn Year;
        private System.Windows.Forms.DataGridViewTextBoxColumn Month;
        private System.Windows.Forms.DataGridViewTextBoxColumn FoodType;
        private System.Windows.Forms.DataGridViewTextBoxColumn FoodItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoldQty;
    }
}