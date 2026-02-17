namespace Dentora.Forms
{
    partial class ClientDashboard
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            pnlSidebar = new Panel();
            logoBox = new PictureBox();
            lblClinicName = new Label();
            btnBook = new Button();
            btnHistory = new Button();
            btnReview = new Button();
            btnLogout = new Button();
            pnlContent = new Panel();
            lblWelcome = new Label();
            dgvHistory = new DataGridView();
            btnRefresh = new Button();
            btnCancelAppointment = new Button();
            pnlSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logoBox).BeginInit();
            pnlContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistory).BeginInit();
            SuspendLayout();
            //
            // pnlSidebar
            //
            pnlSidebar.BackColor = Color.FromArgb(34, 34, 34);
            pnlSidebar.Controls.Add(logoBox);
            pnlSidebar.Controls.Add(lblClinicName);
            pnlSidebar.Controls.Add(btnBook);
            pnlSidebar.Controls.Add(btnHistory);
            pnlSidebar.Controls.Add(btnReview);
            pnlSidebar.Controls.Add(btnLogout);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Location = new Point(0, 0);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(220, 600);
            //
            // logoBox
            //
            logoBox.BackColor = Color.Transparent;
            logoBox.BackgroundImage = Properties.Resources.dentora_logo;
            logoBox.BackgroundImageLayout = ImageLayout.Zoom;
            logoBox.Location = new Point(30, 10);
            logoBox.Name = "logoBox";
            logoBox.Size = new Size(160, 80);
            logoBox.TabStop = false;
            //
            // lblClinicName
            //
            lblClinicName.ForeColor = Color.FromArgb(0, 150, 136);
            lblClinicName.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblClinicName.Location = new Point(10, 95);
            lblClinicName.Name = "lblClinicName";
            lblClinicName.Size = new Size(200, 30);
            lblClinicName.Text = "  Patient Portal";
            lblClinicName.TextAlign = ContentAlignment.MiddleCenter;
            //
            // btnBook
            //
            btnBook.BackColor = Color.FromArgb(0, 150, 136);
            btnBook.FlatStyle = FlatStyle.Flat;
            btnBook.FlatAppearance.BorderSize = 0;
            btnBook.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnBook.ForeColor = Color.White;
            btnBook.Location = new Point(10, 145);
            btnBook.Name = "btnBook";
            btnBook.Size = new Size(200, 45);
            btnBook.Text = "Book Appointment";
            btnBook.TextAlign = ContentAlignment.MiddleLeft;
            btnBook.Click += btnBook_Click;
            //
            // btnHistory
            //
            btnHistory.BackColor = Color.FromArgb(55, 55, 55);
            btnHistory.FlatStyle = FlatStyle.Flat;
            btnHistory.FlatAppearance.BorderSize = 0;
            btnHistory.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnHistory.ForeColor = Color.White;
            btnHistory.Location = new Point(10, 200);
            btnHistory.Name = "btnHistory";
            btnHistory.Size = new Size(200, 45);
            btnHistory.Text = "My History";
            btnHistory.TextAlign = ContentAlignment.MiddleLeft;
            btnHistory.Click += btnRefresh_Click;
            //
            // btnReview
            //
            btnReview.BackColor = Color.FromArgb(55, 55, 55);
            btnReview.FlatStyle = FlatStyle.Flat;
            btnReview.FlatAppearance.BorderSize = 0;
            btnReview.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnReview.ForeColor = Color.White;
            btnReview.Location = new Point(10, 255);
            btnReview.Name = "btnReview";
            btnReview.Size = new Size(200, 45);
            btnReview.Text = "Leave Review";
            btnReview.TextAlign = ContentAlignment.MiddleLeft;
            btnReview.Click += btnReview_Click;
            //
            // btnLogout
            //
            btnLogout.BackColor = Color.FromArgb(180, 40, 40);
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(10, 530);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(200, 45);
            btnLogout.Text = "Logout";
            btnLogout.TextAlign = ContentAlignment.MiddleLeft;
            btnLogout.Click += btnLogout_Click;
            //
            // pnlContent
            //
            pnlContent.BackgroundImage = Properties.Resources.app_backround;
            pnlContent.BackgroundImageLayout = ImageLayout.Stretch;
            pnlContent.Controls.Add(lblWelcome);
            pnlContent.Controls.Add(dgvHistory);
            pnlContent.Controls.Add(btnRefresh);
            pnlContent.Controls.Add(btnCancelAppointment);
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(220, 0);
            pnlContent.Name = "pnlContent";
            //
            // lblWelcome
            //
            lblWelcome.BackColor = Color.Transparent;
            lblWelcome.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblWelcome.ForeColor = Color.FromArgb(0, 150, 136);
            lblWelcome.Location = new Point(20, 15);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(500, 40);
            lblWelcome.Text = "Welcome!";
            //
            // dgvHistory
            //
            dgvHistory.BackgroundColor = Color.FromArgb(45, 45, 45);
            dgvHistory.ForeColor = Color.Black;
            dgvHistory.Location = new Point(20, 65);
            dgvHistory.Name = "dgvHistory";
            dgvHistory.Size = new Size(640, 420);
            dgvHistory.ReadOnly = true;
            dgvHistory.AllowUserToAddRows = false;
            dgvHistory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHistory.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 150, 136);
            dgvHistory.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvHistory.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dgvHistory.EnableHeadersVisualStyles = false;
            dgvHistory.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            //
            // btnRefresh
            //
            btnRefresh.BackColor = Color.FromArgb(0, 150, 136);
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(20, 500);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(130, 40);
            btnRefresh.Text = "Refresh";
            btnRefresh.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnRefresh.Click += btnRefresh_Click;
            //
            // btnCancelAppointment
            //
            btnCancelAppointment.BackColor = Color.FromArgb(180, 40, 40);
            btnCancelAppointment.FlatStyle = FlatStyle.Flat;
            btnCancelAppointment.FlatAppearance.BorderSize = 0;
            btnCancelAppointment.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCancelAppointment.ForeColor = Color.White;
            btnCancelAppointment.Location = new Point(170, 500);
            btnCancelAppointment.Name = "btnCancelAppointment";
            btnCancelAppointment.Size = new Size(200, 40);
            btnCancelAppointment.Text = "Cancel Appointment";
            btnCancelAppointment.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnCancelAppointment.Click += btnCancelAppointment_Click;
            //
            // ClientDashboard
            //
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(pnlContent);
            Controls.Add(pnlSidebar);
            DoubleBuffered = true;
            Name = "ClientDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dentora - Patient Dashboard";
            Load += ClientDashboard_Load;
            pnlSidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)logoBox).EndInit();
            pnlContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvHistory).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlSidebar;
        private PictureBox logoBox;
        private Label lblClinicName;
        private Button btnBook;
        private Button btnHistory;
        private Button btnReview;
        private Button btnLogout;
        private Panel pnlContent;
        private Label lblWelcome;
        private DataGridView dgvHistory;
        private Button btnRefresh;
        private Button btnCancelAppointment;
    }
}
