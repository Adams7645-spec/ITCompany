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
    public partial class CustomerCreationWin : Form
    {
        public CustomerCreationWin()
        {
            InitializeComponent();
        }

        private void button_CloseReportWin_Click(object sender, EventArgs e)
        {
            this
                .Close();
        }

        private void button_CreateCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                DatabaseConnectionHandler.ExecuteCommand($"insert into Customer (CustomerName, ContactInfo, Specification) values ('{textBox_CustomerName.Text}', '{textBox_ContactInfo.Text}', '{textBox_CustomerSpec.Text}')");
                MessageBox.Show("Customer successfully created!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Something went wrong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
    }
}
