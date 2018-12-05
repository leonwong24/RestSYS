namespace RestSYS
{
    partial class frmChangeStaff
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
            this.grpSelectStaff = new System.Windows.Forms.GroupBox();
            this.cboStaffName = new System.Windows.Forms.ComboBox();
            this.btnSelectStaff = new System.Windows.Forms.Button();
            this.grpChangeStaff = new System.Windows.Forms.GroupBox();
            this.lblStaffName = new System.Windows.Forms.Label();
            this.txtStaffName = new System.Windows.Forms.TextBox();
            this.btnChange = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBack = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItmAddFoodType = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItmAddFoodItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItmChangeFoodItm = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItmRevenueAnalysis = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItmFoodAnalysis = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItmAddStaff = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItmChangeStaffDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItmRemoveStaff = new System.Windows.Forms.ToolStripMenuItem();
            this.grpSelectStaff.SuspendLayout();
            this.grpChangeStaff.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpSelectStaff
            // 
            this.grpSelectStaff.Controls.Add(this.btnSelectStaff);
            this.grpSelectStaff.Controls.Add(this.cboStaffName);
            this.grpSelectStaff.Location = new System.Drawing.Point(50, 56);
            this.grpSelectStaff.Name = "grpSelectStaff";
            this.grpSelectStaff.Size = new System.Drawing.Size(459, 267);
            this.grpSelectStaff.TabIndex = 0;
            this.grpSelectStaff.TabStop = false;
            this.grpSelectStaff.Text = "Select Staff to Change";
            // 
            // cboStaffName
            // 
            this.cboStaffName.FormattingEnabled = true;
            this.cboStaffName.Items.AddRange(new object[] {
            "Brian",
            "Colin",
            "George",
            "Jonathon"});
            this.cboStaffName.Location = new System.Drawing.Point(23, 44);
            this.cboStaffName.Name = "cboStaffName";
            this.cboStaffName.Size = new System.Drawing.Size(172, 21);
            this.cboStaffName.TabIndex = 0;
            // 
            // btnSelectStaff
            // 
            this.btnSelectStaff.Location = new System.Drawing.Point(303, 90);
            this.btnSelectStaff.Name = "btnSelectStaff";
            this.btnSelectStaff.Size = new System.Drawing.Size(128, 34);
            this.btnSelectStaff.TabIndex = 1;
            this.btnSelectStaff.Text = "Select Staff";
            this.btnSelectStaff.UseVisualStyleBackColor = true;
            this.btnSelectStaff.Click += new System.EventHandler(this.btnSelectStaff_Click);
            // 
            // grpChangeStaff
            // 
            this.grpChangeStaff.Controls.Add(this.btnChange);
            this.grpChangeStaff.Controls.Add(this.txtStaffName);
            this.grpChangeStaff.Controls.Add(this.lblStaffName);
            this.grpChangeStaff.Location = new System.Drawing.Point(37, 45);
            this.grpChangeStaff.Name = "grpChangeStaff";
            this.grpChangeStaff.Size = new System.Drawing.Size(482, 306);
            this.grpChangeStaff.TabIndex = 1;
            this.grpChangeStaff.TabStop = false;
            this.grpChangeStaff.Text = "Change Staff Details";
            this.grpChangeStaff.Visible = false;
            // 
            // lblStaffName
            // 
            this.lblStaffName.AutoSize = true;
            this.lblStaffName.Location = new System.Drawing.Point(11, 53);
            this.lblStaffName.Name = "lblStaffName";
            this.lblStaffName.Size = new System.Drawing.Size(60, 13);
            this.lblStaffName.TabIndex = 0;
            this.lblStaffName.Text = "Staff Name";
            // 
            // txtStaffName
            // 
            this.txtStaffName.Location = new System.Drawing.Point(77, 50);
            this.txtStaffName.Name = "txtStaffName";
            this.txtStaffName.Size = new System.Drawing.Size(104, 20);
            this.txtStaffName.TabIndex = 1;
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(41, 100);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(119, 26);
            this.btnChange.TabIndex = 2;
            this.btnChange.Text = "Change Details";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuEdit,
            this.mnuOrder,
            this.mnuBack,
            this.mnuAdmin});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuEdit
            // 
            this.mnuEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItmAddFoodType,
            this.mnuItmAddFoodItem,
            this.mnuItmChangeFoodItm});
            this.mnuEdit.Name = "mnuEdit";
            this.mnuEdit.Size = new System.Drawing.Size(39, 20);
            this.mnuEdit.Text = "Edit";
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
            this.mnuItmChangeStaffDetails,
            this.mnuItmRemoveStaff});
            this.mnuAdmin.Name = "mnuAdmin";
            this.mnuAdmin.Size = new System.Drawing.Size(55, 20);
            this.mnuAdmin.Text = "Admin";
            // 
            // mnuItmAddFoodType
            // 
            this.mnuItmAddFoodType.Name = "mnuItmAddFoodType";
            this.mnuItmAddFoodType.Size = new System.Drawing.Size(180, 22);
            this.mnuItmAddFoodType.Text = "Add Food Type";
            this.mnuItmAddFoodType.Click += new System.EventHandler(this.mnuItmAddFoodType_Click);
            // 
            // mnuItmAddFoodItem
            // 
            this.mnuItmAddFoodItem.Name = "mnuItmAddFoodItem";
            this.mnuItmAddFoodItem.Size = new System.Drawing.Size(180, 22);
            this.mnuItmAddFoodItem.Text = "Add Food Item";
            this.mnuItmAddFoodItem.Click += new System.EventHandler(this.mnuItmAddFoodItem_Click);
            // 
            // mnuItmChangeFoodItm
            // 
            this.mnuItmChangeFoodItm.Name = "mnuItmChangeFoodItm";
            this.mnuItmChangeFoodItm.Size = new System.Drawing.Size(180, 22);
            this.mnuItmChangeFoodItm.Text = "Change Food Item";
            this.mnuItmChangeFoodItm.Click += new System.EventHandler(this.mnuItmChangeFoodItm_Click);
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
            // mnuItmChangeStaffDetails
            // 
            this.mnuItmChangeStaffDetails.Name = "mnuItmChangeStaffDetails";
            this.mnuItmChangeStaffDetails.Size = new System.Drawing.Size(180, 22);
            this.mnuItmChangeStaffDetails.Text = "Modify Staff Details";
            // 
            // mnuItmRemoveStaff
            // 
            this.mnuItmRemoveStaff.Name = "mnuItmRemoveStaff";
            this.mnuItmRemoveStaff.Size = new System.Drawing.Size(180, 22);
            this.mnuItmRemoveStaff.Text = "Remove Staff";
            this.mnuItmRemoveStaff.Click += new System.EventHandler(this.mnuItmRemoveStaff_Click);
            // 
            // frmChangeStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpChangeStaff);
            this.Controls.Add(this.grpSelectStaff);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmChangeStaff";
            this.Text = "frmChangeStaff";
            this.grpSelectStaff.ResumeLayout(false);
            this.grpChangeStaff.ResumeLayout(false);
            this.grpChangeStaff.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpSelectStaff;
        private System.Windows.Forms.Button btnSelectStaff;
        private System.Windows.Forms.ComboBox cboStaffName;
        private System.Windows.Forms.GroupBox grpChangeStaff;
        private System.Windows.Forms.TextBox txtStaffName;
        private System.Windows.Forms.Label lblStaffName;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuEdit;
        private System.Windows.Forms.ToolStripMenuItem mnuItmAddFoodType;
        private System.Windows.Forms.ToolStripMenuItem mnuItmAddFoodItem;
        private System.Windows.Forms.ToolStripMenuItem mnuItmChangeFoodItm;
        private System.Windows.Forms.ToolStripMenuItem mnuOrder;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.ToolStripMenuItem mnuAdmin;
        private System.Windows.Forms.ToolStripMenuItem mnuItmRevenueAnalysis;
        private System.Windows.Forms.ToolStripMenuItem mnuItmFoodAnalysis;
        private System.Windows.Forms.ToolStripMenuItem mnuItmAddStaff;
        private System.Windows.Forms.ToolStripMenuItem mnuItmChangeStaffDetails;
        private System.Windows.Forms.ToolStripMenuItem mnuItmRemoveStaff;
    }
}