namespace Dentora.Forms
{
    partial class AboutUs
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing) { if (disposing && (components != null)) components.Dispose(); base.Dispose(disposing); }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            picLogo = new PictureBox();
            lblTitle = new Label();
            lblBody = new Label();
            lblVersion = new Label();
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
            picLogo.Size = new Size(140, 80);
            picLogo.TabStop = false;
            //
            // lblTitle
            //
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(0, 150, 136);
            lblTitle.Location = new Point(20, 105);
            lblTitle.Size = new Size(410, 40);
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            lblTitle.Text = "About Dentora Clinic";
            //
            // lblBody
            //
            lblBody.Font = new Font("Segoe UI", 10.5F);
            lblBody.ForeColor = Color.FromArgb(220, 220, 220);
            lblBody.Location = new Point(25, 155);
            lblBody.Size = new Size(400, 180);
            lblBody.Text = "Dentora is a modern dental clinic management system designed to simplify the daily workflow for both dentists and patients.\n\nOur mission is to make dental care accessible and well-organized. From appointment booking and treatment management to inventory tracking and patient feedback \u2014 Dentora puts everything at your fingertips.\n\nBuilt with care by the Dentora team.";
            //
            // lblVersion
            //
            lblVersion.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            lblVersion.ForeColor = Color.Gray;
            lblVersion.Location = new Point(25, 345);
            lblVersion.Size = new Size(400, 20);
            lblVersion.TextAlign = ContentAlignment.MiddleCenter;
            lblVersion.Text = "Version 1.0.0 \u2014 .NET 8 \u2014 \u00A9 2025 Dentora";
            //
            // btnClose
            //
            btnClose.BackColor = Color.FromArgb(0, 150, 136);
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(155, 380);
            btnClose.Size = new Size(140, 42);
            btnClose.Text = "Close";
            btnClose.Click += btnClose_Click;
            //
            // AboutUs
            //
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 34, 34);
            ClientSize = new Size(450, 440);
            Controls.Add(picLogo);
            Controls.Add(lblTitle);
            Controls.Add(lblBody);
            Controls.Add(lblVersion);
            Controls.Add(btnClose);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = Icon.FromHandle(Properties.Resources.dentora_logo1.GetHicon());
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AboutUs";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Dentora - About Us";
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ResumeLayout(false);
        }
        #endregion

        private PictureBox picLogo;
        private Label lblTitle;
        private Label lblBody;
        private Label lblVersion;
        private Button btnClose;
    }
}
