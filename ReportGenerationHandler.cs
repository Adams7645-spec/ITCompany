using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;

namespace ITCompany
{
    public class DocxTemplateGenerator
    {
        private string _filePath;
        private MainDocumentPart _mainPart;

        public DocxTemplateGenerator(string filePath)
        {
            _filePath = filePath;
        }

        public void CreateDocument(
            string startDate,
            string endDate,
            string projectName,
            string taskDescription,
            string additionalCriteria,
            string status)
        {
            using (WordprocessingDocument document = WordprocessingDocument.Create(_filePath, WordprocessingDocumentType.Document))
            {
                _mainPart = document.AddMainDocumentPart();
                _mainPart.Document = new Document();
                Body body = _mainPart.Document.AppendChild(new Body());

                Paragraph paragraph = body.AppendChild(new Paragraph());
                Run run = paragraph.AppendChild(new Run());
                run.AppendChild(new Text("Отчет о работе над проектом:"));

                paragraph = body.AppendChild(new Paragraph());
                run = paragraph.AppendChild(new Run());
                run.AppendChild(new Text($"Начало работы: {startDate}"));

                paragraph = body.AppendChild(new Paragraph());
                run = paragraph.AppendChild(new Run());
                run.AppendChild(new Text($"Окончание работы: {endDate}"));

                paragraph = body.AppendChild(new Paragraph());
                run = paragraph.AppendChild(new Run());
                run.AppendChild(new Text($"Название работы: {projectName}"));

                paragraph = body.AppendChild(new Paragraph());
                run = paragraph.AppendChild(new Run());
                run.AppendChild(new Text($"Описание задачи: {taskDescription}"));

                paragraph = body.AppendChild(new Paragraph());
                run = paragraph.AppendChild(new Run());
                run.AppendChild(new Text($"Дополнительные критерии: {additionalCriteria}"));

                paragraph = body.AppendChild(new Paragraph());
                run = paragraph.AppendChild(new Run());
                run.AppendChild(new Text($"Статус выполнения: {status}"));
            }
        }

        public void GenerateReport(string text)
        {
            using (WordprocessingDocument document = WordprocessingDocument.Open(_filePath, true))
            {
                _mainPart = document.MainDocumentPart;
                Body body = _mainPart.Document.Body;
                Paragraph paragraph = body.AppendChild(new Paragraph());
                Run run = paragraph.AppendChild(new Run());
                run.AppendChild(new Text(text));
            }
        }
    }
}
