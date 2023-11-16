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
    public partial class ReportCreationWin : Form
    {
        public ReportCreationWin()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        private void button_CloseReportWin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private Point startPoint = new Point(0, 0);

        protected override void OnMouseDown(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                startPoint = new Point(e.X, e.Y);
            }
            base.OnMouseDown(e);
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Location = new Point(
                    (this.Location.X - startPoint.X) + e.X, (this.Location.Y - startPoint.Y) + e.Y);

                this.Update();
            }
            base.OnMouseMove(e);
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
        private void button_CreateReport_Click(object sender, EventArgs e)
        {
            try
            {
                var docxTemplateGenerator = new DocxTemplateGenerator($@"E:\Workspace\Folders\{textBox_ReportName.Text}.docx");
                docxTemplateGenerator.CreateDocument(textBox_WorkStartDate.Text,
                    textBox_WorkEndDate.Text, textBox_WorkTitle.Text, textBox_MainWorkSpecs.Text,
                    textBox_AditionalSpecs.Text, textBox_CurrentStatus.Text);
                
                MessageBox.Show("Document successfully created!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                textBox_AditionalSpecs.Clear();
                textBox_CurrentStatus.Clear();
                textBox_MainWorkSpecs.Clear();
                textBox_ReportName.Clear();
                textBox_WorkEndDate.Clear();
                textBox_WorkStartDate.Clear();
                textBox_WorkTitle.Clear();
            }
            catch
            {
                MessageBox.Show("Not all fields is entered", "Error!");
            }
        }
    }
}
