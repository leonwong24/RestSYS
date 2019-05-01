namespace RestSYS
{
    partial class frmHomeInterface
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
            this.lblHomeInterfaceTitle = new System.Windows.Forms.Label();
            this.btnHomeToManager = new System.Windows.Forms.Button();
            this.btnHomeToOrder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHomeInterfaceTitle
            // 
            this.lblHomeInterfaceTitle.AutoSize = true;
            this.lblHomeInterfaceTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHomeInterfaceTitle.Location = new System.Drawing.Point(113, 21);
            this.lblHomeInterfaceTitle.Name = "lblHomeInterfaceTitle";
            this.lblHomeInterfaceTitle.Size = new System.Drawing.Size(595, 73);
            this.lblHomeInterfaceTitle.TabIndex = 0;
            this.lblHomeInterfaceTitle.Text = "Restaurant System";
            // 
            // btnHomeToManager
            // 
            this.btnHomeToManager.Location = new System.Drawing.Point(145, 203);
            this.btnHomeToManager.Name = "btnHomeToManager";
            this.btnHomeToManager.Size = new System.Drawing.Size(192, 83);
            this.btnHomeToManager.TabIndex = 1;
            this.btnHomeToManager.Text = "Manager";
            this.btnHomeToManager.UseVisualStyleBackColor = true;
            this.btnHomeToManager.Click += new System.EventHandler(this.btnHomeToManager_Click);
            // 
            // btnHomeToOrder
            // 
            this.btnHomeToOrder.Location = new System.Drawing.Point(483, 203);
            this.btnHomeToOrder.Name = "btnHomeToOrder";
            this.btnHomeToOrder.Size = new System.Drawing.Size(192, 83);
            this.btnHomeToOrder.TabIndex = 2;
            this.btnHomeToOrder.Text = "Order";
            this.btnHomeToOrder.UseVisualStyleBackColor = true;
            this.btnHomeToOrder.Click += new System.EventHandler(this.btnHomeToOrder_Click);
            // 
            // frmHomeInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnHomeToOrder);
            this.Controls.Add(this.btnHomeToManager);
            this.Controls.Add(this.lblHomeInterfaceTitle);
            this.Name = "frmHomeInterface";
            this.Text = "Restaurant System";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHomeInterfaceTitle;
        private System.Windows.Forms.Button btnHomeToManager;
        private System.Windows.Forms.Button btnHomeToOrder;
    }
}