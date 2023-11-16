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
    public partial class LoginWin : Form
    {
        private Point startPoint = new Point(0, 0);
        private static LoginWin loginWin;
        public static LoginWin GetInstance { get { return loginWin; } }
        public LoginWin()
        {
            loginWin = this;
            InitializeComponent();
            DatabaseConnectionHandler.GetConnection();
            loginWin.BringToFront();
            this.DoubleBuffered = true;
        }
        private void button_CloseLoginWin_Click(object sender, EventArgs e)
        {
            DatabaseConnectionHandler.CloseConnection();
            Environment.Exit(0);
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            if (DatabaseConnectionHandler.ValidateUser($"{textBox_login.Text}", $"{textBox_password.Text}", 'A'))
            {
                //Открываем новое окно в зависимости от роли пользователя
                var window = new MainCompanyWin();
                this.Visible = false;
                window.Show();
                window.BringToFront();

                textBox_login.Clear();
                textBox_password.Clear();
            }
            else if (DatabaseConnectionHandler.ValidateUser($"{textBox_login.Text}", $"{textBox_password.Text}", 'C'))
            {
                var window = new MainCustomerWin();
                this.Visible = false;
                window.Show();
                window.BringToFront();

                textBox_login.Clear();
                textBox_password.Clear();
            }
            else
                MessageBox.Show("Entered wrong login or password!",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void textBox_login_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetterOrDigit(e.KeyChar) || Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void textBox_password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetterOrDigit(e.KeyChar) || Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void LoginWin_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Capture = true;
            }
        }

        private void LoginWin_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.Capture)
            {
                this.Location = new Point(this.Location.X + e.X - this.Width / 2, this.Location.Y + e.Y - this.Height / 2);
            }
        }
    }
}
