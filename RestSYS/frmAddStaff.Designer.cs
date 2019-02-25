namespace RestSYS
{
    partial class frmAddStaff
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItmAddFoodType = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItmAddFoodItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItmChangeFoodItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBack = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItmRevenueAnalysis = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItmFoodAnalysis = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItmAddStaff = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItmChangeStaff = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItmDeleteStaff = new System.Windows.Forms.ToolStripMenuItem();
            this.lblStaffName = new System.Windows.Forms.Label();
            this.txtStaffName = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblStaffId = new System.Windows.Forms.Label();
            this.txtStaffId = new System.Windows.Forms.TextBox();
            this.lblStaffStatus = new System.Windows.Forms.Label();
            this.cboStaffStatus = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.mnuOrder,
            this.mnuBack,
            this.mnuAdmin});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItmAddFoodType,
            this.mnuItmAddFoodItem,
            this.mnuItmChangeFoodItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // mnuItmAddFoodType
            // 
            this.mnuItmAddFoodType.Name = "mnuItmAddFoodType";
            this.mnuItmAddFoodType.Size = new System.Drawing.Size(172, 22);
            this.mnuItmAddFoodType.Text = "Add Food Type";
            this.mnuItmAddFoodType.Click += new System.EventHandler(this.mnuItmAddFoodType_Click);
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
            this.mnuItmFoodAnalysis,
            this.mnuItmAddStaff,
            this.mnuItmChangeStaff,
            this.mnuItmDeleteStaff});
            this.mnuAdmin.Name = "mnuAdmin";
            this.mnuAdmin.Size = new System.Drawing.Size(55, 20);
            this.mnuAdmin.Text = "Admin";
            // 
            // mnuItmRevenueAnalysis
            // 
            this.mnuItmRevenueAnalysis.Name = "mnuItmRevenueAnalysis";
            this.mnuItmRevenueAnalysis.Size = new System.Drawing.Size(180, 22);
            this.mnuItmRevenueAnalysis.Text = "Revenue Analysis";
            this.mnuItmRevenueAnalysis.Click += new System.EventHandler(this.mnuItmRevenueAnalysis_Click);
            // 
            // mnuItmFoodAnalysis
            // 
            this.mnuItmFoodAnalysis.Name = "mnuItmFoodAnalysis";
            this.mnuItmFoodAnalysis.Size = new System.Drawing.Size(180, 22);
            this.mnuItmFoodAnalysis.Text = "Food Analysis";
            this.mnuItmFoodAnalysis.Click += new System.EventHandler(this.mnuItmFoodAnalysis_Click);
            // 
            // mnuItmAddStaff
            // 
            this.mnuItmAddStaff.Name = "mnuItmAddStaff";
            this.mnuItmAddStaff.Size = new System.Drawing.Size(180, 22);
            this.mnuItmAddStaff.Text = "Add Staff";
            // 
            // mnuItmChangeStaff
            // 
            this.mnuItmChangeStaff.Name = "mnuItmChangeStaff";
            this.mnuItmChangeStaff.Size = new System.Drawing.Size(180, 22);
            this.mnuItmChangeStaff.Text = "Change Staff Details";
            this.mnuItmChangeStaff.Click += new System.EventHandler(this.mnuItmChangeStaff_Click);
            // 
            // mnuItmDeleteStaff
            // 
            this.mnuItmDeleteStaff.Name = "mnuItmDeleteStaff";
            this.mnuItmDeleteStaff.Size = new System.Drawing.Size(180, 22);
            this.mnuItmDeleteStaff.Text = "Delete Staff";
            // 
            // lblStaffName
            // 
            this.lblStaffName.AutoSize = true;
            this.lblStaffName.Location = new System.Drawing.Point(15, 95);
            this.lblStaffName.Name = "lblStaffName";
            this.lblStaffName.Size = new System.Drawing.Size(60, 13);
            this.lblStaffName.TabIndex = 1;
            this.lblStaffName.Text = "Staff Name";
            // 
            // txtStaffName
            // 
            this.txtStaffName.Location = new System.Drawing.Point(96, 92);
            this.txtStaffName.Name = "txtStaffName";
            this.txtStaffName.Size = new System.Drawing.Size(164, 20);
            this.txtStaffName.TabIndex = 2;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(52, 227);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(193, 53);
            this.btnSubmit.TabIndex = 3;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblStaffId
            // 
            this.lblStaffId.AutoSize = true;
            this.lblStaffId.Location = new System.Drawing.Point(15, 44);
            this.lblStaffId.Name = "lblStaffId";
            this.lblStaffId.Size = new System.Drawing.Size(43, 13);
            this.lblStaffId.TabIndex = 4;
            this.lblStaffId.Text = "Staff ID";
            // 
            // txtStaffId
            // 
            this.txtStaffId.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtStaffId.Enabled = false;
            this.txtStaffId.Location = new System.Drawing.Point(96, 44);
            this.txtStaffId.Name = "txtStaffId";
            this.txtStaffId.Size = new System.Drawing.Size(88, 20);
            this.txtStaffId.TabIndex = 5;
            // 
            // lblStaffStatus
            // 
            this.lblStaffStatus.AutoSize = true;
            this.lblStaffStatus.Location = new System.Drawing.Point(15, 132);
            this.lblStaffStatus.Name = "lblStaffStatus";
            this.lblStaffStatus.Size = new System.Drawing.Size(62, 13);
            this.lblStaffStatus.TabIndex = 6;
            this.lblStaffStatus.Text = "Staff Status";
            // 
            // cboStaffStatus
            // 
            this.cboStaffStatus.FormattingEnabled = true;
            this.cboStaffStatus.Items.AddRange(new object[] {
            "W: Working",
            "Q: Quit"});
            this.cboStaffStatus.Location = new System.Drawing.Point(96, 129);
            this.cboStaffStatus.Name = "cboStaffStatus";
            this.cboStaffStatus.Size = new System.Drawing.Size(141, 21);
            this.cboStaffStatus.TabIndex = 7;
            // 
            // frmAddStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cboStaffStatus);
            this.Controls.Add(this.lblStaffStatus);
            this.Controls.Add(this.txtStaffId);
            this.Controls.Add(this.lblStaffId);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtStaffName);
            this.Controls.Add(this.lblStaffName);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmAddStaff";
            this.Text = "Add Staff";
            this.Load += new System.EventHandler(this.frmAddStaff_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuItmAddFoodType;
        private System.Windows.Forms.ToolStripMenuItem mnuItmAddFoodItem;
        private System.Windows.Forms.ToolStripMenuItem mnuItmChangeFoodItem;
        private System.Windows.Forms.ToolStripMenuItem mnuOrder;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.ToolStripMenuItem mnuAdmin;
        private System.Windows.Forms.ToolStripMenuItem mnuItmRevenueAnalysis;
        private System.Windows.Forms.ToolStripMenuItem mnuItmFoodAnalysis;
        private System.Windows.Forms.ToolStripMenuItem mnuItmAddStaff;
        private System.Windows.Forms.Label lblStaffName;
        private System.Windows.Forms.TextBox txtStaffName;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.ToolStripMenuItem mnuItmChangeStaff;
        private System.Windows.Forms.ToolStripMenuItem mnuItmDeleteStaff;
        private System.Windows.Forms.Label lblStaffId;
        private System.Windows.Forms.TextBox txtStaffId;
        private System.Windows.Forms.Label lblStaffStatus;
        private System.Windows.Forms.ComboBox cboStaffStatus;
    }
}