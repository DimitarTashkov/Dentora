using Dentora.Extensions;
using Dentora.Models;
using Dentora.Services.Interfaces;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Dentora.Forms
{
    public partial class BookAppointment : Form
    {
        private readonly ITreatmentService _treatmentService;
        private readonly IAppointmentService _appointmentService;
        private readonly IUserService _userService;
        private User activeUser;

        public BookAppointment(ITreatmentService treatmentService, IAppointmentService appointmentService, IUserService userService)
        {
            InitializeComponent();
            _treatmentService = treatmentService;
            _appointmentService = appointmentService;
            _userService = userService;
            activeUser = _userService.GetLoggedInUserAsync();
        }

        private void BookAppointment_Load(object sender, EventArgs e)
        {
            var treatments = _treatmentService.GetAllTreatments().Where(t => t.IsActive).ToList();
            cmbTreatment.DisplayMember = "Title";
            cmbTreatment.ValueMember = "Id";
            cmbTreatment.DataSource = treatments;

            dtpDate.MinDate = DateTime.Today;
            dtpDate.Value = DateTime.Today;
            dtpDate.Format = DateTimePickerFormat.Custom;
            dtpDate.CustomFormat = "dd MMM yyyy HH:mm";
            dtpDate.ShowUpDown = true;

            UpdatePrice();
        }

        private void cmbTreatment_SelectedIndexChanged(object sender, EventArgs e) => UpdatePrice();

        private void UpdatePrice()
        {
            if (cmbTreatment.SelectedItem is Treatment t)
            {
                lblPriceValue.Text = $"{t.Price:F2}";
                lblDurationValue.Text = $"{t.DurationMinutes} min";
            }
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            if (cmbTreatment.SelectedItem is not Treatment treatment || activeUser == null) return;

            var appointmentDate = dtpDate.Value;
            if (appointmentDate <= DateTime.Now)
            {
                MessageBox.Show("Please select a future date and time.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                _appointmentService.CreateAppointment(activeUser.Id, treatment.Id, appointmentDate);
                MessageBox.Show("Appointment booked successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Program.SwitchMainForm(new ClientDashboard(_userService));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Program.SwitchMainForm(new ClientDashboard(_userService));
        }
    }
}
