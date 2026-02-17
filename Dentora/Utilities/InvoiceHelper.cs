using System.Drawing.Printing;

namespace Dentora.Utilities
{
    public static class DocumentHelper
    {
        private static string _patientName;
        private static string _treatmentName;
        private static string _doctorName;
        private static DateTime _date;

        public static void GeneratePrescription(string patientName, string treatmentName, string doctorName = "Dr. Admin")
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
    }
}
