namespace LibrarySYS
{
    partial class frmCatalogBook
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
            this.lblReleaseDate = new System.Windows.Forms.Label();
            this.lblGenre = new System.Windows.Forms.Label();
            this.txtGenre = new System.Windows.Forms.TextBox();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtRelDate = new System.Windows.Forms.TextBox();
            this.btnRetrFee = new System.Windows.Forms.Button();
            this.txtPopUp = new System.Windows.Forms.TextBox();
            this.btnContinue = new System.Windows.Forms.Button();
            this.mnuAllMainMenu = new System.Windows.Forms.MenuStrip();
            this.returnToMainMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtReleaseDateCon = new System.Windows.Forms.TextBox();
            this.txtGenreCon = new System.Windows.Forms.TextBox();
            this.txtAuthorCon = new System.Windows.Forms.TextBox();
            this.txtTitleCon = new System.Windows.Forms.TextBox();
            this.txtBookID = new System.Windows.Forms.TextBox();
            this.mnuAllMainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblReleaseDate
            // 
            this.lblReleaseDate.AutoSize = true;
            this.lblReleaseDate.Location = new System.Drawing.Point(42, 180);
            this.lblReleaseDate.Name = "lblReleaseDate";
            this.lblReleaseDate.Size = new System.Drawing.Size(91, 16);
            this.lblReleaseDate.TabIndex = 26;
            this.lblReleaseDate.Text = "Release Date";
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Location = new System.Drawing.Point(42, 217);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(44, 16);
            this.lblGenre.TabIndex = 25;
            this.lblGenre.Text = "Genre";
            // 
            // txtGenre
            // 
            this.txtGenre.Location = new System.Drawing.Point(139, 214);
            this.txtGenre.MaxLength = 3;
            this.txtGenre.Name = "txtGenre";
            this.txtGenre.Size = new System.Drawing.Size(154, 22);
            this.txtGenre.TabIndex = 22;
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(42, 82);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(45, 16);
            this.lblAuthor.TabIndex = 24;
            this.lblAuthor.Text = "Author";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(42, 39);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(33, 16);
            this.lblTitle.TabIndex = 23;
            this.lblTitle.Text = "Title";
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(139, 79);
            this.txtAuthor.MaxLength = 40;
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(154, 22);
            this.txtAuthor.TabIndex = 20;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(139, 36);
            this.txtTitle.MaxLength = 35;
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(154, 22);
            this.txtTitle.TabIndex = 19;
            // 
            // txtRelDate
            // 
            this.txtRelDate.Location = new System.Drawing.Point(141, 177);
            this.txtRelDate.MaxLength = 11;
            this.txtRelDate.Name = "txtRelDate";
            this.txtRelDate.Size = new System.Drawing.Size(154, 22);
            this.txtRelDate.TabIndex = 21;
            this.txtRelDate.Text = "YYYY-MMM-DD\r\n";
            // 
            // btnRetrFee
            // 
            this.btnRetrFee.BackColor = System.Drawing.SystemColors.Info;
            this.btnRetrFee.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnRetrFee.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRetrFee.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetrFee.Location = new System.Drawing.Point(45, 338);
            this.btnRetrFee.Name = "btnRetrFee";
            this.btnRetrFee.Size = new System.Drawing.Size(151, 67);
            this.btnRetrFee.TabIndex = 30;
            this.btnRetrFee.Text = "Cataogue Book";
            this.btnRetrFee.UseVisualStyleBackColor = false;
            this.btnRetrFee.Click += new System.EventHandler(this.btnRetrFee_Click);
            // 
            // txtPopUp
            // 
            this.txtPopUp.BackColor = System.Drawing.SystemColors.Menu;
            this.txtPopUp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPopUp.Location = new System.Drawing.Point(420, 130);
            this.txtPopUp.Multiline = true;
            this.txtPopUp.Name = "txtPopUp";
            this.txtPopUp.Size = new System.Drawing.Size(354, 20);
            this.txtPopUp.TabIndex = 31;
            this.txtPopUp.Text = "The following Book has been added to the Catalogue\r\n\r\n";
            this.txtPopUp.Visible = false;
            // 
            // btnContinue
            // 
            this.btnContinue.BackColor = System.Drawing.SystemColors.Info;
            this.btnContinue.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnContinue.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnContinue.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinue.Location = new System.Drawing.Point(420, 338);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(151, 67);
            this.btnContinue.TabIndex = 32;
            this.btnContinue.Text = "Continue";
            this.btnContinue.UseVisualStyleBackColor = false;
            this.btnContinue.Visible = false;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // mnuAllMainMenu
            // 
            this.mnuAllMainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuAllMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.returnToMainMenuToolStripMenuItem});
            this.mnuAllMainMenu.Location = new System.Drawing.Point(0, 0);
            this.mnuAllMainMenu.Name = "mnuAllMainMenu";
            this.mnuAllMainMenu.Size = new System.Drawing.Size(800, 30);
            this.mnuAllMainMenu.TabIndex = 33;
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
            // txtReleaseDateCon
            // 
            this.txtReleaseDateCon.BackColor = System.Drawing.SystemColors.Menu;
            this.txtReleaseDateCon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtReleaseDateCon.Location = new System.Drawing.Point(420, 205);
            this.txtReleaseDateCon.Multiline = true;
            this.txtReleaseDateCon.Name = "txtReleaseDateCon";
            this.txtReleaseDateCon.Size = new System.Drawing.Size(274, 20);
            this.txtReleaseDateCon.TabIndex = 34;
            this.txtReleaseDateCon.Visible = false;
            // 
            // txtGenreCon
            // 
            this.txtGenreCon.BackColor = System.Drawing.SystemColors.Menu;
            this.txtGenreCon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGenreCon.Location = new System.Drawing.Point(420, 231);
            this.txtGenreCon.Multiline = true;
            this.txtGenreCon.Name = "txtGenreCon";
            this.txtGenreCon.Size = new System.Drawing.Size(274, 20);
            this.txtGenreCon.TabIndex = 35;
            this.txtGenreCon.Visible = false;
            // 
            // txtAuthorCon
            // 
            this.txtAuthorCon.BackColor = System.Drawing.SystemColors.Menu;
            this.txtAuthorCon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAuthorCon.Location = new System.Drawing.Point(420, 182);
            this.txtAuthorCon.Multiline = true;
            this.txtAuthorCon.Name = "txtAuthorCon";
            this.txtAuthorCon.Size = new System.Drawing.Size(274, 20);
            this.txtAuthorCon.TabIndex = 37;
            this.txtAuthorCon.Visible = false;
            // 
            // txtTitleCon
            // 
            this.txtTitleCon.BackColor = System.Drawing.SystemColors.Menu;
            this.txtTitleCon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTitleCon.Location = new System.Drawing.Point(420, 156);
            this.txtTitleCon.Multiline = true;
            this.txtTitleCon.Name = "txtTitleCon";
            this.txtTitleCon.Size = new System.Drawing.Size(274, 20);
            this.txtTitleCon.TabIndex = 38;
            this.txtTitleCon.Visible = false;
            // 
            // txtBookID
            // 
            this.txtBookID.BackColor = System.Drawing.SystemColors.Menu;
            this.txtBookID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBookID.Location = new System.Drawing.Point(420, 312);
            this.txtBookID.Multiline = true;
            this.txtBookID.Name = "txtBookID";
            this.txtBookID.Size = new System.Drawing.Size(274, 20);
            this.txtBookID.TabIndex = 39;
            this.txtBookID.Text = "Book ID: 100021";
            this.txtBookID.Visible = false;
            // 
            // frmCatalogBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtBookID);
            this.Controls.Add(this.txtTitleCon);
            this.Controls.Add(this.txtAuthorCon);
            this.Controls.Add(this.txtGenreCon);
            this.Controls.Add(this.txtReleaseDateCon);
            this.Controls.Add(this.mnuAllMainMenu);
            this.Controls.Add(this.btnContinue);
            this.Controls.Add(this.txtPopUp);
            this.Controls.Add(this.btnRetrFee);
            this.Controls.Add(this.txtRelDate);
            this.Controls.Add(this.lblReleaseDate);
            this.Controls.Add(this.lblGenre);
            this.Controls.Add(this.txtGenre);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.txtTitle);
            this.Name = "frmCatalogBook";
            this.Text = "Catalogue Book";
            this.mnuAllMainMenu.ResumeLayout(false);
            this.mnuAllMainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblReleaseDate;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.TextBox txtGenre;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtRelDate;
        private System.Windows.Forms.Button btnRetrFee;
        private System.Windows.Forms.TextBox txtPopUp;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.MenuStrip mnuAllMainMenu;
        private System.Windows.Forms.ToolStripMenuItem returnToMainMenuToolStripMenuItem;
        private System.Windows.Forms.TextBox txtReleaseDateCon;
        private System.Windows.Forms.TextBox txtGenreCon;
        private System.Windows.Forms.TextBox txtAuthorCon;
        private System.Windows.Forms.TextBox txtTitleCon;
        private System.Windows.Forms.TextBox txtBookID;
    }
}