using Dentora.Utilities;

namespace Dentora.Forms
{
    partial class ManagePatients
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing) { if (disposing && (components != null)) components.Dispose(); base.Dispose(disposing); }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            pnlSidebar = SidebarHelper.CreateAdminSidebarPanel("Patients");
            pnlContent = new Panel();
            dgvPatients = new DataGridView();
            lblTitle = new Label();
            btnEdit = new Button();
            btnDelete = new Button();
            btnViewAppointments = new Button();
            pnlContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPatients).BeginInit();
            SuspendLayout();
            // pnlSidebar
            pnlSidebar = SidebarHelper.CreateAdminSidebarPanel("Patients");
            pnlSidebar.Location = new Point(0, 0);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(220, 650);
            pnlSidebar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            // pnlContent
            pnlContent.BackgroundImage = Properties.Resources.app_backround;
            pnlContent.BackgroundImageLayout = ImageLayout.Stretch;
            pnlContent.Location = new Point(220, 0);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(830, 650);
            pnlContent.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlContent.Controls.Add(lblTitle);
            pnlContent.Controls.Add(dgvPatients);
            pnlContent.Controls.Add(btnEdit);
            pnlContent.Controls.Add(btnDelete);
            pnlContent.Controls.Add(btnViewAppointments);
            // lblTitle
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(0, 150, 136);
            lblTitle.Location = new Point(20, 15);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(400, 40);
            lblTitle.Text = "\U0001F465 Patients";
            // dgvPatients
            dgvPatients.Location = new Point(20, 65);
            dgvPatients.Name = "dgvPatients";
            dgvPatients.Size = new Size(780, 480);
            dgvPatients.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvPatients.BackgroundColor = Color.FromArgb(30, 30, 30);
            dgvPatients.GridColor = Color.FromArgb(55, 55, 55);
            dgvPatients.BorderStyle = BorderStyle.None;
            dgvPatients.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvPatients.ReadOnly = true;
            dgvPatients.AllowUserToAddRows = false;
            dgvPatients.AllowUserToResizeRows = false;
            dgvPatients.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPatients.RowHeadersVisible = false;
            dgvPatients.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPatients.EnableHeadersVisualStyles = false;
            dgvPatients.ColumnHeadersHeight = 40;
            dgvPatients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvPatients.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 150, 136);
            dgvPatients.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvPatients.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dgvPatients.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvPatients.ColumnHeadersDefaultCellStyle.Padding = new Padding(8, 0, 0, 0);
            dgvPatients.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 150, 136);
            dgvPatients.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.White;
            dgvPatients.DefaultCellStyle.BackColor = Color.FromArgb(40, 40, 40);
            dgvPatients.DefaultCellStyle.ForeColor = Color.FromArgb(220, 220, 220);
            dgvPatients.DefaultCellStyle.Font = new Font("Segoe UI", 10F);
            dgvPatients.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 120, 110);
            dgvPatients.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvPatients.DefaultCellStyle.Padding = new Padding(8, 4, 4, 4);
            dgvPatients.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(50, 50, 50);
            dgvPatients.AlternatingRowsDefaultCellStyle.ForeColor = Color.FromArgb(220, 220, 220);
            dgvPatients.AlternatingRowsDefaultCellStyle.Font = new Font("Segoe UI", 10F);
            dgvPatients.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 120, 110);
            dgvPatients.AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.White;
            dgvPatients.AlternatingRowsDefaultCellStyle.Padding = new Padding(8, 4, 4, 4);
            dgvPatients.RowTemplate.Height = 36;
            dgvPatients.CellDoubleClick += dgvPatients_CellDoubleClick;
            // btnEdit
            btnEdit.BackColor = Color.FromArgb(0, 150, 136);
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.FlatAppearance.BorderSize = 0;
            btnEdit.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnEdit.ForeColor = Color.White;
            btnEdit.Location = new Point(20, 560);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(150, 40);
            btnEdit.Text = "\u270F\uFE0F Edit Patient";
            btnEdit.Cursor = Cursors.Hand;
            btnEdit.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnEdit.Click += btnEdit_Click;
            // btnDelete
            btnDelete.BackColor = Color.FromArgb(180, 40, 40);
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(190, 560);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(160, 40);
            btnDelete.Text = "\U0001F5D1 Delete Patient";
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnDelete.Click += btnDelete_Click;
            // btnViewAppointments
            btnViewAppointments.BackColor = Color.FromArgb(0, 120, 110);
            btnViewAppointments.FlatStyle = FlatStyle.Flat;
            btnViewAppointments.FlatAppearance.BorderSize = 0;
            btnViewAppointments.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnViewAppointments.ForeColor = Color.White;
            btnViewAppointments.Location = new Point(370, 560);
            btnViewAppointments.Name = "btnViewAppointments";
            btnViewAppointments.Size = new Size(200, 40);
            btnViewAppointments.Text = "\U0001F4CB View Appointments";
            btnViewAppointments.Cursor = Cursors.Hand;
            btnViewAppointments.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnViewAppointments.Click += btnViewAppointments_Click;
            // ManagePatients
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1050, 650);
            Controls.Add(pnlSidebar);
            Controls.Add(pnlContent);
            DoubleBuffered = true;
            Icon = Icon.FromHandle(Properties.Resources.dentora_logo1.GetHicon());
            Name = "ManagePatients";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dentora - Patients";
            Load += ManagePatients_Load;
            pnlContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPatients).EndInit();
            ResumeLayout(false);
        }
        #endregion
        private Panel pnlSidebar;
        private Panel pnlContent;
        private DataGridView dgvPatients;
        private Label lblTitle;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnViewAppointments;
    }
}
