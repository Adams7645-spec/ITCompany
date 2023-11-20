namespace ITCompany
{
    partial class CustomerCreationWin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerCreationWin));
            this.button_CloseReportWin = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_CreateCustomer = new System.Windows.Forms.Button();
            this.textBox_ContactInfo = new System.Windows.Forms.TextBox();
            this.textBox_CustomerName = new System.Windows.Forms.TextBox();
            this.textBox_CustomerSpec = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
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
            this.button_CloseReportWin.TabIndex = 10;
            this.button_CloseReportWin.TabStop = false;
            this.button_CloseReportWin.Click += new System.EventHandler(this.button_CloseReportWin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(25, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 22);
            this.label1.TabIndex = 11;
            this.label1.Text = "Customer name";
            // 
            // button_CreateCustomer
            // 
            this.button_CreateCustomer.BackColor = System.Drawing.SystemColors.Window;
            this.button_CreateCustomer.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_CreateCustomer.Location = new System.Drawing.Point(147, 292);
            this.button_CreateCustomer.Margin = new System.Windows.Forms.Padding(5);
            this.button_CreateCustomer.Name = "button_CreateCustomer";
            this.button_CreateCustomer.Size = new System.Drawing.Size(108, 68);
            this.button_CreateCustomer.TabIndex = 14;
            this.button_CreateCustomer.Text = "Create customer";
            this.button_CreateCustomer.UseVisualStyleBackColor = false;
            this.button_CreateCustomer.Click += new System.EventHandler(this.button_CreateCustomer_Click);
            // 
            // textBox_ContactInfo
            // 
            this.textBox_ContactInfo.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.textBox_ContactInfo.Location = new System.Drawing.Point(29, 171);
            this.textBox_ContactInfo.Margin = new System.Windows.Forms.Padding(25);
            this.textBox_ContactInfo.Name = "textBox_ContactInfo";
            this.textBox_ContactInfo.Size = new System.Drawing.Size(337, 26);
            this.textBox_ContactInfo.TabIndex = 15;
            // 
            // textBox_CustomerName
            // 
            this.textBox_CustomerName.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.textBox_CustomerName.Location = new System.Drawing.Point(29, 105);
            this.textBox_CustomerName.Margin = new System.Windows.Forms.Padding(25);
            this.textBox_CustomerName.Name = "textBox_CustomerName";
            this.textBox_CustomerName.Size = new System.Drawing.Size(337, 26);
            this.textBox_CustomerName.TabIndex = 16;
            // 
            // textBox_CustomerSpec
            // 
            this.textBox_CustomerSpec.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.textBox_CustomerSpec.Location = new System.Drawing.Point(29, 236);
            this.textBox_CustomerSpec.Margin = new System.Windows.Forms.Padding(25);
            this.textBox_CustomerSpec.Name = "textBox_CustomerSpec";
            this.textBox_CustomerSpec.Size = new System.Drawing.Size(337, 26);
            this.textBox_CustomerSpec.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(25, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 22);
            this.label2.TabIndex = 11;
            this.label2.Text = "Contact Information";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(25, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(230, 22);
            this.label3.TabIndex = 11;
            this.label3.Text = "Customer Specification";
            // 
            // CustomerCreationWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(400, 400);
            this.Controls.Add(this.textBox_CustomerSpec);
            this.Controls.Add(this.textBox_CustomerName);
            this.Controls.Add(this.textBox_ContactInfo);
            this.Controls.Add(this.button_CreateCustomer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_CloseReportWin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CustomerCreationWin";
            this.Text = "CustomerCreationWin";
            ((System.ComponentModel.ISupportInitialize)(this.button_CloseReportWin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox button_CloseReportWin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_CreateCustomer;
        private System.Windows.Forms.TextBox textBox_ContactInfo;
        private System.Windows.Forms.TextBox textBox_CustomerName;
        private System.Windows.Forms.TextBox textBox_CustomerSpec;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}