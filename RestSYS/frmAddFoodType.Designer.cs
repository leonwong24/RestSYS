namespace RestSYS
{
    partial class frmAddFoodType
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
            this.txtFoodType = new System.Windows.Forms.TextBox();
            this.txtFdTypeDesc = new System.Windows.Forms.TextBox();
            this.lblFoodType = new System.Windows.Forms.Label();
            this.lblFdTypeDesc = new System.Windows.Forms.Label();
            this.btnFdTypeSubmit = new System.Windows.Forms.Button();
            this.lblFdTypeTitle = new System.Windows.Forms.Label();
            this.mnuFoodType = new System.Windows.Forms.MenuStrip();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addFoodTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addFoodItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeFoodItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFoodType.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFoodType
            // 
            this.txtFoodType.Location = new System.Drawing.Point(110, 108);
            this.txtFoodType.MaxLength = 1;
            this.txtFoodType.Name = "txtFoodType";
            this.txtFoodType.Size = new System.Drawing.Size(45, 20);
            this.txtFoodType.TabIndex = 0;
            // 
            // txtFdTypeDesc
            // 
            this.txtFdTypeDesc.Location = new System.Drawing.Point(110, 152);
            this.txtFdTypeDesc.MaxLength = 20;
            this.txtFdTypeDesc.Name = "txtFdTypeDesc";
            this.txtFdTypeDesc.Size = new System.Drawing.Size(158, 20);
            this.txtFdTypeDesc.TabIndex = 1;
            // 
            // lblFoodType
            // 
            this.lblFoodType.AutoSize = true;
            this.lblFoodType.Location = new System.Drawing.Point(23, 111);
            this.lblFoodType.Name = "lblFoodType";
            this.lblFoodType.Size = new System.Drawing.Size(64, 13);
            this.lblFoodType.TabIndex = 2;
            this.lblFoodType.Text = "Food Type: ";
            // 
            // lblFdTypeDesc
            // 
            this.lblFdTypeDesc.AutoSize = true;
            this.lblFdTypeDesc.Location = new System.Drawing.Point(23, 155);
            this.lblFdTypeDesc.Name = "lblFdTypeDesc";
            this.lblFdTypeDesc.Size = new System.Drawing.Size(66, 13);
            this.lblFdTypeDesc.TabIndex = 3;
            this.lblFdTypeDesc.Text = "Description: ";
            // 
            // btnFdTypeSubmit
            // 
            this.btnFdTypeSubmit.Location = new System.Drawing.Point(30, 226);
            this.btnFdTypeSubmit.Name = "btnFdTypeSubmit";
            this.btnFdTypeSubmit.Size = new System.Drawing.Size(215, 32);
            this.btnFdTypeSubmit.TabIndex = 4;
            this.btnFdTypeSubmit.Text = "Submit";
            this.btnFdTypeSubmit.UseVisualStyleBackColor = true;
            this.btnFdTypeSubmit.Click += new System.EventHandler(this.btnFdTypeSubmit_Click);
            // 
            // lblFdTypeTitle
            // 
            this.lblFdTypeTitle.AutoSize = true;
            this.lblFdTypeTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFdTypeTitle.Location = new System.Drawing.Point(183, 35);
            this.lblFdTypeTitle.Name = "lblFdTypeTitle";
            this.lblFdTypeTitle.Size = new System.Drawing.Size(237, 37);
            this.lblFdTypeTitle.TabIndex = 5;
            this.lblFdTypeTitle.Text = "Add Food Type";
            // 
            // mnuFoodType
            // 
            this.mnuFoodType.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.orderToolStripMenuItem});
            this.mnuFoodType.Location = new System.Drawing.Point(0, 0);
            this.mnuFoodType.Name = "mnuFoodType";
            this.mnuFoodType.Size = new System.Drawing.Size(567, 24);
            this.mnuFoodType.TabIndex = 6;
            this.mnuFoodType.Text = "menuAddFoodType";
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
            // frmAddFoodType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 474);
            this.Controls.Add(this.lblFdTypeTitle);
            this.Controls.Add(this.btnFdTypeSubmit);
            this.Controls.Add(this.lblFdTypeDesc);
            this.Controls.Add(this.lblFoodType);
            this.Controls.Add(this.txtFdTypeDesc);
            this.Controls.Add(this.txtFoodType);
            this.Controls.Add(this.mnuFoodType);
            this.MainMenuStrip = this.mnuFoodType;
            this.Name = "frmAddFoodType";
            this.Text = "RestSys - Add Food Type";
            this.mnuFoodType.ResumeLayout(false);
            this.mnuFoodType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFoodType;
        private System.Windows.Forms.TextBox txtFdTypeDesc;
        private System.Windows.Forms.Label lblFoodType;
        private System.Windows.Forms.Label lblFdTypeDesc;
        private System.Windows.Forms.Button btnFdTypeSubmit;
        private System.Windows.Forms.Label lblFdTypeTitle;
        private System.Windows.Forms.MenuStrip mnuFoodType;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addFoodTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addFoodItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeFoodItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderToolStripMenuItem;
    }
}

