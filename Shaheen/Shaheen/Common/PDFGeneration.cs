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
        public static void GeneratePDF(string filePath, DataTable dt)
        {
            const int pageMargin = 5;
            const int pageRows = 9;
            const int pageCols = 3;

            Document doc = new Document(PageSize.A4);
            doc.SetMargins(pageMargin, pageMargin, pageMargin, pageMargin);
            var memoryStream = new MemoryStream();

            var pdfWriter = PdfWriter.GetInstance(doc, new FileStream(filePath, FileMode.Create));
            doc.Open();

            PdfPTable table = new PdfPTable(pageCols);
            table.WidthPercentage = 100f;
            table.DefaultCell.Border = 0;

            var baseFont = BaseFont.CreateFont("C:\\Windows\\Fonts\\Rasa-Regular.ttf", BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);

            foreach (DataRow dr in dt.Rows)
            {
                PdfPCell cell = new PdfPCell();
                cell.Border = 0;
                cell.FixedHeight = (doc.PageSize.Height - (pageMargin * 2)) / pageRows;
                cell.VerticalAlignment = Element.ALIGN_LEFT;
                var contents = new Paragraph();
                contents.Alignment = Element.ALIGN_LEFT;
                contents.Add(new Chunk(Convert.ToString(dr["personName"]) + "\n", new Font(baseFont, 12f)));
                contents.Add(new Chunk(Convert.ToString(dr["personAddress"]) + "\n", new Font(baseFont, 10f)));
                if (!string.IsNullOrEmpty(Convert.ToString(dr["areaName"])))
                {
                    contents.Add(new Chunk(Convert.ToString(dr["areaName"]) + ", ", new Font(baseFont, 10f)));
                }

                contents.Add(new Chunk(Convert.ToString(dr["cityName"]), new Font(baseFont, 10f)));
                if (!string.IsNullOrEmpty(Convert.ToString(dr["pin"])))
                {
                    contents.Add(new Chunk(" - " + Convert.ToString(dr["pin"]), new Font(baseFont, 10f)));
                }
                if (!string.IsNullOrEmpty(Convert.ToString(dr["districtName"])))
                {
                    contents.Add(new Chunk("\n" + Convert.ToString(dr["districtName"]) + ", ", new Font(baseFont, 10f)));
                }
                else
                {
                    contents.Add(new Chunk("\n", new Font(baseFont, 10f)));
                }
                if (!string.IsNullOrEmpty(Convert.ToString(dr["stateName"])))
                {
                    contents.Add(new Chunk(Convert.ToString(dr["stateName"]), new Font(baseFont, 10f)));
                }
                cell.AddElement(contents);
                table.AddCell(cell);
            }
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
