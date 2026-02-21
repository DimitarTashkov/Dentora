using Dentora.Utilities;
using Dentora.Common.Constants;
using Dentora.DTOs.User;
using Dentora.Models.DbConfiguration;
using Dentora.Services.Interfaces;

using static Dentora.Common.Constants.ValidationConstants.UserConstants;
using static Dentora.Utilities.DynamicContentTranslator.EntitiesTranslation;

namespace Dentora.Forms
{
    public partial class Login : Form
    {
        private readonly IUserService userService;

        public Login(IUserService userService)
        {
            this.userService = userService;
            InitializeComponent();
            usernameField.TextChanged += EventsEffects.input_TextChanged;
            usernameField.Click += EventsEffects.clearInputs_click;
            passwordField.TextChanged += EventsEffects.input_TextChanged;
            passwordField.Click += EventsEffects.clearInputs_click;
            passwordField.PasswordChar = '*';
        }
        private void register_hover(object sender, EventArgs e)
        {
            register.ForeColor = Color.Indigo;
        }

        private void register_leave(object sender, EventArgs e)
        {
            register.ForeColor = Color.Blue;
        }
        private void register_Click(object sender, EventArgs e)
        {
            register.ForeColor = Color.BlueViolet;
            Register registerForm = new Register(userService);
            Program.SwitchMainForm(registerForm);
        }

        private void login_hover(object sender, EventArgs e)
        {
            loginBtn.BackColor = Color.FromArgb(0, 170, 156);
        }

        private void login_leave(object sender, EventArgs e)
        {
            loginBtn.BackColor = Color.FromArgb(0, 150, 136);
            loginBtn.ForeColor = Color.White;
        }
        private async void login_Click(object sender, EventArgs e)
        {
            List<TextBox> inputs = new List<TextBox>()
            {
                usernameField,
                passwordField
            };

            bool areInputValid = ValidationHelper.ValidateUserInputs(inputs);
            if (!areInputValid)
            {
                MessageBox.Show(EmptyInputData, Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string username = usernameField.Text.Trim();
            string password = passwordField.Text.Trim();

            var loginModel = new LoginUserInputModel
            {
                Username = username,
                Password = password
            };

            var (isValid, errors) = await userService.ValidateModelAsync(loginModel);

            if (!isValid)
            {
                foreach (var error in errors)
                {
                    if (error.MemberNames.Contains(nameof(loginModel.Username)))
                    {
                        usernameError.Text = string.Format(FieldLength, Username, NameMinLength);
                        usernameError.Visible = true;
                    }

                    if (error.MemberNames.Contains(nameof(loginModel.Password)))
                    {
                        passwordError.Text = string.Format(FieldLength, Password, PasswordMinLength);
                        passwordError.Visible = true;
                    }
                }
                return;
            }

            bool isAuthenticated = await userService.AuthenticateUserAsync(username, password);
            bool isAdmin = await AuthorizationHelper.InitializeAuthorizationStatusAsync(userService);

            if (isAuthenticated)
            {
                if (isAdmin)
                {
                    var home = new Home(userService, true);
                    Program.SwitchMainForm(home);
                }
                else
                {
                    var home = new Home(userService, false);
                    Program.SwitchMainForm(home);
                }
            }
            else
            {
                MessageBox.Show(InvalidUserCredentials, Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void input_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            textBox.ForeColor = Color.White;
            textBox.Font = FontsPicker.BaseFont;
        }

        private async void Login_Load(object sender, EventArgs e)
        {
            await SeedAdmin.SeedAdminUserAsync();
        }

        private void formPanel_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}
