namespace LibrarySYS
{
    partial class frmPayFee
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
            this.lblPFMemID = new System.Windows.Forms.Label();
            this.txtMemberID = new System.Windows.Forms.TextBox();
            this.btnRetrFee = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFeeAmount = new System.Windows.Forms.Label();
            this.btnPayFee = new System.Windows.Forms.Button();
            this.lblCVV = new System.Windows.Forms.Label();
            this.txtCVV = new System.Windows.Forms.TextBox();
            this.lblBankCardNo = new System.Windows.Forms.Label();
            this.txtBankCardNo = new System.Windows.Forms.TextBox();
            this.mnuAllMainMenu = new System.Windows.Forms.MenuStrip();
            this.returnToMainMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.mnuAllMainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPFMemID
            // 
            this.lblPFMemID.AutoSize = true;
            this.lblPFMemID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPFMemID.Location = new System.Drawing.Point(8, 52);
            this.lblPFMemID.Name = "lblPFMemID";
            this.lblPFMemID.Size = new System.Drawing.Size(93, 20);
            this.lblPFMemID.TabIndex = 9;
            this.lblPFMemID.Text = "MemberID*";
            // 
            // txtMemberID
            // 
            this.txtMemberID.Location = new System.Drawing.Point(106, 50);
            this.txtMemberID.MaxLength = 5;
            this.txtMemberID.Name = "txtMemberID";
            this.txtMemberID.Size = new System.Drawing.Size(154, 22);
            this.txtMemberID.TabIndex = 8;
            // 
            // btnRetrFee
            // 
            this.btnRetrFee.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRetrFee.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnRetrFee.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRetrFee.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetrFee.Location = new System.Drawing.Point(12, 189);
            this.btnRetrFee.Name = "btnRetrFee";
            this.btnRetrFee.Size = new System.Drawing.Size(151, 48);
            this.btnRetrFee.TabIndex = 20;
            this.btnRetrFee.Text = "Retrieve Fees";
            this.btnRetrFee.UseVisualStyleBackColor = false;
            this.btnRetrFee.Click += new System.EventHandler(this.btnRetrFee_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(583, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 21;
            // 
            // lblFeeAmount
            // 
            this.lblFeeAmount.AutoSize = true;
            this.lblFeeAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFeeAmount.Location = new System.Drawing.Point(494, 53);
            this.lblFeeAmount.Name = "lblFeeAmount";
            this.lblFeeAmount.Size = new System.Drawing.Size(146, 25);
            this.lblFeeAmount.TabIndex = 22;
            this.lblFeeAmount.Text = "Fee Amount:  €";
            this.lblFeeAmount.Visible = false;
            // 
            // btnPayFee
            // 
            this.btnPayFee.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPayFee.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnPayFee.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPayFee.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayFee.Location = new System.Drawing.Point(498, 244);
            this.btnPayFee.Name = "btnPayFee";
            this.btnPayFee.Size = new System.Drawing.Size(151, 48);
            this.btnPayFee.TabIndex = 23;
            this.btnPayFee.Text = "Pay Fee";
            this.btnPayFee.UseVisualStyleBackColor = false;
            this.btnPayFee.Visible = false;
            this.btnPayFee.Click += new System.EventHandler(this.btnPayFee_Click);
            // 
            // lblCVV
            // 
            this.lblCVV.AutoSize = true;
            this.lblCVV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCVV.Location = new System.Drawing.Point(494, 153);
            this.lblCVV.Name = "lblCVV";
            this.lblCVV.Size = new System.Drawing.Size(43, 20);
            this.lblCVV.TabIndex = 25;
            this.lblCVV.Text = "CVV";
            this.lblCVV.Visible = false;
            // 
            // txtCVV
            // 
            this.txtCVV.Location = new System.Drawing.Point(619, 148);
            this.txtCVV.MaxLength = 3;
            this.txtCVV.Name = "txtCVV";
            this.txtCVV.Size = new System.Drawing.Size(48, 22);
            this.txtCVV.TabIndex = 24;
            this.txtCVV.Visible = false;
            // 
            // lblBankCardNo
            // 
            this.lblBankCardNo.AutoSize = true;
            this.lblBankCardNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBankCardNo.Location = new System.Drawing.Point(494, 105);
            this.lblBankCardNo.Name = "lblBankCardNo";
            this.lblBankCardNo.Size = new System.Drawing.Size(114, 20);
            this.lblBankCardNo.TabIndex = 27;
            this.lblBankCardNo.Text = "Bank Card No";
            this.lblBankCardNo.Visible = false;
            // 
            // txtBankCardNo
            // 
            this.txtBankCardNo.Location = new System.Drawing.Point(621, 103);
            this.txtBankCardNo.MaxLength = 16;
            this.txtBankCardNo.Name = "txtBankCardNo";
            this.txtBankCardNo.Size = new System.Drawing.Size(154, 22);
            this.txtBankCardNo.TabIndex = 26;
            this.txtBankCardNo.Visible = false;
            // 
            // mnuAllMainMenu
            // 
            this.mnuAllMainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuAllMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.returnToMainMenuToolStripMenuItem});
            this.mnuAllMainMenu.Location = new System.Drawing.Point(0, 0);
            this.mnuAllMainMenu.Name = "mnuAllMainMenu";
            this.mnuAllMainMenu.Size = new System.Drawing.Size(800, 28);
            this.mnuAllMainMenu.TabIndex = 34;
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
            // frmPayFee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mnuAllMainMenu);
            this.Controls.Add(this.lblBankCardNo);
            this.Controls.Add(this.txtBankCardNo);
            this.Controls.Add(this.lblCVV);
            this.Controls.Add(this.txtCVV);
            this.Controls.Add(this.btnPayFee);
            this.Controls.Add(this.lblFeeAmount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRetrFee);
            this.Controls.Add(this.lblPFMemID);
            this.Controls.Add(this.txtMemberID);
            this.Name = "frmPayFee";
            this.Text = "Pay Fee";
            this.mnuAllMainMenu.ResumeLayout(false);
            this.mnuAllMainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPFMemID;
        private System.Windows.Forms.TextBox txtMemberID;
        private System.Windows.Forms.Button btnRetrFee;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFeeAmount;
        private System.Windows.Forms.Button btnPayFee;
        private System.Windows.Forms.Label lblCVV;
        private System.Windows.Forms.TextBox txtCVV;
        private System.Windows.Forms.Label lblBankCardNo;
        private System.Windows.Forms.TextBox txtBankCardNo;
        private System.Windows.Forms.MenuStrip mnuAllMainMenu;
        private System.Windows.Forms.ToolStripMenuItem returnToMainMenuToolStripMenuItem;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}