namespace ITCompany
{
    partial class MainCompanyWin
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainCompanyWin));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button_IssueOrder = new System.Windows.Forms.Button();
            this.button_OpenReportForm = new System.Windows.Forms.Button();
            this.button_CancelOrder = new System.Windows.Forms.Button();
            this.dataGridView_Employee = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_Employment = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button_CloseApp = new System.Windows.Forms.PictureBox();
            this.button_CloseCompanyWin = new System.Windows.Forms.PictureBox();
            this.label_EmployeeTableInfo = new System.Windows.Forms.Label();
            this.dataGridView_Orders = new System.Windows.Forms.DataGridView();
            this.dataGridView_Employment = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Employee)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.button_CloseApp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_CloseCompanyWin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Orders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Employment)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel1.Controls.Add(this.dataGridView_Orders);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(14, 14);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(564, 214);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel2.Controls.Add(this.label_EmployeeTableInfo);
            this.panel2.Controls.Add(this.dataGridView_Employment);
            this.panel2.Controls.Add(this.label_Employment);
            this.panel2.Location = new System.Drawing.Point(14, 238);
            this.panel2.Margin = new System.Windows.Forms.Padding(5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(263, 201);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel3.Controls.Add(this.button_CancelOrder);
            this.panel3.Controls.Add(this.button_IssueOrder);
            this.panel3.Location = new System.Drawing.Point(14, 449);
            this.panel3.Margin = new System.Windows.Forms.Padding(5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(263, 106);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.dataGridView_Employee);
            this.panel4.Location = new System.Drawing.Point(287, 313);
            this.panel4.Margin = new System.Windows.Forms.Padding(5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(291, 242);
            this.panel4.TabIndex = 3;
            // 
            // button_IssueOrder
            // 
            this.button_IssueOrder.BackColor = System.Drawing.SystemColors.Window;
            this.button_IssueOrder.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_IssueOrder.Location = new System.Drawing.Point(30, 21);
            this.button_IssueOrder.Margin = new System.Windows.Forms.Padding(5);
            this.button_IssueOrder.Name = "button_IssueOrder";
            this.button_IssueOrder.Size = new System.Drawing.Size(80, 68);
            this.button_IssueOrder.TabIndex = 0;
            this.button_IssueOrder.Text = "Issue order";
            this.button_IssueOrder.UseVisualStyleBackColor = false;
            this.button_IssueOrder.Click += new System.EventHandler(this.button_IssueOrder_Click);
            // 
            // button_OpenReportForm
            // 
            this.button_OpenReportForm.BackColor = System.Drawing.SystemColors.Window;
            this.button_OpenReportForm.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_OpenReportForm.Location = new System.Drawing.Point(10, 13);
            this.button_OpenReportForm.Margin = new System.Windows.Forms.Padding(5);
            this.button_OpenReportForm.Name = "button_OpenReportForm";
            this.button_OpenReportForm.Size = new System.Drawing.Size(80, 38);
            this.button_OpenReportForm.TabIndex = 1;
            this.button_OpenReportForm.Text = "Report";
            this.button_OpenReportForm.UseVisualStyleBackColor = false;
            this.button_OpenReportForm.Click += new System.EventHandler(this.button_OpenReportForm_Click);
            // 
            // button_CancelOrder
            // 
            this.button_CancelOrder.BackColor = System.Drawing.SystemColors.Window;
            this.button_CancelOrder.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_CancelOrder.Location = new System.Drawing.Point(159, 21);
            this.button_CancelOrder.Margin = new System.Windows.Forms.Padding(5);
            this.button_CancelOrder.Name = "button_CancelOrder";
            this.button_CancelOrder.Size = new System.Drawing.Size(80, 68);
            this.button_CancelOrder.TabIndex = 2;
            this.button_CancelOrder.Text = "Cancel order";
            this.button_CancelOrder.UseVisualStyleBackColor = false;
            this.button_CancelOrder.Click += new System.EventHandler(this.button_CancelOrder_Click);
            // 
            // dataGridView_Employee
            // 
            this.dataGridView_Employee.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            this.dataGridView_Employee.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridView_Employee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle22.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Employee.DefaultCellStyle = dataGridViewCellStyle22;
            this.dataGridView_Employee.Location = new System.Drawing.Point(10, 55);
            this.dataGridView_Employee.Margin = new System.Windows.Forms.Padding(10);
            this.dataGridView_Employee.Name = "dataGridView_Employee";
            this.dataGridView_Employee.RowHeadersVisible = false;
            this.dataGridView_Employee.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Employee.RowsDefaultCellStyle = dataGridViewCellStyle23;
            this.dataGridView_Employee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Employee.Size = new System.Drawing.Size(271, 177);
            this.dataGridView_Employee.TabIndex = 0;
            this.dataGridView_Employee.SelectionChanged += new System.EventHandler(this.dataGridView_Employee_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(38, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Company Employees";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(183, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Available orders";
            // 
            // label_Employment
            // 
            this.label_Employment.AutoSize = true;
            this.label_Employment.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Employment.Location = new System.Drawing.Point(67, 14);
            this.label_Employment.Name = "label_Employment";
            this.label_Employment.Size = new System.Drawing.Size(130, 24);
            this.label_Employment.TabIndex = 2;
            this.label_Employment.Text = "Employment";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel5.Controls.Add(this.button_CloseCompanyWin);
            this.panel5.Controls.Add(this.button_CloseApp);
            this.panel5.Controls.Add(this.button_OpenReportForm);
            this.panel5.Location = new System.Drawing.Point(287, 238);
            this.panel5.Margin = new System.Windows.Forms.Padding(5);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(291, 64);
            this.panel5.TabIndex = 4;
            // 
            // button_CloseApp
            // 
            this.button_CloseApp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_CloseApp.Image = ((System.Drawing.Image)(resources.GetObject("button_CloseApp.Image")));
            this.button_CloseApp.Location = new System.Drawing.Point(238, 8);
            this.button_CloseApp.Name = "button_CloseApp";
            this.button_CloseApp.Size = new System.Drawing.Size(45, 45);
            this.button_CloseApp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.button_CloseApp.TabIndex = 2;
            this.button_CloseApp.TabStop = false;
            this.button_CloseApp.Click += new System.EventHandler(this.button_CloseApp_Click);
            // 
            // button_CloseCompanyWin
            // 
            this.button_CloseCompanyWin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_CloseCompanyWin.Image = ((System.Drawing.Image)(resources.GetObject("button_CloseCompanyWin.Image")));
            this.button_CloseCompanyWin.Location = new System.Drawing.Point(182, 6);
            this.button_CloseCompanyWin.Name = "button_CloseCompanyWin";
            this.button_CloseCompanyWin.Size = new System.Drawing.Size(50, 50);
            this.button_CloseCompanyWin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.button_CloseCompanyWin.TabIndex = 3;
            this.button_CloseCompanyWin.TabStop = false;
            this.button_CloseCompanyWin.Click += new System.EventHandler(this.button_CloseCompanyWin_Click);
            // 
            // label_EmployeeTableInfo
            // 
            this.label_EmployeeTableInfo.AutoSize = true;
            this.label_EmployeeTableInfo.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label_EmployeeTableInfo.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_EmployeeTableInfo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label_EmployeeTableInfo.Location = new System.Drawing.Point(40, 75);
            this.label_EmployeeTableInfo.MaximumSize = new System.Drawing.Size(180, 0);
            this.label_EmployeeTableInfo.Name = "label_EmployeeTableInfo";
            this.label_EmployeeTableInfo.Size = new System.Drawing.Size(180, 88);
            this.label_EmployeeTableInfo.TabIndex = 3;
            this.label_EmployeeTableInfo.Text = "Select any employee on a company employees table";
            this.label_EmployeeTableInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView_Orders
            // 
            this.dataGridView_Orders.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            this.dataGridView_Orders.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Orders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle24;
            this.dataGridView_Orders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle25.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle25.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle25.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle25.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle25.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Orders.DefaultCellStyle = dataGridViewCellStyle25;
            this.dataGridView_Orders.Location = new System.Drawing.Point(10, 53);
            this.dataGridView_Orders.Margin = new System.Windows.Forms.Padding(10);
            this.dataGridView_Orders.Name = "dataGridView_Orders";
            this.dataGridView_Orders.RowHeadersVisible = false;
            this.dataGridView_Orders.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Orders.RowsDefaultCellStyle = dataGridViewCellStyle26;
            this.dataGridView_Orders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Orders.Size = new System.Drawing.Size(544, 151);
            this.dataGridView_Orders.TabIndex = 2;
            this.dataGridView_Orders.SelectionChanged += new System.EventHandler(this.dataGridView_Orders_SelectionChanged);
            // 
            // dataGridView_Employment
            // 
            this.dataGridView_Employment.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            this.dataGridView_Employment.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridView_Employment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle27.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle27.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle27.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Employment.DefaultCellStyle = dataGridViewCellStyle27;
            this.dataGridView_Employment.Location = new System.Drawing.Point(10, 48);
            this.dataGridView_Employment.Margin = new System.Windows.Forms.Padding(10);
            this.dataGridView_Employment.Name = "dataGridView_Employment";
            this.dataGridView_Employment.RowHeadersVisible = false;
            this.dataGridView_Employment.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle28.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Employment.RowsDefaultCellStyle = dataGridViewCellStyle28;
            this.dataGridView_Employment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Employment.Size = new System.Drawing.Size(243, 143);
            this.dataGridView_Employment.TabIndex = 2;
            // 
            // MainCompanyWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(592, 569);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainCompanyWin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainCompanyWin";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainCompanyWin_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainCompanyWin_MouseMove);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Employee)).EndInit();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.button_CloseApp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_CloseCompanyWin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Orders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Employment)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button_CancelOrder;
        private System.Windows.Forms.Button button_OpenReportForm;
        private System.Windows.Forms.Button button_IssueOrder;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dataGridView_Employee;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_Employment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox button_CloseCompanyWin;
        private System.Windows.Forms.PictureBox button_CloseApp;
        private System.Windows.Forms.Label label_EmployeeTableInfo;
        private System.Windows.Forms.DataGridView dataGridView_Orders;
        private System.Windows.Forms.DataGridView dataGridView_Employment;
    }
}