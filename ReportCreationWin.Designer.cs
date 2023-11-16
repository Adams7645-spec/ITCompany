namespace ITCompany
{
    partial class ReportCreationWin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportCreationWin));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_ReportName = new System.Windows.Forms.TextBox();
            this.textBox_WorkTitle = new System.Windows.Forms.TextBox();
            this.textBox_MainWorkSpecs = new System.Windows.Forms.TextBox();
            this.textBox_CurrentStatus = new System.Windows.Forms.TextBox();
            this.textBox_AditionalSpecs = new System.Windows.Forms.TextBox();
            this.textBox_WorkStartDate = new System.Windows.Forms.TextBox();
            this.textBox_WorkEndDate = new System.Windows.Forms.TextBox();
            this.button_CloseReportWin = new System.Windows.Forms.PictureBox();
            this.button_CreateReport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.button_CloseReportWin)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(31, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Report name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(31, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Completed work title";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(31, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Completed work specs";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(175, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Current status ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(31, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(207, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Aditional onwork specs";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(31, 329);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "Work start date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(181, 329);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 19);
            this.label7.TabIndex = 6;
            this.label7.Text = "Work end date";
            // 
            // textBox_ReportName
            // 
            this.textBox_ReportName.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox_ReportName.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_ReportName.Location = new System.Drawing.Point(32, 51);
            this.textBox_ReportName.Multiline = true;
            this.textBox_ReportName.Name = "textBox_ReportName";
            this.textBox_ReportName.Size = new System.Drawing.Size(125, 25);
            this.textBox_ReportName.TabIndex = 7;
            this.textBox_ReportName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_WorkTitle
            // 
            this.textBox_WorkTitle.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox_WorkTitle.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_WorkTitle.Location = new System.Drawing.Point(32, 101);
            this.textBox_WorkTitle.Multiline = true;
            this.textBox_WorkTitle.Name = "textBox_WorkTitle";
            this.textBox_WorkTitle.Size = new System.Drawing.Size(275, 26);
            this.textBox_WorkTitle.TabIndex = 7;
            this.textBox_WorkTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_MainWorkSpecs
            // 
            this.textBox_MainWorkSpecs.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox_MainWorkSpecs.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_MainWorkSpecs.Location = new System.Drawing.Point(32, 152);
            this.textBox_MainWorkSpecs.Multiline = true;
            this.textBox_MainWorkSpecs.Name = "textBox_MainWorkSpecs";
            this.textBox_MainWorkSpecs.Size = new System.Drawing.Size(275, 73);
            this.textBox_MainWorkSpecs.TabIndex = 7;
            this.textBox_MainWorkSpecs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_CurrentStatus
            // 
            this.textBox_CurrentStatus.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox_CurrentStatus.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_CurrentStatus.Location = new System.Drawing.Point(179, 52);
            this.textBox_CurrentStatus.Multiline = true;
            this.textBox_CurrentStatus.Name = "textBox_CurrentStatus";
            this.textBox_CurrentStatus.Size = new System.Drawing.Size(128, 24);
            this.textBox_CurrentStatus.TabIndex = 7;
            this.textBox_CurrentStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_AditionalSpecs
            // 
            this.textBox_AditionalSpecs.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox_AditionalSpecs.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_AditionalSpecs.Location = new System.Drawing.Point(32, 250);
            this.textBox_AditionalSpecs.Multiline = true;
            this.textBox_AditionalSpecs.Name = "textBox_AditionalSpecs";
            this.textBox_AditionalSpecs.Size = new System.Drawing.Size(275, 66);
            this.textBox_AditionalSpecs.TabIndex = 7;
            this.textBox_AditionalSpecs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_WorkStartDate
            // 
            this.textBox_WorkStartDate.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox_WorkStartDate.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_WorkStartDate.Location = new System.Drawing.Point(32, 351);
            this.textBox_WorkStartDate.Multiline = true;
            this.textBox_WorkStartDate.Name = "textBox_WorkStartDate";
            this.textBox_WorkStartDate.Size = new System.Drawing.Size(143, 24);
            this.textBox_WorkStartDate.TabIndex = 7;
            this.textBox_WorkStartDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_WorkEndDate
            // 
            this.textBox_WorkEndDate.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox_WorkEndDate.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_WorkEndDate.Location = new System.Drawing.Point(185, 351);
            this.textBox_WorkEndDate.Multiline = true;
            this.textBox_WorkEndDate.Name = "textBox_WorkEndDate";
            this.textBox_WorkEndDate.Size = new System.Drawing.Size(122, 24);
            this.textBox_WorkEndDate.TabIndex = 7;
            this.textBox_WorkEndDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button_CloseReportWin
            // 
            this.button_CloseReportWin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_CloseReportWin.Image = ((System.Drawing.Image)(resources.GetObject("button_CloseReportWin.Image")));
            this.button_CloseReportWin.Location = new System.Drawing.Point(338, 12);
            this.button_CloseReportWin.Name = "button_CloseReportWin";
            this.button_CloseReportWin.Size = new System.Drawing.Size(50, 50);
            this.button_CloseReportWin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.button_CloseReportWin.TabIndex = 8;
            this.button_CloseReportWin.TabStop = false;
            this.button_CloseReportWin.Click += new System.EventHandler(this.button_CloseReportWin_Click);
            // 
            // button_CreateReport
            // 
            this.button_CreateReport.BackColor = System.Drawing.SystemColors.Window;
            this.button_CreateReport.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_CreateReport.Location = new System.Drawing.Point(315, 318);
            this.button_CreateReport.Margin = new System.Windows.Forms.Padding(5);
            this.button_CreateReport.Name = "button_CreateReport";
            this.button_CreateReport.Size = new System.Drawing.Size(73, 68);
            this.button_CreateReport.TabIndex = 9;
            this.button_CreateReport.Text = "Create report";
            this.button_CreateReport.UseVisualStyleBackColor = false;
            this.button_CreateReport.Click += new System.EventHandler(this.button_CreateReport_Click);
            // 
            // ReportCreationWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(400, 400);
            this.Controls.Add(this.button_CreateReport);
            this.Controls.Add(this.button_CloseReportWin);
            this.Controls.Add(this.textBox_WorkEndDate);
            this.Controls.Add(this.textBox_WorkStartDate);
            this.Controls.Add(this.textBox_AditionalSpecs);
            this.Controls.Add(this.textBox_CurrentStatus);
            this.Controls.Add(this.textBox_MainWorkSpecs);
            this.Controls.Add(this.textBox_WorkTitle);
            this.Controls.Add(this.textBox_ReportName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReportCreationWin";
            this.Text = "ReportCreationWin";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ReportCreationWin_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ReportCreationWin_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.button_CloseReportWin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_ReportName;
        private System.Windows.Forms.TextBox textBox_WorkTitle;
        private System.Windows.Forms.TextBox textBox_MainWorkSpecs;
        private System.Windows.Forms.TextBox textBox_CurrentStatus;
        private System.Windows.Forms.TextBox textBox_AditionalSpecs;
        private System.Windows.Forms.TextBox textBox_WorkStartDate;
        private System.Windows.Forms.TextBox textBox_WorkEndDate;
        private System.Windows.Forms.PictureBox button_CloseReportWin;
        private System.Windows.Forms.Button button_CreateReport;
    }
}