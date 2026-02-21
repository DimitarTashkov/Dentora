using Dentora.Models;
using Dentora.Services.Interfaces;
using Dentora.Utilities;
using System;
using System.Windows.Forms;

namespace Dentora.Forms
{
    public partial class EditPatient : Form
    {
        private readonly IUserService _userService;
        private readonly User _user;

        public EditPatient(IUserService userService, User user)
        {
            InitializeComponent();
            _userService = userService;
            _user = user;
        }

        private void EditPatient_Load(object sender, EventArgs e)
        {
            if (_user == null) { Close(); return; }
            txtUsername.Text = _user.Username;
            txtEmail.Text = _user.Email;
            txtFullName.Text = _user.FullName ?? "";
            txtPhone.Text = _user.Phone ?? "";
            nudAge.Value = _user.Age.HasValue && _user.Age.Value >= 1 ? _user.Age.Value : 1;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Username and Email are required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _user.Username = txtUsername.Text.Trim();
            _user.Email = txtEmail.Text.Trim();
            _user.FullName = txtFullName.Text.Trim();
            _user.Phone = txtPhone.Text.Trim();
            _user.Age = (int)nudAge.Value;

            var model = new DTOs.User.EditProfileInputModel
            {
                Id = _user.Id,
                Username = _user.Username,
                Password = _user.Password,
                Email = _user.Email,
                Age = _user.Age,
                AvatarUrl = _user.AvatarUrl
            };

            var result = _userService.UpdateUserAsync(model).GetAwaiter().GetResult();
            if (result)
            {
                MessageBox.Show("Patient updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Failed to update patient.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
