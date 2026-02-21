using Dentora.Utilities;

namespace Dentora.Forms
{
    partial class FeedbackForm
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing) { if (disposing && (components != null)) components.Dispose(); base.Dispose(disposing); }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            pnlSidebar = SidebarHelper.CreateClientSidebarPanel("Review");
            pnlContent = new Panel();
            lblHeader = new Label();
            lblAppointment = new Label();
            cmbAppointment = new ComboBox();
            lblStars = new Label();
            nudStars = new NumericUpDown();
            lblComment = new Label();
            txtComment = new TextBox();
            btnSubmit = new Button();
            pnlContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudStars).BeginInit();
            SuspendLayout();
            // pnlSidebar
            pnlSidebar = SidebarHelper.CreateClientSidebarPanel("Review");
            pnlSidebar.Location = new Point(0, 0);
            pnlSidebar.Size = new Size(220, 650);
            // pnlContent
            pnlContent.BackgroundImage = Properties.Resources.app_backround;
            pnlContent.BackgroundImageLayout = ImageLayout.Stretch;
            pnlContent.Location = new Point(220, 0);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(830, 650);
            pnlContent.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlContent.Controls.Add(lblHeader); pnlContent.Controls.Add(lblAppointment); pnlContent.Controls.Add(cmbAppointment); pnlContent.Controls.Add(lblStars); pnlContent.Controls.Add(nudStars); pnlContent.Controls.Add(lblComment); pnlContent.Controls.Add(txtComment); pnlContent.Controls.Add(btnSubmit);
            // lblHeader
            lblHeader.BackColor = Color.Transparent; lblHeader.Font = new Font("Segoe UI", 18F, FontStyle.Bold); lblHeader.ForeColor = Color.FromArgb(0, 150, 136); lblHeader.Location = new Point(20, 15); lblHeader.Name = "lblHeader"; lblHeader.Size = new Size(400, 45); lblHeader.Text = "\u2B50 Leave a Review";
            // lblAppointment
            lblAppointment.AutoSize = true; lblAppointment.BackColor = Color.Transparent; lblAppointment.Font = new Font("Segoe UI", 12F, FontStyle.Bold); lblAppointment.ForeColor = Color.White; lblAppointment.Location = new Point(30, 80); lblAppointment.Text = "\U0001F4CB Select Appointment:";
            // cmbAppointment
            cmbAppointment.Font = new Font("Segoe UI", 11F); cmbAppointment.Location = new Point(30, 110); cmbAppointment.Size = new Size(420, 30); cmbAppointment.DropDownStyle = ComboBoxStyle.DropDownList;
            // lblStars
            lblStars.AutoSize = true; lblStars.BackColor = Color.Transparent; lblStars.Font = new Font("Segoe UI", 12F, FontStyle.Bold); lblStars.ForeColor = Color.White; lblStars.Location = new Point(30, 160); lblStars.Text = "\u2B50 Stars (1-5):";
            // nudStars
            nudStars.Font = new Font("Segoe UI", 12F); nudStars.Location = new Point(30, 190); nudStars.Size = new Size(100, 30); nudStars.Minimum = 1; nudStars.Maximum = 5; nudStars.Value = 5;
            // lblComment
            lblComment.AutoSize = true; lblComment.BackColor = Color.Transparent; lblComment.Font = new Font("Segoe UI", 12F, FontStyle.Bold); lblComment.ForeColor = Color.White; lblComment.Location = new Point(30, 235); lblComment.Text = "\U0001F4AC Comment:";
            // txtComment
            txtComment.Font = new Font("Segoe UI", 11F); txtComment.Location = new Point(30, 265); txtComment.Size = new Size(420, 100); txtComment.Multiline = true;
            // btnSubmit
            btnSubmit.BackColor = Color.FromArgb(0, 150, 136); btnSubmit.FlatStyle = FlatStyle.Flat; btnSubmit.FlatAppearance.BorderSize = 0; btnSubmit.Font = new Font("Segoe UI", 12F, FontStyle.Bold); btnSubmit.ForeColor = Color.White; btnSubmit.Location = new Point(30, 385); btnSubmit.Name = "btnSubmit"; btnSubmit.Size = new Size(200, 50); btnSubmit.Text = "\u2705 Submit Review"; btnSubmit.Click += btnSubmit_Click;
            // FeedbackForm
            AutoScaleDimensions = new SizeF(8F, 20F); AutoScaleMode = AutoScaleMode.Font; ClientSize = new Size(1050, 650);
            Controls.Add(pnlSidebar); Controls.Add(pnlContent); DoubleBuffered = true; Icon = Icon.FromHandle(Properties.Resources.dentora_logo1.GetHicon()); Name = "FeedbackForm"; StartPosition = FormStartPosition.CenterScreen; Text = "Dentora - Leave Review"; Load += FeedbackForm_Load;
            pnlContent.ResumeLayout(false); pnlContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudStars).EndInit();
            ResumeLayout(false);
        }
        #endregion

        private Panel pnlSidebar;
        private Panel pnlContent;
        private Label lblHeader;
        private Label lblAppointment;
        private ComboBox cmbAppointment;
        private Label lblStars;
        private NumericUpDown nudStars;
        private Label lblComment;
        private TextBox txtComment;
        private Button btnSubmit;
    }
}
