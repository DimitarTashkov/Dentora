namespace Dentora.Forms
{
    partial class PatientAppointments
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing) { if (disposing && (components != null)) components.Dispose(); base.Dispose(disposing); }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            pnlContent = new Panel();
            lblTitle = new Label();
            dgvAppointments = new DataGridView();
            btnClose = new Button();
            pnlContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAppointments).BeginInit();
            SuspendLayout();
            //
            // pnlContent
            //
            pnlContent.BackgroundImage = Properties.Resources.app_backround;
            pnlContent.BackgroundImageLayout = ImageLayout.Stretch;
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Name = "pnlContent";
            pnlContent.Controls.Add(lblTitle);
            pnlContent.Controls.Add(dgvAppointments);
            pnlContent.Controls.Add(btnClose);
            //
            // lblTitle
            //
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(0, 150, 136);
            lblTitle.Location = new Point(20, 15);
            lblTitle.Size = new Size(900, 40);
            lblTitle.Text = "\U0001F4CB Patient Appointments";
            //
            // dgvAppointments
            //
            dgvAppointments.Location = new Point(20, 65);
            dgvAppointments.Name = "dgvAppointments";
            dgvAppointments.Size = new Size(960, 460);
            dgvAppointments.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvAppointments.BackgroundColor = Color.FromArgb(30, 30, 30);
            dgvAppointments.GridColor = Color.FromArgb(55, 55, 55);
            dgvAppointments.BorderStyle = BorderStyle.None;
            dgvAppointments.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvAppointments.ReadOnly = true;
            dgvAppointments.AllowUserToAddRows = false;
            dgvAppointments.AllowUserToResizeRows = false;
            dgvAppointments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAppointments.RowHeadersVisible = false;
            dgvAppointments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dgvAppointments.EnableHeadersVisualStyles = false;
            dgvAppointments.ColumnHeadersHeight = 40;
            dgvAppointments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvAppointments.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 150, 136);
            dgvAppointments.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvAppointments.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dgvAppointments.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvAppointments.ColumnHeadersDefaultCellStyle.Padding = new Padding(8, 0, 0, 0);
            dgvAppointments.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 150, 136);
            dgvAppointments.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.White;
            dgvAppointments.DefaultCellStyle.BackColor = Color.FromArgb(40, 40, 40);
            dgvAppointments.DefaultCellStyle.ForeColor = Color.FromArgb(220, 220, 220);
            dgvAppointments.DefaultCellStyle.Font = new Font("Segoe UI", 10F);
            dgvAppointments.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 120, 110);
            dgvAppointments.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvAppointments.DefaultCellStyle.Padding = new Padding(8, 4, 4, 4);
            dgvAppointments.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(50, 50, 50);
            dgvAppointments.AlternatingRowsDefaultCellStyle.ForeColor = Color.FromArgb(220, 220, 220);
            dgvAppointments.AlternatingRowsDefaultCellStyle.Font = new Font("Segoe UI", 10F);
            dgvAppointments.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 120, 110);
            dgvAppointments.AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.White;
            dgvAppointments.AlternatingRowsDefaultCellStyle.Padding = new Padding(8, 4, 4, 4);
            dgvAppointments.RowTemplate.Height = 36;
            //
            // btnClose
            //
            btnClose.BackColor = Color.FromArgb(55, 55, 55);
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(20, 540);
            btnClose.Size = new Size(120, 40);
            btnClose.Text = "Close";
            btnClose.Cursor = Cursors.Hand;
            btnClose.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnClose.Click += btnClose_Click;
            //
            // PatientAppointments
            //
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 600);
            Controls.Add(pnlContent);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = Icon.FromHandle(Properties.Resources.dentora_logo1.GetHicon());
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "PatientAppointments";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Dentora - Patient Appointments";
            Load += PatientAppointments_Load;
            pnlContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvAppointments).EndInit();
            ResumeLayout(false);
        }
        #endregion

        private Panel pnlContent;
        private Label lblTitle;
        private DataGridView dgvAppointments;
        private Button btnClose;
    }
}
