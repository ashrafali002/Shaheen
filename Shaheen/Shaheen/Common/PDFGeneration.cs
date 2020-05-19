using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shaheen
{
    public class PDFGeneration
    {
        public void GeneratePDF(string filePath, DataTable dt)
        {
            const int pageMargin = 5;
            const int pageRows = 5;
            const int pageCols = 2;

            Document doc = new Document(PageSize.A4);
            doc.SetMargins(pageMargin, pageMargin, pageMargin, pageMargin);
            var memoryStream = new MemoryStream();

            var pdfWriter = PdfWriter.GetInstance(doc, new FileStream(filePath, FileMode.Create));
            doc.Open();

            PdfPTable table = new PdfPTable(pageCols);
            table.WidthPercentage = 100f;
            table.DefaultCell.Border = 0;

            var baseFont = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, false);


            PdfPCell cell = new PdfPCell();
            cell.Border = 0;
            cell.FixedHeight = (doc.PageSize.Height - (pageMargin * 2)) / pageRows;
            cell.VerticalAlignment = Element.ALIGN_LEFT;
            var contents = new Paragraph();
            contents.Alignment = Element.ALIGN_LEFT;
            contents.Add(new Chunk(string.Format("Thing #{0}\n", "MohammedAshrafali Ansari"), new Font(baseFont, 11f, Font.BOLD)));
            contents.Add(new Chunk(string.Format("Thing Name: {0}\n", "Ahmedabad"), new Font(baseFont, 8f)));
            cell.AddElement(contents);
            table.AddCell(cell);

            PdfPCell cell1 = new PdfPCell();
            cell1.Border = 0;
            cell1.FixedHeight = (doc.PageSize.Height - (pageMargin * 2)) / pageRows;
            cell1.VerticalAlignment = Element.ALIGN_LEFT;
            var contents1 = new Paragraph();
            contents1.Alignment = Element.ALIGN_LEFT;
            contents1.Add(new Chunk(string.Format("Thing #{0}\n", "Danish Afzal Asgharali Ansari"), new Font(baseFont, 11f, Font.BOLD)));
            contents1.Add(new Chunk(string.Format("Thing Name: {0}\n", "Baroda"), new Font(baseFont, 8f)));
            cell1.AddElement(contents1);
            table.AddCell(cell1);

            PdfPCell cell2 = new PdfPCell();
            cell2.Border = 0;
            cell2.FixedHeight = (doc.PageSize.Height - (pageMargin * 2)) / pageRows;
            cell2.VerticalAlignment = Element.ALIGN_MIDDLE;
            var contents2 = new Paragraph();
            contents2.Alignment = Element.ALIGN_CENTER;
            contents2.Add(new Chunk(string.Format("Thing #{0}\n", "Ab.Razzaq Shaikh"), new Font(baseFont, 11f, Font.BOLD)));
            contents2.Add(new Chunk(string.Format("Thing Name: {0}\n", "Shahpur"), new Font(baseFont, 8f)));
            cell.AddElement(contents);
            table.AddCell(cell2);

            table.CompleteRow();
            doc.Add(table);

            doc.Close();
        }

        public PdfPTable AddContentToPDF(PdfPTable tableLayout)
        {
            float[] headers = { 20, 20, 30, 30 };  //Header Widths
            tableLayout.SetWidths(headers);        //Set the pdf headers
            tableLayout.WidthPercentage = 80;       //Set the PDF File witdh percentage

            //Add Title to the PDF file at the top
            tableLayout.AddCell(new PdfPCell(new Phrase("Creating PDF file using iTextsharp", new Font(Font.FontFamily.HELVETICA, 13, 1, new iTextSharp.text.BaseColor(153, 51, 0)))) { Colspan = 4, Border = 0, PaddingBottom = 20, HorizontalAlignment = Element.ALIGN_CENTER });

            //Add header
            AddCellToHeader(tableLayout, "Cricketer Name");
            AddCellToHeader(tableLayout, "Height");
            AddCellToHeader(tableLayout, "Born On");
            AddCellToHeader(tableLayout, "Parents");

            //Add body
            AddCellToBody(tableLayout, "Sachin Tendulkar");
            AddCellToBody(tableLayout, "1.65 m");
            AddCellToBody(tableLayout, "April 24, 1973");
            AddCellToBody(tableLayout, "Ramesh Tendulkar, Rajni Tendulkar");

            AddCellToBody(tableLayout, "Mahendra Singh Dhoni");
            AddCellToBody(tableLayout, "1.75 m");
            AddCellToBody(tableLayout, "July 7, 1981");
            AddCellToBody(tableLayout, "Devki Devi, Pan Singh");

            AddCellToBody(tableLayout, "Virender Sehwag");
            AddCellToBody(tableLayout, "1.70 m");
            AddCellToBody(tableLayout, "October 20, 1978");
            AddCellToBody(tableLayout, "Aryavir Sehwag, Vedant Sehwag");

            AddCellToBody(tableLayout, "Virat Kohli");
            AddCellToBody(tableLayout, "1.75 m");
            AddCellToBody(tableLayout, "November 5, 1988");
            AddCellToBody(tableLayout, "Saroj Kohli, Prem Kohli");

            return tableLayout;
        }

        // Method to add single cell to the header
        private static void AddCellToHeader(PdfPTable tableLayout, string cellText)
        {
            tableLayout.AddCell(new PdfPCell(new Phrase(cellText, new Font(Font.FontFamily.HELVETICA, 8, 1, iTextSharp.text.BaseColor.WHITE))) { HorizontalAlignment = Element.ALIGN_CENTER, Padding = 5, BackgroundColor = new iTextSharp.text.BaseColor(0, 51, 102) });
        }

        // Method to add single cell to the body
        private static void AddCellToBody(PdfPTable tableLayout, string cellText)
        {
            tableLayout.AddCell(new PdfPCell(new Phrase(cellText, new Font(Font.FontFamily.HELVETICA, 8, 1, iTextSharp.text.BaseColor.BLACK))) { HorizontalAlignment = Element.ALIGN_CENTER, Padding = 5, BackgroundColor = iTextSharp.text.BaseColor.WHITE });
        }
    }
}
