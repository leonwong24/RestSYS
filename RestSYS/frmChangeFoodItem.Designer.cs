namespace RestSYS
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
            this.txtChgFoodItemStatus = new System.Windows.Forms.TextBox();
            this.txtChgFoodItemPrice = new System.Windows.Forms.TextBox();
            this.txtChgFoodItemType = new System.Windows.Forms.TextBox();
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
            this.lblChangeFdItemTitle = new System.Windows.Forms.Label();
            this.mnuFoodItem.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnChgFoodItemSubmit
            // 
            this.btnChgFoodItemSubmit.Location = new System.Drawing.Point(46, 376);
            this.btnChgFoodItemSubmit.Name = "btnChgFoodItemSubmit";
            this.btnChgFoodItemSubmit.Size = new System.Drawing.Size(147, 32);
            this.btnChgFoodItemSubmit.TabIndex = 31;
            this.btnChgFoodItemSubmit.Text = "Submit";
            this.btnChgFoodItemSubmit.UseVisualStyleBackColor = true;
            this.btnChgFoodItemSubmit.Click += new System.EventHandler(this.btnChgFoodItemSubmit_Click);
            // 
            // txtChgFoodItemStatus
            // 
            this.txtChgFoodItemStatus.Location = new System.Drawing.Point(90, 318);
            this.txtChgFoodItemStatus.MaxLength = 1;
            this.txtChgFoodItemStatus.Name = "txtChgFoodItemStatus";
            this.txtChgFoodItemStatus.Size = new System.Drawing.Size(47, 20);
            this.txtChgFoodItemStatus.TabIndex = 30;
            // 
            // txtChgFoodItemPrice
            // 
            this.txtChgFoodItemPrice.Location = new System.Drawing.Point(90, 271);
            this.txtChgFoodItemPrice.MaxLength = 5;
            this.txtChgFoodItemPrice.Name = "txtChgFoodItemPrice";
            this.txtChgFoodItemPrice.Size = new System.Drawing.Size(146, 20);
            this.txtChgFoodItemPrice.TabIndex = 29;
            // 
            // txtChgFoodItemType
            // 
            this.txtChgFoodItemType.Location = new System.Drawing.Point(90, 235);
            this.txtChgFoodItemType.MaxLength = 1;
            this.txtChgFoodItemType.Name = "txtChgFoodItemType";
            this.txtChgFoodItemType.Size = new System.Drawing.Size(35, 20);
            this.txtChgFoodItemType.TabIndex = 28;
            // 
            // txtChangeFoodItemDesc
            // 
            this.txtChangeFoodItemDesc.Location = new System.Drawing.Point(90, 191);
            this.txtChangeFoodItemDesc.MaxLength = 100;
            this.txtChangeFoodItemDesc.Name = "txtChangeFoodItemDesc";
            this.txtChangeFoodItemDesc.Size = new System.Drawing.Size(387, 20);
            this.txtChangeFoodItemDesc.TabIndex = 27;
            // 
            // txtChangeFoodItem
            // 
            this.txtChangeFoodItem.Location = new System.Drawing.Point(90, 148);
            this.txtChangeFoodItem.MaxLength = 25;
            this.txtChangeFoodItem.Name = "txtChangeFoodItem";
            this.txtChangeFoodItem.Size = new System.Drawing.Size(258, 20);
            this.txtChangeFoodItem.TabIndex = 26;
            // 
            // lblFoodStatus
            // 
            this.lblFoodStatus.AutoSize = true;
            this.lblFoodStatus.Location = new System.Drawing.Point(18, 321);
            this.lblFoodStatus.Name = "lblFoodStatus";
            this.lblFoodStatus.Size = new System.Drawing.Size(43, 13);
            this.lblFoodStatus.TabIndex = 25;
            this.lblFoodStatus.Text = "Status: ";
            // 
            // lblFoodPrice
            // 
            this.lblFoodPrice.AutoSize = true;
            this.lblFoodPrice.Location = new System.Drawing.Point(18, 274);
            this.lblFoodPrice.Name = "lblFoodPrice";
            this.lblFoodPrice.Size = new System.Drawing.Size(37, 13);
            this.lblFoodPrice.TabIndex = 24;
            this.lblFoodPrice.Text = "Price: ";
            // 
            // lblFoodType
            // 
            this.lblFoodType.AutoSize = true;
            this.lblFoodType.Location = new System.Drawing.Point(18, 235);
            this.lblFoodType.Name = "lblFoodType";
            this.lblFoodType.Size = new System.Drawing.Size(58, 13);
            this.lblFoodType.TabIndex = 23;
            this.lblFoodType.Text = "Food Type";
            // 
            // lblFoodItemDesc
            // 
            this.lblFoodItemDesc.AutoSize = true;
            this.lblFoodItemDesc.Location = new System.Drawing.Point(18, 191);
            this.lblFoodItemDesc.Name = "lblFoodItemDesc";
            this.lblFoodItemDesc.Size = new System.Drawing.Size(66, 13);
            this.lblFoodItemDesc.TabIndex = 22;
            this.lblFoodItemDesc.Text = "Description: ";
            // 
            // lblFoodItem
            // 
            this.lblFoodItem.AutoSize = true;
            this.lblFoodItem.Location = new System.Drawing.Point(18, 149);
            this.lblFoodItem.Name = "lblFoodItem";
            this.lblFoodItem.Size = new System.Drawing.Size(57, 13);
            this.lblFoodItem.TabIndex = 21;
            this.lblFoodItem.Text = "Food Item:";
            // 
            // mnuFoodItem
            // 
            this.mnuFoodItem.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.orderToolStripMenuItem});
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
            this.addFoodTypeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addFoodTypeToolStripMenuItem.Text = "Add Food Type";
            // 
            // addFoodItemToolStripMenuItem
            // 
            this.addFoodItemToolStripMenuItem.Name = "addFoodItemToolStripMenuItem";
            this.addFoodItemToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addFoodItemToolStripMenuItem.Text = "Add Food Item";
            // 
            // changeFoodItemToolStripMenuItem
            // 
            this.changeFoodItemToolStripMenuItem.Name = "changeFoodItemToolStripMenuItem";
            this.changeFoodItemToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.changeFoodItemToolStripMenuItem.Text = "Change Food Item";
            // 
            // orderToolStripMenuItem
            // 
            this.orderToolStripMenuItem.Name = "orderToolStripMenuItem";
            this.orderToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.orderToolStripMenuItem.Text = "Order";
            // 
            // lblChangeFdItemTitle
            // 
            this.lblChangeFdItemTitle.AutoSize = true;
            this.lblChangeFdItemTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChangeFdItemTitle.Location = new System.Drawing.Point(249, 75);
            this.lblChangeFdItemTitle.Name = "lblChangeFdItemTitle";
            this.lblChangeFdItemTitle.Size = new System.Drawing.Size(282, 37);
            this.lblChangeFdItemTitle.TabIndex = 19;
            this.lblChangeFdItemTitle.Text = "Change Food Item";
            // 
            // frmChangeFoodItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnChgFoodItemSubmit);
            this.Controls.Add(this.txtChgFoodItemStatus);
            this.Controls.Add(this.txtChgFoodItemPrice);
            this.Controls.Add(this.txtChgFoodItemType);
            this.Controls.Add(this.txtChangeFoodItemDesc);
            this.Controls.Add(this.txtChangeFoodItem);
            this.Controls.Add(this.lblFoodStatus);
            this.Controls.Add(this.lblFoodPrice);
            this.Controls.Add(this.lblFoodType);
            this.Controls.Add(this.lblFoodItemDesc);
            this.Controls.Add(this.lblFoodItem);
            this.Controls.Add(this.mnuFoodItem);
            this.Controls.Add(this.lblChangeFdItemTitle);
            this.Name = "frmChangeFoodItem";
            this.Text = "frmChangeFoodItem";
            this.mnuFoodItem.ResumeLayout(false);
            this.mnuFoodItem.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChgFoodItemSubmit;
        private System.Windows.Forms.TextBox txtChgFoodItemStatus;
        private System.Windows.Forms.TextBox txtChgFoodItemPrice;
        private System.Windows.Forms.TextBox txtChgFoodItemType;
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
    }
}