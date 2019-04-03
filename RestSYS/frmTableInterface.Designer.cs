namespace RestSYS
{
    partial class frmTableInterface
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
            this.btnTable1 = new System.Windows.Forms.Button();
            this.btnTable2 = new System.Windows.Forms.Button();
            this.btnTable3 = new System.Windows.Forms.Button();
            this.btnTable4 = new System.Windows.Forms.Button();
            this.btnTable5 = new System.Windows.Forms.Button();
            this.btnTable6 = new System.Windows.Forms.Button();
            this.lblCashRegister = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnTable1
            // 
            this.btnTable1.Location = new System.Drawing.Point(87, 356);
            this.btnTable1.Name = "btnTable1";
            this.btnTable1.Size = new System.Drawing.Size(112, 68);
            this.btnTable1.TabIndex = 0;
            this.btnTable1.Text = "Table 1";
            this.btnTable1.UseVisualStyleBackColor = true;
            this.btnTable1.Click += new System.EventHandler(this.btnTable1_Click);
            // 
            // btnTable2
            // 
            this.btnTable2.Location = new System.Drawing.Point(87, 245);
            this.btnTable2.Name = "btnTable2";
            this.btnTable2.Size = new System.Drawing.Size(112, 68);
            this.btnTable2.TabIndex = 1;
            this.btnTable2.Text = "Table 2";
            this.btnTable2.UseVisualStyleBackColor = true;
            this.btnTable2.Click += new System.EventHandler(this.btnTable2_Click);
            // 
            // btnTable3
            // 
            this.btnTable3.Location = new System.Drawing.Point(87, 133);
            this.btnTable3.Name = "btnTable3";
            this.btnTable3.Size = new System.Drawing.Size(112, 68);
            this.btnTable3.TabIndex = 2;
            this.btnTable3.Text = "Table 3";
            this.btnTable3.UseVisualStyleBackColor = true;
            this.btnTable3.Click += new System.EventHandler(this.btnTable3_Click);
            // 
            // btnTable4
            // 
            this.btnTable4.Location = new System.Drawing.Point(87, 30);
            this.btnTable4.Name = "btnTable4";
            this.btnTable4.Size = new System.Drawing.Size(112, 68);
            this.btnTable4.TabIndex = 3;
            this.btnTable4.Text = "Table 4";
            this.btnTable4.UseVisualStyleBackColor = true;
            this.btnTable4.Click += new System.EventHandler(this.btnTable4_Click);
            // 
            // btnTable5
            // 
            this.btnTable5.Location = new System.Drawing.Point(321, 30);
            this.btnTable5.Name = "btnTable5";
            this.btnTable5.Size = new System.Drawing.Size(112, 68);
            this.btnTable5.TabIndex = 4;
            this.btnTable5.Text = "Table 5";
            this.btnTable5.UseVisualStyleBackColor = true;
            this.btnTable5.Click += new System.EventHandler(this.btnTable5_Click);
            // 
            // btnTable6
            // 
            this.btnTable6.Location = new System.Drawing.Point(574, 30);
            this.btnTable6.Name = "btnTable6";
            this.btnTable6.Size = new System.Drawing.Size(112, 68);
            this.btnTable6.TabIndex = 5;
            this.btnTable6.Text = "Table 6";
            this.btnTable6.UseVisualStyleBackColor = true;
            this.btnTable6.Click += new System.EventHandler(this.btnTable6_Click);
            // 
            // lblCashRegister
            // 
            this.lblCashRegister.AutoSize = true;
            this.lblCashRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCashRegister.Location = new System.Drawing.Point(351, 296);
            this.lblCashRegister.Name = "lblCashRegister";
            this.lblCashRegister.Padding = new System.Windows.Forms.Padding(40);
            this.lblCashRegister.Size = new System.Drawing.Size(302, 113);
            this.lblCashRegister.TabIndex = 6;
            this.lblCashRegister.Text = "Cash Register ";
            // 
            // frmTableInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblCashRegister);
            this.Controls.Add(this.btnTable6);
            this.Controls.Add(this.btnTable5);
            this.Controls.Add(this.btnTable4);
            this.Controls.Add(this.btnTable3);
            this.Controls.Add(this.btnTable2);
            this.Controls.Add(this.btnTable1);
            this.Name = "frmTableInterface";
            this.Text = "Table";
            this.Load += new System.EventHandler(this.frmTableInterface_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTable1;
        private System.Windows.Forms.Button btnTable2;
        private System.Windows.Forms.Button btnTable3;
        private System.Windows.Forms.Button btnTable4;
        private System.Windows.Forms.Button btnTable5;
        private System.Windows.Forms.Button btnTable6;
        private System.Windows.Forms.Label lblCashRegister;
    }
}