using Dentora.Extensions;
using Dentora.Services.Interfaces;
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
        }

        private async void ManagePatients_Load(object sender, EventArgs e) => await LoadData();

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

        private void btnBack_Click(object sender, EventArgs e)
        {
            Program.SwitchMainForm(new AdminDashboard(_userService));
        }
    }
}
