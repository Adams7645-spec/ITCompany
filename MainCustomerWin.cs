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
    public partial class MainCustomerWin : Form
    {
        private int CustomerSelectedIndex = 0;
        public MainCustomerWin()
        {
            InitializeComponent();
            HandleDataGrid();
        }

        private void button_CloseApp_Click(object sender, EventArgs e)
        {
            DatabaseConnectionHandler.CloseConnection();
            Environment.Exit(0);
        }

        private void button_CloseCustomerWin_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginWin.GetInstance.Visible = true;
        }

        private void button_ShowInfo_Click(object sender, EventArgs e)
        {
            var window = new CompanyInfoWin();
            window.Show();
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
        private void FillDataGridView(DataGridView dataGridView, string query)
        {
            dataGridView.DataSource = DatabaseConnectionHandler.GetDataFromDB(query);
        }
        private void HandleDataGrid()
        {
            DataGridSettings(dataGridView_Customers);

            FillDataGridView(dataGridView_Customers, "SELECT CustomerID, CustomerName AS 'Name', ContactInfo AS 'Contact' FROM Customer");

            dataGridView_Customers.Columns["CustomerID"].Visible = false;

            foreach (DataGridViewColumn column in dataGridView_Customers.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView_Customers.SelectedRows.Count > 0)
                CustomerSelectedIndex = dataGridView_Customers.SelectedRows[0].Index + 1;

            foreach (DataGridViewRow row in dataGridView_Customers.Rows)
            {
                if (Convert.ToInt32(row.Cells["CustomerID"].Value) == CustomerSelectedIndex)
                {
                    CustomerSelectedIndex = row.Index + 1;
                    break;
                }
            }
        }

        private void button_AddCustomer_Click(object sender, EventArgs e)
        {
            var window = new CustomerCreationWin();
            window.Show();
        }

        private void button_AddOrderToCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                DatabaseConnectionHandler.ExecuteCommand($"insert into Order_ (OrderName, Specification, OrderStatus, CustomerID) values ('{textBox_OrderName.Text}', '{textBox_OrderSpecification.Text}', 'Pending', {CustomerSelectedIndex})");
                MessageBox.Show("Customer successfully created!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Something went wrong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void button_ClearFields_Click(object sender, EventArgs e)
        {
            textBox_OrderName.Clear();
            textBox_OrderSpecification.Clear();
        }
    }
}
