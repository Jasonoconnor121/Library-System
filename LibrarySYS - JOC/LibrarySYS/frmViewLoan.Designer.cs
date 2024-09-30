namespace LibrarySYS
{
    partial class frmViewLoan
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
            this.returnToSearchCatalogueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnViewLoan = new System.Windows.Forms.Button();
            this.txtConfirm = new System.Windows.Forms.TextBox();
            this.lblConfirm = new System.Windows.Forms.Label();
            this.dgvLoanView = new System.Windows.Forms.DataGridView();
            this.mnuAllMainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoanView)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuAllMainMenu
            // 
            this.mnuAllMainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuAllMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.returnToMainMenuToolStripMenuItem,
            this.returnToSearchCatalogueToolStripMenuItem});
            this.mnuAllMainMenu.Location = new System.Drawing.Point(0, 0);
            this.mnuAllMainMenu.Name = "mnuAllMainMenu";
            this.mnuAllMainMenu.Size = new System.Drawing.Size(862, 28);
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
            // returnToSearchCatalogueToolStripMenuItem
            // 
            this.returnToSearchCatalogueToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.returnToSearchCatalogueToolStripMenuItem.Name = "returnToSearchCatalogueToolStripMenuItem";
            this.returnToSearchCatalogueToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.returnToSearchCatalogueToolStripMenuItem.Text = "Go to Search Catalogue";
            this.returnToSearchCatalogueToolStripMenuItem.Click += new System.EventHandler(this.returnToSearchCatalogueToolStripMenuItem_Click);
            // 
            // btnViewLoan
            // 
            this.btnViewLoan.BackColor = System.Drawing.Color.SpringGreen;
            this.btnViewLoan.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnViewLoan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnViewLoan.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewLoan.Location = new System.Drawing.Point(12, 129);
            this.btnViewLoan.Name = "btnViewLoan";
            this.btnViewLoan.Size = new System.Drawing.Size(188, 53);
            this.btnViewLoan.TabIndex = 40;
            this.btnViewLoan.Text = "View Loans\r\n";
            this.btnViewLoan.UseVisualStyleBackColor = false;
            this.btnViewLoan.Click += new System.EventHandler(this.btnViewLoan_Click);
            // 
            // txtConfirm
            // 
            this.txtConfirm.Location = new System.Drawing.Point(12, 83);
            this.txtConfirm.MaxLength = 5;
            this.txtConfirm.Name = "txtConfirm";
            this.txtConfirm.Size = new System.Drawing.Size(186, 22);
            this.txtConfirm.TabIndex = 41;
            // 
            // lblConfirm
            // 
            this.lblConfirm.AutoSize = true;
            this.lblConfirm.Location = new System.Drawing.Point(9, 50);
            this.lblConfirm.Name = "lblConfirm";
            this.lblConfirm.Size = new System.Drawing.Size(189, 16);
            this.lblConfirm.TabIndex = 42;
            this.lblConfirm.Text = "Enter member id to view Loans\r\n";
            // 
            // dgvLoanView
            // 
            this.dgvLoanView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoanView.Location = new System.Drawing.Point(12, 224);
            this.dgvLoanView.Name = "dgvLoanView";
            this.dgvLoanView.RowHeadersWidth = 51;
            this.dgvLoanView.RowTemplate.Height = 24;
            this.dgvLoanView.Size = new System.Drawing.Size(630, 150);
            this.dgvLoanView.TabIndex = 53;
            this.dgvLoanView.Visible = false;
            // 
            // frmViewLoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 450);
            this.Controls.Add(this.dgvLoanView);
            this.Controls.Add(this.lblConfirm);
            this.Controls.Add(this.txtConfirm);
            this.Controls.Add(this.btnViewLoan);
            this.Controls.Add(this.mnuAllMainMenu);
            this.Name = "frmViewLoan";
            this.Text = "Record Loan";
            this.Load += new System.EventHandler(this.frmViewLoan_Load);
            this.mnuAllMainMenu.ResumeLayout(false);
            this.mnuAllMainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoanView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuAllMainMenu;
        private System.Windows.Forms.ToolStripMenuItem returnToMainMenuToolStripMenuItem;
        private System.Windows.Forms.Button btnViewLoan;
        private System.Windows.Forms.ToolStripMenuItem returnToSearchCatalogueToolStripMenuItem;
        private System.Windows.Forms.TextBox txtConfirm;
        private System.Windows.Forms.Label lblConfirm;
        private System.Windows.Forms.DataGridView dgvLoanView;
    }
}