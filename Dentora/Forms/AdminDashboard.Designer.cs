namespace Dentora.Forms
{
    partial class AdminDashboard
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
            lblClinicName = new Label();
            logoBox = new PictureBox();
            btnSchedule = new Button();
            btnTreatments = new Button();
            btnInventory = new Button();
            btnPatients = new Button();
            btnLogout = new Button();
            pnlContent = new Panel();
            lblDate = new Label();
            dgvSchedule = new DataGridView();
            btnRefresh = new Button();
            btnCompleteAppointment = new Button();
            pnlSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logoBox).BeginInit();
            pnlContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSchedule).BeginInit();
            SuspendLayout();
            //
            // pnlSidebar
            //
            pnlSidebar.BackColor = Color.FromArgb(34, 34, 34);
            pnlSidebar.Controls.Add(logoBox);
            pnlSidebar.Controls.Add(lblClinicName);
            pnlSidebar.Controls.Add(btnSchedule);
            pnlSidebar.Controls.Add(btnTreatments);
            pnlSidebar.Controls.Add(btnInventory);
            pnlSidebar.Controls.Add(btnPatients);
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
            lblClinicName.Text = "  Admin Panel";
            lblClinicName.TextAlign = ContentAlignment.MiddleCenter;
            //
            // btnSchedule
            //
            btnSchedule.BackColor = Color.FromArgb(0, 150, 136);
            btnSchedule.FlatStyle = FlatStyle.Flat;
            btnSchedule.FlatAppearance.BorderSize = 0;
            btnSchedule.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnSchedule.ForeColor = Color.White;
            btnSchedule.Location = new Point(10, 145);
            btnSchedule.Name = "btnSchedule";
            btnSchedule.Size = new Size(200, 45);
            btnSchedule.Text = "[=] Schedule";
            btnSchedule.TextAlign = ContentAlignment.MiddleLeft;
            btnSchedule.Click += btnRefresh_Click;
            //
            // btnTreatments
            //
            btnTreatments.BackColor = Color.FromArgb(55, 55, 55);
            btnTreatments.FlatStyle = FlatStyle.Flat;
            btnTreatments.FlatAppearance.BorderSize = 0;
            btnTreatments.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnTreatments.ForeColor = Color.White;
            btnTreatments.Location = new Point(10, 200);
            btnTreatments.Name = "btnTreatments";
            btnTreatments.Size = new Size(200, 45);
            btnTreatments.Text = "[T] Treatments";
            btnTreatments.TextAlign = ContentAlignment.MiddleLeft;
            btnTreatments.Click += btnTreatments_Click;
            //
            // btnInventory
            //
            btnInventory.BackColor = Color.FromArgb(55, 55, 55);
            btnInventory.FlatStyle = FlatStyle.Flat;
            btnInventory.FlatAppearance.BorderSize = 0;
            btnInventory.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnInventory.ForeColor = Color.White;
            btnInventory.Location = new Point(10, 255);
            btnInventory.Name = "btnInventory";
            btnInventory.Size = new Size(200, 45);
            btnInventory.Text = "[I] Inventory";
            btnInventory.TextAlign = ContentAlignment.MiddleLeft;
            btnInventory.Click += btnInventory_Click;
            //
            // btnPatients
            //
            btnPatients.BackColor = Color.FromArgb(55, 55, 55);
            btnPatients.FlatStyle = FlatStyle.Flat;
            btnPatients.FlatAppearance.BorderSize = 0;
            btnPatients.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnPatients.ForeColor = Color.White;
            btnPatients.Location = new Point(10, 310);
            btnPatients.Name = "btnPatients";
            btnPatients.Size = new Size(200, 45);
            btnPatients.Text = "[P] Patients";
            btnPatients.TextAlign = ContentAlignment.MiddleLeft;
            btnPatients.Click += btnPatients_Click;
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
            pnlContent.Controls.Add(lblDate);
            pnlContent.Controls.Add(dgvSchedule);
            pnlContent.Controls.Add(btnRefresh);
            pnlContent.Controls.Add(btnCompleteAppointment);
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(220, 0);
            pnlContent.Name = "pnlContent";
            //
            // lblDate
            //
            lblDate.BackColor = Color.Transparent;
            lblDate.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblDate.ForeColor = Color.FromArgb(0, 150, 136);
            lblDate.Location = new Point(20, 15);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(500, 40);
            lblDate.Text = "Today's Schedule";
            //
            // dgvSchedule
            //
            dgvSchedule.BackgroundColor = Color.FromArgb(45, 45, 45);
            dgvSchedule.ForeColor = Color.Black;
            dgvSchedule.Location = new Point(20, 65);
            dgvSchedule.Name = "dgvSchedule";
            dgvSchedule.Size = new Size(640, 420);
            dgvSchedule.ReadOnly = true;
            dgvSchedule.AllowUserToAddRows = false;
            dgvSchedule.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSchedule.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 150, 136);
            dgvSchedule.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvSchedule.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dgvSchedule.EnableHeadersVisualStyles = false;
            dgvSchedule.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
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
            btnRefresh.Size = new Size(140, 40);
            btnRefresh.Text = "Refresh";
            btnRefresh.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnRefresh.Click += btnRefresh_Click;
            //
            // btnCompleteAppointment
            //
            btnCompleteAppointment.BackColor = Color.FromArgb(39, 174, 96);
            btnCompleteAppointment.FlatStyle = FlatStyle.Flat;
            btnCompleteAppointment.FlatAppearance.BorderSize = 0;
            btnCompleteAppointment.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCompleteAppointment.ForeColor = Color.White;
            btnCompleteAppointment.Location = new Point(180, 500);
            btnCompleteAppointment.Name = "btnCompleteAppointment";
            btnCompleteAppointment.Size = new Size(220, 40);
            btnCompleteAppointment.Text = "Complete + Prescription";
            btnCompleteAppointment.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnCompleteAppointment.Click += btnCompleteAppointment_Click;
            //
            // AdminDashboard
            //
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(pnlContent);
            Controls.Add(pnlSidebar);
            DoubleBuffered = true;
            Name = "AdminDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dentora - Admin Dashboard";
            Load += AdminDashboard_Load;
            pnlSidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)logoBox).EndInit();
            pnlContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSchedule).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlSidebar;
        private Label lblClinicName;
        private PictureBox logoBox;
        private Button btnSchedule;
        private Button btnTreatments;
        private Button btnInventory;
        private Button btnPatients;
        private Button btnLogout;
        private Panel pnlContent;
        private Label lblDate;
        private DataGridView dgvSchedule;
        private Button btnRefresh;
        private Button btnCompleteAppointment;
    }
}
