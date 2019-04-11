namespace RestSYS
{
    partial class frmRevenueAnalysis
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
            this.components = new System.ComponentModel.Container();
            this.mnuRevenueAnalysis = new System.Windows.Forms.MenuStrip();
            this.mnuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItmAddFoodType = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItmAddFoodItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItmChangeFoodItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBck = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItmRevenueAnalysis = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemFoodAnalysis = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItmAddStaff = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItmModifyStaff = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItmRemoveStaff = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.grpFilter = new System.Windows.Forms.GroupBox();
            this.cboMonth = new System.Windows.Forms.ComboBox();
            this.cboYear = new System.Windows.Forms.ComboBox();
            this.grdRevnAnalys = new System.Windows.Forms.DataGridView();
            this.btnPrint = new System.Windows.Forms.Button();
            this.Year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Month = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Week = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Day = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cboWeek = new System.Windows.Forms.ComboBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.mnuRevenueAnalysis.SuspendLayout();
            this.grpFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdRevnAnalys)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuRevenueAnalysis
            // 
            this.mnuRevenueAnalysis.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuEdit,
            this.mnuOrder,
            this.mnuBck,
            this.mnuAdmin});
            this.mnuRevenueAnalysis.Location = new System.Drawing.Point(0, 0);
            this.mnuRevenueAnalysis.Name = "mnuRevenueAnalysis";
            this.mnuRevenueAnalysis.Size = new System.Drawing.Size(800, 24);
            this.mnuRevenueAnalysis.TabIndex = 0;
            this.mnuRevenueAnalysis.Text = "menuStrip1";
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
            this.mnuItmAddFoodType.Click += new System.EventHandler(this.addFoodTypeToolStripMenuItem_Click);
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
            // mnuBck
            // 
            this.mnuBck.Name = "mnuBck";
            this.mnuBck.Size = new System.Drawing.Size(44, 20);
            this.mnuBck.Text = "Back";
            this.mnuBck.Click += new System.EventHandler(this.mnuBck_Click);
            // 
            // mnuAdmin
            // 
            this.mnuAdmin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItmRevenueAnalysis,
            this.mnuItemFoodAnalysis,
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
            this.mnuItmRevenueAnalysis.Size = new System.Drawing.Size(165, 22);
            this.mnuItmRevenueAnalysis.Text = "Revenue Analysis";
            // 
            // mnuItemFoodAnalysis
            // 
            this.mnuItemFoodAnalysis.Name = "mnuItemFoodAnalysis";
            this.mnuItemFoodAnalysis.Size = new System.Drawing.Size(165, 22);
            this.mnuItemFoodAnalysis.Text = "Food Analysis";
            this.mnuItemFoodAnalysis.Click += new System.EventHandler(this.foodAnalysisToolStripMenuItem_Click);
            // 
            // mnuItmAddStaff
            // 
            this.mnuItmAddStaff.Name = "mnuItmAddStaff";
            this.mnuItmAddStaff.Size = new System.Drawing.Size(165, 22);
            this.mnuItmAddStaff.Text = "Add Staff";
            this.mnuItmAddStaff.Click += new System.EventHandler(this.mnuItmAddStaff_Click);
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
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // grpFilter
            // 
            this.grpFilter.Controls.Add(this.cboWeek);
            this.grpFilter.Controls.Add(this.cboMonth);
            this.grpFilter.Controls.Add(this.cboYear);
            this.grpFilter.Location = new System.Drawing.Point(12, 38);
            this.grpFilter.Name = "grpFilter";
            this.grpFilter.Size = new System.Drawing.Size(381, 69);
            this.grpFilter.TabIndex = 2;
            this.grpFilter.TabStop = false;
            this.grpFilter.Text = "Filter Option";
            // 
            // cboMonth
            // 
            this.cboMonth.FormattingEnabled = true;
            this.cboMonth.Location = new System.Drawing.Point(108, 33);
            this.cboMonth.Name = "cboMonth";
            this.cboMonth.Size = new System.Drawing.Size(99, 21);
            this.cboMonth.TabIndex = 1;
            this.cboMonth.Text = "Month";
            this.cboMonth.SelectedIndexChanged += new System.EventHandler(this.cboMonth_SelectedIndexChanged);
            // 
            // cboYear
            // 
            this.cboYear.FormattingEnabled = true;
            this.cboYear.Location = new System.Drawing.Point(12, 33);
            this.cboYear.Name = "cboYear";
            this.cboYear.Size = new System.Drawing.Size(76, 21);
            this.cboYear.TabIndex = 0;
            this.cboYear.Text = "Year";
            this.cboYear.SelectedIndexChanged += new System.EventHandler(this.cboYear_SelectedIndexChanged);
            // 
            // grdRevnAnalys
            // 
            this.grdRevnAnalys.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdRevnAnalys.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Year,
            this.Month,
            this.Week,
            this.Day,
            this.Cost});
            this.grdRevnAnalys.Location = new System.Drawing.Point(18, 124);
            this.grdRevnAnalys.Name = "grdRevnAnalys";
            this.grdRevnAnalys.RowHeadersWidth = 30;
            this.grdRevnAnalys.Size = new System.Drawing.Size(661, 314);
            this.grdRevnAnalys.TabIndex = 3;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(688, 379);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(100, 59);
            this.btnPrint.TabIndex = 4;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
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
            // Week
            // 
            this.Week.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Week.HeaderText = "Week";
            this.Week.Name = "Week";
            // 
            // Day
            // 
            this.Day.HeaderText = "Day";
            this.Day.Name = "Day";
            // 
            // Cost
            // 
            this.Cost.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Cost.HeaderText = "Cost";
            this.Cost.Name = "Cost";
            // 
            // cboWeek
            // 
            this.cboWeek.FormattingEnabled = true;
            this.cboWeek.Location = new System.Drawing.Point(226, 33);
            this.cboWeek.Name = "cboWeek";
            this.cboWeek.Size = new System.Drawing.Size(92, 21);
            this.cboWeek.TabIndex = 2;
            this.cboWeek.Text = "Week";
            this.cboWeek.SelectedIndexChanged += new System.EventHandler(this.cboWeek_SelectedIndexChanged);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(688, 313);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(100, 50);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // frmRevenueAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.grdRevnAnalys);
            this.Controls.Add(this.grpFilter);
            this.Controls.Add(this.mnuRevenueAnalysis);
            this.MainMenuStrip = this.mnuRevenueAnalysis;
            this.Name = "frmRevenueAnalysis";
            this.Text = "frmRevenueAnalysis";
            this.Load += new System.EventHandler(this.frmRevenueAnalysis_Load);
            this.mnuRevenueAnalysis.ResumeLayout(false);
            this.mnuRevenueAnalysis.PerformLayout();
            this.grpFilter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdRevnAnalys)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuRevenueAnalysis;
        private System.Windows.Forms.ToolStripMenuItem mnuEdit;
        private System.Windows.Forms.ToolStripMenuItem mnuItmAddFoodType;
        private System.Windows.Forms.ToolStripMenuItem mnuItmAddFoodItem;
        private System.Windows.Forms.ToolStripMenuItem mnuItmChangeFoodItem;
        private System.Windows.Forms.ToolStripMenuItem mnuOrder;
        private System.Windows.Forms.ToolStripMenuItem mnuBck;
        private System.Windows.Forms.ToolStripMenuItem mnuAdmin;
        private System.Windows.Forms.ToolStripMenuItem mnuItmRevenueAnalysis;
        private System.Windows.Forms.ToolStripMenuItem mnuItemFoodAnalysis;
        private System.Windows.Forms.ToolStripMenuItem mnuItmAddStaff;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.GroupBox grpFilter;
        private System.Windows.Forms.ComboBox cboMonth;
        private System.Windows.Forms.ComboBox cboYear;
        private System.Windows.Forms.DataGridView grdRevnAnalys;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.ToolStripMenuItem mnuItmModifyStaff;
        private System.Windows.Forms.ToolStripMenuItem mnuItmRemoveStaff;
        private System.Windows.Forms.DataGridViewTextBoxColumn Year;
        private System.Windows.Forms.DataGridViewTextBoxColumn Month;
        private System.Windows.Forms.DataGridViewTextBoxColumn Week;
        private System.Windows.Forms.DataGridViewTextBoxColumn Day;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cost;
        private System.Windows.Forms.ComboBox cboWeek;
        private System.Windows.Forms.Button btnReset;
    }
}