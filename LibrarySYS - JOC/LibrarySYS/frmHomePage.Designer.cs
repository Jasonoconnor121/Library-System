namespace LibrarySYS
{
    partial class frmHomePage
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
            this.mnuHomeMainMenu = new System.Windows.Forms.MenuStrip();
            this.membersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRegMem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUpdMem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPayFee = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRemMem = new System.Windows.Forms.ToolStripMenuItem();
            this.booksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCatBook = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSearchCat = new System.Windows.Forms.ToolStripMenuItem();
            this.loansToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuViewLoan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRetBook = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRevBookLoan = new System.Windows.Forms.ToolStripMenuItem();
            this.picHomeArt = new System.Windows.Forms.PictureBox();
            this.viewMemberDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHomeMainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHomeArt)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuHomeMainMenu
            // 
            this.mnuHomeMainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuHomeMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.membersToolStripMenuItem,
            this.booksToolStripMenuItem,
            this.loansToolStripMenuItem,
            this.adminToolStripMenuItem});
            this.mnuHomeMainMenu.Location = new System.Drawing.Point(0, 0);
            this.mnuHomeMainMenu.Name = "mnuHomeMainMenu";
            this.mnuHomeMainMenu.Size = new System.Drawing.Size(1174, 28);
            this.mnuHomeMainMenu.TabIndex = 0;
            this.mnuHomeMainMenu.Text = "menuStrip1";
            // 
            // membersToolStripMenuItem
            // 
            this.membersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuRegMem,
            this.viewMemberDetailsToolStripMenuItem,
            this.mnuUpdMem,
            this.mnuPayFee,
            this.mnuRemMem});
            this.membersToolStripMenuItem.Name = "membersToolStripMenuItem";
            this.membersToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.membersToolStripMenuItem.Text = "Members";
            // 
            // mnuRegMem
            // 
            this.mnuRegMem.Name = "mnuRegMem";
            this.mnuRegMem.Size = new System.Drawing.Size(234, 26);
            this.mnuRegMem.Text = "Register Member";
            this.mnuRegMem.Click += new System.EventHandler(this.mnuRegMem_Click);
            // 
            // mnuUpdMem
            // 
            this.mnuUpdMem.Name = "mnuUpdMem";
            this.mnuUpdMem.Size = new System.Drawing.Size(234, 26);
            this.mnuUpdMem.Text = "Update Member";
            this.mnuUpdMem.Click += new System.EventHandler(this.mnuUpdMem_Click);
            // 
            // mnuPayFee
            // 
            this.mnuPayFee.Name = "mnuPayFee";
            this.mnuPayFee.Size = new System.Drawing.Size(234, 26);
            this.mnuPayFee.Text = "Pay Fee";
            this.mnuPayFee.Click += new System.EventHandler(this.mnuPayFee_Click);
            // 
            // mnuRemMem
            // 
            this.mnuRemMem.Name = "mnuRemMem";
            this.mnuRemMem.Size = new System.Drawing.Size(234, 26);
            this.mnuRemMem.Text = "Remove Member";
            this.mnuRemMem.Click += new System.EventHandler(this.mnuRemMem_Click);
            // 
            // booksToolStripMenuItem
            // 
            this.booksToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCatBook,
            this.mnuSearchCat});
            this.booksToolStripMenuItem.Name = "booksToolStripMenuItem";
            this.booksToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.booksToolStripMenuItem.Text = "Books";
            // 
            // mnuCatBook
            // 
            this.mnuCatBook.Name = "mnuCatBook";
            this.mnuCatBook.Size = new System.Drawing.Size(208, 26);
            this.mnuCatBook.Text = "Catalogue Book";
            this.mnuCatBook.Click += new System.EventHandler(this.mnuCatBook_Click);
            // 
            // mnuSearchCat
            // 
            this.mnuSearchCat.Name = "mnuSearchCat";
            this.mnuSearchCat.Size = new System.Drawing.Size(208, 26);
            this.mnuSearchCat.Text = "Search Catalogue";
            this.mnuSearchCat.Click += new System.EventHandler(this.mnuSearchCat_Click);
            // 
            // loansToolStripMenuItem
            // 
            this.loansToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuViewLoan,
            this.mnuRetBook});
            this.loansToolStripMenuItem.Name = "loansToolStripMenuItem";
            this.loansToolStripMenuItem.Size = new System.Drawing.Size(61, 24);
            this.loansToolStripMenuItem.Text = "Loans";
            // 
            // mnuViewLoan
            // 
            this.mnuViewLoan.Name = "mnuViewLoan";
            this.mnuViewLoan.Size = new System.Drawing.Size(173, 26);
            this.mnuViewLoan.Text = "View Loan";
            this.mnuViewLoan.Click += new System.EventHandler(this.mnuViewLoan_Click);
            // 
            // mnuRetBook
            // 
            this.mnuRetBook.Name = "mnuRetBook";
            this.mnuRetBook.Size = new System.Drawing.Size(173, 26);
            this.mnuRetBook.Text = "Return Book";
            this.mnuRetBook.Click += new System.EventHandler(this.mnuRetBook_Click);
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuRevBookLoan});
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.adminToolStripMenuItem.Text = "Admin";
            // 
            // mnuRevBookLoan
            // 
            this.mnuRevBookLoan.Name = "mnuRevBookLoan";
            this.mnuRevBookLoan.Size = new System.Drawing.Size(219, 26);
            this.mnuRevBookLoan.Text = "Review Book Loans";
            this.mnuRevBookLoan.Click += new System.EventHandler(this.mnuRevBookLoan_Click);
            // 
            // picHomeArt
            // 
            this.picHomeArt.Image = global::LibrarySYS.Properties.Resources.vecteezy_3d_illustration_mouse_in_online_learning_set_21596621;
            this.picHomeArt.Location = new System.Drawing.Point(358, 85);
            this.picHomeArt.Name = "picHomeArt";
            this.picHomeArt.Size = new System.Drawing.Size(503, 341);
            this.picHomeArt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHomeArt.TabIndex = 1;
            this.picHomeArt.TabStop = false;
            // 
            // viewMemberDetailsToolStripMenuItem
            // 
            this.viewMemberDetailsToolStripMenuItem.Name = "viewMemberDetailsToolStripMenuItem";
            this.viewMemberDetailsToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.viewMemberDetailsToolStripMenuItem.Text = "View Member Details";
            this.viewMemberDetailsToolStripMenuItem.Click += new System.EventHandler(this.viewMemberDetailsToolStripMenuItem_Click);
            // 
            // frmHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 450);
            this.Controls.Add(this.picHomeArt);
            this.Controls.Add(this.mnuHomeMainMenu);
            this.MainMenuStrip = this.mnuHomeMainMenu;
            this.Name = "frmHomePage";
            this.Text = "Library Home";
            this.mnuHomeMainMenu.ResumeLayout(false);
            this.mnuHomeMainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHomeArt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuHomeMainMenu;
        private System.Windows.Forms.ToolStripMenuItem membersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem booksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loansToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuRegMem;
        private System.Windows.Forms.ToolStripMenuItem mnuUpdMem;
        private System.Windows.Forms.ToolStripMenuItem mnuPayFee;
        private System.Windows.Forms.ToolStripMenuItem mnuRemMem;
        private System.Windows.Forms.ToolStripMenuItem mnuCatBook;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuSearchCat;
        private System.Windows.Forms.ToolStripMenuItem mnuViewLoan;
        private System.Windows.Forms.ToolStripMenuItem mnuRetBook;
        private System.Windows.Forms.ToolStripMenuItem mnuRevBookLoan;
        private System.Windows.Forms.PictureBox picHomeArt;
        private System.Windows.Forms.ToolStripMenuItem viewMemberDetailsToolStripMenuItem;
    }
}

