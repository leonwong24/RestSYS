﻿namespace RestSYS
{
    partial class frmChangeFoodItem
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
            this.btnChgFoodItemSubmit = new System.Windows.Forms.Button();
            this.txtChangeFoodItemDesc = new System.Windows.Forms.TextBox();
            this.txtChangeFoodItem = new System.Windows.Forms.TextBox();
            this.lblFoodStatus = new System.Windows.Forms.Label();
            this.lblFoodPrice = new System.Windows.Forms.Label();
            this.lblFoodType = new System.Windows.Forms.Label();
            this.lblFoodItemDesc = new System.Windows.Forms.Label();
            this.lblFoodItem = new System.Windows.Forms.Label();
            this.mnuFoodItem = new System.Windows.Forms.MenuStrip();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addFoodTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addFoodItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeFoodItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBack = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.revenueAnalysisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.foodAnalysisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItmAddStaff = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItmChangeStaff = new System.Windows.Forms.ToolStripMenuItem();
            this.lblChangeFdItemTitle = new System.Windows.Forms.Label();
            this.cboChangeFoodItemType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpChangeFoodItemSelectFood = new System.Windows.Forms.GroupBox();
            this.grdChangeFoodItemSelectFoodItem = new System.Windows.Forms.DataGridView();
            this.btnChangeFoodItemSelectFoodItemButton = new System.Windows.Forms.Button();
            this.grpChangeFoodItemChangeFood = new System.Windows.Forms.GroupBox();
            this.txtChangeFoodItemId = new System.Windows.Forms.TextBox();
            this.txtChgFoodItemPrice = new System.Windows.Forms.NumericUpDown();
            this.cboChangeFoodItemFoodStatus = new System.Windows.Forms.ComboBox();
            this.cboChangeFoodItemFoodType = new System.Windows.Forms.ComboBox();
            this.mnuFoodItem.SuspendLayout();
            this.grpChangeFoodItemSelectFood.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdChangeFoodItemSelectFoodItem)).BeginInit();
            this.grpChangeFoodItemChangeFood.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtChgFoodItemPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // btnChgFoodItemSubmit
            // 
            this.btnChgFoodItemSubmit.Location = new System.Drawing.Point(33, 273);
            this.btnChgFoodItemSubmit.Name = "btnChgFoodItemSubmit";
            this.btnChgFoodItemSubmit.Size = new System.Drawing.Size(147, 32);
            this.btnChgFoodItemSubmit.TabIndex = 31;
            this.btnChgFoodItemSubmit.Text = "Submit";
            this.btnChgFoodItemSubmit.UseVisualStyleBackColor = true;
            this.btnChgFoodItemSubmit.Click += new System.EventHandler(this.btnChgFoodItemSubmit_Click);
            // 
            // txtChangeFoodItemDesc
            // 
            this.txtChangeFoodItemDesc.Location = new System.Drawing.Point(77, 88);
            this.txtChangeFoodItemDesc.MaxLength = 100;
            this.txtChangeFoodItemDesc.Name = "txtChangeFoodItemDesc";
            this.txtChangeFoodItemDesc.Size = new System.Drawing.Size(387, 20);
            this.txtChangeFoodItemDesc.TabIndex = 27;
            // 
            // txtChangeFoodItem
            // 
            this.txtChangeFoodItem.Location = new System.Drawing.Point(77, 45);
            this.txtChangeFoodItem.MaxLength = 15;
            this.txtChangeFoodItem.Name = "txtChangeFoodItem";
            this.txtChangeFoodItem.Size = new System.Drawing.Size(258, 20);
            this.txtChangeFoodItem.TabIndex = 26;
            // 
            // lblFoodStatus
            // 
            this.lblFoodStatus.AutoSize = true;
            this.lblFoodStatus.Location = new System.Drawing.Point(5, 218);
            this.lblFoodStatus.Name = "lblFoodStatus";
            this.lblFoodStatus.Size = new System.Drawing.Size(43, 13);
            this.lblFoodStatus.TabIndex = 25;
            this.lblFoodStatus.Text = "Status: ";
            // 
            // lblFoodPrice
            // 
            this.lblFoodPrice.AutoSize = true;
            this.lblFoodPrice.Location = new System.Drawing.Point(5, 171);
            this.lblFoodPrice.Name = "lblFoodPrice";
            this.lblFoodPrice.Size = new System.Drawing.Size(37, 13);
            this.lblFoodPrice.TabIndex = 24;
            this.lblFoodPrice.Text = "Price: ";
            // 
            // lblFoodType
            // 
            this.lblFoodType.AutoSize = true;
            this.lblFoodType.Location = new System.Drawing.Point(5, 132);
            this.lblFoodType.Name = "lblFoodType";
            this.lblFoodType.Size = new System.Drawing.Size(58, 13);
            this.lblFoodType.TabIndex = 23;
            this.lblFoodType.Text = "Food Type";
            // 
            // lblFoodItemDesc
            // 
            this.lblFoodItemDesc.AutoSize = true;
            this.lblFoodItemDesc.Location = new System.Drawing.Point(5, 88);
            this.lblFoodItemDesc.Name = "lblFoodItemDesc";
            this.lblFoodItemDesc.Size = new System.Drawing.Size(66, 13);
            this.lblFoodItemDesc.TabIndex = 22;
            this.lblFoodItemDesc.Text = "Description: ";
            // 
            // lblFoodItem
            // 
            this.lblFoodItem.AutoSize = true;
            this.lblFoodItem.Location = new System.Drawing.Point(5, 46);
            this.lblFoodItem.Name = "lblFoodItem";
            this.lblFoodItem.Size = new System.Drawing.Size(57, 13);
            this.lblFoodItem.TabIndex = 21;
            this.lblFoodItem.Text = "Food Item:";
            // 
            // mnuFoodItem
            // 
            this.mnuFoodItem.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.orderToolStripMenuItem,
            this.mnuBack,
            this.mnuAdmin});
            this.mnuFoodItem.Location = new System.Drawing.Point(0, 0);
            this.mnuFoodItem.Name = "mnuFoodItem";
            this.mnuFoodItem.Size = new System.Drawing.Size(800, 24);
            this.mnuFoodItem.TabIndex = 20;
            this.mnuFoodItem.Text = "menuAddFoodType";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addFoodTypeToolStripMenuItem,
            this.addFoodItemToolStripMenuItem,
            this.changeFoodItemToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // addFoodTypeToolStripMenuItem
            // 
            this.addFoodTypeToolStripMenuItem.Name = "addFoodTypeToolStripMenuItem";
            this.addFoodTypeToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.addFoodTypeToolStripMenuItem.Text = "Add Food Type";
            this.addFoodTypeToolStripMenuItem.Click += new System.EventHandler(this.addFoodTypeToolStripMenuItem_Click);
            // 
            // addFoodItemToolStripMenuItem
            // 
            this.addFoodItemToolStripMenuItem.Name = "addFoodItemToolStripMenuItem";
            this.addFoodItemToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.addFoodItemToolStripMenuItem.Text = "Add Food Item";
            this.addFoodItemToolStripMenuItem.Click += new System.EventHandler(this.addFoodItemToolStripMenuItem_Click);
            // 
            // changeFoodItemToolStripMenuItem
            // 
            this.changeFoodItemToolStripMenuItem.Name = "changeFoodItemToolStripMenuItem";
            this.changeFoodItemToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.changeFoodItemToolStripMenuItem.Text = "Change Food Item";
            // 
            // orderToolStripMenuItem
            // 
            this.orderToolStripMenuItem.Name = "orderToolStripMenuItem";
            this.orderToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.orderToolStripMenuItem.Text = "Order";
            this.orderToolStripMenuItem.Click += new System.EventHandler(this.orderToolStripMenuItem_Click);
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
            this.revenueAnalysisToolStripMenuItem,
            this.foodAnalysisToolStripMenuItem,
            this.mnuItmAddStaff,
            this.mnuItmChangeStaff});
            this.mnuAdmin.Name = "mnuAdmin";
            this.mnuAdmin.Size = new System.Drawing.Size(55, 20);
            this.mnuAdmin.Text = "Admin";
            // 
            // revenueAnalysisToolStripMenuItem
            // 
            this.revenueAnalysisToolStripMenuItem.Name = "revenueAnalysisToolStripMenuItem";
            this.revenueAnalysisToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.revenueAnalysisToolStripMenuItem.Text = "Revenue Analysis";
            this.revenueAnalysisToolStripMenuItem.Click += new System.EventHandler(this.revenueAnalysisToolStripMenuItem_Click);
            // 
            // foodAnalysisToolStripMenuItem
            // 
            this.foodAnalysisToolStripMenuItem.Name = "foodAnalysisToolStripMenuItem";
            this.foodAnalysisToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.foodAnalysisToolStripMenuItem.Text = "Food Analysis";
            this.foodAnalysisToolStripMenuItem.Click += new System.EventHandler(this.foodAnalysisToolStripMenuItem_Click);
            // 
            // mnuItmAddStaff
            // 
            this.mnuItmAddStaff.Name = "mnuItmAddStaff";
            this.mnuItmAddStaff.Size = new System.Drawing.Size(165, 22);
            this.mnuItmAddStaff.Text = "Add Staff";
            this.mnuItmAddStaff.Click += new System.EventHandler(this.mnuItmAddStaff_Click);
            // 
            // mnuItmChangeStaff
            // 
            this.mnuItmChangeStaff.Name = "mnuItmChangeStaff";
            this.mnuItmChangeStaff.Size = new System.Drawing.Size(165, 22);
            this.mnuItmChangeStaff.Text = "Modify Staff";
            this.mnuItmChangeStaff.Click += new System.EventHandler(this.mnuItmChangeStaff_Click);
            // 
            // lblChangeFdItemTitle
            // 
            this.lblChangeFdItemTitle.AutoSize = true;
            this.lblChangeFdItemTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChangeFdItemTitle.Location = new System.Drawing.Point(269, 45);
            this.lblChangeFdItemTitle.Name = "lblChangeFdItemTitle";
            this.lblChangeFdItemTitle.Size = new System.Drawing.Size(282, 37);
            this.lblChangeFdItemTitle.TabIndex = 19;
            this.lblChangeFdItemTitle.Text = "Change Food Item";
            // 
            // cboChangeFoodItemType
            // 
            this.cboChangeFoodItemType.FormattingEnabled = true;
            this.cboChangeFoodItemType.Location = new System.Drawing.Point(115, 24);
            this.cboChangeFoodItemType.Name = "cboChangeFoodItemType";
            this.cboChangeFoodItemType.Size = new System.Drawing.Size(108, 21);
            this.cboChangeFoodItemType.TabIndex = 32;
            this.cboChangeFoodItemType.SelectedIndexChanged += new System.EventHandler(this.cboChangeFoodItemType_SelectedIndexChange);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Food Type";
            // 
            // grpChangeFoodItemSelectFood
            // 
            this.grpChangeFoodItemSelectFood.Controls.Add(this.grdChangeFoodItemSelectFoodItem);
            this.grpChangeFoodItemSelectFood.Controls.Add(this.btnChangeFoodItemSelectFoodItemButton);
            this.grpChangeFoodItemSelectFood.Controls.Add(this.label1);
            this.grpChangeFoodItemSelectFood.Controls.Add(this.cboChangeFoodItemType);
            this.grpChangeFoodItemSelectFood.Location = new System.Drawing.Point(12, 45);
            this.grpChangeFoodItemSelectFood.Name = "grpChangeFoodItemSelectFood";
            this.grpChangeFoodItemSelectFood.Size = new System.Drawing.Size(728, 332);
            this.grpChangeFoodItemSelectFood.TabIndex = 34;
            this.grpChangeFoodItemSelectFood.TabStop = false;
            this.grpChangeFoodItemSelectFood.Text = "Select Food Item";
            // 
            // grdChangeFoodItemSelectFoodItem
            // 
            this.grdChangeFoodItemSelectFoodItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdChangeFoodItemSelectFoodItem.Location = new System.Drawing.Point(32, 65);
            this.grdChangeFoodItemSelectFoodItem.Name = "grdChangeFoodItemSelectFoodItem";
            this.grdChangeFoodItemSelectFoodItem.Size = new System.Drawing.Size(671, 195);
            this.grdChangeFoodItemSelectFoodItem.TabIndex = 36;
            // 
            // btnChangeFoodItemSelectFoodItemButton
            // 
            this.btnChangeFoodItemSelectFoodItemButton.Location = new System.Drawing.Point(579, 277);
            this.btnChangeFoodItemSelectFoodItemButton.Name = "btnChangeFoodItemSelectFoodItemButton";
            this.btnChangeFoodItemSelectFoodItemButton.Size = new System.Drawing.Size(125, 32);
            this.btnChangeFoodItemSelectFoodItemButton.TabIndex = 35;
            this.btnChangeFoodItemSelectFoodItemButton.Text = "Select Food";
            this.btnChangeFoodItemSelectFoodItemButton.UseVisualStyleBackColor = true;
            this.btnChangeFoodItemSelectFoodItemButton.Click += new System.EventHandler(this.btnChangeFoodItemSelectFoodItemButton_Click);
            // 
            // grpChangeFoodItemChangeFood
            // 
            this.grpChangeFoodItemChangeFood.Controls.Add(this.txtChangeFoodItemId);
            this.grpChangeFoodItemChangeFood.Controls.Add(this.txtChgFoodItemPrice);
            this.grpChangeFoodItemChangeFood.Controls.Add(this.cboChangeFoodItemFoodStatus);
            this.grpChangeFoodItemChangeFood.Controls.Add(this.cboChangeFoodItemFoodType);
            this.grpChangeFoodItemChangeFood.Controls.Add(this.btnChgFoodItemSubmit);
            this.grpChangeFoodItemChangeFood.Controls.Add(this.txtChangeFoodItemDesc);
            this.grpChangeFoodItemChangeFood.Controls.Add(this.txtChangeFoodItem);
            this.grpChangeFoodItemChangeFood.Controls.Add(this.lblFoodStatus);
            this.grpChangeFoodItemChangeFood.Controls.Add(this.lblFoodPrice);
            this.grpChangeFoodItemChangeFood.Controls.Add(this.lblFoodType);
            this.grpChangeFoodItemChangeFood.Controls.Add(this.lblFoodItemDesc);
            this.grpChangeFoodItemChangeFood.Controls.Add(this.lblFoodItem);
            this.grpChangeFoodItemChangeFood.Location = new System.Drawing.Point(12, 85);
            this.grpChangeFoodItemChangeFood.Name = "grpChangeFoodItemChangeFood";
            this.grpChangeFoodItemChangeFood.Size = new System.Drawing.Size(583, 319);
            this.grpChangeFoodItemChangeFood.TabIndex = 35;
            this.grpChangeFoodItemChangeFood.TabStop = false;
            this.grpChangeFoodItemChangeFood.Text = "Change Food Item";
            this.grpChangeFoodItemChangeFood.Visible = false;
            // 
            // txtChangeFoodItemId
            // 
            this.txtChangeFoodItemId.Enabled = false;
            this.txtChangeFoodItemId.Location = new System.Drawing.Point(103, 19);
            this.txtChangeFoodItemId.Name = "txtChangeFoodItemId";
            this.txtChangeFoodItemId.Size = new System.Drawing.Size(118, 20);
            this.txtChangeFoodItemId.TabIndex = 35;
            this.txtChangeFoodItemId.Visible = false;
            // 
            // txtChgFoodItemPrice
            // 
            this.txtChgFoodItemPrice.DecimalPlaces = 2;
            this.txtChgFoodItemPrice.Location = new System.Drawing.Point(77, 171);
            this.txtChgFoodItemPrice.Name = "txtChgFoodItemPrice";
            this.txtChgFoodItemPrice.Size = new System.Drawing.Size(120, 20);
            this.txtChgFoodItemPrice.TabIndex = 34;
            // 
            // cboChangeFoodItemFoodStatus
            // 
            this.cboChangeFoodItemFoodStatus.FormattingEnabled = true;
            this.cboChangeFoodItemFoodStatus.Items.AddRange(new object[] {
            "A : Available",
            "U : Unavailable"});
            this.cboChangeFoodItemFoodStatus.Location = new System.Drawing.Point(77, 218);
            this.cboChangeFoodItemFoodStatus.Name = "cboChangeFoodItemFoodStatus";
            this.cboChangeFoodItemFoodStatus.Size = new System.Drawing.Size(90, 21);
            this.cboChangeFoodItemFoodStatus.TabIndex = 33;
            // 
            // cboChangeFoodItemFoodType
            // 
            this.cboChangeFoodItemFoodType.FormattingEnabled = true;
            this.cboChangeFoodItemFoodType.Location = new System.Drawing.Point(77, 129);
            this.cboChangeFoodItemFoodType.Name = "cboChangeFoodItemFoodType";
            this.cboChangeFoodItemFoodType.Size = new System.Drawing.Size(97, 21);
            this.cboChangeFoodItemFoodType.TabIndex = 32;
            // 
            // frmChangeFoodItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpChangeFoodItemChangeFood);
            this.Controls.Add(this.grpChangeFoodItemSelectFood);
            this.Controls.Add(this.mnuFoodItem);
            this.Controls.Add(this.lblChangeFdItemTitle);
            this.Name = "frmChangeFoodItem";
            this.Text = "frmChangeFoodItem";
            this.Load += new System.EventHandler(this.frmChangeFoodItem_Load);
            this.mnuFoodItem.ResumeLayout(false);
            this.mnuFoodItem.PerformLayout();
            this.grpChangeFoodItemSelectFood.ResumeLayout(false);
            this.grpChangeFoodItemSelectFood.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdChangeFoodItemSelectFoodItem)).EndInit();
            this.grpChangeFoodItemChangeFood.ResumeLayout(false);
            this.grpChangeFoodItemChangeFood.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtChgFoodItemPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChgFoodItemSubmit;
        private System.Windows.Forms.TextBox txtChangeFoodItemDesc;
        private System.Windows.Forms.TextBox txtChangeFoodItem;
        private System.Windows.Forms.Label lblFoodStatus;
        private System.Windows.Forms.Label lblFoodPrice;
        private System.Windows.Forms.Label lblFoodType;
        private System.Windows.Forms.Label lblFoodItemDesc;
        private System.Windows.Forms.Label lblFoodItem;
        private System.Windows.Forms.MenuStrip mnuFoodItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addFoodTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addFoodItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeFoodItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderToolStripMenuItem;
        private System.Windows.Forms.Label lblChangeFdItemTitle;
        private System.Windows.Forms.ComboBox cboChangeFoodItemType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpChangeFoodItemSelectFood;
        private System.Windows.Forms.Button btnChangeFoodItemSelectFoodItemButton;
        private System.Windows.Forms.GroupBox grpChangeFoodItemChangeFood;
        private System.Windows.Forms.ComboBox cboChangeFoodItemFoodStatus;
        private System.Windows.Forms.ComboBox cboChangeFoodItemFoodType;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.ToolStripMenuItem mnuAdmin;
        private System.Windows.Forms.ToolStripMenuItem revenueAnalysisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem foodAnalysisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuItmAddStaff;
        private System.Windows.Forms.ToolStripMenuItem mnuItmChangeStaff;
        private System.Windows.Forms.DataGridView grdChangeFoodItemSelectFoodItem;
        private System.Windows.Forms.NumericUpDown txtChgFoodItemPrice;
        private System.Windows.Forms.TextBox txtChangeFoodItemId;
    }
}