using Dentora.Extensions;
using Dentora.Models;
using Dentora.Services.Interfaces;
using Dentora.Utilities;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Dentora.Forms
{
    public partial class FeedbackForm : Form
    {
        private readonly IUserService _userService;
        private readonly IAppointmentService _appointmentService;
        private readonly IReviewService _reviewService;
        private User activeUser;

        public FeedbackForm(IUserService userService)
        {
            InitializeComponent();
            _userService = userService;
            _appointmentService = ServiceLocator.GetService<IAppointmentService>();
            _reviewService = ServiceLocator.GetService<IReviewService>();
            activeUser = _userService.GetLoggedInUserAsync();
            Tag = _userService;

            SidebarHelper.WireClientSidebar(this,
                (s, e) => Program.SwitchMainForm(new BookAppointment(_userService)),
                (s, e) => Program.SwitchMainForm(new ClientDashboard(_userService)),
                (s, e) => { },
                (s, e) => { _userService.LogoutUser(); Program.SwitchMainForm(new Login(_userService)); });
        }

        private void FeedbackForm_Load(object sender, EventArgs e)
        {
            if (activeUser == null) return;
            var completed = _appointmentService.GetCompletedAppointmentsByUser(activeUser.Id)
                .Where(a => !_reviewService.HasReviewedAppointment(a.Id))
                .ToList();

            cmbAppointment.DisplayMember = "Display";
            cmbAppointment.ValueMember = "Id";
            cmbAppointment.DataSource = completed.Select(a => new
            {
                a.Id,
                Display = $"{a.Treatment?.Title} \u2014 {a.AppointmentDate:dd MMM yyyy}"
            }).ToList();

            nudStars.Minimum = 1;
            nudStars.Maximum = 5;
            nudStars.Value = 5;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (cmbAppointment.SelectedValue == null || activeUser == null)
            {
                MessageBox.Show("No completed appointment selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtComment.Text))
            {
                MessageBox.Show("Please write a comment.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var review = new Review
            {
                UserId = activeUser.Id,
                AppointmentId = (Guid)cmbAppointment.SelectedValue,
                Stars = (int)nudStars.Value,
                Comment = txtComment.Text.Trim()
            };

            _reviewService.AddReview(review);
            MessageBox.Show("\u2B50 Thank you for your feedback!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Program.SwitchMainForm(new ClientDashboard(_userService));
        }
    }
}
