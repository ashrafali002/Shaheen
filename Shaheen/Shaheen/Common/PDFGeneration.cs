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

            var baseFont = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, false);
            //var baseFont = BaseFont.CreateFont("C:\\Windows\\Fonts\\Rasa-Regular.ttf", BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);

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

        public static void AddContentToPDF(string filePath, DataTable dt)
        {
            const int pageMargin = 5;
            const int pageCols = 6;

            Document doc = new Document(PageSize.A4);
            doc.SetMargins(pageMargin, pageMargin, pageMargin, pageMargin);
            var memoryStream = new MemoryStream();

            var pdfWriter = PdfWriter.GetInstance(doc, new FileStream(filePath, FileMode.Create));
            doc.Open();

            PdfPTable tableLayout = new PdfPTable(pageCols);
            //tableLayout.WidthPercentage = 100f;
            //tableLayout.DefaultCell.Border = 0;

            float[] headers = { 8, 22, 40, 10, 10, 12 };  //Header Widths
            tableLayout.SetWidths(headers);        //Set the pdf headers
            tableLayout.WidthPercentage = 90;       //Set the PDF File witdh percentage

            //Add Title to the PDF file at the top
            tableLayout.AddCell(new PdfPCell(new Phrase("Agent-wise Report (Shaheen Weekly)", new Font(Font.FontFamily.HELVETICA, 13, 1, new iTextSharp.text.BaseColor(153, 51, 0)))) { Colspan = 6, Border = 0, PaddingTop = 5, PaddingBottom = 5, HorizontalAlignment = Element.ALIGN_CENTER });
            tableLayout.AddCell(new PdfPCell(new Phrase("Agent Name : " + dt.Rows[0]["agentName"] + "", new Font(Font.FontFamily.HELVETICA, 13, 1, new iTextSharp.text.BaseColor(153, 51, 0)))) { Colspan = 6, Border = 0, PaddingTop = 5, PaddingBottom = 5, HorizontalAlignment = Element.ALIGN_CENTER });

            //Add header
            AddCellToHeader(tableLayout, "Code");
            AddCellToHeader(tableLayout, "Name");
            AddCellToHeader(tableLayout, "Address");
            AddCellToHeader(tableLayout, "Last Date");
            AddCellToHeader(tableLayout, "Pending Amount");
            AddCellToHeader(tableLayout, "Contact");
            //Add body

            foreach (DataRow dr in dt.Rows)
            {
                AddCellToBody(tableLayout, Convert.ToString(dr["subscriptionCode"]), Element.ALIGN_CENTER);
                AddCellToBody(tableLayout, Convert.ToString(dr["personName"]), Element.ALIGN_LEFT);
                AddCellToBody(tableLayout, Convert.ToString(dr["personAddress"]), Element.ALIGN_LEFT);
                AddCellToBody(tableLayout, Convert.ToDateTime(dr["subscriptionEndDate"]).ToShortDateString(), Element.ALIGN_LEFT);
                AddCellToBody(tableLayout, Convert.ToString(dr["pendingAmount"]), Element.ALIGN_RIGHT);
                AddCellToBody(tableLayout, Convert.ToString(dr["mobile"]), Element.ALIGN_LEFT);
            }
            doc.Add(tableLayout);
            doc.Close();
        }

        // Method to add single cell to the header
        private static void AddCellToHeader(PdfPTable tableLayout, string cellText)
        {
            tableLayout.AddCell(new PdfPCell(new Phrase(cellText, new Font(Font.FontFamily.HELVETICA, 8, 1, iTextSharp.text.BaseColor.WHITE))) { HorizontalAlignment = Element.ALIGN_CENTER, Padding = 5, BackgroundColor = new iTextSharp.text.BaseColor(0, 51, 102) });
        }

        // Method to add single cell to the body
        private static void AddCellToBody(PdfPTable tableLayout, string cellText, int alignment)
        {
            tableLayout.AddCell(new PdfPCell(new Phrase(cellText, new Font(Font.FontFamily.HELVETICA, 8, 1, iTextSharp.text.BaseColor.BLACK))) { HorizontalAlignment = alignment, Padding = 5, BackgroundColor = iTextSharp.text.BaseColor.WHITE });
        }
    }
}
