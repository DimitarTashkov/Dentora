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
            btnSave = new Button(); btnCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).BeginInit(); ((System.ComponentModel.ISupportInitialize)nudPrice).BeginInit(); SuspendLayout();
            lblHeader.Font = new Font("Segoe UI", 16F, FontStyle.Bold); lblHeader.ForeColor = Color.FromArgb(0, 150, 136); lblHeader.Location = new Point(20, 10); lblHeader.Name = "lblHeader"; lblHeader.Size = new Size(360, 40); lblHeader.Text = "Add Inventory Item";
            lblName.AutoSize = true; lblName.Font = new Font("Segoe UI", 11F, FontStyle.Bold); lblName.Location = new Point(30, 65); lblName.Text = "Name *";
            txtName.Location = new Point(30, 90); txtName.Size = new Size(320, 27); txtName.Font = new Font("Segoe UI", 11F);
            lblDescription.AutoSize = true; lblDescription.Font = new Font("Segoe UI", 11F, FontStyle.Bold); lblDescription.Location = new Point(30, 125); lblDescription.Text = "Description";
            txtDescription.Location = new Point(30, 150); txtDescription.Size = new Size(320, 55); txtDescription.Multiline = true; txtDescription.Font = new Font("Segoe UI", 11F);
            lblQuantity.AutoSize = true; lblQuantity.Font = new Font("Segoe UI", 11F, FontStyle.Bold); lblQuantity.Location = new Point(30, 215); lblQuantity.Text = "Quantity";
            nudQuantity.Location = new Point(30, 240); nudQuantity.Size = new Size(140, 27); nudQuantity.Maximum = 99999; nudQuantity.Font = new Font("Segoe UI", 11F);
            lblPrice.AutoSize = true; lblPrice.Font = new Font("Segoe UI", 11F, FontStyle.Bold); lblPrice.Location = new Point(200, 215); lblPrice.Text = "Price";
            nudPrice.Location = new Point(200, 240); nudPrice.Size = new Size(140, 27); nudPrice.DecimalPlaces = 2; nudPrice.Maximum = 99999; nudPrice.Font = new Font("Segoe UI", 11F);
            btnSave.BackColor = Color.FromArgb(0, 150, 136); btnSave.FlatStyle = FlatStyle.Flat; btnSave.FlatAppearance.BorderSize = 0; btnSave.Font = new Font("Segoe UI", 11F, FontStyle.Bold); btnSave.ForeColor = Color.White; btnSave.Location = new Point(30, 290); btnSave.Size = new Size(140, 45); btnSave.Text = "Save"; btnSave.Click += btnSave_Click;
            btnCancel.BackColor = Color.FromArgb(55, 55, 55); btnCancel.FlatStyle = FlatStyle.Flat; btnCancel.FlatAppearance.BorderSize = 0; btnCancel.Font = new Font("Segoe UI", 11F, FontStyle.Bold); btnCancel.ForeColor = Color.White; btnCancel.Location = new Point(200, 290); btnCancel.Size = new Size(140, 45); btnCancel.Text = "Cancel"; btnCancel.Click += btnCancel_Click;
            AutoScaleDimensions = new SizeF(8F, 20F); AutoScaleMode = AutoScaleMode.Font; ClientSize = new Size(400, 360); Controls.Add(lblHeader); Controls.Add(lblName); Controls.Add(txtName); Controls.Add(lblDescription); Controls.Add(txtDescription); Controls.Add(lblQuantity); Controls.Add(nudQuantity); Controls.Add(lblPrice); Controls.Add(nudPrice); Controls.Add(btnSave); Controls.Add(btnCancel); FormBorderStyle = FormBorderStyle.FixedDialog; MaximizeBox = false; Name = "AddEditInventoryItem"; StartPosition = FormStartPosition.CenterParent; Text = "Dentora - Inventory Item"; Load += AddEditInventoryItem_Load;
            ((System.ComponentModel.ISupportInitialize)nudQuantity).EndInit(); ((System.ComponentModel.ISupportInitialize)nudPrice).EndInit(); ResumeLayout(false); PerformLayout();
        }
        #endregion
        private Label lblHeader; private TextBox txtName; private Label lblName; private TextBox txtDescription; private Label lblDescription;
        private NumericUpDown nudQuantity; private Label lblQuantity; private NumericUpDown nudPrice; private Label lblPrice;
        private Button btnSave; private Button btnCancel;
    }
}
