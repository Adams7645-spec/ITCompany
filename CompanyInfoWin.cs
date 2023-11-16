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
    public partial class CompanyInfoWin : Form
    {
        public CompanyInfoWin()
        {
            InitializeComponent();
        }

        private void button_CloseReportWin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ReportCreationWin_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.Capture)
            {
                this.Location = new Point(this.Location.X + e.X - this.Width / 2, this.Location.Y + e.Y - this.Height / 2);
            }
        }

        private void ReportCreationWin_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Capture = true;
            }
        }
    }
}
