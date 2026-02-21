namespace Dentora.Forms
{
    partial class AddEditInventoryItem
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing) { if (disposing && (components != null)) components.Dispose(); base.Dispose(disposing); }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            lblHeader = new Label(); txtName = new TextBox(); lblName = new Label(); txtDescription = new TextBox(); lblDescription = new Label();
            nudQuantity = new NumericUpDown(); lblQuantity = new Label(); nudPrice = new NumericUpDown(); lblPrice = new Label();
            lblImage = new Label(); picImage = new PictureBox(); btnBrowseImage = new Button(); btnClearImage = new Button();
            btnSave = new Button(); btnCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).BeginInit(); ((System.ComponentModel.ISupportInitialize)nudPrice).BeginInit(); ((System.ComponentModel.ISupportInitialize)picImage).BeginInit(); SuspendLayout();
            lblHeader.Font = new Font("Segoe UI", 16F, FontStyle.Bold); lblHeader.ForeColor = Color.FromArgb(0, 150, 136); lblHeader.Location = new Point(20, 10); lblHeader.Name = "lblHeader"; lblHeader.Size = new Size(360, 40); lblHeader.Text = "\U0001F4E6 Add Inventory Item";
            lblName.AutoSize = true; lblName.Font = new Font("Segoe UI", 11F, FontStyle.Bold); lblName.Location = new Point(30, 65); lblName.Text = "Name *";
            txtName.Location = new Point(30, 90); txtName.Size = new Size(320, 27); txtName.Font = new Font("Segoe UI", 11F);
            lblDescription.AutoSize = true; lblDescription.Font = new Font("Segoe UI", 11F, FontStyle.Bold); lblDescription.Location = new Point(30, 125); lblDescription.Text = "Description";
            txtDescription.Location = new Point(30, 150); txtDescription.Size = new Size(320, 55); txtDescription.Multiline = true; txtDescription.Font = new Font("Segoe UI", 11F);
            lblQuantity.AutoSize = true; lblQuantity.Font = new Font("Segoe UI", 11F, FontStyle.Bold); lblQuantity.Location = new Point(30, 215); lblQuantity.Text = "Quantity";
            nudQuantity.Location = new Point(30, 240); nudQuantity.Size = new Size(140, 27); nudQuantity.Maximum = 99999; nudQuantity.Font = new Font("Segoe UI", 11F);
            lblPrice.AutoSize = true; lblPrice.Font = new Font("Segoe UI", 11F, FontStyle.Bold); lblPrice.Location = new Point(200, 215); lblPrice.Text = "Price";
            nudPrice.Location = new Point(200, 240); nudPrice.Size = new Size(140, 27); nudPrice.DecimalPlaces = 2; nudPrice.Maximum = 99999; nudPrice.Font = new Font("Segoe UI", 11F);
            // lblImage
            lblImage.AutoSize = true; lblImage.Font = new Font("Segoe UI", 11F, FontStyle.Bold); lblImage.Location = new Point(30, 280); lblImage.Text = "Image";
            // picImage
            picImage.Location = new Point(30, 305); picImage.Size = new Size(120, 90); picImage.SizeMode = PictureBoxSizeMode.Zoom; picImage.BorderStyle = BorderStyle.FixedSingle; picImage.BackColor = Color.FromArgb(45, 45, 45);
            // btnBrowseImage
            btnBrowseImage.BackColor = Color.FromArgb(0, 150, 136); btnBrowseImage.FlatStyle = FlatStyle.Flat; btnBrowseImage.FlatAppearance.BorderSize = 0; btnBrowseImage.Font = new Font("Segoe UI", 9F, FontStyle.Bold); btnBrowseImage.ForeColor = Color.White; btnBrowseImage.Location = new Point(160, 305); btnBrowseImage.Size = new Size(100, 35); btnBrowseImage.Text = "\U0001F4C2 Browse"; btnBrowseImage.Click += btnBrowseImage_Click;
            // btnClearImage
            btnClearImage.BackColor = Color.FromArgb(55, 55, 55); btnClearImage.FlatStyle = FlatStyle.Flat; btnClearImage.FlatAppearance.BorderSize = 0; btnClearImage.Font = new Font("Segoe UI", 9F, FontStyle.Bold); btnClearImage.ForeColor = Color.White; btnClearImage.Location = new Point(270, 305); btnClearImage.Size = new Size(80, 35); btnClearImage.Text = "Clear"; btnClearImage.Click += btnClearImage_Click;
            btnSave.BackColor = Color.FromArgb(0, 150, 136); btnSave.FlatStyle = FlatStyle.Flat; btnSave.FlatAppearance.BorderSize = 0; btnSave.Font = new Font("Segoe UI", 11F, FontStyle.Bold); btnSave.ForeColor = Color.White; btnSave.Location = new Point(30, 410); btnSave.Size = new Size(140, 45); btnSave.Text = "\U0001F4BE Save"; btnSave.Click += btnSave_Click;
            btnCancel.BackColor = Color.FromArgb(55, 55, 55); btnCancel.FlatStyle = FlatStyle.Flat; btnCancel.FlatAppearance.BorderSize = 0; btnCancel.Font = new Font("Segoe UI", 11F, FontStyle.Bold); btnCancel.ForeColor = Color.White; btnCancel.Location = new Point(200, 410); btnCancel.Size = new Size(140, 45); btnCancel.Text = "Cancel"; btnCancel.Click += btnCancel_Click;
            AutoScaleDimensions = new SizeF(8F, 20F); AutoScaleMode = AutoScaleMode.Font; ClientSize = new Size(400, 475); Controls.Add(lblHeader); Controls.Add(lblName); Controls.Add(txtName); Controls.Add(lblDescription); Controls.Add(txtDescription); Controls.Add(lblQuantity); Controls.Add(nudQuantity); Controls.Add(lblPrice); Controls.Add(nudPrice); Controls.Add(lblImage); Controls.Add(picImage); Controls.Add(btnBrowseImage); Controls.Add(btnClearImage); Controls.Add(btnSave); Controls.Add(btnCancel); FormBorderStyle = FormBorderStyle.FixedDialog; Icon = Icon.FromHandle(Properties.Resources.dentora_logo1.GetHicon()); MaximizeBox = false; Name = "AddEditInventoryItem"; StartPosition = FormStartPosition.CenterParent; Text = "Dentora - Inventory Item"; Load += AddEditInventoryItem_Load;
            ((System.ComponentModel.ISupportInitialize)nudQuantity).EndInit(); ((System.ComponentModel.ISupportInitialize)nudPrice).EndInit(); ((System.ComponentModel.ISupportInitialize)picImage).EndInit(); ResumeLayout(false); PerformLayout();
        }
        #endregion
        private Label lblHeader; private TextBox txtName; private Label lblName; private TextBox txtDescription; private Label lblDescription;
        private NumericUpDown nudQuantity; private Label lblQuantity; private NumericUpDown nudPrice; private Label lblPrice;
        private Label lblImage; private PictureBox picImage; private Button btnBrowseImage; private Button btnClearImage;
        private Button btnSave; private Button btnCancel;
    }
}
