namespace Dentora.Forms
{
    partial class ManagePatients
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing) { if (disposing && (components != null)) components.Dispose(); base.Dispose(disposing); }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            dgvPatients = new DataGridView(); btnBack = new Button(); lblTitle = new Label(); logoBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvPatients).BeginInit(); ((System.ComponentModel.ISupportInitialize)logoBox).BeginInit(); SuspendLayout();
            logoBox.BackColor = Color.Transparent; logoBox.BackgroundImage = Properties.Resources.dentora_logo; logoBox.BackgroundImageLayout = ImageLayout.Zoom; logoBox.Location = new Point(10, 5); logoBox.Name = "logoBox"; logoBox.Size = new Size(100, 50); logoBox.TabStop = false;
            lblTitle.BackColor = Color.Transparent; lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold); lblTitle.ForeColor = Color.FromArgb(0, 150, 136); lblTitle.Location = new Point(120, 10); lblTitle.Name = "lblTitle"; lblTitle.Size = new Size(400, 40); lblTitle.Text = "Patients";
            dgvPatients.BackgroundColor = Color.FromArgb(45, 45, 45); dgvPatients.ForeColor = Color.Black; dgvPatients.Location = new Point(20, 65); dgvPatients.Name = "dgvPatients"; dgvPatients.Size = new Size(860, 420); dgvPatients.ReadOnly = true; dgvPatients.AllowUserToAddRows = false; dgvPatients.SelectionMode = DataGridViewSelectionMode.FullRowSelect; dgvPatients.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 150, 136); dgvPatients.ColumnHeadersDefaultCellStyle.ForeColor = Color.White; dgvPatients.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold); dgvPatients.EnableHeadersVisualStyles = false; dgvPatients.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnBack.BackColor = Color.FromArgb(55, 55, 55); btnBack.FlatStyle = FlatStyle.Flat; btnBack.FlatAppearance.BorderSize = 0; btnBack.Font = new Font("Segoe UI", 10F, FontStyle.Bold); btnBack.ForeColor = Color.White; btnBack.Location = new Point(740, 500); btnBack.Name = "btnBack"; btnBack.Size = new Size(140, 40); btnBack.Text = "< Back"; btnBack.Anchor = AnchorStyles.Bottom | AnchorStyles.Right; btnBack.Click += btnBack_Click;
            AutoScaleDimensions = new SizeF(8F, 20F); AutoScaleMode = AutoScaleMode.Font; BackgroundImage = Properties.Resources.app_backround; BackgroundImageLayout = ImageLayout.Stretch; ClientSize = new Size(914, 560); Controls.Add(logoBox); Controls.Add(lblTitle); Controls.Add(dgvPatients); Controls.Add(btnBack); DoubleBuffered = true; Name = "ManagePatients"; StartPosition = FormStartPosition.CenterScreen; Text = "Dentora - Patients"; Load += ManagePatients_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPatients).EndInit(); ((System.ComponentModel.ISupportInitialize)logoBox).EndInit(); ResumeLayout(false);
        }
        #endregion
        private DataGridView dgvPatients; private Button btnBack; private Label lblTitle; private PictureBox logoBox;
    }
}
