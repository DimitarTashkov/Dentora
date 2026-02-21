using Dentora.Extensions;
using Dentora.Models;
using Dentora.Services.Interfaces;
using Dentora.Utilities;
using System;
using System.Drawing;
using System.IO;
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

        public BookAppointment(IUserService userService)
        {
            InitializeComponent();
            _userService = userService;
            _treatmentService = ServiceLocator.GetService<ITreatmentService>();
            _appointmentService = ServiceLocator.GetService<IAppointmentService>();
            activeUser = _userService.GetLoggedInUserAsync();
            Tag = _userService;

            SidebarHelper.WireClientSidebar(this,
                (s, e) => { },
                (s, e) => Program.SwitchMainForm(new ClientDashboard(_userService)),
                (s, e) => Program.SwitchMainForm(new FeedbackForm(_userService)),
                (s, e) => { _userService.LogoutUser(); Program.SwitchMainForm(new Login(_userService)); });
        }

        private void BookAppointment_Load(object sender, EventArgs e)
        {
            var treatments = _treatmentService.GetAllTreatments().Where(t => t.IsActive).ToList();
            cmbTreatment.DisplayMember = "Title";
            cmbTreatment.ValueMember = "Id";
            cmbTreatment.DataSource = treatments;

            dtpDate.MinDate = DateTime.Today;
            dtpDate.Value = DateTime.Today;

            dtpTime.Value = DateTime.Today.AddHours(9);

            UpdateTreatmentPreview();
        }

        private void cmbTreatment_SelectedIndexChanged(object sender, EventArgs e) => UpdateTreatmentPreview();

        private void UpdateTreatmentPreview()
        {
            if (cmbTreatment.SelectedItem is Treatment t)
            {
                lblPriceValue.Text = $"{t.Price:F2} eur";
                lblDurationValue.Text = $"{t.DurationMinutes} min";

                lblTreatmentDesc.Text = !string.IsNullOrWhiteSpace(t.Description)
                    ? $"{t.Title}\n\n{t.Description}\n\nCategory: {t.Category}"
                    : $"{t.Title}\n\nCategory: {t.Category}";

                picTreatment.Image = null;
                if (t.Image != null && t.Image.Length > 0)
                {
                    try
                    {
                        using var ms = new MemoryStream(t.Image);
                        picTreatment.Image = Image.FromStream(ms);
                    }
                    catch { }
                }
            }
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            if (cmbTreatment.SelectedItem is not Treatment treatment || activeUser == null) return;

            var appointmentDate = dtpDate.Value.Date.Add(dtpTime.Value.TimeOfDay);
            if (appointmentDate <= DateTime.Now)
            {
                MessageBox.Show("Please select a future date and time.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                _appointmentService.CreateAppointment(activeUser.Id, treatment.Id, appointmentDate);
                MessageBox.Show("\u2705 Appointment booked successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Program.SwitchMainForm(new ClientDashboard(_userService));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
