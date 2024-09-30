namespace LibrarySYS
{
    partial class frmReviewLoans
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.mnuAllMainMenu = new System.Windows.Forms.MenuStrip();
            this.returnToMainMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblReview = new System.Windows.Forms.Label();
            this.btnRetrieveLoan = new System.Windows.Forms.Button();
            this.chrtGenrePop = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.mnuAllMainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrtGenrePop)).BeginInit();
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
            this.mnuAllMainMenu.TabIndex = 36;
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
            // lblReview
            // 
            this.lblReview.AutoSize = true;
            this.lblReview.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReview.Location = new System.Drawing.Point(190, 30);
            this.lblReview.Name = "lblReview";
            this.lblReview.Size = new System.Drawing.Size(408, 25);
            this.lblReview.TabIndex = 37;
            this.lblReview.Text = "Review Loans based on Genre Popularity";
            this.lblReview.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnRetrieveLoan
            // 
            this.btnRetrieveLoan.BackColor = System.Drawing.Color.Cyan;
            this.btnRetrieveLoan.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnRetrieveLoan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRetrieveLoan.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetrieveLoan.Location = new System.Drawing.Point(12, 196);
            this.btnRetrieveLoan.Name = "btnRetrieveLoan";
            this.btnRetrieveLoan.Size = new System.Drawing.Size(139, 102);
            this.btnRetrieveLoan.TabIndex = 44;
            this.btnRetrieveLoan.Text = "Check Popularity";
            this.btnRetrieveLoan.UseVisualStyleBackColor = false;
            this.btnRetrieveLoan.Click += new System.EventHandler(this.btnRetrieveLoan_Click);
            // 
            // chrtGenrePop
            // 
            this.chrtGenrePop.BackSecondaryColor = System.Drawing.Color.White;
            chartArea1.AxisX2.LineWidth = 0;
            chartArea1.AxisY.LineWidth = 0;
            chartArea1.AxisY2.LineWidth = 0;
            chartArea1.Name = "ChartArea1";
            this.chrtGenrePop.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chrtGenrePop.Legends.Add(legend1);
            this.chrtGenrePop.Location = new System.Drawing.Point(195, 58);
            this.chrtGenrePop.Name = "chrtGenrePop";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.CustomProperties = "MinimumRelativePieSize=50, PieLabelStyle=Outside, PieLineColor=Black";
            series1.Legend = "Legend1";
            series1.Name = "Genres";
            this.chrtGenrePop.Series.Add(series1);
            this.chrtGenrePop.Size = new System.Drawing.Size(593, 380);
            this.chrtGenrePop.TabIndex = 45;
            this.chrtGenrePop.Text = "chart1";
            this.chrtGenrePop.Visible = false;
            // 
            // frmReviewLoans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chrtGenrePop);
            this.Controls.Add(this.btnRetrieveLoan);
            this.Controls.Add(this.lblReview);
            this.Controls.Add(this.mnuAllMainMenu);
            this.Name = "frmReviewLoans";
            this.Text = "frmReviewLoans";
            this.mnuAllMainMenu.ResumeLayout(false);
            this.mnuAllMainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrtGenrePop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuAllMainMenu;
        private System.Windows.Forms.ToolStripMenuItem returnToMainMenuToolStripMenuItem;
        private System.Windows.Forms.Label lblReview;
        private System.Windows.Forms.Button btnRetrieveLoan;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrtGenrePop;
    }
}