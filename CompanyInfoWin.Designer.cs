namespace ITCompany
{
    partial class CompanyInfoWin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompanyInfoWin));
            this.button_CloseReportWin = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.button_CloseReportWin)).BeginInit();
            this.SuspendLayout();
            // 
            // button_CloseReportWin
            // 
            this.button_CloseReportWin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_CloseReportWin.Image = ((System.Drawing.Image)(resources.GetObject("button_CloseReportWin.Image")));
            this.button_CloseReportWin.Location = new System.Drawing.Point(338, 12);
            this.button_CloseReportWin.Name = "button_CloseReportWin";
            this.button_CloseReportWin.Size = new System.Drawing.Size(50, 50);
            this.button_CloseReportWin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.button_CloseReportWin.TabIndex = 9;
            this.button_CloseReportWin.TabStop = false;
            this.button_CloseReportWin.Click += new System.EventHandler(this.button_CloseReportWin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(90, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "About our company";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(30, 115);
            this.label2.MaximumSize = new System.Drawing.Size(350, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(342, 209);
            this.label2.TabIndex = 10;
            this.label2.Text = resources.GetString("label2.Text");
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CompanyInfoWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(400, 400);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_CloseReportWin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CompanyInfoWin";
            this.Text = "CompanyInfoWin";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ReportCreationWin_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ReportCreationWin_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.button_CloseReportWin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox button_CloseReportWin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}