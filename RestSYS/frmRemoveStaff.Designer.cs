namespace RestSYS
{
    partial class frmRemoveStaff
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
            this.cboStaff = new System.Windows.Forms.ComboBox();
            this.lblStaffName = new System.Windows.Forms.Label();
            this.grpRemoveStaff = new System.Windows.Forms.GroupBox();
            this.btnRemoveStaff = new System.Windows.Forms.Button();
            this.mnuRemoveStaff = new System.Windows.Forms.MenuStrip();
            this.mnuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItmAddFoodType = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItmAddFoodItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItmChangeFoodItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBack = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItmRevenueAnalysis = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItmFoodAnalysis = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItmAddStaff = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItmModifyStaff = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItmRemoveStaff = new System.Windows.Forms.ToolStripMenuItem();
            this.grpRemoveStaff.SuspendLayout();
            this.mnuRemoveStaff.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboStaff
            // 
            this.cboStaff.FormattingEnabled = true;
            this.cboStaff.Items.AddRange(new object[] {
            "Brian",
            "Colin",
            "George",
            "Jonathon"});
            this.cboStaff.Location = new System.Drawing.Point(90, 51);
            this.cboStaff.Name = "cboStaff";
            this.cboStaff.Size = new System.Drawing.Size(186, 21);
            this.cboStaff.TabIndex = 0;
            // 
            // lblStaffName
            // 
            this.lblStaffName.AutoSize = true;
            this.lblStaffName.Location = new System.Drawing.Point(8, 54);
            this.lblStaffName.Name = "lblStaffName";
            this.lblStaffName.Size = new System.Drawing.Size(60, 13);
            this.lblStaffName.TabIndex = 1;
            this.lblStaffName.Text = "Staff Name";
            // 
            // grpRemoveStaff
            // 
            this.grpRemoveStaff.Controls.Add(this.btnRemoveStaff);
            this.grpRemoveStaff.Controls.Add(this.lblStaffName);
            this.grpRemoveStaff.Controls.Add(this.cboStaff);
            this.grpRemoveStaff.Location = new System.Drawing.Point(17, 51);
            this.grpRemoveStaff.Name = "grpRemoveStaff";
            this.grpRemoveStaff.Size = new System.Drawing.Size(303, 190);
            this.grpRemoveStaff.TabIndex = 2;
            this.grpRemoveStaff.TabStop = false;
            this.grpRemoveStaff.Text = "Remove Staff";
            // 
            // btnRemoveStaff
            // 
            this.btnRemoveStaff.Location = new System.Drawing.Point(70, 114);
            this.btnRemoveStaff.Name = "btnRemoveStaff";
            this.btnRemoveStaff.Size = new System.Drawing.Size(142, 55);
            this.btnRemoveStaff.TabIndex = 2;
            this.btnRemoveStaff.Text = "Remove Staff";
            this.btnRemoveStaff.UseVisualStyleBackColor = true;
            this.btnRemoveStaff.Click += new System.EventHandler(this.btnRemoveStaff_Click);
            // 
            // mnuRemoveStaff
            // 
            this.mnuRemoveStaff.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuEdit,
            this.mnuOrder,
            this.mnuBack,
            this.mnuAdmin});
            this.mnuRemoveStaff.Location = new System.Drawing.Point(0, 0);
            this.mnuRemoveStaff.Name = "mnuRemoveStaff";
            this.mnuRemoveStaff.Size = new System.Drawing.Size(800, 24);
            this.mnuRemoveStaff.TabIndex = 3;
            this.mnuRemoveStaff.Text = "menuStrip1";
            // 
            // mnuEdit
            // 
            this.mnuEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItmAddFoodType,
            this.mnuItmAddFoodItem,
            this.mnuItmChangeFoodItem});
            this.mnuEdit.Name = "mnuEdit";
            this.mnuEdit.Size = new System.Drawing.Size(39, 20);
            this.mnuEdit.Text = "Edit";
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
            this.mnuItmModifyStaff,
            this.mnuItmRemoveStaff});
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
            this.mnuItmAddStaff.Click += new System.EventHandler(this.mnuItmAddStaff_Click);
            // 
            // mnuItmModifyStaff
            // 
            this.mnuItmModifyStaff.Name = "mnuItmModifyStaff";
            this.mnuItmModifyStaff.Size = new System.Drawing.Size(180, 22);
            this.mnuItmModifyStaff.Text = "Modify Staff";
            this.mnuItmModifyStaff.Click += new System.EventHandler(this.mnuItmModifyStaff_Click);
            // 
            // mnuItmRemoveStaff
            // 
            this.mnuItmRemoveStaff.Name = "mnuItmRemoveStaff";
            this.mnuItmRemoveStaff.Size = new System.Drawing.Size(180, 22);
            this.mnuItmRemoveStaff.Text = "Remove Staff";
            // 
            // frmRemoveStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpRemoveStaff);
            this.Controls.Add(this.mnuRemoveStaff);
            this.MainMenuStrip = this.mnuRemoveStaff;
            this.Name = "frmRemoveStaff";
            this.Text = "frmRemoveStaff";
            this.grpRemoveStaff.ResumeLayout(false);
            this.grpRemoveStaff.PerformLayout();
            this.mnuRemoveStaff.ResumeLayout(false);
            this.mnuRemoveStaff.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboStaff;
        private System.Windows.Forms.Label lblStaffName;
        private System.Windows.Forms.GroupBox grpRemoveStaff;
        private System.Windows.Forms.Button btnRemoveStaff;
        private System.Windows.Forms.MenuStrip mnuRemoveStaff;
        private System.Windows.Forms.ToolStripMenuItem mnuEdit;
        private System.Windows.Forms.ToolStripMenuItem mnuItmAddFoodType;
        private System.Windows.Forms.ToolStripMenuItem mnuItmAddFoodItem;
        private System.Windows.Forms.ToolStripMenuItem mnuItmChangeFoodItem;
        private System.Windows.Forms.ToolStripMenuItem mnuOrder;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.ToolStripMenuItem mnuAdmin;
        private System.Windows.Forms.ToolStripMenuItem mnuItmRevenueAnalysis;
        private System.Windows.Forms.ToolStripMenuItem mnuItmFoodAnalysis;
        private System.Windows.Forms.ToolStripMenuItem mnuItmAddStaff;
        private System.Windows.Forms.ToolStripMenuItem mnuItmModifyStaff;
        private System.Windows.Forms.ToolStripMenuItem mnuItmRemoveStaff;
    }
}