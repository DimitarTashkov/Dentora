using Dentora.Extensions;
using Dentora.Services.Interfaces;
using Dentora.Utilities;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Dentora.Forms
{
    public partial class ManagePatients : Form
    {
        private readonly IUserService _userService;

        public ManagePatients(IUserService userService)
        {
            InitializeComponent();
            _userService = userService;
            Tag = _userService;

            SidebarHelper.WireAdminSidebar(this,
                (s, e) => Program.SwitchMainForm(new AdminDashboard(_userService)),
                (s, e) => Program.SwitchMainForm(new ManageTreatments(_userService)),
                (s, e) => Program.SwitchMainForm(new ManageInventory(_userService)),
                (s, e) => { },
                (s, e) => { _userService.LogoutUser(); Program.SwitchMainForm(new Login(_userService)); });
        }

        private async void ManagePatients_Load(object sender, EventArgs e)
        {
            await LoadData();
        }

        private async System.Threading.Tasks.Task LoadData()
        {
            var users = await _userService.GetUsersAsync();
            dgvPatients.DataSource = users.Select(u => new
            {
                u.Id, u.Username, u.Email, u.Age, u.AvatarUrl
            }).ToList();
            dgvPatients.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            if (dgvPatients.Columns.Contains("Id")) dgvPatients.Columns["Id"].Visible = false;
            if (dgvPatients.Columns.Contains("AvatarUrl")) dgvPatients.Columns["AvatarUrl"].Visible = false;
        }

        private async void EditSelectedPatient()
        {
            if (dgvPatients.SelectedRows.Count == 0) return;
            var id = (Guid)dgvPatients.SelectedRows[0].Cells["Id"].Value;
            var user = await _userService.FindUserByIdAsync(id);
            if (user == null)
            {
                MessageBox.Show("Patient not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var form = new EditPatient(_userService, user);
            if (form.ShowDialog() == DialogResult.OK)
            {
                await LoadData();
            }
        }

        private void dgvPatients_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            EditSelectedPatient();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditSelectedPatient();
        }

        private async void btnViewAppointments_Click(object sender, EventArgs e)
        {
            if (dgvPatients.SelectedRows.Count == 0) return;
            var id = (Guid)dgvPatients.SelectedRows[0].Cells["Id"].Value;
            var user = await _userService.FindUserByIdAsync(id);
            if (user == null)
            {
                MessageBox.Show("Patient not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            new PatientAppointments(user).ShowDialog();
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvPatients.SelectedRows.Count == 0) return;
            var id = (Guid)dgvPatients.SelectedRows[0].Cells["Id"].Value;

            if (MessageBox.Show("Are you sure you want to delete this patient?", "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                var result = await _userService.DeleteUserAsync(id);
                if (result)
                {
                    MessageBox.Show("Patient deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    await LoadData();
                }
                else
                {
                    MessageBox.Show("Failed to delete patient.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
