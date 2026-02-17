namespace Dentora.Forms
{
    partial class BookAppointment
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing) { if (disposing && (components != null)) components.Dispose(); base.Dispose(disposing); }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            lblHeader = new Label(); logoBox = new PictureBox();
            lblSelectTreatment = new Label(); cmbTreatment = new ComboBox();
            lblSelectDate = new Label(); dtpDate = new DateTimePicker();
            lblPrice = new Label(); lblPriceValue = new Label();
            lblDuration = new Label(); lblDurationValue = new Label();
            btnBook = new Button(); btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)logoBox).BeginInit(); SuspendLayout();
            // logoBox
            logoBox.BackColor = Color.Transparent; logoBox.BackgroundImage = Properties.Resources.dentora_logo; logoBox.BackgroundImageLayout = ImageLayout.Zoom; logoBox.Location = new Point(10, 5); logoBox.Name = "logoBox"; logoBox.Size = new Size(100, 50); logoBox.TabStop = false;
            // lblHeader
            lblHeader.BackColor = Color.Transparent; lblHeader.Font = new Font("Segoe UI", 18F, FontStyle.Bold); lblHeader.ForeColor = Color.FromArgb(0, 150, 136); lblHeader.Location = new Point(120, 10); lblHeader.Name = "lblHeader"; lblHeader.Size = new Size(500, 45); lblHeader.Text = "Book an Appointment";
            // lblSelectTreatment
            lblSelectTreatment.AutoSize = true; lblSelectTreatment.BackColor = Color.Transparent; lblSelectTreatment.Font = new Font("Segoe UI", 13F, FontStyle.Bold); lblSelectTreatment.ForeColor = Color.White; lblSelectTreatment.Location = new Point(50, 90); lblSelectTreatment.Text = "Select Treatment:";
            // cmbTreatment
            cmbTreatment.Font = new Font("Segoe UI", 12F); cmbTreatment.Location = new Point(50, 120); cmbTreatment.Size = new Size(400, 32); cmbTreatment.DropDownStyle = ComboBoxStyle.DropDownList; cmbTreatment.SelectedIndexChanged += cmbTreatment_SelectedIndexChanged;
            // lblSelectDate
            lblSelectDate.AutoSize = true; lblSelectDate.BackColor = Color.Transparent; lblSelectDate.Font = new Font("Segoe UI", 13F, FontStyle.Bold); lblSelectDate.ForeColor = Color.White; lblSelectDate.Location = new Point(50, 175); lblSelectDate.Text = "Select Date & Time:";
            // dtpDate
            dtpDate.Font = new Font("Segoe UI", 12F); dtpDate.Location = new Point(50, 205); dtpDate.Size = new Size(400, 32);
            // lblDuration
            lblDuration.AutoSize = true; lblDuration.BackColor = Color.Transparent; lblDuration.Font = new Font("Segoe UI", 12F, FontStyle.Bold); lblDuration.ForeColor = Color.White; lblDuration.Location = new Point(50, 260); lblDuration.Text = "Duration:";
            // lblDurationValue
            lblDurationValue.AutoSize = true; lblDurationValue.BackColor = Color.Transparent; lblDurationValue.Font = new Font("Segoe UI", 12F); lblDurationValue.ForeColor = Color.FromArgb(0, 150, 136); lblDurationValue.Location = new Point(180, 260); lblDurationValue.Text = "0 min";
            // lblPrice
            lblPrice.AutoSize = true; lblPrice.BackColor = Color.Transparent; lblPrice.Font = new Font("Segoe UI", 12F, FontStyle.Bold); lblPrice.ForeColor = Color.White; lblPrice.Location = new Point(50, 300); lblPrice.Text = "Total Price:";
            // lblPriceValue
            lblPriceValue.AutoSize = true; lblPriceValue.BackColor = Color.Transparent; lblPriceValue.Font = new Font("Segoe UI", 14F, FontStyle.Bold); lblPriceValue.ForeColor = Color.FromArgb(0, 150, 136); lblPriceValue.Location = new Point(180, 296); lblPriceValue.Text = "0.00";
            // btnBook
            btnBook.BackColor = Color.FromArgb(0, 150, 136); btnBook.FlatStyle = FlatStyle.Flat; btnBook.FlatAppearance.BorderSize = 0; btnBook.Font = new Font("Segoe UI", 13F, FontStyle.Bold); btnBook.ForeColor = Color.White; btnBook.Location = new Point(50, 360); btnBook.Name = "btnBook"; btnBook.Size = new Size(190, 50); btnBook.Text = "Confirm"; btnBook.Click += btnBook_Click;
            // btnBack
            btnBack.BackColor = Color.FromArgb(55, 55, 55); btnBack.FlatStyle = FlatStyle.Flat; btnBack.FlatAppearance.BorderSize = 0; btnBack.Font = new Font("Segoe UI", 13F, FontStyle.Bold); btnBack.ForeColor = Color.White; btnBack.Location = new Point(260, 360); btnBack.Name = "btnBack"; btnBack.Size = new Size(190, 50); btnBack.Text = "< Back"; btnBack.Click += btnBack_Click;
            // BookAppointment
            AutoScaleDimensions = new SizeF(8F, 20F); AutoScaleMode = AutoScaleMode.Font; BackgroundImage = Properties.Resources.app_backround; BackgroundImageLayout = ImageLayout.Stretch; ClientSize = new Size(550, 440); Controls.Add(logoBox); Controls.Add(lblHeader); Controls.Add(lblSelectTreatment); Controls.Add(cmbTreatment); Controls.Add(lblSelectDate); Controls.Add(dtpDate); Controls.Add(lblDuration); Controls.Add(lblDurationValue); Controls.Add(lblPrice); Controls.Add(lblPriceValue); Controls.Add(btnBook); Controls.Add(btnBack); DoubleBuffered = true; FormBorderStyle = FormBorderStyle.FixedSingle; MaximizeBox = false; Name = "BookAppointment"; StartPosition = FormStartPosition.CenterScreen; Text = "Dentora - Book Appointment"; Load += BookAppointment_Load;
            ((System.ComponentModel.ISupportInitialize)logoBox).EndInit(); ResumeLayout(false); PerformLayout();
        }
        #endregion
        private Label lblHeader; private PictureBox logoBox;
        private Label lblSelectTreatment; private ComboBox cmbTreatment;
        private Label lblSelectDate; private DateTimePicker dtpDate;
        private Label lblPrice; private Label lblPriceValue;
        private Label lblDuration; private Label lblDurationValue;
        private Button btnBook; private Button btnBack;
    }
}
