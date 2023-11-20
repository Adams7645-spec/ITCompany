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
            var reportBoxList = new List<TextBox> 
            {
                textBox_ReportName,
                textBox_WorkStartDate,
                textBox_WorkEndDate,
                textBox_WorkTitle,
                textBox_MainWorkSpecs,
                textBox_AditionalSpecs,
                textBox_CurrentStatus
            };
            var tempFlag = false;

            foreach (var reportBox in reportBoxList)
                if (!string.IsNullOrWhiteSpace(reportBox.Text))
                    tempFlag = true;

            if (tempFlag)
            {
                // Записываем созданный ниже документ в базу документов

                //var query = "";
                //DatabaseConnectionHandler.ExecuteCommand(query);

                // Создаем новый отчет, прикрепляя id созданного в базе документа 

                var docxTemplateGenerator = new DocxTemplateGenerator($@"E:\Workspace\Folders\{textBox_ReportName.Text}.docx");
                docxTemplateGenerator.CreateDocument(textBox_WorkStartDate.Text,
                    textBox_WorkEndDate.Text, textBox_WorkTitle.Text, textBox_MainWorkSpecs.Text,
                    textBox_AditionalSpecs.Text, textBox_CurrentStatus.Text);
                MessageBox.Show("Report successfully created!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Not all fields is entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            foreach (var reportBox in reportBoxList)
                reportBox.Clear();
        }
    }
}
