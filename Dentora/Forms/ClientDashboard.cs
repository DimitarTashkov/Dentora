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
        }

        private void ClientDashboard_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = $"Welcome, {activeUser?.FullName ?? activeUser?.Username ?? "Patient"}!";
            LoadMyAppointments();
        }

        private void LoadMyAppointments()
        {
            if (activeUser == null) return;
            var appointments = _appointmentService.GetAppointmentsByUser(activeUser.Id);
            var data = appointments.Select(a => new
            {
                Date = a.AppointmentDate.ToString("dd MMM yyyy HH:mm"),
                Treatment = a.Treatment?.Title ?? "N/A",
                Duration = (a.Treatment?.DurationMinutes ?? 0) + " min",
                Price = $"{a.TotalPrice:F2}",
                a.Status
            }).ToList();

            dgvHistory.DataSource = data;
            dgvHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            Program.SwitchMainForm(new BookAppointment(_treatmentService, _appointmentService, _userService));
        }

        private void btnReview_Click(object sender, EventArgs e)
        {
            Program.SwitchMainForm(new FeedbackForm(_userService, _appointmentService, _reviewService));
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadMyAppointments();
        }

        private void btnCancelAppointment_Click(object sender, EventArgs e)
        {
            if (dgvHistory.SelectedRows.Count == 0) return;
            if (activeUser == null) return;

            var appointments = _appointmentService.GetAppointmentsByUser(activeUser.Id);
            int idx = dgvHistory.SelectedRows[0].Index;
            if (idx >= 0 && idx < appointments.Count)
            {
                var apt = appointments[idx];
                if (apt.Status == "Pending")
                {
                    if (MessageBox.Show("Are you sure you want to cancel this appointment?", "Confirm",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        _appointmentService.CancelAppointment(apt.Id);
                        LoadMyAppointments();
                    }
                }
                else
                {
                    MessageBox.Show("Only pending appointments can be cancelled.", "Info",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            _userService.LogoutUser();
            Program.SwitchMainForm(new Login(_userService));
        }
    }
}
