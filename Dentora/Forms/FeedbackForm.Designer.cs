namespace Dentora.Forms
{
    partial class FeedbackForm
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing) { if (disposing && (components != null)) components.Dispose(); base.Dispose(disposing); }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            lblHeader = new Label();
            logoBox = new PictureBox();
            lblAppointment = new Label();
            cmbAppointment = new ComboBox();
            lblStars = new Label();
            nudStars = new NumericUpDown();
            lblComment = new Label();
            txtComment = new TextBox();
            btnSubmit = new Button();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)logoBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudStars).BeginInit();
            SuspendLayout();
            // logoBox
            logoBox.BackColor = Color.Transparent;
            logoBox.BackgroundImage = Properties.Resources.dentora_logo;
            logoBox.BackgroundImageLayout = ImageLayout.Zoom;
            logoBox.Location = new Point(10, 5);
            logoBox.Name = "logoBox";
            logoBox.Size = new Size(100, 50);
            logoBox.TabStop = false;
            // lblHeader
            lblHeader.BackColor = Color.Transparent;
            lblHeader.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblHeader.ForeColor = Color.FromArgb(0, 150, 136);
            lblHeader.Location = new Point(120, 10);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(400, 45);
            lblHeader.Text = "Leave a Review";
            // lblAppointment
            lblAppointment.AutoSize = true;
            lblAppointment.BackColor = Color.Transparent;
            lblAppointment.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblAppointment.ForeColor = Color.White;
            lblAppointment.Location = new Point(40, 80);
            lblAppointment.Text = "Select Appointment:";
            // cmbAppointment
            cmbAppointment.Font = new Font("Segoe UI", 11F);
            cmbAppointment.Location = new Point(40, 110);
            cmbAppointment.Size = new Size(420, 30);
            cmbAppointment.DropDownStyle = ComboBoxStyle.DropDownList;
            // lblStars
            lblStars.AutoSize = true;
            lblStars.BackColor = Color.Transparent;
            lblStars.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblStars.ForeColor = Color.White;
            lblStars.Location = new Point(40, 160);
            lblStars.Text = "Stars (1-5):";
            // nudStars
            nudStars.Font = new Font("Segoe UI", 12F);
            nudStars.Location = new Point(40, 190);
            nudStars.Size = new Size(100, 30);
            nudStars.Minimum = 1;
            nudStars.Maximum = 5;
            nudStars.Value = 5;
            // lblComment
            lblComment.AutoSize = true;
            lblComment.BackColor = Color.Transparent;
            lblComment.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblComment.ForeColor = Color.White;
            lblComment.Location = new Point(40, 235);
            lblComment.Text = "Comment:";
            // txtComment
            txtComment.Font = new Font("Segoe UI", 11F);
            txtComment.Location = new Point(40, 265);
            txtComment.Size = new Size(420, 100);
            txtComment.Multiline = true;
            // btnSubmit
            btnSubmit.BackColor = Color.FromArgb(0, 150, 136);
            btnSubmit.FlatStyle = FlatStyle.Flat;
            btnSubmit.FlatAppearance.BorderSize = 0;
            btnSubmit.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnSubmit.ForeColor = Color.White;
            btnSubmit.Location = new Point(40, 385);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(190, 50);
            btnSubmit.Text = "Submit";
            btnSubmit.Click += btnSubmit_Click;
            // btnBack
            btnBack.BackColor = Color.FromArgb(55, 55, 55);
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(260, 385);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(190, 50);
            btnBack.Text = "< Back";
            btnBack.Click += btnBack_Click;
            // FeedbackForm
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.app_backround;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(520, 460);
            Controls.Add(logoBox);
            Controls.Add(lblHeader);
            Controls.Add(lblAppointment);
            Controls.Add(cmbAppointment);
            Controls.Add(lblStars);
            Controls.Add(nudStars);
            Controls.Add(lblComment);
            Controls.Add(txtComment);
            Controls.Add(btnSubmit);
            Controls.Add(btnBack);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FeedbackForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dentora - Leave Review";
            Load += FeedbackForm_Load;
            ((System.ComponentModel.ISupportInitialize)logoBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudStars).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion

        private Label lblHeader;
        private PictureBox logoBox;
        private Label lblAppointment;
        private ComboBox cmbAppointment;
        private Label lblStars;
        private NumericUpDown nudStars;
        private Label lblComment;
        private TextBox txtComment;
        private Button btnSubmit;
        private Button btnBack;
    }
}
