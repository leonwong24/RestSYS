namespace RestSYS
{
    partial class frmAddFoodItem
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
            this.lblAddFdItemTitle = new System.Windows.Forms.Label();
            this.mnuFoodItem = new System.Windows.Forms.MenuStrip();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addFoodTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addFoodItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeFoodItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblFoodItem = new System.Windows.Forms.Label();
            this.lblFoodItemDesc = new System.Windows.Forms.Label();
            this.lblFoodType = new System.Windows.Forms.Label();
            this.lblFoodPrice = new System.Windows.Forms.Label();
            this.lblFoodStatus = new System.Windows.Forms.Label();
            this.txtAddFoodItem = new System.Windows.Forms.TextBox();
            this.txtAddFoodItemDesc = new System.Windows.Forms.TextBox();
            this.txtAddFoodItemPrice = new System.Windows.Forms.TextBox();
            this.btnAddFoodItemSubmit = new System.Windows.Forms.Button();
            this.cboAddFoodItemType = new System.Windows.Forms.ComboBox();
            this.cboAddFoodItemStatus = new System.Windows.Forms.ComboBox();
            this.mnuFoodItem.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAddFdItemTitle
            // 
            this.lblAddFdItemTitle.AutoSize = true;
            this.lblAddFdItemTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddFdItemTitle.Location = new System.Drawing.Point(249, 33);
            this.lblAddFdItemTitle.Name = "lblAddFdItemTitle";
            this.lblAddFdItemTitle.Size = new System.Drawing.Size(228, 37);
            this.lblAddFdItemTitle.TabIndex = 6;
            this.lblAddFdItemTitle.Text = "Add Food Item";
            // 
            // mnuFoodItem
            // 
            this.mnuFoodItem.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.orderToolStripMenuItem});
            this.mnuFoodItem.Location = new System.Drawing.Point(0, 0);
            this.mnuFoodItem.Name = "mnuFoodItem";
            this.mnuFoodItem.Size = new System.Drawing.Size(800, 24);
            this.mnuFoodItem.TabIndex = 7;
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
            // 
            // lblFoodItem
            // 
            this.lblFoodItem.AutoSize = true;
            this.lblFoodItem.Location = new System.Drawing.Point(18, 107);
            this.lblFoodItem.Name = "lblFoodItem";
            this.lblFoodItem.Size = new System.Drawing.Size(57, 13);
            this.lblFoodItem.TabIndex = 8;
            this.lblFoodItem.Text = "Food Item:";
            // 
            // lblFoodItemDesc
            // 
            this.lblFoodItemDesc.AutoSize = true;
            this.lblFoodItemDesc.Location = new System.Drawing.Point(18, 149);
            this.lblFoodItemDesc.Name = "lblFoodItemDesc";
            this.lblFoodItemDesc.Size = new System.Drawing.Size(66, 13);
            this.lblFoodItemDesc.TabIndex = 9;
            this.lblFoodItemDesc.Text = "Description: ";
            // 
            // lblFoodType
            // 
            this.lblFoodType.AutoSize = true;
            this.lblFoodType.Location = new System.Drawing.Point(18, 193);
            this.lblFoodType.Name = "lblFoodType";
            this.lblFoodType.Size = new System.Drawing.Size(58, 13);
            this.lblFoodType.TabIndex = 10;
            this.lblFoodType.Text = "Food Type";
            // 
            // lblFoodPrice
            // 
            this.lblFoodPrice.AutoSize = true;
            this.lblFoodPrice.Location = new System.Drawing.Point(18, 232);
            this.lblFoodPrice.Name = "lblFoodPrice";
            this.lblFoodPrice.Size = new System.Drawing.Size(37, 13);
            this.lblFoodPrice.TabIndex = 11;
            this.lblFoodPrice.Text = "Price: ";
            // 
            // lblFoodStatus
            // 
            this.lblFoodStatus.AutoSize = true;
            this.lblFoodStatus.Location = new System.Drawing.Point(18, 279);
            this.lblFoodStatus.Name = "lblFoodStatus";
            this.lblFoodStatus.Size = new System.Drawing.Size(43, 13);
            this.lblFoodStatus.TabIndex = 12;
            this.lblFoodStatus.Text = "Status: ";
            // 
            // txtAddFoodItem
            // 
            this.txtAddFoodItem.Location = new System.Drawing.Point(90, 106);
            this.txtAddFoodItem.MaxLength = 25;
            this.txtAddFoodItem.Name = "txtAddFoodItem";
            this.txtAddFoodItem.Size = new System.Drawing.Size(258, 20);
            this.txtAddFoodItem.TabIndex = 13;
            // 
            // txtAddFoodItemDesc
            // 
            this.txtAddFoodItemDesc.Location = new System.Drawing.Point(90, 149);
            this.txtAddFoodItemDesc.MaxLength = 100;
            this.txtAddFoodItemDesc.Name = "txtAddFoodItemDesc";
            this.txtAddFoodItemDesc.Size = new System.Drawing.Size(387, 20);
            this.txtAddFoodItemDesc.TabIndex = 14;
            // 
            // txtAddFoodItemPrice
            // 
            this.txtAddFoodItemPrice.Location = new System.Drawing.Point(90, 229);
            this.txtAddFoodItemPrice.MaxLength = 5;
            this.txtAddFoodItemPrice.Name = "txtAddFoodItemPrice";
            this.txtAddFoodItemPrice.Size = new System.Drawing.Size(146, 20);
            this.txtAddFoodItemPrice.TabIndex = 16;
            // 
            // btnAddFoodItemSubmit
            // 
            this.btnAddFoodItemSubmit.Location = new System.Drawing.Point(46, 334);
            this.btnAddFoodItemSubmit.Name = "btnAddFoodItemSubmit";
            this.btnAddFoodItemSubmit.Size = new System.Drawing.Size(147, 32);
            this.btnAddFoodItemSubmit.TabIndex = 18;
            this.btnAddFoodItemSubmit.Text = "Submit";
            this.btnAddFoodItemSubmit.UseVisualStyleBackColor = true;
            this.btnAddFoodItemSubmit.Click += new System.EventHandler(this.btnAddFoodItemSubmit_Click);
            // 
            // cboAddFoodItemType
            // 
            this.cboAddFoodItemType.FormattingEnabled = true;
            this.cboAddFoodItemType.Items.AddRange(new object[] {
            "M : Main",
            "S : Starter",
            "D : Dessert",
            "B : Beverage"});
            this.cboAddFoodItemType.Location = new System.Drawing.Point(90, 190);
            this.cboAddFoodItemType.Name = "cboAddFoodItemType";
            this.cboAddFoodItemType.Size = new System.Drawing.Size(128, 21);
            this.cboAddFoodItemType.TabIndex = 19;
            // 
            // cboAddFoodItemStatus
            // 
            this.cboAddFoodItemStatus.FormattingEnabled = true;
            this.cboAddFoodItemStatus.Items.AddRange(new object[] {
            "A : Available",
            "U : Unavailable"});
            this.cboAddFoodItemStatus.Location = new System.Drawing.Point(90, 276);
            this.cboAddFoodItemStatus.Name = "cboAddFoodItemStatus";
            this.cboAddFoodItemStatus.Size = new System.Drawing.Size(109, 21);
            this.cboAddFoodItemStatus.TabIndex = 20;
            // 
            // frmAddFoodItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cboAddFoodItemStatus);
            this.Controls.Add(this.cboAddFoodItemType);
            this.Controls.Add(this.btnAddFoodItemSubmit);
            this.Controls.Add(this.txtAddFoodItemPrice);
            this.Controls.Add(this.txtAddFoodItemDesc);
            this.Controls.Add(this.txtAddFoodItem);
            this.Controls.Add(this.lblFoodStatus);
            this.Controls.Add(this.lblFoodPrice);
            this.Controls.Add(this.lblFoodType);
            this.Controls.Add(this.lblFoodItemDesc);
            this.Controls.Add(this.lblFoodItem);
            this.Controls.Add(this.mnuFoodItem);
            this.Controls.Add(this.lblAddFdItemTitle);
            this.Name = "frmAddFoodItem";
            this.Text = "           ";
            this.mnuFoodItem.ResumeLayout(false);
            this.mnuFoodItem.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddFdItemTitle;
        private System.Windows.Forms.MenuStrip mnuFoodItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addFoodTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addFoodItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeFoodItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderToolStripMenuItem;
        private System.Windows.Forms.Label lblFoodItem;
        private System.Windows.Forms.Label lblFoodItemDesc;
        private System.Windows.Forms.Label lblFoodType;
        private System.Windows.Forms.Label lblFoodPrice;
        private System.Windows.Forms.Label lblFoodStatus;
        private System.Windows.Forms.TextBox txtAddFoodItem;
        private System.Windows.Forms.TextBox txtAddFoodItemDesc;
        private System.Windows.Forms.TextBox txtAddFoodItemPrice;
        private System.Windows.Forms.Button btnAddFoodItemSubmit;
        private System.Windows.Forms.ComboBox cboAddFoodItemType;
        private System.Windows.Forms.ComboBox cboAddFoodItemStatus;
    }
}