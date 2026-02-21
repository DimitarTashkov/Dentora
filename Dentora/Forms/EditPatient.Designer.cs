namespace Dentora.Forms
{
    partial class EditPatient
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing) { if (disposing && (components != null)) components.Dispose(); base.Dispose(disposing); }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            lblHeader = new Label();
            lblUsername = new Label(); txtUsername = new TextBox();
            lblEmail = new Label(); txtEmail = new TextBox();
            lblFullName = new Label(); txtFullName = new TextBox();
            lblPhone = new Label(); txtPhone = new TextBox();
            lblAge = new Label(); nudAge = new NumericUpDown();
            btnSave = new Button(); btnCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)nudAge).BeginInit();
            SuspendLayout();
            // lblHeader
            lblHeader.Font = new Font("Segoe UI", 16F, FontStyle.Bold); lblHeader.ForeColor = Color.FromArgb(0, 150, 136); lblHeader.Location = new Point(20, 10); lblHeader.Size = new Size(360, 40); lblHeader.Text = "\u270F\uFE0F Edit Patient";
            // lblUsername
            lblUsername.AutoSize = true; lblUsername.Font = new Font("Segoe UI", 11F, FontStyle.Bold); lblUsername.Location = new Point(30, 65); lblUsername.Text = "Username *";
            // txtUsername
            txtUsername.Location = new Point(30, 90); txtUsername.Size = new Size(320, 27); txtUsername.Font = new Font("Segoe UI", 11F);
            // lblEmail
            lblEmail.AutoSize = true; lblEmail.Font = new Font("Segoe UI", 11F, FontStyle.Bold); lblEmail.Location = new Point(30, 125); lblEmail.Text = "Email *";
            // txtEmail
            txtEmail.Location = new Point(30, 150); txtEmail.Size = new Size(320, 27); txtEmail.Font = new Font("Segoe UI", 11F);
            // lblFullName
            lblFullName.AutoSize = true; lblFullName.Font = new Font("Segoe UI", 11F, FontStyle.Bold); lblFullName.Location = new Point(30, 185); lblFullName.Text = "Full Name";
            // txtFullName
            txtFullName.Location = new Point(30, 210); txtFullName.Size = new Size(320, 27); txtFullName.Font = new Font("Segoe UI", 11F);
            // lblPhone
            lblPhone.AutoSize = true; lblPhone.Font = new Font("Segoe UI", 11F, FontStyle.Bold); lblPhone.Location = new Point(30, 245); lblPhone.Text = "Phone";
            // txtPhone
            txtPhone.Location = new Point(30, 270); txtPhone.Size = new Size(320, 27); txtPhone.Font = new Font("Segoe UI", 11F);
            // lblAge
            lblAge.AutoSize = true; lblAge.Font = new Font("Segoe UI", 11F, FontStyle.Bold); lblAge.Location = new Point(30, 305); lblAge.Text = "Age";
            // nudAge
            nudAge.Location = new Point(30, 330); nudAge.Size = new Size(120, 27); nudAge.Minimum = 1; nudAge.Maximum = 120; nudAge.Value = 25; nudAge.Font = new Font("Segoe UI", 11F);
            // btnSave
            btnSave.BackColor = Color.FromArgb(0, 150, 136); btnSave.FlatStyle = FlatStyle.Flat; btnSave.FlatAppearance.BorderSize = 0; btnSave.Font = new Font("Segoe UI", 11F, FontStyle.Bold); btnSave.ForeColor = Color.White; btnSave.Location = new Point(30, 380); btnSave.Size = new Size(140, 45); btnSave.Text = "\U0001F4BE Save"; btnSave.Click += btnSave_Click;
            // btnCancel
            btnCancel.BackColor = Color.FromArgb(55, 55, 55); btnCancel.FlatStyle = FlatStyle.Flat; btnCancel.FlatAppearance.BorderSize = 0; btnCancel.Font = new Font("Segoe UI", 11F, FontStyle.Bold); btnCancel.ForeColor = Color.White; btnCancel.Location = new Point(200, 380); btnCancel.Size = new Size(140, 45); btnCancel.Text = "Cancel"; btnCancel.Click += btnCancel_Click;
            // EditPatient
            AutoScaleDimensions = new SizeF(8F, 20F); AutoScaleMode = AutoScaleMode.Font; ClientSize = new Size(400, 450); Controls.Add(lblHeader); Controls.Add(lblUsername); Controls.Add(txtUsername); Controls.Add(lblEmail); Controls.Add(txtEmail); Controls.Add(lblFullName); Controls.Add(txtFullName); Controls.Add(lblPhone); Controls.Add(txtPhone); Controls.Add(lblAge); Controls.Add(nudAge); Controls.Add(btnSave); Controls.Add(btnCancel); FormBorderStyle = FormBorderStyle.FixedDialog; Icon = Icon.FromHandle(Properties.Resources.dentora_logo1.GetHicon()); MaximizeBox = false; Name = "EditPatient"; StartPosition = FormStartPosition.CenterParent; Text = "Dentora - Edit Patient"; Load += EditPatient_Load;
            ((System.ComponentModel.ISupportInitialize)nudAge).EndInit(); ResumeLayout(false); PerformLayout();
        }
        #endregion

        private Label lblHeader;
        private Label lblUsername; private TextBox txtUsername;
        private Label lblEmail; private TextBox txtEmail;
        private Label lblFullName; private TextBox txtFullName;
        private Label lblPhone; private TextBox txtPhone;
        private Label lblAge; private NumericUpDown nudAge;
        private Button btnSave; private Button btnCancel;
    }
}
