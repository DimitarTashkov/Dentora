using Dentora.Utilities;

namespace Dentora.Forms
{
    partial class BookAppointment
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing) { if (disposing && (components != null)) components.Dispose(); base.Dispose(disposing); }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            pnlSidebar = SidebarHelper.CreateClientSidebarPanel("Book");
            pnlContent = new Panel();
            lblHeader = new Label();
            lblSelectTreatment = new Label(); cmbTreatment = new ComboBox();
            lblSelectDoctor = new Label(); cmbDoctor = new ComboBox();
            pnlTreatmentPreview = new Panel();
            picTreatment = new PictureBox();
            lblTreatmentDesc = new Label();
            lblSelectDate = new Label(); dtpDate = new DateTimePicker();
            lblSelectTime = new Label(); dtpTime = new DateTimePicker();
            pnlSummary = new Panel();
            lblDuration = new Label(); lblDurationValue = new Label();
            lblPrice = new Label(); lblPriceValue = new Label();
            btnBook = new Button();
            pnlContent.SuspendLayout();
            pnlTreatmentPreview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picTreatment).BeginInit();
            pnlSummary.SuspendLayout();
            SuspendLayout();
            // pnlContent
            pnlContent.BackgroundImage = Properties.Resources.app_backround; pnlContent.BackgroundImageLayout = ImageLayout.Stretch; pnlContent.Location = new Point(220, 0); pnlContent.Name = "pnlContent"; pnlContent.Size = new Size(830, 650); pnlContent.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlContent.Controls.Add(lblHeader); pnlContent.Controls.Add(lblSelectTreatment); pnlContent.Controls.Add(cmbTreatment); pnlContent.Controls.Add(lblSelectDoctor); pnlContent.Controls.Add(cmbDoctor); pnlContent.Controls.Add(pnlTreatmentPreview); pnlContent.Controls.Add(lblSelectDate); pnlContent.Controls.Add(dtpDate); pnlContent.Controls.Add(lblSelectTime); pnlContent.Controls.Add(dtpTime); pnlContent.Controls.Add(pnlSummary); pnlContent.Controls.Add(btnBook);
            // lblHeader
            lblHeader.BackColor = Color.Transparent; lblHeader.Font = new Font("Segoe UI", 18F, FontStyle.Bold); lblHeader.ForeColor = Color.FromArgb(0, 150, 136); lblHeader.Location = new Point(25, 15); lblHeader.Size = new Size(500, 45); lblHeader.Text = "\U0001F4C5 Book an Appointment";
            // lblSelectTreatment
            lblSelectTreatment.AutoSize = true; lblSelectTreatment.BackColor = Color.Transparent; lblSelectTreatment.Font = new Font("Segoe UI", 12F, FontStyle.Bold); lblSelectTreatment.ForeColor = Color.White; lblSelectTreatment.Location = new Point(30, 75); lblSelectTreatment.Text = "\U0001F9B7 Select Treatment:";
            // cmbTreatment
            cmbTreatment.Font = new Font("Segoe UI", 11F); cmbTreatment.Location = new Point(30, 102); cmbTreatment.Size = new Size(360, 30); cmbTreatment.DropDownStyle = ComboBoxStyle.DropDownList; cmbTreatment.SelectedIndexChanged += cmbTreatment_SelectedIndexChanged;
            // lblSelectDoctor
            lblSelectDoctor.AutoSize = true; lblSelectDoctor.BackColor = Color.Transparent; lblSelectDoctor.Font = new Font("Segoe UI", 12F, FontStyle.Bold); lblSelectDoctor.ForeColor = Color.White; lblSelectDoctor.Location = new Point(30, 145); lblSelectDoctor.Text = "\U0001FA7A Select Doctor:";
            // cmbDoctor
            cmbDoctor.Font = new Font("Segoe UI", 11F); cmbDoctor.Location = new Point(30, 172); cmbDoctor.Size = new Size(360, 30); cmbDoctor.DropDownStyle = ComboBoxStyle.DropDownList;
            // pnlTreatmentPreview
            pnlTreatmentPreview.BackColor = Color.FromArgb(35, 35, 35); pnlTreatmentPreview.Location = new Point(420, 75); pnlTreatmentPreview.Size = new Size(370, 310); pnlTreatmentPreview.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pnlTreatmentPreview.Controls.Add(picTreatment); pnlTreatmentPreview.Controls.Add(lblTreatmentDesc);
            // picTreatment
            picTreatment.Location = new Point(10, 10); picTreatment.Size = new Size(350, 220); picTreatment.SizeMode = PictureBoxSizeMode.Zoom; picTreatment.BackColor = Color.FromArgb(28, 28, 28);
            // lblTreatmentDesc
            lblTreatmentDesc.Font = new Font("Segoe UI", 9.5F); lblTreatmentDesc.ForeColor = Color.FromArgb(190, 190, 190); lblTreatmentDesc.Location = new Point(10, 238); lblTreatmentDesc.Size = new Size(350, 62); lblTreatmentDesc.Text = "Select a treatment to see details.";
            // lblSelectDate
            lblSelectDate.AutoSize = true; lblSelectDate.BackColor = Color.Transparent; lblSelectDate.Font = new Font("Segoe UI", 12F, FontStyle.Bold); lblSelectDate.ForeColor = Color.White; lblSelectDate.Location = new Point(30, 220); lblSelectDate.Text = "\U0001F4C6 Select Date:";
            // dtpDate
            dtpDate.Font = new Font("Segoe UI", 11F); dtpDate.Location = new Point(30, 248); dtpDate.Size = new Size(230, 30); dtpDate.Format = DateTimePickerFormat.Short;
            // lblSelectTime
            lblSelectTime.AutoSize = true; lblSelectTime.BackColor = Color.Transparent; lblSelectTime.Font = new Font("Segoe UI", 12F, FontStyle.Bold); lblSelectTime.ForeColor = Color.White; lblSelectTime.Location = new Point(30, 295); lblSelectTime.Text = "\u23F0 Select Time:";
            // dtpTime
            dtpTime.Font = new Font("Segoe UI", 11F); dtpTime.Location = new Point(30, 323); dtpTime.Size = new Size(160, 30); dtpTime.Format = DateTimePickerFormat.Time; dtpTime.ShowUpDown = true;
            // pnlSummary
            pnlSummary.BackColor = Color.FromArgb(35, 35, 35); pnlSummary.Location = new Point(30, 370); pnlSummary.Size = new Size(360, 80);
            pnlSummary.Controls.Add(lblDuration); pnlSummary.Controls.Add(lblDurationValue); pnlSummary.Controls.Add(lblPrice); pnlSummary.Controls.Add(lblPriceValue);
            // lblDuration
            lblDuration.BackColor = Color.Transparent; lblDuration.Font = new Font("Segoe UI", 11F, FontStyle.Bold); lblDuration.ForeColor = Color.White; lblDuration.Location = new Point(15, 12); lblDuration.AutoSize = true; lblDuration.Text = "\u23F1 Duration:";
            // lblDurationValue
            lblDurationValue.BackColor = Color.Transparent; lblDurationValue.Font = new Font("Segoe UI", 11F, FontStyle.Bold); lblDurationValue.ForeColor = Color.FromArgb(0, 200, 180); lblDurationValue.Location = new Point(155, 12); lblDurationValue.AutoSize = true; lblDurationValue.Text = "0 min";
            // lblPrice
            lblPrice.BackColor = Color.Transparent; lblPrice.Font = new Font("Segoe UI", 11F, FontStyle.Bold); lblPrice.ForeColor = Color.White; lblPrice.Location = new Point(15, 45); lblPrice.AutoSize = true; lblPrice.Text = "\U0001F4B0 Total Price:";
            // lblPriceValue
            lblPriceValue.BackColor = Color.Transparent; lblPriceValue.Font = new Font("Segoe UI", 14F, FontStyle.Bold); lblPriceValue.ForeColor = Color.FromArgb(0, 200, 180); lblPriceValue.Location = new Point(155, 40); lblPriceValue.AutoSize = true; lblPriceValue.Text = "0.00";
            // btnBook
            btnBook.BackColor = Color.FromArgb(0, 150, 136); btnBook.FlatStyle = FlatStyle.Flat; btnBook.FlatAppearance.BorderSize = 0; btnBook.Font = new Font("Segoe UI", 13F, FontStyle.Bold); btnBook.ForeColor = Color.White; btnBook.Location = new Point(30, 470); btnBook.Size = new Size(220, 55); btnBook.Text = "\u2705 Confirm Booking"; btnBook.Cursor = Cursors.Hand; btnBook.Click += btnBook_Click;
            // BookAppointment
            AutoScaleDimensions = new SizeF(8F, 20F); AutoScaleMode = AutoScaleMode.Font; ClientSize = new Size(1050, 650); Controls.Add(pnlSidebar); Controls.Add(pnlContent); DoubleBuffered = true; Icon = Icon.FromHandle(Properties.Resources.dentora_logo1.GetHicon()); Name = "BookAppointment"; StartPosition = FormStartPosition.CenterScreen; Text = "Dentora - Book Appointment"; Load += BookAppointment_Load;
            pnlContent.ResumeLayout(false); pnlContent.PerformLayout();
            pnlTreatmentPreview.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picTreatment).EndInit();
            pnlSummary.ResumeLayout(false); pnlSummary.PerformLayout();
            ResumeLayout(false);
        }
        #endregion
        private Panel pnlSidebar;
        private Panel pnlContent;
        private Label lblHeader;
        private Label lblSelectTreatment; private ComboBox cmbTreatment;
        private Label lblSelectDoctor; private ComboBox cmbDoctor;
        private Panel pnlTreatmentPreview;
        private PictureBox picTreatment;
        private Label lblTreatmentDesc;
        private Label lblSelectDate; private DateTimePicker dtpDate;
        private Label lblSelectTime; private DateTimePicker dtpTime;
        private Panel pnlSummary;
        private Label lblPrice; private Label lblPriceValue;
        private Label lblDuration; private Label lblDurationValue;
        private Button btnBook;
    }
}
