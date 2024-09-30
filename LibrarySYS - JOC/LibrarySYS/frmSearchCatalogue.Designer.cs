namespace LibrarySYS
{
    partial class frmSearchCatalogue
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
            this.lblSearch = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblSearchFor = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.btnCart = new System.Windows.Forms.Button();
            this.dgvBookView = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dgvCart = new System.Windows.Forms.DataGridView();
            this.lblRemCart = new System.Windows.Forms.Label();
            this.lblAddCart = new System.Windows.Forms.Label();
            this.mnuAllMainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuAllMainMenu
            // 
            this.mnuAllMainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuAllMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.returnToMainMenuToolStripMenuItem});
            this.mnuAllMainMenu.Location = new System.Drawing.Point(0, 0);
            this.mnuAllMainMenu.Name = "mnuAllMainMenu";
            this.mnuAllMainMenu.Size = new System.Drawing.Size(1097, 30);
            this.mnuAllMainMenu.TabIndex = 34;
            this.mnuAllMainMenu.Text = "menuStrip1";
            // 
            // returnToMainMenuToolStripMenuItem
            // 
            this.returnToMainMenuToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.returnToMainMenuToolStripMenuItem.Name = "returnToMainMenuToolStripMenuItem";
            this.returnToMainMenuToolStripMenuItem.Size = new System.Drawing.Size(162, 26);
            this.returnToMainMenuToolStripMenuItem.Text = "Return to Main Menu";
            this.returnToMainMenuToolStripMenuItem.Click += new System.EventHandler(this.returnToMainMenuToolStripMenuItem_Click);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(12, 65);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(74, 16);
            this.lblSearch.TabIndex = 35;
            this.lblSearch.Text = "Search by: ";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Title",
            "Author",
            "Genre"});
            this.comboBox1.Location = new System.Drawing.Point(103, 62);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 36;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblSearchFor
            // 
            this.lblSearchFor.AutoSize = true;
            this.lblSearchFor.Location = new System.Drawing.Point(12, 104);
            this.lblSearchFor.Name = "lblSearchFor";
            this.lblSearchFor.Size = new System.Drawing.Size(0, 16);
            this.lblSearchFor.TabIndex = 37;
            this.lblSearchFor.Visible = false;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(103, 101);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(121, 22);
            this.txtSearch.TabIndex = 38;
            this.txtSearch.Visible = false;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.SpringGreen;
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearch.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(12, 149);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(188, 53);
            this.btnSearch.TabIndex = 39;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtTitle
            // 
            this.txtTitle.BackColor = System.Drawing.SystemColors.Control;
            this.txtTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTitle.Location = new System.Drawing.Point(291, 30);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(144, 15);
            this.txtTitle.TabIndex = 40;
            this.txtTitle.Visible = false;
            // 
            // btnCart
            // 
            this.btnCart.BackColor = System.Drawing.Color.SpringGreen;
            this.btnCart.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCart.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCart.Location = new System.Drawing.Point(858, 338);
            this.btnCart.Name = "btnCart";
            this.btnCart.Size = new System.Drawing.Size(122, 53);
            this.btnCart.TabIndex = 47;
            this.btnCart.Text = "Checkout";
            this.btnCart.UseVisualStyleBackColor = false;
            this.btnCart.Visible = false;
            this.btnCart.Click += new System.EventHandler(this.btnCart_Click);
            // 
            // dgvBookView
            // 
            this.dgvBookView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBookView.Location = new System.Drawing.Point(260, 52);
            this.dgvBookView.Name = "dgvBookView";
            this.dgvBookView.RowHeadersWidth = 51;
            this.dgvBookView.RowTemplate.Height = 24;
            this.dgvBookView.Size = new System.Drawing.Size(825, 150);
            this.dgvBookView.TabIndex = 52;
            this.dgvBookView.Visible = false;
            this.dgvBookView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBookView_CellClick);
            // 
            // dgvCart
            // 
            this.dgvCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCart.Location = new System.Drawing.Point(15, 302);
            this.dgvCart.Name = "dgvCart";
            this.dgvCart.RowHeadersWidth = 51;
            this.dgvCart.RowTemplate.Height = 24;
            this.dgvCart.Size = new System.Drawing.Size(825, 134);
            this.dgvCart.TabIndex = 53;
            this.dgvCart.Visible = false;
            this.dgvCart.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCart_CellClick);
            // 
            // lblRemCart
            // 
            this.lblRemCart.AutoSize = true;
            this.lblRemCart.Location = new System.Drawing.Point(12, 283);
            this.lblRemCart.Name = "lblRemCart";
            this.lblRemCart.Size = new System.Drawing.Size(246, 16);
            this.lblRemCart.TabIndex = 54;
            this.lblRemCart.Text = "Click on a book to remove it from the cart";
            this.lblRemCart.Visible = false;
            // 
            // lblAddCart
            // 
            this.lblAddCart.AutoSize = true;
            this.lblAddCart.Location = new System.Drawing.Point(257, 33);
            this.lblAddCart.Name = "lblAddCart";
            this.lblAddCart.Size = new System.Drawing.Size(209, 16);
            this.lblAddCart.TabIndex = 55;
            this.lblAddCart.Text = "Click on a book to add it to the cart";
            this.lblAddCart.Visible = false;
            // 
            // frmSearchCatalogue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 471);
            this.Controls.Add(this.lblAddCart);
            this.Controls.Add(this.lblRemCart);
            this.Controls.Add(this.dgvCart);
            this.Controls.Add(this.dgvBookView);
            this.Controls.Add(this.btnCart);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblSearchFor);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.mnuAllMainMenu);
            this.Name = "frmSearchCatalogue";
            this.Text = "Search Catalogue";
            this.mnuAllMainMenu.ResumeLayout(false);
            this.mnuAllMainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuAllMainMenu;
        private System.Windows.Forms.ToolStripMenuItem returnToMainMenuToolStripMenuItem;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblSearchFor;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Button btnCart;
        private System.Windows.Forms.DataGridView dgvBookView;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView dgvCart;
        private System.Windows.Forms.Label lblRemCart;
        private System.Windows.Forms.Label lblAddCart;
    }
}