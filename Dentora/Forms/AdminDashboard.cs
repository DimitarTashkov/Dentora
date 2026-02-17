using Dentora.Extensions;
using Dentora.Models;
using Dentora.Services.Interfaces;
using Dentora.Utilities;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Dentora.Forms
{
    public partial class AdminDashboard : Form
    {
        private readonly IUserService _userService;
        private readonly IAppointmentService _appointmentService;
        private readonly ITreatmentService _treatmentService;
        private readonly IInventoryService _inventoryService;
        private User activeUser;

        public AdminDashboard(IUserService userService)
        {
            InitializeComponent();
            _userService = userService;
            _appointmentService = ServiceLocator.GetService<IAppointmentService>();
            _treatmentService = ServiceLocator.GetService<ITreatmentService>();
            _inventoryService = ServiceLocator.GetService<IInventoryService>();
            activeUser = _userService.GetLoggedInUserAsync();
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            LoadTodaySchedule();
        }

        private void LoadTodaySchedule()
        {
            var allAppointments = _appointmentService.GetAllAppointments();
            var today = allAppointments
                .Where(a => a.AppointmentDate.Date == DateTime.Today && a.Status != "Cancelled")
                .Select(a => new
                {
                    Time = a.AppointmentDate.ToString("HH:mm"),
                    Patient = a.User?.FullName ?? a.User?.Username ?? "N/A",
                    Treatment = a.Treatment?.Title ?? "N/A",
                    Duration = (a.Treatment?.DurationMinutes ?? 0) + " min",
                    Price = $"{a.TotalPrice:F2}",
                    a.Status
                }).ToList();

            dgvSchedule.DataSource = today;
            dgvSchedule.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            lblDate.Text = $"Today's Schedule — {DateTime.Today:dd MMM yyyy}";
        }

        private void btnTreatments_Click(object sender, EventArgs e)
        {
            Program.SwitchMainForm(new ManageTreatments(_treatmentService));
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            Program.SwitchMainForm(new ManageInventory(_inventoryService));
        }

        private void btnPatients_Click(object sender, EventArgs e)
        {
            Program.SwitchMainForm(new ManagePatients(_userService));
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadTodaySchedule();
        }

        private void btnCompleteAppointment_Click(object sender, EventArgs e)
        {
            if (dgvSchedule.SelectedRows.Count == 0) return;

            int idx = dgvSchedule.SelectedRows[0].Index;
            string selectedStatus = dgvSchedule.Rows[idx].Cells["Status"]?.Value?.ToString();

            if (selectedStatus != "Pending")
            {
                MessageBox.Show("Only pending appointments can be completed.", "Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var allAppointments = _appointmentService.GetAllAppointments();
            var todayNonCancelled = allAppointments
                .Where(a => a.AppointmentDate.Date == DateTime.Today && a.Status != "Cancelled")
                .ToList();

            if (idx >= 0 && idx < todayNonCancelled.Count)
            {
                var apt = todayNonCancelled[idx];
                _appointmentService.CompleteAppointment(apt.Id);

                DocumentHelper.GeneratePrescription(
                    apt.User?.FullName ?? apt.User?.Username ?? "Patient",
                    apt.Treatment?.Title ?? "Treatment");

                LoadTodaySchedule();
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            _userService.LogoutUser();
            Program.SwitchMainForm(new Login(_userService));
        }
    }
}
