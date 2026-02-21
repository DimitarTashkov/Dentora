using Dentora.Extensions;
using Dentora.Models;
using Dentora.Services.Interfaces;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Dentora.Forms
{
    public partial class PatientAppointments : Form
    {
        private readonly IAppointmentService _appointmentService;
        private readonly User _patient;

        public PatientAppointments(User patient)
        {
            InitializeComponent();
            _appointmentService = ServiceLocator.GetService<IAppointmentService>();
            _patient = patient;
        }

        private void PatientAppointments_Load(object sender, EventArgs e)
        {
            lblTitle.Text = $"\U0001F4CB Appointments \u2014 {_patient.FullName ?? _patient.Username}";

            var appointments = _appointmentService.GetAppointmentsByUser(_patient.Id);
            var data = appointments.Select(a => new
            {
                Date = a.AppointmentDate.ToString("dd MMM yyyy"),
                Time = a.AppointmentDate.ToString("HH:mm"),
                Treatment = a.Treatment?.Title ?? "N/A",
                Category = a.Treatment?.Category ?? "N/A",
                Duration = (a.Treatment?.DurationMinutes ?? 0) + " min",
                Price = $"{a.TotalPrice:F2}",
                a.Status
            }).ToList();

            dgvAppointments.DataSource = data;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
