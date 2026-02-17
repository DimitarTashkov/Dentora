namespace Dentora.Forms
{
    partial class Register
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            formPanel = new Panel();
            pfpErrorMessages = new Label();
            ageErrors = new Label();
            emailErrors = new Label();
            passwordErrors = new Label();
            usernameErrors = new Label();
            disclaimer = new Label();
            navigationButton = new Button();
            profilePicture = new Dentora.Utilities.RoundPictureBox();
            registerButton = new Button();
            uploadButton = new Button();
            fullNameField = new TextBox();
            fullNameLabel = new Label();
            phoneField = new TextBox();
            phoneLabel = new Label();
            ageField = new TextBox();
            ageLabel = new Label();
            emailField = new TextBox();
            emailLabel = new Label();
            passwordField = new TextBox();
            passwordLabel = new Label();
            usernameField = new TextBox();
            usernameLabel = new Label();
            logo = new PictureBox();
            register_label = new Label();
            formPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)profilePicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            SuspendLayout();
            // 
            // formPanel
            // 
            formPanel.BackColor = SystemColors.Control;
            formPanel.BackgroundImage = Properties.Resources.gradient_img__4_;
            formPanel.BackgroundImageLayout = ImageLayout.Stretch;
            formPanel.Controls.Add(pfpErrorMessages);
            formPanel.Controls.Add(ageErrors);
            formPanel.Controls.Add(emailErrors);
            formPanel.Controls.Add(passwordErrors);
            formPanel.Controls.Add(usernameErrors);
            formPanel.Controls.Add(disclaimer);
            formPanel.Controls.Add(navigationButton);
            formPanel.Controls.Add(profilePicture);
            formPanel.Controls.Add(registerButton);
            formPanel.Controls.Add(uploadButton);
            formPanel.Controls.Add(fullNameField);
            formPanel.Controls.Add(fullNameLabel);
            formPanel.Controls.Add(phoneField);
            formPanel.Controls.Add(phoneLabel);
            formPanel.Controls.Add(ageField);
            formPanel.Controls.Add(ageLabel);
            formPanel.Controls.Add(emailField);
            formPanel.Controls.Add(emailLabel);
            formPanel.Controls.Add(passwordField);
            formPanel.Controls.Add(passwordLabel);
            formPanel.Controls.Add(usernameField);
            formPanel.Controls.Add(usernameLabel);
            formPanel.Controls.Add(logo);
            formPanel.Controls.Add(register_label);
            formPanel.Location = new Point(57, 12);
            formPanel.Margin = new Padding(3, 4, 3, 4);
            formPanel.Name = "formPanel";
            formPanel.Size = new Size(800, 570);
            formPanel.TabIndex = 1;
            formPanel.Paint += formPanel_Paint;
            // 
            // pfpErrorMessages
            // 
            pfpErrorMessages.AutoSize = true;
            pfpErrorMessages.BackColor = Color.Transparent;
            pfpErrorMessages.Font = new Font("Verdana", 8.25F, FontStyle.Bold | FontStyle.Italic);
            pfpErrorMessages.ForeColor = Color.Red;
            pfpErrorMessages.Location = new Point(487, 337);
            pfpErrorMessages.Name = "pfpErrorMessages";
            pfpErrorMessages.Size = new Size(54, 17);
            pfpErrorMessages.TabIndex = 23;
            pfpErrorMessages.Text = "label1";
            pfpErrorMessages.Visible = false;
            // 
            // ageErrors
            // 
            ageErrors.AutoSize = true;
            ageErrors.BackColor = Color.Transparent;
            ageErrors.Font = new Font("Verdana", 8.25F, FontStyle.Bold | FontStyle.Italic);
            ageErrors.ForeColor = Color.Red;
            ageErrors.Location = new Point(420, 393);
            ageErrors.Name = "ageErrors";
            ageErrors.Size = new Size(54, 17);
            ageErrors.TabIndex = 22;
            ageErrors.Text = "label1";
            ageErrors.Visible = false;
            // 
            // emailErrors
            // 
            emailErrors.AutoSize = true;
            emailErrors.BackColor = Color.Transparent;
            emailErrors.Font = new Font("Verdana", 8.25F, FontStyle.Bold | FontStyle.Italic);
            emailErrors.ForeColor = Color.Red;
            emailErrors.Location = new Point(131, 301);
            emailErrors.Name = "emailErrors";
            emailErrors.Size = new Size(54, 17);
            emailErrors.TabIndex = 21;
            emailErrors.Text = "label1";
            emailErrors.Visible = false;
            // 
            // passwordErrors
            // 
            passwordErrors.AutoSize = true;
            passwordErrors.BackColor = Color.Transparent;
            passwordErrors.Font = new Font("Verdana", 8.25F, FontStyle.Bold | FontStyle.Italic);
            passwordErrors.ForeColor = Color.Red;
            passwordErrors.Location = new Point(131, 211);
            passwordErrors.Name = "passwordErrors";
            passwordErrors.Size = new Size(54, 17);
            passwordErrors.TabIndex = 20;
            passwordErrors.Text = "label1";
            passwordErrors.Visible = false;
            // 
            // usernameErrors
            // 
            usernameErrors.AutoSize = true;
            usernameErrors.BackColor = Color.Transparent;
            usernameErrors.Font = new Font("Verdana", 8.25F, FontStyle.Bold | FontStyle.Italic);
            usernameErrors.ForeColor = Color.Red;
            usernameErrors.Location = new Point(131, 120);
            usernameErrors.Name = "usernameErrors";
            usernameErrors.Size = new Size(54, 17);
            usernameErrors.TabIndex = 19;
            usernameErrors.Text = "label1";
            usernameErrors.Visible = false;
            // 
            // disclaimer
            // 
            disclaimer.AutoSize = true;
            disclaimer.BackColor = Color.Transparent;
            disclaimer.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            disclaimer.ForeColor = Color.DimGray;
            disclaimer.Location = new Point(0, 520);
            disclaimer.Name = "disclaimer";
            disclaimer.Size = new Size(199, 25);
            disclaimer.TabIndex = 18;
            disclaimer.Text = "(if you have account)";
            // 
            // navigationButton
            // 
            navigationButton.BackColor = Color.FromArgb(34, 34, 34);
            navigationButton.FlatStyle = FlatStyle.Flat;
            navigationButton.FlatAppearance.BorderSize = 0;
            navigationButton.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            navigationButton.ForeColor = Color.White;
            navigationButton.Location = new Point(0, 460);
            navigationButton.Margin = new Padding(3, 4, 3, 4);
            navigationButton.Name = "navigationButton";
            navigationButton.Size = new Size(183, 55);
            navigationButton.TabIndex = 17;
            navigationButton.Text = "Return to login";
            navigationButton.UseVisualStyleBackColor = false;
            navigationButton.Click += navigationButton_Click;
            // 
            // profilePicture
            // 
            profilePicture.Location = new Point(526, 69);
            profilePicture.Margin = new Padding(3, 4, 3, 4);
            profilePicture.Name = "profilePicture";
            profilePicture.Size = new Size(165, 157);
            profilePicture.SizeMode = PictureBoxSizeMode.StretchImage;
            profilePicture.TabIndex = 16;
            profilePicture.TabStop = false;
            // 
            // registerButton
            // 
            registerButton.BackColor = Color.FromArgb(0, 150, 136);
            registerButton.FlatStyle = FlatStyle.Flat;
            registerButton.FlatAppearance.BorderSize = 0;
            registerButton.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            registerButton.ForeColor = Color.White;
            registerButton.Location = new Point(507, 460);
            registerButton.Margin = new Padding(3, 4, 3, 4);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(183, 55);
            registerButton.TabIndex = 15;
            registerButton.Text = "Register";
            registerButton.UseVisualStyleBackColor = false;
            registerButton.Click += btnRegister_Click;
            // 
            // uploadButton
            // 
            uploadButton.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            uploadButton.Location = new Point(526, 267);
            uploadButton.Margin = new Padding(3, 4, 3, 4);
            uploadButton.Name = "uploadButton";
            uploadButton.Size = new Size(149, 40);
            uploadButton.TabIndex = 13;
            uploadButton.Text = "Upload pfp";
            uploadButton.UseVisualStyleBackColor = true;
            uploadButton.Click += uploadImage_click;
            // 
            // fullNameLabel
            // 
            fullNameLabel.AutoSize = true;
            fullNameLabel.BackColor = Color.Transparent;
            fullNameLabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            fullNameLabel.ForeColor = Color.FromArgb(0, 150, 136);
            fullNameLabel.Location = new Point(487, 321);
            fullNameLabel.Name = "fullNameLabel";
            fullNameLabel.Size = new Size(90, 25);
            fullNameLabel.TabIndex = 24;
            fullNameLabel.Text = "Full Name";
            // 
            // fullNameField
            // 
            fullNameField.BackColor = Color.FromArgb(45, 45, 45);
            fullNameField.Font = new Font("Verdana", 9.75F, FontStyle.Bold | FontStyle.Italic);
            fullNameField.ForeColor = Color.White;
            fullNameField.BorderStyle = BorderStyle.FixedSingle;
            fullNameField.Location = new Point(487, 349);
            fullNameField.Name = "fullNameField";
            fullNameField.Size = new Size(220, 27);
            fullNameField.TabIndex = 25;
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.BackColor = Color.Transparent;
            phoneLabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            phoneLabel.ForeColor = Color.FromArgb(0, 150, 136);
            phoneLabel.Location = new Point(487, 385);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new Size(60, 25);
            phoneLabel.TabIndex = 26;
            phoneLabel.Text = "Phone";
            // 
            // phoneField
            // 
            phoneField.BackColor = Color.FromArgb(45, 45, 45);
            phoneField.Font = new Font("Verdana", 9.75F, FontStyle.Bold | FontStyle.Italic);
            phoneField.ForeColor = Color.White;
            phoneField.BorderStyle = BorderStyle.FixedSingle;
            phoneField.Location = new Point(487, 413);
            phoneField.Name = "phoneField";
            phoneField.Size = new Size(220, 27);
            phoneField.TabIndex = 27;
            // 
            // ageField
            // 
            ageField.BackColor = Color.FromArgb(45, 45, 45);
            ageField.Font = new Font("Verdana", 9.75F, FontStyle.Bold | FontStyle.Italic);
            ageField.ForeColor = Color.White;
            ageField.BorderStyle = BorderStyle.FixedSingle;
            ageField.Location = new Point(131, 359);
            ageField.Margin = new Padding(3, 4, 3, 4);
            ageField.Name = "ageField";
            ageField.Size = new Size(278, 27);
            ageField.TabIndex = 12;
            // 
            // ageLabel
            // 
            ageLabel.AutoSize = true;
            ageLabel.BackColor = Color.Transparent;
            ageLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            ageLabel.ForeColor = Color.FromArgb(0, 150, 136);
            ageLabel.Location = new Point(215, 321);
            ageLabel.Name = "ageLabel";
            ageLabel.Size = new Size(59, 32);
            ageLabel.TabIndex = 11;
            ageLabel.Text = "Age";
            // 
            // emailField
            // 
            emailField.BackColor = Color.FromArgb(45, 45, 45);
            emailField.Font = new Font("Verdana", 9.75F, FontStyle.Bold | FontStyle.Italic);
            emailField.ForeColor = Color.White;
            emailField.BorderStyle = BorderStyle.FixedSingle;
            emailField.Location = new Point(131, 267);
            emailField.Margin = new Padding(3, 4, 3, 4);
            emailField.Name = "emailField";
            emailField.Size = new Size(278, 27);
            emailField.TabIndex = 10;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.BackColor = Color.Transparent;
            emailLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            emailLabel.ForeColor = Color.FromArgb(0, 150, 136);
            emailLabel.Location = new Point(215, 229);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(87, 32);
            emailLabel.TabIndex = 9;
            emailLabel.Text = "*Email";
            // 
            // passwordField
            // 
            passwordField.BackColor = Color.FromArgb(45, 45, 45);
            passwordField.Font = new Font("Verdana", 9.75F, FontStyle.Bold | FontStyle.Italic);
            passwordField.ForeColor = Color.White;
            passwordField.BorderStyle = BorderStyle.FixedSingle;
            passwordField.Location = new Point(131, 176);
            passwordField.Margin = new Padding(3, 4, 3, 4);
            passwordField.Name = "passwordField";
            passwordField.Size = new Size(278, 27);
            passwordField.TabIndex = 8;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.BackColor = Color.Transparent;
            passwordLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            passwordLabel.ForeColor = Color.FromArgb(0, 150, 136);
            passwordLabel.Location = new Point(215, 139);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(133, 32);
            passwordLabel.TabIndex = 7;
            passwordLabel.Text = "*Password";
            // 
            // usernameField
            // 
            usernameField.BackColor = Color.FromArgb(45, 45, 45);
            usernameField.Font = new Font("Verdana", 9.75F, FontStyle.Bold | FontStyle.Italic);
            usernameField.ForeColor = Color.White;
            usernameField.BorderStyle = BorderStyle.FixedSingle;
            usernameField.Location = new Point(131, 85);
            usernameField.Margin = new Padding(3, 4, 3, 4);
            usernameField.Name = "usernameField";
            usernameField.Size = new Size(278, 27);
            usernameField.TabIndex = 6;
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.BackColor = Color.Transparent;
            usernameLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            usernameLabel.ForeColor = Color.FromArgb(0, 150, 136);
            usernameLabel.Location = new Point(215, 48);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(139, 32);
            usernameLabel.TabIndex = 5;
            usernameLabel.Text = "*Username";
            // 
            // logo
            // 
            logo.BackColor = Color.Transparent;
            logo.BackgroundImage = Properties.Resources.dentora_logo;
            logo.BackgroundImageLayout = ImageLayout.Stretch;
            logo.Location = new Point(-13, -32);
            logo.Margin = new Padding(3, 4, 3, 4);
            logo.Name = "logo";
            logo.Size = new Size(184, 213);
            logo.TabIndex = 1;
            logo.TabStop = false;
            // 
            // register_label
            // 
            register_label.AutoSize = true;
            register_label.BackColor = Color.Transparent;
            register_label.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            register_label.ForeColor = Color.FromArgb(0, 150, 136);
            register_label.Location = new Point(261, 0);
            register_label.Name = "register_label";
            register_label.Size = new Size(275, 37);
            register_label.TabIndex = 0;
            register_label.Text = "Register Credentials";
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.app_backround;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(914, 600);
            Controls.Add(formPanel);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "Register";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dentora - Register";
            Load += Register_Load;
            formPanel.ResumeLayout(false);
            formPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)profilePicture).EndInit();
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel formPanel;
        private Label disclaimer;
        private Button navigationButton;
        private Dentora.Utilities.RoundPictureBox profilePicture;
        private Button registerButton;
        private Button uploadButton;
        private TextBox fullNameField;
        private Label fullNameLabel;
        private TextBox phoneField;
        private Label phoneLabel;
        private TextBox ageField;
        private Label ageLabel;
        private TextBox emailField;
        private Label emailLabel;
        private TextBox passwordField;
        private Label passwordLabel;
        private TextBox usernameField;
        private Label usernameLabel;
        private PictureBox logo;
        private Label register_label;
        private Label usernameErrors;
        private Label ageErrors;
        private Label emailErrors;
        private Label passwordErrors;
        private Label pfpErrorMessages;
    }
}