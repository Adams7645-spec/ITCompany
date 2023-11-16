using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITCompany
{
    public partial class MainCompanyWin : Form
    {
        private int EmployeeSelectedIndex = 0;
        private int OrderSelectedIndex = 0;
        private static MainCompanyWin CompanyWin;
        public static MainCompanyWin GetInstance { get { return CompanyWin; } }
        public MainCompanyWin()
        {
            InitializeComponent();
            HandleDataGrid();
            CompanyWin = this;
            this.DoubleBuffered = true;
        }
        private void DataGridSettings(DataGridView grid)
        {
            grid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid.AllowUserToAddRows = false;
            grid.AllowUserToDeleteRows = false;
            grid.AllowUserToResizeColumns = false;
            grid.AllowUserToResizeRows = false;
            grid.AllowUserToOrderColumns = false;
            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid.EditMode = DataGridViewEditMode.EditProgrammatically;
            grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        }
        private void HandleDataGrid()
        {
            DataGridSettings(dataGridView_Employee);
            DataGridSettings(dataGridView_Orders);
            DataGridSettings(dataGridView_Employment);

            FillDataGridView(dataGridView_Employee, "SELECT EmployeeID, EmployeeName AS 'Name', JobPosition AS 'Job position' FROM Employee");
            FillDataGridView(dataGridView_Orders, "SELECT OrderID, OrderName as 'Order', Specification as 'Specific', OrderStatus as 'Status' from Order_");

            dataGridView_Employee.Columns["EmployeeID"].Visible = false;
            dataGridView_Orders.Columns["OrderID"].Visible = false;

            foreach (DataGridViewColumn column in dataGridView_Employee.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            foreach (DataGridViewColumn column in dataGridView_Orders.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }
        private void FillDataGridView(DataGridView dataGridView, string query)
        {
            dataGridView.DataSource = DatabaseConnectionHandler.GetDataFromDB(query);
        }
        private void button_CloseApp_Click(object sender, EventArgs e)
        {
            DatabaseConnectionHandler.CloseConnection();
            Environment.Exit(0);
        }

        private void button_CloseCompanyWin_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginWin.GetInstance.Visible = true;
        }

        private void dataGridView_Employee_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView_Employee.Rows.Count != 0 && dataGridView_Employee.SelectedRows.Count > 0)
                EmployeeSelectedIndex = dataGridView_Employee.SelectedRows[0].Index + 1;

            foreach (DataGridViewRow row in dataGridView_Employee.Rows)
            {
                if (Convert.ToInt32(row.Cells["EmployeeID"].Value) == EmployeeSelectedIndex)
                {
                    EmployeeSelectedIndex = Convert.ToInt32(row.Cells["EmployeeID"].Value);
                    break;
                }
            }

            EmploymentDataGridUpdate();
        }
        private void dataGridView_Orders_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView_Orders.SelectedRows.Count > 0)
                OrderSelectedIndex = dataGridView_Orders.SelectedRows[0].Index + 1;

            foreach (DataGridViewRow row in dataGridView_Orders.Rows)
            {
                if (Convert.ToInt32(row.Cells["OrderID"].Value) == OrderSelectedIndex)
                {
                    OrderSelectedIndex = row.Index + 1;
                    break;
                }
            }

            EmploymentDataGridUpdate();
        }

        private void EmploymentDataGridUpdate()
        {
            FillDataGridView(dataGridView_Employment, $"select Order_.OrderName as 'Order', Employee.EmployeeName as Programmer, Order_.OrderStatus as 'Status' from Order_ inner join Employee on Order_.EmployeeID = Employee.EmployeeID where Employee.EmployeeID = {EmployeeSelectedIndex}");

            foreach (DataGridViewColumn column in dataGridView_Employment.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            if (dataGridView_Employment.Rows.Count < 1)
                dataGridView_Employment.DataSource = null;

            if (dataGridView_Employment.DataSource == null)
                label_EmployeeTableInfo.Visible = true;
            else
                label_EmployeeTableInfo.Visible = false;
        }

        private void button_IssueOrder_Click(object sender, EventArgs e)
        {
            DatabaseConnectionHandler.ExecuteCommand($"Update Order_ set EmployeeID = '{EmployeeSelectedIndex}' where OrderID = '{OrderSelectedIndex}'");
            EmploymentDataGridUpdate();
        }

        private void button_CancelOrder_Click(object sender, EventArgs e)
        {
            DatabaseConnectionHandler.ExecuteCommand($"Update Order_ set EmployeeID = null where OrderID = {OrderSelectedIndex}");
            EmploymentDataGridUpdate();
        }

        private void button_OpenReportForm_Click(object sender, EventArgs e)
        {
            var window = new ReportCreationWin();
            window.Show();
        }

        private void MainCompanyWin_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Capture = true;
            }
        }

        private void MainCompanyWin_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.Capture)
            {
                this.Location = new Point(this.Location.X + e.X - this.Width / 2, this.Location.Y + e.Y - this.Height / 2);
            }
        }
    }
}
