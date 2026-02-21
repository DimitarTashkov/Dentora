using Dentora.Extensions;
using Dentora.Models;
using Dentora.Services.Interfaces;
using Dentora.Utilities;
using System;
using System.Collections.Generic;
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
        private List<Appointment> _cachedAppointments;

        public AdminDashboard(IUserService userService)
        {
            InitializeComponent();
            _userService = userService;
            _appointmentService = ServiceLocator.GetService<IAppointmentService>();
            _treatmentService = ServiceLocator.GetService<ITreatmentService>();
            _inventoryService = ServiceLocator.GetService<IInventoryService>();
            activeUser = _userService.GetLoggedInUserAsync();
            Tag = _userService;

            SidebarHelper.WireAdminSidebar(this,
                (s, e) => RefreshData(),
                (s, e) => Program.SwitchMainForm(new ManageTreatments(_userService)),
                (s, e) => Program.SwitchMainForm(new ManageInventory(_userService)),
                (s, e) => Program.SwitchMainForm(new ManagePatients(_userService)),
                (s, e) => { _userService.LogoutUser(); Program.SwitchMainForm(new Login(_userService)); });
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            cmbFilter.Items.AddRange(new object[] { "Today", "All Appointments", "Pending", "Completed", "Cancelled" });
            cmbFilter.SelectedIndex = 0;
        }

        private void cmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void RefreshData()
        {
            _cachedAppointments = _appointmentService.GetAllAppointments();
            string filter = cmbFilter.SelectedItem?.ToString() ?? "Today";

            var filtered = filter switch
            {
                "Today" => _cachedAppointments
                    .Where(a => a.AppointmentDate.Date == DateTime.Today)
                    .ToList(),
                "Pending" => _cachedAppointments
                    .Where(a => a.Status == "Pending")
                    .ToList(),
                "Completed" => _cachedAppointments
                    .Where(a => a.Status == "Completed")
                    .ToList(),
                "Cancelled" => _cachedAppointments
                    .Where(a => a.Status == "Cancelled")
                    .ToList(),
                _ => _cachedAppointments
            };

            var data = filtered.Select(a => new
            {
                a.Id,
                Date = a.AppointmentDate.ToString("dd MMM yyyy"),
                Time = a.AppointmentDate.ToString("HH:mm"),
                Patient = a.User?.FullName ?? a.User?.Username ?? "N/A",
                Treatment = a.Treatment?.Title ?? "N/A",
                Duration = (a.Treatment?.DurationMinutes ?? 0) + " min",
                Price = $"{a.TotalPrice:F2}",
                a.Status
            }).ToList();

            dgvSchedule.DataSource = data;

            if (dgvSchedule.Columns.Contains("Id"))
                dgvSchedule.Columns["Id"].Visible = false;

            lblDate.Text = filter == "Today"
                ? $"\U0001F4C5 Schedule \u2014 {DateTime.Today:dd MMM yyyy}  ({data.Count})"
                : $"\U0001F4C5 {filter}  ({data.Count})";
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void btnCompleteAppointment_Click(object sender, EventArgs e)
        {
            if (dgvSchedule.SelectedRows.Count == 0) return;

            var row = dgvSchedule.SelectedRows[0];
            string selectedStatus = row.Cells["Status"]?.Value?.ToString();

            if (selectedStatus != "Pending")
            {
                MessageBox.Show("Only pending appointments can be completed.", "Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var id = (Guid)row.Cells["Id"].Value;
            var apt = _cachedAppointments.FirstOrDefault(a => a.Id == id);
            if (apt == null) return;

            _appointmentService.CompleteAppointment(apt.Id);

            DocumentHelper.GeneratePrescription(
                apt.User?.FullName ?? apt.User?.Username ?? "Patient",
                apt.Treatment?.Title ?? "Treatment");

            RefreshData();
        }

        private void btnCancelAppointment_Click(object sender, EventArgs e)
        {
            if (dgvSchedule.SelectedRows.Count == 0) return;

            var row = dgvSchedule.SelectedRows[0];
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
                RefreshData();
            }
        }

        private void btnPrintReport_Click(object sender, EventArgs e)
        {
            var allAppointments = _appointmentService.GetAllAppointments();
            var todayLines = allAppointments
                .Where(a => a.AppointmentDate.Date == DateTime.Today && a.Status != "Cancelled")
                .Select(a => (
                    Time: a.AppointmentDate.ToString("HH:mm"),
                    Patient: a.User?.FullName ?? a.User?.Username ?? "N/A",
                    Treatment: a.Treatment?.Title ?? "N/A",
                    Status: a.Status,
                    Price: $"{a.TotalPrice:F2}"
                )).ToList();

            DocumentHelper.GenerateDailyReport(todayLines, DateTime.Today);
        }
    }
}
