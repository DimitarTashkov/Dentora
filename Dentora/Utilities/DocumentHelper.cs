using System.Drawing.Printing;

namespace Dentora.Utilities
{
    public static class DocumentHelper
    {
        private static string _patientName;
        private static string _treatmentName;
        private static string _doctorName;
        private static DateTime _date;

        public static void GeneratePrescription(string patientName, string treatmentName, string doctorName = "Dr. Petrov")
        {
            _patientName = patientName;
            _treatmentName = treatmentName;
            _doctorName = doctorName;
            _date = DateTime.Now;

            PrintDocument printDoc = new PrintDocument();
            printDoc.PrintPage += PrintDoc_PrintPage;

            PrintPreviewDialog previewDialog = new PrintPreviewDialog();
            previewDialog.Document = printDoc;
            previewDialog.ShowDialog();
        }

        private static void PrintDoc_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            Font headerFont = new Font("Segoe UI", 22, FontStyle.Bold);
            Font subHeaderFont = new Font("Segoe UI", 14, FontStyle.Bold);
            Font bodyFont = new Font("Segoe UI", 12);
            Font footerFont = new Font("Segoe UI", 9, FontStyle.Italic);

            Brush darkBrush = Brushes.Black;
            Brush accentBrush = new SolidBrush(Color.FromArgb(0, 150, 136));

            int x = 80;
            int y = 60;

            g.DrawString("DENTORA CLINIC", headerFont, accentBrush, x, y);
            y += 50;
            g.DrawLine(new Pen(Color.FromArgb(0, 150, 136), 2), x, y, 500, y);
            y += 20;

            g.DrawString("Prescription / Receipt", subHeaderFont, darkBrush, x, y);
            y += 40;

            g.DrawString($"Patient:      {_patientName}", bodyFont, darkBrush, x, y);
            y += 30;
            g.DrawString($"Treatment:  {_treatmentName}", bodyFont, darkBrush, x, y);
            y += 30;
            g.DrawString($"Doctor:       {_doctorName}", bodyFont, darkBrush, x, y);
            y += 30;
            g.DrawString($"Date:           {_date:dd MMM yyyy, HH:mm}", bodyFont, darkBrush, x, y);
            y += 50;

            g.DrawLine(new Pen(Color.Gray, 1), x, y, 500, y);
            y += 20;

            g.DrawString("Thank you for choosing Dentora Clinic!", footerFont, darkBrush, x, y);
        }

        private static List<(string Time, string Patient, string Treatment, string Status, string Price)> _reportLines;
        private static string _reportDate;

        public static void GenerateDailyReport(List<(string Time, string Patient, string Treatment, string Status, string Price)> lines, DateTime date)
        {
            _reportLines = lines;
            _reportDate = date.ToString("dd MMM yyyy");

            PrintDocument printDoc = new PrintDocument();
            printDoc.PrintPage += ReportDoc_PrintPage;

            PrintPreviewDialog previewDialog = new PrintPreviewDialog();
            previewDialog.Document = printDoc;
            previewDialog.ShowDialog();
        }

        private static void ReportDoc_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            Font headerFont = new Font("Segoe UI", 22, FontStyle.Bold);
            Font subHeaderFont = new Font("Segoe UI", 14, FontStyle.Bold);
            Font colHeaderFont = new Font("Segoe UI", 10, FontStyle.Bold);
            Font bodyFont = new Font("Segoe UI", 10);
            Font footerFont = new Font("Segoe UI", 9, FontStyle.Italic);

            Brush darkBrush = Brushes.Black;
            Brush accentBrush = new SolidBrush(Color.FromArgb(0, 150, 136));
            Pen linePen = new Pen(Color.FromArgb(0, 150, 136), 2);

            int x = 60;
            int y = 50;

            g.DrawString("DENTORA CLINIC", headerFont, accentBrush, x, y);
            y += 50;
            g.DrawLine(linePen, x, y, 550, y);
            y += 20;

            g.DrawString($"Daily Report \u2014 {_reportDate}", subHeaderFont, darkBrush, x, y);
            y += 40;

            // Column headers
            g.DrawString("Time", colHeaderFont, accentBrush, x, y);
            g.DrawString("Patient", colHeaderFont, accentBrush, x + 70, y);
            g.DrawString("Treatment", colHeaderFont, accentBrush, x + 200, y);
            g.DrawString("Status", colHeaderFont, accentBrush, x + 370, y);
            g.DrawString("Price", colHeaderFont, accentBrush, x + 450, y);
            y += 25;
            g.DrawLine(new Pen(Color.Gray, 1), x, y, 550, y);
            y += 5;

            if (_reportLines.Count == 0)
            {
                y += 10;
                g.DrawString("No appointments for this day.", bodyFont, darkBrush, x, y);
            }
            else
            {
                foreach (var line in _reportLines)
                {
                    g.DrawString(line.Time, bodyFont, darkBrush, x, y);
                    g.DrawString(line.Patient, bodyFont, darkBrush, x + 70, y);
                    g.DrawString(line.Treatment, bodyFont, darkBrush, x + 200, y);
                    g.DrawString(line.Status, bodyFont, darkBrush, x + 370, y);
                    g.DrawString(line.Price, bodyFont, darkBrush, x + 450, y);
                    y += 22;
                }
            }

            y += 20;
            g.DrawLine(new Pen(Color.Gray, 1), x, y, 550, y);
            y += 15;
            g.DrawString($"Total appointments: {_reportLines.Count}", bodyFont, darkBrush, x, y);
            y += 30;
            g.DrawString("Generated by Dentora Clinic Management System", footerFont, darkBrush, x, y);
        }
    }
}
