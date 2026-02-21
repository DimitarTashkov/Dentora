using Dentora.Extensions;
using Dentora.Models;
using Dentora.Services.Interfaces;
using Dentora.Utilities;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Dentora.Forms
{
    public partial class ClientDashboard : Form
    {
        private readonly IUserService _userService;
        private readonly IAppointmentService _appointmentService;
        private readonly ITreatmentService _treatmentService;
        private readonly IReviewService _reviewService;
        private User activeUser;

        public ClientDashboard(IUserService userService)
        {
            InitializeComponent();
            _userService = userService;
            _appointmentService = ServiceLocator.GetService<IAppointmentService>();
            _treatmentService = ServiceLocator.GetService<ITreatmentService>();
            _reviewService = ServiceLocator.GetService<IReviewService>();
            activeUser = _userService.GetLoggedInUserAsync();
            Tag = _userService;

            SidebarHelper.WireClientSidebar(this,
                (s, e) => Program.SwitchMainForm(new BookAppointment(_userService)),
                (s, e) => LoadMyAppointments(),
                (s, e) => Program.SwitchMainForm(new FeedbackForm(_userService)),
                (s, e) => { _userService.LogoutUser(); Program.SwitchMainForm(new Login(_userService)); });
        }

        private void ClientDashboard_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = $"\U0001F44B Welcome, {activeUser?.FullName ?? activeUser?.Username ?? "Patient"}!";
            LoadMyAppointments();
        }

        private void LoadMyAppointments()
        {
            if (activeUser == null) return;
            var appointments = _appointmentService.GetAppointmentsByUser(activeUser.Id);
            var data = appointments.Select(a => new
            {
                a.Id,
                Date = a.AppointmentDate.ToString("dd MMM yyyy HH:mm"),
                Treatment = a.Treatment?.Title ?? "N/A",
                Duration = (a.Treatment?.DurationMinutes ?? 0) + " min",
                Price = $"{a.TotalPrice:F2}",
                a.Status
            }).ToList();

            dgvHistory.DataSource = data;

            if (dgvHistory.Columns.Contains("Id"))
                dgvHistory.Columns["Id"].Visible = false;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadMyAppointments();
        }

        private void btnCancelAppointment_Click(object sender, EventArgs e)
        {
            if (dgvHistory.SelectedRows.Count == 0 || activeUser == null) return;

            var row = dgvHistory.SelectedRows[0];
            string selectedStatus = row.Cells["Status"]?.Value?.ToString();

            if (selectedStatus != "Pending")
            {
                MessageBox.Show("Only pending appointments can be cancelled.", "Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var id = (Guid)row.Cells["Id"].Value;

            if (MessageBox.Show("Are you sure you want to cancel this appointment?", "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _appointmentService.CancelAppointment(id);
                LoadMyAppointments();
            }
        }
    }
}
