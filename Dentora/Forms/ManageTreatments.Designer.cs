using Dentora.Utilities;

namespace Dentora.Forms
{
    partial class ManageTreatments
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing) { if (disposing && (components != null)) components.Dispose(); base.Dispose(disposing); }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            pnlSidebar = SidebarHelper.CreateAdminSidebarPanel("Treatments");
            pnlContent = new Panel();
            dgvTreatments = new DataGridView();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            lblTitle = new Label();
            pnlContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTreatments).BeginInit();
            SuspendLayout();
            // pnlSidebar
            pnlSidebar = SidebarHelper.CreateAdminSidebarPanel("Treatments");
            // pnlContent
            pnlContent.BackgroundImage = Properties.Resources.app_backround; pnlContent.BackgroundImageLayout = ImageLayout.Stretch; pnlContent.Location = new Point(220, 0); pnlContent.Name = "pnlContent"; pnlContent.Size = new Size(830, 650); pnlContent.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlContent.Controls.Add(lblTitle); pnlContent.Controls.Add(dgvTreatments); pnlContent.Controls.Add(btnAdd); pnlContent.Controls.Add(btnEdit); pnlContent.Controls.Add(btnDelete);
            // lblTitle
            lblTitle.BackColor = Color.Transparent; lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold); lblTitle.ForeColor = Color.FromArgb(0, 150, 136); lblTitle.Location = new Point(20, 15); lblTitle.Name = "lblTitle"; lblTitle.Size = new Size(400, 40); lblTitle.Text = "\U0001F9B7 Manage Treatments";
            // dgvTreatments
            dgvTreatments.Location = new Point(20, 65); dgvTreatments.Name = "dgvTreatments"; dgvTreatments.Size = new Size(780, 480); dgvTreatments.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right; dgvTreatments.BackgroundColor = Color.FromArgb(30, 30, 30); dgvTreatments.GridColor = Color.FromArgb(55, 55, 55); dgvTreatments.BorderStyle = BorderStyle.None; dgvTreatments.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal; dgvTreatments.ReadOnly = true; dgvTreatments.AllowUserToAddRows = false; dgvTreatments.AllowUserToResizeRows = false; dgvTreatments.SelectionMode = DataGridViewSelectionMode.FullRowSelect; dgvTreatments.RowHeadersVisible = false; dgvTreatments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; dgvTreatments.EnableHeadersVisualStyles = false; dgvTreatments.ColumnHeadersHeight = 40; dgvTreatments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing; dgvTreatments.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 150, 136); dgvTreatments.ColumnHeadersDefaultCellStyle.ForeColor = Color.White; dgvTreatments.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold); dgvTreatments.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft; dgvTreatments.ColumnHeadersDefaultCellStyle.Padding = new Padding(8, 0, 0, 0); dgvTreatments.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 150, 136); dgvTreatments.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.White; dgvTreatments.DefaultCellStyle.BackColor = Color.FromArgb(40, 40, 40); dgvTreatments.DefaultCellStyle.ForeColor = Color.FromArgb(220, 220, 220); dgvTreatments.DefaultCellStyle.Font = new Font("Segoe UI", 10F); dgvTreatments.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 120, 110); dgvTreatments.DefaultCellStyle.SelectionForeColor = Color.White; dgvTreatments.DefaultCellStyle.Padding = new Padding(8, 4, 4, 4); dgvTreatments.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(50, 50, 50); dgvTreatments.AlternatingRowsDefaultCellStyle.ForeColor = Color.FromArgb(220, 220, 220); dgvTreatments.AlternatingRowsDefaultCellStyle.Font = new Font("Segoe UI", 10F); dgvTreatments.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 120, 110); dgvTreatments.AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.White; dgvTreatments.AlternatingRowsDefaultCellStyle.Padding = new Padding(8, 4, 4, 4); dgvTreatments.RowTemplate.Height = 36; dgvTreatments.CellDoubleClick += dgvTreatments_CellDoubleClick;
            // btnAdd
            btnAdd.BackColor = Color.FromArgb(0, 150, 136); btnAdd.FlatStyle = FlatStyle.Flat; btnAdd.FlatAppearance.BorderSize = 0; btnAdd.Font = new Font("Segoe UI", 10F, FontStyle.Bold); btnAdd.ForeColor = Color.White; btnAdd.Location = new Point(20, 560); btnAdd.Name = "btnAdd"; btnAdd.Size = new Size(150, 40); btnAdd.Text = "\u2795 Add Treatment"; btnAdd.Cursor = Cursors.Hand; btnAdd.Anchor = AnchorStyles.Bottom | AnchorStyles.Left; btnAdd.Click += btnAdd_Click;
            // btnEdit
            btnEdit.BackColor = Color.FromArgb(0, 120, 200); btnEdit.FlatStyle = FlatStyle.Flat; btnEdit.FlatAppearance.BorderSize = 0; btnEdit.Font = new Font("Segoe UI", 10F, FontStyle.Bold); btnEdit.ForeColor = Color.White; btnEdit.Location = new Point(190, 560); btnEdit.Name = "btnEdit"; btnEdit.Size = new Size(150, 40); btnEdit.Text = "\u270F\uFE0F Edit"; btnEdit.Cursor = Cursors.Hand; btnEdit.Anchor = AnchorStyles.Bottom | AnchorStyles.Left; btnEdit.Click += btnEdit_Click;
            // btnDelete
            btnDelete.BackColor = Color.FromArgb(180, 40, 40); btnDelete.FlatStyle = FlatStyle.Flat; btnDelete.FlatAppearance.BorderSize = 0; btnDelete.Font = new Font("Segoe UI", 10F, FontStyle.Bold); btnDelete.ForeColor = Color.White; btnDelete.Location = new Point(360, 560); btnDelete.Name = "btnDelete"; btnDelete.Size = new Size(150, 40); btnDelete.Text = "\U0001F5D1 Delete"; btnDelete.Cursor = Cursors.Hand; btnDelete.Anchor = AnchorStyles.Bottom | AnchorStyles.Left; btnDelete.Click += btnDelete_Click;
            // ManageTreatments
            AutoScaleDimensions = new SizeF(8F, 20F); AutoScaleMode = AutoScaleMode.Font; ClientSize = new Size(1050, 650); Controls.Add(pnlSidebar); Controls.Add(pnlContent); DoubleBuffered = true; Icon = Icon.FromHandle(Properties.Resources.dentora_logo1.GetHicon()); Name = "ManageTreatments"; StartPosition = FormStartPosition.CenterScreen; Text = "Dentora - Manage Treatments"; Load += ManageTreatments_Load;
            pnlContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTreatments).EndInit(); ResumeLayout(false);
        }
        #endregion

        private Panel pnlSidebar;
        private Panel pnlContent;
        private DataGridView dgvTreatments;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private Label lblTitle;
    }
}
