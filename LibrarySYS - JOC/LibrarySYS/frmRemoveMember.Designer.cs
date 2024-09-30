namespace LibrarySYS
{
    partial class frmRemoveMember
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
            this.btnRetrieve = new System.Windows.Forms.Button();
            this.lblMemID = new System.Windows.Forms.Label();
            this.txtMemID = new System.Windows.Forms.TextBox();
            this.txtForename = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtMemberID = new System.Windows.Forms.TextBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.btnRemoveMember = new System.Windows.Forms.Button();
            this.txtStrike = new System.Windows.Forms.TextBox();
            this.mnuAllMainMenu.SuspendLayout();
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
            // btnRetrieve
            // 
            this.btnRetrieve.BackColor = System.Drawing.Color.MediumPurple;
            this.btnRetrieve.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnRetrieve.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRetrieve.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetrieve.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRetrieve.Location = new System.Drawing.Point(545, 50);
            this.btnRetrieve.Name = "btnRetrieve";
            this.btnRetrieve.Size = new System.Drawing.Size(169, 32);
            this.btnRetrieve.TabIndex = 46;
            this.btnRetrieve.Text = "Retrieve Details";
            this.btnRetrieve.UseVisualStyleBackColor = false;
            this.btnRetrieve.Click += new System.EventHandler(this.btnRetrieve_Click);
            // 
            // lblMemID
            // 
            this.lblMemID.AutoSize = true;
            this.lblMemID.Location = new System.Drawing.Point(49, 53);
            this.lblMemID.Name = "lblMemID";
            this.lblMemID.Size = new System.Drawing.Size(70, 16);
            this.lblMemID.TabIndex = 45;
            this.lblMemID.Text = "MemberID";
            // 
            // txtMemID
            // 
            this.txtMemID.Location = new System.Drawing.Point(146, 50);
            this.txtMemID.Name = "txtMemID";
            this.txtMemID.Size = new System.Drawing.Size(154, 22);
            this.txtMemID.TabIndex = 44;
            // 
            // txtForename
            // 
            this.txtForename.BackColor = System.Drawing.SystemColors.Menu;
            this.txtForename.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtForename.Location = new System.Drawing.Point(52, 249);
            this.txtForename.Multiline = true;
            this.txtForename.Name = "txtForename";
            this.txtForename.Size = new System.Drawing.Size(354, 20);
            this.txtForename.TabIndex = 47;
            this.txtForename.Visible = false;
            // 
            // txtSurname
            // 
            this.txtSurname.BackColor = System.Drawing.SystemColors.Menu;
            this.txtSurname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSurname.Location = new System.Drawing.Point(52, 271);
            this.txtSurname.Multiline = true;
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(354, 20);
            this.txtSurname.TabIndex = 48;
            this.txtSurname.Visible = false;
            // 
            // txtMemberID
            // 
            this.txtMemberID.BackColor = System.Drawing.SystemColors.Menu;
            this.txtMemberID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMemberID.Location = new System.Drawing.Point(52, 297);
            this.txtMemberID.Multiline = true;
            this.txtMemberID.Name = "txtMemberID";
            this.txtMemberID.Size = new System.Drawing.Size(354, 20);
            this.txtMemberID.TabIndex = 49;
            this.txtMemberID.Visible = false;
            // 
            // txtStatus
            // 
            this.txtStatus.BackColor = System.Drawing.SystemColors.Menu;
            this.txtStatus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStatus.Location = new System.Drawing.Point(52, 323);
            this.txtStatus.Multiline = true;
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(354, 20);
            this.txtStatus.TabIndex = 50;
            this.txtStatus.Visible = false;
            // 
            // btnRemoveMember
            // 
            this.btnRemoveMember.BackColor = System.Drawing.Color.Red;
            this.btnRemoveMember.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnRemoveMember.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRemoveMember.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveMember.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRemoveMember.Location = new System.Drawing.Point(545, 285);
            this.btnRemoveMember.Name = "btnRemoveMember";
            this.btnRemoveMember.Size = new System.Drawing.Size(107, 84);
            this.btnRemoveMember.TabIndex = 54;
            this.btnRemoveMember.Text = "Remove Member";
            this.btnRemoveMember.UseVisualStyleBackColor = false;
            this.btnRemoveMember.Visible = false;
            this.btnRemoveMember.Click += new System.EventHandler(this.btnRemoveMember_Click);
            // 
            // txtStrike
            // 
            this.txtStrike.BackColor = System.Drawing.SystemColors.Menu;
            this.txtStrike.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStrike.Location = new System.Drawing.Point(52, 349);
            this.txtStrike.Multiline = true;
            this.txtStrike.Name = "txtStrike";
            this.txtStrike.Size = new System.Drawing.Size(354, 20);
            this.txtStrike.TabIndex = 55;
            this.txtStrike.Visible = false;
            // 
            // frmRemoveMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtStrike);
            this.Controls.Add(this.btnRemoveMember);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.txtMemberID);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.txtForename);
            this.Controls.Add(this.btnRetrieve);
            this.Controls.Add(this.lblMemID);
            this.Controls.Add(this.txtMemID);
            this.Controls.Add(this.mnuAllMainMenu);
            this.Name = "frmRemoveMember";
            this.Text = "frmRemoveMember";
            this.mnuAllMainMenu.ResumeLayout(false);
            this.mnuAllMainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuAllMainMenu;
        private System.Windows.Forms.ToolStripMenuItem returnToMainMenuToolStripMenuItem;
        private System.Windows.Forms.Button btnRetrieve;
        private System.Windows.Forms.Label lblMemID;
        private System.Windows.Forms.TextBox txtMemID;
        private System.Windows.Forms.TextBox txtForename;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtMemberID;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Button btnRemoveMember;
        private System.Windows.Forms.TextBox txtStrike;
    }
}