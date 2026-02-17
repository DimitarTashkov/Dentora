namespace Dentora.Forms
{
    partial class AddEditTreatment
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing) { if (disposing && (components != null)) components.Dispose(); base.Dispose(disposing); }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            lblHeader = new Label();
            txtTitle = new TextBox(); lblTitle = new Label();
            txtDescription = new TextBox(); lblDescription = new Label();
            txtCategory = new TextBox(); lblCategory = new Label();
            nudDuration = new NumericUpDown(); lblDuration = new Label();
            nudPrice = new NumericUpDown(); lblPrice = new Label();
            chkActive = new CheckBox();
            btnSave = new Button();
            btnCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)nudDuration).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudPrice).BeginInit();
            SuspendLayout();
            // lblHeader
            lblHeader.Font = new Font("Segoe UI", 16F, FontStyle.Bold); lblHeader.ForeColor = Color.FromArgb(0, 150, 136); lblHeader.Location = new Point(20, 10); lblHeader.Name = "lblHeader"; lblHeader.Size = new Size(400, 40); lblHeader.Text = "Add Treatment";
            // lblTitle
            lblTitle.AutoSize = true; lblTitle.Font = new Font("Segoe UI", 11F, FontStyle.Bold); lblTitle.Location = new Point(30, 65); lblTitle.Text = "Title *";
            // txtTitle
            txtTitle.Location = new Point(30, 90); txtTitle.Size = new Size(350, 27); txtTitle.Font = new Font("Segoe UI", 11F);
            // lblDescription
            lblDescription.AutoSize = true; lblDescription.Font = new Font("Segoe UI", 11F, FontStyle.Bold); lblDescription.Location = new Point(30, 130); lblDescription.Text = "Description";
            // txtDescription
            txtDescription.Location = new Point(30, 155); txtDescription.Size = new Size(350, 60); txtDescription.Multiline = true; txtDescription.Font = new Font("Segoe UI", 11F);
            // lblCategory
            lblCategory.AutoSize = true; lblCategory.Font = new Font("Segoe UI", 11F, FontStyle.Bold); lblCategory.Location = new Point(30, 225); lblCategory.Text = "Category *";
            // txtCategory
            txtCategory.Location = new Point(30, 250); txtCategory.Size = new Size(350, 27); txtCategory.Font = new Font("Segoe UI", 11F);
            // lblDuration
            lblDuration.AutoSize = true; lblDuration.Font = new Font("Segoe UI", 11F, FontStyle.Bold); lblDuration.Location = new Point(30, 290); lblDuration.Text = "Duration (min)";
            // nudDuration
            nudDuration.Location = new Point(30, 315); nudDuration.Size = new Size(150, 27); nudDuration.Minimum = 5; nudDuration.Maximum = 480; nudDuration.Value = 30; nudDuration.Font = new Font("Segoe UI", 11F);
            // lblPrice
            lblPrice.AutoSize = true; lblPrice.Font = new Font("Segoe UI", 11F, FontStyle.Bold); lblPrice.Location = new Point(200, 290); lblPrice.Text = "Price";
            // nudPrice
            nudPrice.Location = new Point(200, 315); nudPrice.Size = new Size(150, 27); nudPrice.DecimalPlaces = 2; nudPrice.Maximum = 99999; nudPrice.Font = new Font("Segoe UI", 11F);
            // chkActive
            chkActive.AutoSize = true; chkActive.Checked = true; chkActive.Font = new Font("Segoe UI", 11F, FontStyle.Bold); chkActive.Location = new Point(30, 355); chkActive.Text = "Active";
            // btnSave
            btnSave.BackColor = Color.FromArgb(0, 150, 136); btnSave.FlatStyle = FlatStyle.Flat; btnSave.FlatAppearance.BorderSize = 0; btnSave.Font = new Font("Segoe UI", 11F, FontStyle.Bold); btnSave.ForeColor = Color.White; btnSave.Location = new Point(30, 400); btnSave.Size = new Size(150, 45); btnSave.Text = "Save"; btnSave.Click += btnSave_Click;
            // btnCancel
            btnCancel.BackColor = Color.FromArgb(55, 55, 55); btnCancel.FlatStyle = FlatStyle.Flat; btnCancel.FlatAppearance.BorderSize = 0; btnCancel.Font = new Font("Segoe UI", 11F, FontStyle.Bold); btnCancel.ForeColor = Color.White; btnCancel.Location = new Point(200, 400); btnCancel.Size = new Size(150, 45); btnCancel.Text = "Cancel"; btnCancel.Click += btnCancel_Click;
            // AddEditTreatment
            AutoScaleDimensions = new SizeF(8F, 20F); AutoScaleMode = AutoScaleMode.Font; ClientSize = new Size(420, 470); Controls.Add(lblHeader); Controls.Add(lblTitle); Controls.Add(txtTitle); Controls.Add(lblDescription); Controls.Add(txtDescription); Controls.Add(lblCategory); Controls.Add(txtCategory); Controls.Add(lblDuration); Controls.Add(nudDuration); Controls.Add(lblPrice); Controls.Add(nudPrice); Controls.Add(chkActive); Controls.Add(btnSave); Controls.Add(btnCancel); FormBorderStyle = FormBorderStyle.FixedDialog; MaximizeBox = false; Name = "AddEditTreatment"; StartPosition = FormStartPosition.CenterParent; Text = "Dentora - Treatment"; Load += AddEditTreatment_Load;
            ((System.ComponentModel.ISupportInitialize)nudDuration).EndInit(); ((System.ComponentModel.ISupportInitialize)nudPrice).EndInit(); ResumeLayout(false); PerformLayout();
        }
        #endregion

        private Label lblHeader;
        private TextBox txtTitle; private Label lblTitle;
        private TextBox txtDescription; private Label lblDescription;
        private TextBox txtCategory; private Label lblCategory;
        private NumericUpDown nudDuration; private Label lblDuration;
        private NumericUpDown nudPrice; private Label lblPrice;
        private CheckBox chkActive;
        private Button btnSave;
        private Button btnCancel;
    }
}
