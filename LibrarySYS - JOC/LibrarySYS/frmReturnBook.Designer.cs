namespace LibrarySYS
{
    partial class frmReturnBook
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
            this.mnuAllMainMenu = new System.Windows.Forms.MenuStrip();
            this.returnToMainMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPayFee = new System.Windows.Forms.Button();
            this.dgvLoanView = new System.Windows.Forms.DataGridView();
            this.lblMemid = new System.Windows.Forms.Label();
            this.txtMemid = new System.Windows.Forms.TextBox();
            this.btnViewLoan = new System.Windows.Forms.Button();
            this.mnuAllMainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoanView)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuAllMainMenu
            // 
            this.mnuAllMainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuAllMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.returnToMainMenuToolStripMenuItem});
            this.mnuAllMainMenu.Location = new System.Drawing.Point(0, 0);
            this.mnuAllMainMenu.Name = "mnuAllMainMenu";
            this.mnuAllMainMenu.Size = new System.Drawing.Size(800, 28);
            this.mnuAllMainMenu.TabIndex = 35;
            this.mnuAllMainMenu.Text = "menuStrip1";
            // 
            // returnToMainMenuToolStripMenuItem
            // 
            this.returnToMainMenuToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.returnToMainMenuToolStripMenuItem.Name = "returnToMainMenuToolStripMenuItem";
            this.returnToMainMenuToolStripMenuItem.Size = new System.Drawing.Size(162, 24);
            this.returnToMainMenuToolStripMenuItem.Text = "Return to Main Menu";
            this.returnToMainMenuToolStripMenuItem.Click += new System.EventHandler(this.returnToMainMenuToolStripMenuItem_Click);
            // 
            // btnPayFee
            // 
            this.btnPayFee.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPayFee.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnPayFee.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPayFee.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayFee.Location = new System.Drawing.Point(617, 96);
            this.btnPayFee.Name = "btnPayFee";
            this.btnPayFee.Size = new System.Drawing.Size(159, 70);
            this.btnPayFee.TabIndex = 55;
            this.btnPayFee.Text = "Pay Fee";
            this.btnPayFee.UseVisualStyleBackColor = false;
            this.btnPayFee.Visible = false;
            this.btnPayFee.Click += new System.EventHandler(this.btnPayFee_Click);
            // 
            // dgvLoanView
            // 
            this.dgvLoanView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoanView.Location = new System.Drawing.Point(12, 208);
            this.dgvLoanView.Name = "dgvLoanView";
            this.dgvLoanView.RowHeadersWidth = 51;
            this.dgvLoanView.RowTemplate.Height = 24;
            this.dgvLoanView.Size = new System.Drawing.Size(686, 150);
            this.dgvLoanView.TabIndex = 59;
            this.dgvLoanView.Visible = false;
            this.dgvLoanView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLoanView_CellClick);
            // 
            // lblMemid
            // 
            this.lblMemid.AutoSize = true;
            this.lblMemid.Location = new System.Drawing.Point(9, 34);
            this.lblMemid.Name = "lblMemid";
            this.lblMemid.Size = new System.Drawing.Size(207, 16);
            this.lblMemid.TabIndex = 58;
            this.lblMemid.Text = "Enter member id to retrieve Loans\r\n";
            // 
            // txtMemid
            // 
            this.txtMemid.Location = new System.Drawing.Point(12, 67);
            this.txtMemid.MaxLength = 5;
            this.txtMemid.Name = "txtMemid";
            this.txtMemid.Size = new System.Drawing.Size(186, 22);
            this.txtMemid.TabIndex = 57;
            // 
            // btnViewLoan
            // 
            this.btnViewLoan.BackColor = System.Drawing.Color.MediumPurple;
            this.btnViewLoan.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnViewLoan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnViewLoan.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewLoan.Location = new System.Drawing.Point(12, 113);
            this.btnViewLoan.Name = "btnViewLoan";
            this.btnViewLoan.Size = new System.Drawing.Size(188, 53);
            this.btnViewLoan.TabIndex = 56;
            this.btnViewLoan.Text = "Retrieve Loans\r\n";
            this.btnViewLoan.UseVisualStyleBackColor = false;
            this.btnViewLoan.Click += new System.EventHandler(this.btnViewLoan_Click);
            // 
            // frmReturnBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvLoanView);
            this.Controls.Add(this.lblMemid);
            this.Controls.Add(this.txtMemid);
            this.Controls.Add(this.btnViewLoan);
            this.Controls.Add(this.btnPayFee);
            this.Controls.Add(this.mnuAllMainMenu);
            this.Name = "frmReturnBook";
            this.Text = "Return Book";
            this.mnuAllMainMenu.ResumeLayout(false);
            this.mnuAllMainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoanView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuAllMainMenu;
        private System.Windows.Forms.ToolStripMenuItem returnToMainMenuToolStripMenuItem;
        private System.Windows.Forms.Button btnPayFee;
        private System.Windows.Forms.DataGridView dgvLoanView;
        private System.Windows.Forms.Label lblMemid;
        private System.Windows.Forms.TextBox txtMemid;
        private System.Windows.Forms.Button btnViewLoan;
    }
}