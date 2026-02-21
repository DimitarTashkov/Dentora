namespace Dentora.Forms
{
    partial class ContactUs
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing) { if (disposing && (components != null)) components.Dispose(); base.Dispose(disposing); }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            picLogo = new PictureBox();
            lblTitle = new Label();
            lblAddress = new Label();
            lblPhone = new Label();
            lblEmail = new Label();
            lblHours = new Label();
            lblHoursValue = new Label();
            lblMessage = new Label();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            SuspendLayout();
            // 
            // picLogo
            // 
            picLogo.BackColor = Color.Transparent;
            picLogo.BackgroundImage = Properties.Resources.dentora_logo;
            picLogo.BackgroundImageLayout = ImageLayout.Zoom;
            picLogo.Location = new Point(155, 15);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(140, 80);
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(0, 150, 136);
            lblTitle.Location = new Point(20, 105);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(410, 40);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "📧 Contact Us";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Font = new Font("Segoe UI", 11F);
            lblAddress.ForeColor = Color.FromArgb(220, 220, 220);
            lblAddress.Location = new Point(30, 160);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(392, 25);
            lblAddress.TabIndex = 2;
            lblAddress.Text = "📍 Address:  123 Dental Street, Sofia, Bulgaria";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Segoe UI", 11F);
            lblPhone.ForeColor = Color.FromArgb(220, 220, 220);
            lblPhone.Location = new Point(30, 195);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(259, 25);
            lblPhone.TabIndex = 3;
            lblPhone.Text = "📞 Phone:     +359 2 123 4567";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 11F);
            lblEmail.ForeColor = Color.FromArgb(220, 220, 220);
            lblEmail.Location = new Point(30, 230);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(304, 25);
            lblEmail.TabIndex = 4;
            lblEmail.Text = "✉️ Email:      contact@dentora.com";
            // 
            // lblHours
            // 
            lblHours.AutoSize = true;
            lblHours.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblHours.ForeColor = Color.FromArgb(0, 150, 136);
            lblHours.Location = new Point(30, 280);
            lblHours.Name = "lblHours";
            lblHours.Size = new Size(188, 28);
            lblHours.TabIndex = 5;
            lblHours.Text = "🕒 Working Hours";
            // 
            // lblHoursValue
            // 
            lblHoursValue.Font = new Font("Segoe UI", 10.5F);
            lblHoursValue.ForeColor = Color.FromArgb(200, 200, 200);
            lblHoursValue.Location = new Point(30, 317);
            lblHoursValue.Name = "lblHoursValue";
            lblHoursValue.Size = new Size(390, 79);
            lblHoursValue.TabIndex = 6;
            lblHoursValue.Text = "Monday – Friday:  08:00 – 18:00\r\nSaturday:  09:00 – 14:00\r\nSunday:  Closed";
            // 
            // lblMessage
            // 
            lblMessage.Font = new Font("Segoe UI", 9.5F, FontStyle.Italic);
            lblMessage.ForeColor = Color.Gray;
            lblMessage.Location = new Point(20, 396);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(390, 25);
            lblMessage.TabIndex = 7;
            lblMessage.Text = "We'd love to hear from you. Reach out anytime!";
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(0, 150, 136);
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(155, 424);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(140, 42);
            btnClose.TabIndex = 8;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // ContactUs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 34, 34);
            ClientSize = new Size(450, 475);
            Controls.Add(picLogo);
            Controls.Add(lblTitle);
            Controls.Add(lblAddress);
            Controls.Add(lblPhone);
            Controls.Add(lblEmail);
            Controls.Add(lblHours);
            Controls.Add(lblHoursValue);
            Controls.Add(lblMessage);
            Controls.Add(btnClose);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = Icon.FromHandle(Properties.Resources.dentora_logo1.GetHicon());
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ContactUs";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Dentora - Contact Us";
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion

        private PictureBox picLogo;
        private Label lblTitle;
        private Label lblAddress;
        private Label lblPhone;
        private Label lblEmail;
        private Label lblHours;
        private Label lblHoursValue;
        private Label lblMessage;
        private Button btnClose;
    }
}
