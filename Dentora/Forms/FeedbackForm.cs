using Dentora.Extensions;
using Dentora.Models;
using Dentora.Services.Interfaces;
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

        public FeedbackForm(IUserService userService, IAppointmentService appointmentService, IReviewService reviewService)
        {
            InitializeComponent();
            _userService = userService;
            _appointmentService = appointmentService;
            _reviewService = reviewService;
            activeUser = _userService.GetLoggedInUserAsync();
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
                Display = $"{a.Treatment?.Title} — {a.AppointmentDate:dd MMM yyyy}"
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
            MessageBox.Show("Thank you for your feedback!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Program.SwitchMainForm(new ClientDashboard(_userService));
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Program.SwitchMainForm(new ClientDashboard(_userService));
        }
    }
}
