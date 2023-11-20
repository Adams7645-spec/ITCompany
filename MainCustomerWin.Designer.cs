namespace ITCompany
{
    partial class MainCustomerWin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainCustomerWin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_OrderName = new System.Windows.Forms.TextBox();
            this.textBox_OrderSpecification = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button_ClearFields = new System.Windows.Forms.Button();
            this.button_AddOrderToCustomer = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button_AddCustomer = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView_Customers = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button_ShowInfo = new System.Windows.Forms.PictureBox();
            this.button_CloseCustomerWin = new System.Windows.Forms.PictureBox();
            this.button_CloseApp = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.button_AddCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Customers)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.button_ShowInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_CloseCustomerWin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_CloseApp)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox_OrderName);
            this.panel1.Controls.Add(this.textBox_OrderSpecification);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(14, 14);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(357, 541);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 15.75F);
            this.label2.Location = new System.Drawing.Point(66, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Order specification";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 15.75F);
            this.label1.Location = new System.Drawing.Point(76, 13);
            this.label1.MaximumSize = new System.Drawing.Size(250, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 48);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter the name of your order";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_OrderName
            // 
            this.textBox_OrderName.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.textBox_OrderName.Location = new System.Drawing.Point(10, 78);
            this.textBox_OrderName.Margin = new System.Windows.Forms.Padding(25);
            this.textBox_OrderName.Name = "textBox_OrderName";
            this.textBox_OrderName.Size = new System.Drawing.Size(337, 26);
            this.textBox_OrderName.TabIndex = 2;
            // 
            // textBox_OrderSpecification
            // 
            this.textBox_OrderSpecification.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.textBox_OrderSpecification.Location = new System.Drawing.Point(10, 163);
            this.textBox_OrderSpecification.Margin = new System.Windows.Forms.Padding(25);
            this.textBox_OrderSpecification.Multiline = true;
            this.textBox_OrderSpecification.Name = "textBox_OrderSpecification";
            this.textBox_OrderSpecification.Size = new System.Drawing.Size(337, 285);
            this.textBox_OrderSpecification.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel3.Controls.Add(this.button_ClearFields);
            this.panel3.Controls.Add(this.button_AddOrderToCustomer);
            this.panel3.Location = new System.Drawing.Point(10, 458);
            this.panel3.Margin = new System.Windows.Forms.Padding(15);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(337, 73);
            this.panel3.TabIndex = 0;
            // 
            // button_ClearFields
            // 
            this.button_ClearFields.AutoSize = true;
            this.button_ClearFields.BackColor = System.Drawing.SystemColors.Window;
            this.button_ClearFields.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.button_ClearFields.Location = new System.Drawing.Point(123, 18);
            this.button_ClearFields.Name = "button_ClearFields";
            this.button_ClearFields.Size = new System.Drawing.Size(127, 41);
            this.button_ClearFields.TabIndex = 1;
            this.button_ClearFields.Text = "Clear fields";
            this.button_ClearFields.UseVisualStyleBackColor = false;
            this.button_ClearFields.Click += new System.EventHandler(this.button_ClearFields_Click);
            // 
            // button_AddOrderToCustomer
            // 
            this.button_AddOrderToCustomer.AutoSize = true;
            this.button_AddOrderToCustomer.BackColor = System.Drawing.SystemColors.Window;
            this.button_AddOrderToCustomer.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.button_AddOrderToCustomer.Location = new System.Drawing.Point(17, 18);
            this.button_AddOrderToCustomer.Name = "button_AddOrderToCustomer";
            this.button_AddOrderToCustomer.Size = new System.Drawing.Size(100, 41);
            this.button_AddOrderToCustomer.TabIndex = 0;
            this.button_AddOrderToCustomer.Text = "Add order";
            this.button_AddOrderToCustomer.UseVisualStyleBackColor = false;
            this.button_AddOrderToCustomer.Click += new System.EventHandler(this.button_AddOrderToCustomer_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel2.Controls.Add(this.button_AddCustomer);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.dataGridView_Customers);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(381, 83);
            this.panel2.Margin = new System.Windows.Forms.Padding(5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(197, 472);
            this.panel2.TabIndex = 1;
            // 
            // button_AddCustomer
            // 
            this.button_AddCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_AddCustomer.Image = ((System.Drawing.Image)(resources.GetObject("button_AddCustomer.Image")));
            this.button_AddCustomer.Location = new System.Drawing.Point(72, 407);
            this.button_AddCustomer.Name = "button_AddCustomer";
            this.button_AddCustomer.Size = new System.Drawing.Size(50, 50);
            this.button_AddCustomer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.button_AddCustomer.TabIndex = 6;
            this.button_AddCustomer.TabStop = false;
            this.button_AddCustomer.Click += new System.EventHandler(this.button_AddCustomer_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 15.75F);
            this.label4.Location = new System.Drawing.Point(49, 352);
            this.label4.MaximumSize = new System.Drawing.Size(150, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 48);
            this.label4.TabIndex = 3;
            this.label4.Text = "Create customer";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView_Customers
            // 
            this.dataGridView_Customers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Customers.Location = new System.Drawing.Point(10, 73);
            this.dataGridView_Customers.Margin = new System.Windows.Forms.Padding(15);
            this.dataGridView_Customers.Name = "dataGridView_Customers";
            this.dataGridView_Customers.RowHeadersVisible = false;
            this.dataGridView_Customers.Size = new System.Drawing.Size(177, 264);
            this.dataGridView_Customers.TabIndex = 1;
            this.dataGridView_Customers.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 15.75F);
            this.label3.Location = new System.Drawing.Point(42, 10);
            this.label3.MaximumSize = new System.Drawing.Size(150, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 48);
            this.label3.TabIndex = 0;
            this.label3.Text = "Change of customer";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel4.Controls.Add(this.button_ShowInfo);
            this.panel4.Controls.Add(this.button_CloseCustomerWin);
            this.panel4.Controls.Add(this.button_CloseApp);
            this.panel4.Location = new System.Drawing.Point(381, 14);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(197, 61);
            this.panel4.TabIndex = 2;
            // 
            // button_ShowInfo
            // 
            this.button_ShowInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_ShowInfo.Image = ((System.Drawing.Image)(resources.GetObject("button_ShowInfo.Image")));
            this.button_ShowInfo.Location = new System.Drawing.Point(10, 6);
            this.button_ShowInfo.Name = "button_ShowInfo";
            this.button_ShowInfo.Size = new System.Drawing.Size(48, 48);
            this.button_ShowInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.button_ShowInfo.TabIndex = 7;
            this.button_ShowInfo.TabStop = false;
            this.button_ShowInfo.Click += new System.EventHandler(this.button_ShowInfo_Click);
            // 
            // button_CloseCustomerWin
            // 
            this.button_CloseCustomerWin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_CloseCustomerWin.Image = ((System.Drawing.Image)(resources.GetObject("button_CloseCustomerWin.Image")));
            this.button_CloseCustomerWin.Location = new System.Drawing.Point(75, 6);
            this.button_CloseCustomerWin.Name = "button_CloseCustomerWin";
            this.button_CloseCustomerWin.Size = new System.Drawing.Size(50, 50);
            this.button_CloseCustomerWin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.button_CloseCustomerWin.TabIndex = 5;
            this.button_CloseCustomerWin.TabStop = false;
            this.button_CloseCustomerWin.Click += new System.EventHandler(this.button_CloseCustomerWin_Click);
            // 
            // button_CloseApp
            // 
            this.button_CloseApp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_CloseApp.Image = ((System.Drawing.Image)(resources.GetObject("button_CloseApp.Image")));
            this.button_CloseApp.Location = new System.Drawing.Point(142, 8);
            this.button_CloseApp.Name = "button_CloseApp";
            this.button_CloseApp.Size = new System.Drawing.Size(45, 45);
            this.button_CloseApp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.button_CloseApp.TabIndex = 4;
            this.button_CloseApp.TabStop = false;
            this.button_CloseApp.Click += new System.EventHandler(this.button_CloseApp_Click);
            // 
            // MainCustomerWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(592, 569);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainCustomerWin";
            this.Text = "MainCustomerWin";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.button_AddCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Customers)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.button_ShowInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_CloseCustomerWin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_CloseApp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_OrderName;
        private System.Windows.Forms.TextBox textBox_OrderSpecification;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView_Customers;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_AddOrderToCustomer;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox button_CloseCustomerWin;
        private System.Windows.Forms.PictureBox button_CloseApp;
        private System.Windows.Forms.PictureBox button_AddCustomer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox button_ShowInfo;
        private System.Windows.Forms.Button button_ClearFields;
    }
}