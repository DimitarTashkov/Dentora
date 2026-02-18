namespace Dentora.Forms
{
    partial class ManageInventory
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing) { if (disposing && (components != null)) components.Dispose(); base.Dispose(disposing); }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            dgvInventory = new DataGridView(); btnAdd = new Button(); btnDelete = new Button(); btnBack = new Button(); lblTitle = new Label(); logoBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvInventory).BeginInit(); ((System.ComponentModel.ISupportInitialize)logoBox).BeginInit(); SuspendLayout();
            logoBox.BackColor = Color.Transparent; logoBox.BackgroundImage = Properties.Resources.dentora_logo; logoBox.BackgroundImageLayout = ImageLayout.Zoom; logoBox.Location = new Point(10, 5); logoBox.Name = "logoBox"; logoBox.Size = new Size(100, 50); logoBox.TabStop = false;
            lblTitle.BackColor = Color.Transparent; lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold); lblTitle.ForeColor = Color.FromArgb(0, 150, 136); lblTitle.Location = new Point(120, 10); lblTitle.Name = "lblTitle"; lblTitle.Size = new Size(400, 40); lblTitle.Text = "Clinic Inventory";
            dgvInventory.BackgroundColor = Color.FromArgb(45, 45, 45); dgvInventory.ForeColor = Color.Black; dgvInventory.Location = new Point(20, 65); dgvInventory.Name = "dgvInventory"; dgvInventory.Size = new Size(860, 420); dgvInventory.ReadOnly = true; dgvInventory.AllowUserToAddRows = false; dgvInventory.SelectionMode = DataGridViewSelectionMode.FullRowSelect; dgvInventory.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 150, 136); dgvInventory.ColumnHeadersDefaultCellStyle.ForeColor = Color.White; dgvInventory.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold); dgvInventory.EnableHeadersVisualStyles = false; dgvInventory.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right; dgvInventory.CellDoubleClick += dgvInventory_CellDoubleClick;
            btnAdd.BackColor = Color.FromArgb(0, 150, 136); btnAdd.FlatStyle = FlatStyle.Flat; btnAdd.FlatAppearance.BorderSize = 0; btnAdd.Font = new Font("Segoe UI", 10F, FontStyle.Bold); btnAdd.ForeColor = Color.White; btnAdd.Location = new Point(20, 500); btnAdd.Name = "btnAdd"; btnAdd.Size = new Size(140, 40); btnAdd.Text = "+ Add"; btnAdd.Anchor = AnchorStyles.Bottom | AnchorStyles.Left; btnAdd.Click += btnAdd_Click;
            btnDelete.BackColor = Color.FromArgb(180, 40, 40); btnDelete.FlatStyle = FlatStyle.Flat; btnDelete.FlatAppearance.BorderSize = 0; btnDelete.Font = new Font("Segoe UI", 10F, FontStyle.Bold); btnDelete.ForeColor = Color.White; btnDelete.Location = new Point(180, 500); btnDelete.Name = "btnDelete"; btnDelete.Size = new Size(140, 40); btnDelete.Text = "Delete"; btnDelete.Anchor = AnchorStyles.Bottom | AnchorStyles.Left; btnDelete.Click += btnDelete_Click;
            btnBack.BackColor = Color.FromArgb(55, 55, 55); btnBack.FlatStyle = FlatStyle.Flat; btnBack.FlatAppearance.BorderSize = 0; btnBack.Font = new Font("Segoe UI", 10F, FontStyle.Bold); btnBack.ForeColor = Color.White; btnBack.Location = new Point(740, 500); btnBack.Name = "btnBack"; btnBack.Size = new Size(140, 40); btnBack.Text = "< Back"; btnBack.Anchor = AnchorStyles.Bottom | AnchorStyles.Right; btnBack.Click += btnBack_Click;
            AutoScaleDimensions = new SizeF(8F, 20F); AutoScaleMode = AutoScaleMode.Font; BackgroundImage = Properties.Resources.app_backround; BackgroundImageLayout = ImageLayout.Stretch; ClientSize = new Size(914, 560); Controls.Add(logoBox); Controls.Add(lblTitle); Controls.Add(dgvInventory); Controls.Add(btnAdd); Controls.Add(btnDelete); Controls.Add(btnBack); DoubleBuffered = true; Name = "ManageInventory"; StartPosition = FormStartPosition.CenterScreen; Text = "Dentora - Clinic Inventory"; Load += ManageInventory_Load;
            ((System.ComponentModel.ISupportInitialize)dgvInventory).EndInit(); ((System.ComponentModel.ISupportInitialize)logoBox).EndInit(); ResumeLayout(false);
        }
        #endregion
        private DataGridView dgvInventory; private Button btnAdd; private Button btnDelete; private Button btnBack; private Label lblTitle; private PictureBox logoBox;
    }
}
