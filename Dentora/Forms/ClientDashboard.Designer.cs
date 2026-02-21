using Dentora.Utilities;

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
            pnlSidebar = SidebarHelper.CreateClientSidebarPanel("History");
            pnlContent = new Panel();
            lblWelcome = new Label();
            dgvHistory = new DataGridView();
            btnRefresh = new Button();
            btnCancelAppointment = new Button();
            pnlContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistory).BeginInit();
            SuspendLayout();
            //
            // pnlSidebar
            //
            pnlSidebar.Location = new Point(0, 0);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(220, 650);
            pnlSidebar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            //
            // pnlContent
            //
            pnlContent.BackgroundImage = Properties.Resources.app_backround;
            pnlContent.BackgroundImageLayout = ImageLayout.Stretch;
            pnlContent.Controls.Add(lblWelcome);
            pnlContent.Controls.Add(dgvHistory);
            pnlContent.Controls.Add(btnRefresh);
            pnlContent.Controls.Add(btnCancelAppointment);
            pnlContent.Location = new Point(220, 0);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(830, 650);
            pnlContent.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
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
            dgvHistory.Location = new Point(20, 65);
            dgvHistory.Name = "dgvHistory";
            dgvHistory.Size = new Size(780, 480);
            dgvHistory.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvHistory.BackgroundColor = Color.FromArgb(30, 30, 30);
            dgvHistory.GridColor = Color.FromArgb(55, 55, 55);
            dgvHistory.BorderStyle = BorderStyle.None;
            dgvHistory.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvHistory.ReadOnly = true;
            dgvHistory.AllowUserToAddRows = false;
            dgvHistory.AllowUserToResizeRows = false;
            dgvHistory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHistory.RowHeadersVisible = false;
            dgvHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHistory.EnableHeadersVisualStyles = false;
            dgvHistory.ColumnHeadersHeight = 40;
            dgvHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvHistory.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 150, 136);
            dgvHistory.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvHistory.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dgvHistory.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvHistory.ColumnHeadersDefaultCellStyle.Padding = new Padding(8, 0, 0, 0);
            dgvHistory.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 150, 136);
            dgvHistory.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.White;
            dgvHistory.DefaultCellStyle.BackColor = Color.FromArgb(40, 40, 40);
            dgvHistory.DefaultCellStyle.ForeColor = Color.FromArgb(220, 220, 220);
            dgvHistory.DefaultCellStyle.Font = new Font("Segoe UI", 10F);
            dgvHistory.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 120, 110);
            dgvHistory.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvHistory.DefaultCellStyle.Padding = new Padding(8, 4, 4, 4);
            dgvHistory.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(50, 50, 50);
            dgvHistory.AlternatingRowsDefaultCellStyle.ForeColor = Color.FromArgb(220, 220, 220);
            dgvHistory.AlternatingRowsDefaultCellStyle.Font = new Font("Segoe UI", 10F);
            dgvHistory.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 120, 110);
            dgvHistory.AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.White;
            dgvHistory.AlternatingRowsDefaultCellStyle.Padding = new Padding(8, 4, 4, 4);
            dgvHistory.RowTemplate.Height = 36;
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
            btnRefresh.Size = new Size(140, 40);
            btnRefresh.Text = "\U0001F504 Refresh";
            btnRefresh.Cursor = Cursors.Hand;
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
            btnCancelAppointment.Location = new Point(180, 560);
            btnCancelAppointment.Name = "btnCancelAppointment";
            btnCancelAppointment.Size = new Size(220, 40);
            btnCancelAppointment.Text = "\u274C Cancel Appointment";
            btnCancelAppointment.Cursor = Cursors.Hand;
            btnCancelAppointment.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnCancelAppointment.Click += btnCancelAppointment_Click;
            //
            // ClientDashboard
            //
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1050, 650);
            Controls.Add(pnlSidebar);
            Controls.Add(pnlContent);
            DoubleBuffered = true;
            Icon = Icon.FromHandle(Properties.Resources.dentora_logo1.GetHicon());
            Name = "ClientDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dentora - Patient Dashboard";
            Load += ClientDashboard_Load;
            pnlContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvHistory).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlSidebar;
        private Panel pnlContent;
        private Label lblWelcome;
        private DataGridView dgvHistory;
        private Button btnRefresh;
        private Button btnCancelAppointment;
    }
}
