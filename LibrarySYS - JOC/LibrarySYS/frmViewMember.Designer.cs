namespace LibrarySYS
{
    partial class frmViewMember
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
            this.btnRetrieve = new System.Windows.Forms.Button();
            this.lblMemID = new System.Windows.Forms.Label();
            this.txtMemID = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblHouseNo = new System.Windows.Forms.Label();
            this.lblEirCode = new System.Windows.Forms.Label();
            this.lblCounty = new System.Windows.Forms.Label();
            this.lblTown = new System.Windows.Forms.Label();
            this.lblStreet = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblForeName = new System.Windows.Forms.Label();
            this.lblSurName = new System.Windows.Forms.Label();
            this.lblFee = new System.Windows.Forms.Label();
            this.lblStrike = new System.Windows.Forms.Label();
            this.btnPayFee = new System.Windows.Forms.Button();
            this.mnuAllMainMenu = new System.Windows.Forms.MenuStrip();
            this.returnToMainMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAllMainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRetrieve
            // 
            this.btnRetrieve.BackColor = System.Drawing.Color.Green;
            this.btnRetrieve.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnRetrieve.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRetrieve.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetrieve.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRetrieve.Location = new System.Drawing.Point(15, 56);
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
            this.lblMemID.Location = new System.Drawing.Point(12, 31);
            this.lblMemID.Name = "lblMemID";
            this.lblMemID.Size = new System.Drawing.Size(70, 16);
            this.lblMemID.TabIndex = 45;
            this.lblMemID.Text = "MemberID";
            // 
            // txtMemID
            // 
            this.txtMemID.Location = new System.Drawing.Point(109, 28);
            this.txtMemID.MaxLength = 5;
            this.txtMemID.Name = "txtMemID";
            this.txtMemID.Size = new System.Drawing.Size(154, 22);
            this.txtMemID.TabIndex = 44;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(12, 239);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(52, 16);
            this.lblPhone.TabIndex = 65;
            this.lblPhone.Text = "Phone: ";
            this.lblPhone.Visible = false;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(12, 283);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(51, 16);
            this.lblEmail.TabIndex = 64;
            this.lblEmail.Text = "E-mail: ";
            this.lblEmail.Visible = false;
            // 
            // lblHouseNo
            // 
            this.lblHouseNo.AutoSize = true;
            this.lblHouseNo.Location = new System.Drawing.Point(276, 147);
            this.lblHouseNo.Name = "lblHouseNo";
            this.lblHouseNo.Size = new System.Drawing.Size(74, 16);
            this.lblHouseNo.TabIndex = 63;
            this.lblHouseNo.Text = "House No: ";
            this.lblHouseNo.Visible = false;
            // 
            // lblEirCode
            // 
            this.lblEirCode.AutoSize = true;
            this.lblEirCode.Location = new System.Drawing.Point(276, 325);
            this.lblEirCode.Name = "lblEirCode";
            this.lblEirCode.Size = new System.Drawing.Size(59, 16);
            this.lblEirCode.TabIndex = 62;
            this.lblEirCode.Text = "EirCode:";
            this.lblEirCode.Visible = false;
            // 
            // lblCounty
            // 
            this.lblCounty.AutoSize = true;
            this.lblCounty.Location = new System.Drawing.Point(276, 283);
            this.lblCounty.Name = "lblCounty";
            this.lblCounty.Size = new System.Drawing.Size(54, 16);
            this.lblCounty.TabIndex = 61;
            this.lblCounty.Text = "County: ";
            this.lblCounty.Visible = false;
            // 
            // lblTown
            // 
            this.lblTown.AutoSize = true;
            this.lblTown.Location = new System.Drawing.Point(276, 239);
            this.lblTown.Name = "lblTown";
            this.lblTown.Size = new System.Drawing.Size(46, 16);
            this.lblTown.TabIndex = 60;
            this.lblTown.Text = "Town: ";
            this.lblTown.Visible = false;
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.Location = new System.Drawing.Point(276, 190);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(88, 16);
            this.lblStreet.TabIndex = 59;
            this.lblStreet.Text = "Street Name: ";
            this.lblStreet.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(301, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 16);
            this.label3.TabIndex = 58;
            // 
            // lblForeName
            // 
            this.lblForeName.AutoSize = true;
            this.lblForeName.Location = new System.Drawing.Point(12, 190);
            this.lblForeName.Name = "lblForeName";
            this.lblForeName.Size = new System.Drawing.Size(75, 16);
            this.lblForeName.TabIndex = 57;
            this.lblForeName.Text = "Forename: ";
            this.lblForeName.Visible = false;
            // 
            // lblSurName
            // 
            this.lblSurName.AutoSize = true;
            this.lblSurName.Location = new System.Drawing.Point(12, 147);
            this.lblSurName.Name = "lblSurName";
            this.lblSurName.Size = new System.Drawing.Size(67, 16);
            this.lblSurName.TabIndex = 55;
            this.lblSurName.Text = "Surname: ";
            this.lblSurName.Visible = false;
            // 
            // lblFee
            // 
            this.lblFee.AutoSize = true;
            this.lblFee.Location = new System.Drawing.Point(512, 147);
            this.lblFee.Name = "lblFee";
            this.lblFee.Size = new System.Drawing.Size(95, 16);
            this.lblFee.TabIndex = 66;
            this.lblFee.Text = "Fee Amount: € ";
            this.lblFee.Visible = false;
            // 
            // lblStrike
            // 
            this.lblStrike.AutoSize = true;
            this.lblStrike.Location = new System.Drawing.Point(12, 325);
            this.lblStrike.Name = "lblStrike";
            this.lblStrike.Size = new System.Drawing.Size(84, 16);
            this.lblStrike.TabIndex = 67;
            this.lblStrike.Text = "Strike Count: ";
            this.lblStrike.Visible = false;
            // 
            // btnPayFee
            // 
            this.btnPayFee.BackColor = System.Drawing.Color.Green;
            this.btnPayFee.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnPayFee.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPayFee.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayFee.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPayFee.Location = new System.Drawing.Point(515, 223);
            this.btnPayFee.Name = "btnPayFee";
            this.btnPayFee.Size = new System.Drawing.Size(169, 32);
            this.btnPayFee.TabIndex = 68;
            this.btnPayFee.Text = "Go to Pay Fee";
            this.btnPayFee.UseVisualStyleBackColor = false;
            this.btnPayFee.Visible = false;
            this.btnPayFee.Click += new System.EventHandler(this.btnPayFee_Click);
            // 
            // mnuAllMainMenu
            // 
            this.mnuAllMainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuAllMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.returnToMainMenuToolStripMenuItem});
            this.mnuAllMainMenu.Location = new System.Drawing.Point(0, 0);
            this.mnuAllMainMenu.Name = "mnuAllMainMenu";
            this.mnuAllMainMenu.Size = new System.Drawing.Size(800, 30);
            this.mnuAllMainMenu.TabIndex = 69;
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
            // frmViewMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mnuAllMainMenu);
            this.Controls.Add(this.btnPayFee);
            this.Controls.Add(this.lblStrike);
            this.Controls.Add(this.lblFee);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblHouseNo);
            this.Controls.Add(this.lblEirCode);
            this.Controls.Add(this.lblCounty);
            this.Controls.Add(this.lblTown);
            this.Controls.Add(this.lblStreet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblForeName);
            this.Controls.Add(this.lblSurName);
            this.Controls.Add(this.btnRetrieve);
            this.Controls.Add(this.lblMemID);
            this.Controls.Add(this.txtMemID);
            this.Name = "frmViewMember";
            this.Text = "frmViewMember";
            this.mnuAllMainMenu.ResumeLayout(false);
            this.mnuAllMainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRetrieve;
        private System.Windows.Forms.Label lblMemID;
        private System.Windows.Forms.TextBox txtMemID;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblHouseNo;
        private System.Windows.Forms.Label lblEirCode;
        private System.Windows.Forms.Label lblCounty;
        private System.Windows.Forms.Label lblTown;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblForeName;
        private System.Windows.Forms.Label lblSurName;
        private System.Windows.Forms.Label lblFee;
        private System.Windows.Forms.Label lblStrike;
        private System.Windows.Forms.Button btnPayFee;
        private System.Windows.Forms.MenuStrip mnuAllMainMenu;
        private System.Windows.Forms.ToolStripMenuItem returnToMainMenuToolStripMenuItem;
    }
}