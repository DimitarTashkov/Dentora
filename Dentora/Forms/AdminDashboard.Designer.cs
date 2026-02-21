using Dentora.Utilities;

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
            pnlSidebar = SidebarHelper.CreateAdminSidebarPanel("Schedule");
            pnlContent = new Panel();
            lblDate = new Label();
            cmbFilter = new ComboBox();
            lblFilter = new Label();
            dgvSchedule = new DataGridView();
            btnRefresh = new Button();
            btnCompleteAppointment = new Button();
            btnPrintReport = new Button();
            btnCancelAppointment = new Button();
            pnlContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSchedule).BeginInit();
            SuspendLayout();
            //
            // pnlSidebar
            //
            pnlSidebar = SidebarHelper.CreateAdminSidebarPanel("Schedule");
            //
            // pnlContent
            //
            pnlContent.BackgroundImage = Properties.Resources.app_backround;
            pnlContent.BackgroundImageLayout = ImageLayout.Stretch;
            pnlContent.Controls.Add(lblDate);
            pnlContent.Controls.Add(lblFilter);
            pnlContent.Controls.Add(cmbFilter);
            pnlContent.Controls.Add(dgvSchedule);
            pnlContent.Controls.Add(btnRefresh);
            pnlContent.Controls.Add(btnCompleteAppointment);
            pnlContent.Controls.Add(btnCancelAppointment);
            pnlContent.Controls.Add(btnPrintReport);
            pnlContent.Location = new Point(220, 0);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(830, 650);
            pnlContent.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            //
            // lblDate
            //
            lblDate.BackColor = Color.Transparent;
            lblDate.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblDate.ForeColor = Color.FromArgb(0, 150, 136);
            lblDate.Location = new Point(20, 15);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(500, 40);
            lblDate.Text = "\U0001F4C5 Appointments";
            //
            // lblFilter
            //
            lblFilter.AutoSize = true;
            lblFilter.BackColor = Color.Transparent;
            lblFilter.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblFilter.ForeColor = Color.White;
            lblFilter.Location = new Point(550, 22);
            lblFilter.Name = "lblFilter";
            lblFilter.Text = "Show:";
            lblFilter.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            //
            // cmbFilter
            //
            cmbFilter.Font = new Font("Segoe UI", 10F);
            cmbFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFilter.Location = new Point(610, 18);
            cmbFilter.Size = new Size(190, 30);
            cmbFilter.Name = "cmbFilter";
            cmbFilter.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cmbFilter.SelectedIndexChanged += cmbFilter_SelectedIndexChanged;
            //
            // dgvSchedule
            //
            dgvSchedule.Location = new Point(20, 65);
            dgvSchedule.Name = "dgvSchedule";
            dgvSchedule.Size = new Size(780, 480);
            dgvSchedule.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvSchedule.BackgroundColor = Color.FromArgb(30, 30, 30);
            dgvSchedule.GridColor = Color.FromArgb(55, 55, 55);
            dgvSchedule.BorderStyle = BorderStyle.None;
            dgvSchedule.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvSchedule.ReadOnly = true;
            dgvSchedule.AllowUserToAddRows = false;
            dgvSchedule.AllowUserToResizeRows = false;
            dgvSchedule.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSchedule.RowHeadersVisible = false;
            dgvSchedule.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSchedule.EnableHeadersVisualStyles = false;
            dgvSchedule.ColumnHeadersHeight = 40;
            dgvSchedule.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvSchedule.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 150, 136);
            dgvSchedule.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvSchedule.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dgvSchedule.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvSchedule.ColumnHeadersDefaultCellStyle.Padding = new Padding(8, 0, 0, 0);
            dgvSchedule.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 150, 136);
            dgvSchedule.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.White;
            dgvSchedule.DefaultCellStyle.BackColor = Color.FromArgb(40, 40, 40);
            dgvSchedule.DefaultCellStyle.ForeColor = Color.FromArgb(220, 220, 220);
            dgvSchedule.DefaultCellStyle.Font = new Font("Segoe UI", 10F);
            dgvSchedule.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 120, 110);
            dgvSchedule.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvSchedule.DefaultCellStyle.Padding = new Padding(8, 4, 4, 4);
            dgvSchedule.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(50, 50, 50);
            dgvSchedule.AlternatingRowsDefaultCellStyle.ForeColor = Color.FromArgb(220, 220, 220);
            dgvSchedule.AlternatingRowsDefaultCellStyle.Font = new Font("Segoe UI", 10F);
            dgvSchedule.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 120, 110);
            dgvSchedule.AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.White;
            dgvSchedule.AlternatingRowsDefaultCellStyle.Padding = new Padding(8, 4, 4, 4);
            dgvSchedule.RowTemplate.Height = 36;
            //
            // btnRefresh
            //
            btnRefresh.BackColor = Color.FromArgb(0, 150, 136);
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(20, 560);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(120, 40);
            btnRefresh.Text = "\U0001F504 Refresh";
            btnRefresh.Cursor = Cursors.Hand;
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
            btnCompleteAppointment.Location = new Point(150, 560);
            btnCompleteAppointment.Name = "btnCompleteAppointment";
            btnCompleteAppointment.Size = new Size(250, 40);
            btnCompleteAppointment.Text = "\u2705 Complete + Prescription";
            btnCompleteAppointment.Cursor = Cursors.Hand;
            btnCompleteAppointment.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnCompleteAppointment.Click += btnCompleteAppointment_Click;
            //
            // btnPrintReport
            //
            btnPrintReport.BackColor = Color.FromArgb(55, 55, 55);
            btnPrintReport.FlatStyle = FlatStyle.Flat;
            btnPrintReport.FlatAppearance.BorderSize = 0;
            btnPrintReport.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnPrintReport.ForeColor = Color.White;
            btnPrintReport.Location = new Point(410, 560);
            btnPrintReport.Name = "btnPrintReport";
            btnPrintReport.Size = new Size(200, 40);
            btnPrintReport.Text = "\U0001F5A8 Print Daily Report";
            btnPrintReport.Cursor = Cursors.Hand;
            btnPrintReport.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnPrintReport.Click += btnPrintReport_Click;
            //
            // btnCancelAppointment
            //
            btnCancelAppointment.BackColor = Color.FromArgb(180, 40, 40);
            btnCancelAppointment.FlatStyle = FlatStyle.Flat;
            btnCancelAppointment.FlatAppearance.BorderSize = 0;
            btnCancelAppointment.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCancelAppointment.ForeColor = Color.White;
            btnCancelAppointment.Location = new Point(620, 560);
            btnCancelAppointment.Name = "btnCancelAppointment";
            btnCancelAppointment.Size = new Size(180, 40);
            btnCancelAppointment.Text = "\u274C Cancel";
            btnCancelAppointment.Cursor = Cursors.Hand;
            btnCancelAppointment.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnCancelAppointment.Click += btnCancelAppointment_Click;
            //
            // AdminDashboard
            //
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1050, 650);
            Controls.Add(pnlSidebar);
            Controls.Add(pnlContent);
            DoubleBuffered = true;
            Icon = Icon.FromHandle(Properties.Resources.dentora_logo1.GetHicon());
            Name = "AdminDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dentora - Admin Dashboard";
            Load += AdminDashboard_Load;
            pnlContent.ResumeLayout(false);
            pnlContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSchedule).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlSidebar;
        private Panel pnlContent;
        private Label lblDate;
        private Label lblFilter;
        private ComboBox cmbFilter;
        private DataGridView dgvSchedule;
        private Button btnRefresh;
        private Button btnCompleteAppointment;
        private Button btnPrintReport;
        private Button btnCancelAppointment;
    }
}
