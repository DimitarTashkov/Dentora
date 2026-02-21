using Dentora.Utilities;

namespace Dentora.Forms
{
    partial class ManageInventory
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing) { if (disposing && (components != null)) components.Dispose(); base.Dispose(disposing); }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            pnlSidebar = SidebarHelper.CreateAdminSidebarPanel("Inventory");
            pnlContent = new Panel();
            dgvInventory = new DataGridView();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            lblTitle = new Label();
            pnlContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInventory).BeginInit();
            SuspendLayout();
            // pnlSidebar
            pnlSidebar = SidebarHelper.CreateAdminSidebarPanel("Inventory");
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
            pnlContent.Controls.Add(dgvInventory);
            pnlContent.Controls.Add(btnAdd);
            pnlContent.Controls.Add(btnEdit);
            pnlContent.Controls.Add(btnDelete);
            // lblTitle
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(0, 150, 136);
            lblTitle.Location = new Point(20, 15);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(400, 40);
            lblTitle.Text = "\U0001F4E6 Clinic Inventory";
            // dgvInventory
            dgvInventory.Location = new Point(20, 65);
            dgvInventory.Name = "dgvInventory";
            dgvInventory.Size = new Size(780, 480);
            dgvInventory.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvInventory.BackgroundColor = Color.FromArgb(30, 30, 30);
            dgvInventory.GridColor = Color.FromArgb(55, 55, 55);
            dgvInventory.BorderStyle = BorderStyle.None;
            dgvInventory.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvInventory.ReadOnly = true;
            dgvInventory.AllowUserToAddRows = false;
            dgvInventory.AllowUserToResizeRows = false;
            dgvInventory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvInventory.RowHeadersVisible = false;
            dgvInventory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvInventory.EnableHeadersVisualStyles = false;
            dgvInventory.ColumnHeadersHeight = 40;
            dgvInventory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvInventory.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 150, 136);
            dgvInventory.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvInventory.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dgvInventory.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvInventory.ColumnHeadersDefaultCellStyle.Padding = new Padding(8, 0, 0, 0);
            dgvInventory.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 150, 136);
            dgvInventory.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.White;
            dgvInventory.DefaultCellStyle.BackColor = Color.FromArgb(40, 40, 40);
            dgvInventory.DefaultCellStyle.ForeColor = Color.FromArgb(220, 220, 220);
            dgvInventory.DefaultCellStyle.Font = new Font("Segoe UI", 10F);
            dgvInventory.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 120, 110);
            dgvInventory.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvInventory.DefaultCellStyle.Padding = new Padding(8, 4, 4, 4);
            dgvInventory.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(50, 50, 50);
            dgvInventory.AlternatingRowsDefaultCellStyle.ForeColor = Color.FromArgb(220, 220, 220);
            dgvInventory.AlternatingRowsDefaultCellStyle.Font = new Font("Segoe UI", 10F);
            dgvInventory.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 120, 110);
            dgvInventory.AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.White;
            dgvInventory.AlternatingRowsDefaultCellStyle.Padding = new Padding(8, 4, 4, 4);
            dgvInventory.RowTemplate.Height = 36;
            dgvInventory.CellDoubleClick += dgvInventory_CellDoubleClick;
            // btnAdd
            btnAdd.BackColor = Color.FromArgb(0, 150, 136);
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(20, 560);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(150, 40);
            btnAdd.Text = "\u2795 Add Item";
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAdd.Click += btnAdd_Click;
            // btnEdit
            btnEdit.BackColor = Color.FromArgb(0, 120, 200);
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.FlatAppearance.BorderSize = 0;
            btnEdit.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnEdit.ForeColor = Color.White;
            btnEdit.Location = new Point(190, 560);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(150, 40);
            btnEdit.Text = "\u270F\uFE0F Edit";
            btnEdit.Cursor = Cursors.Hand;
            btnEdit.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnEdit.Click += btnEdit_Click;
            // btnDelete
            btnDelete.BackColor = Color.FromArgb(180, 40, 40);
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(360, 560);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(150, 40);
            btnDelete.Text = "\U0001F5D1 Delete";
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnDelete.Click += btnDelete_Click;
            // ManageInventory
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1050, 650);
            Controls.Add(pnlSidebar);
            Controls.Add(pnlContent);
            DoubleBuffered = true;
            Icon = Icon.FromHandle(Properties.Resources.dentora_logo1.GetHicon());
            Name = "ManageInventory";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dentora - Clinic Inventory";
            Load += ManageInventory_Load;
            pnlContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvInventory).EndInit();
            ResumeLayout(false);
        }
        #endregion
        private Panel pnlSidebar;
        private Panel pnlContent;
        private DataGridView dgvInventory;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private Label lblTitle;
    }
}
