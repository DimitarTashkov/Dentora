using Dentora.Extensions;
using Dentora.Models;
using Dentora.Services.Interfaces;
using Dentora.Utilities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Dentora.Forms
{
    public partial class Home : Form
    {
        private readonly IUserService _userService;
        private readonly ITreatmentService _treatmentService;
        private readonly bool _isAdmin;

        public Home(IUserService userService, bool isAdmin)
        {
            InitializeComponent();
            _userService = userService;
            _isAdmin = isAdmin;
            _treatmentService = ServiceLocator.GetService<ITreatmentService>();
            Tag = _userService;

            if (_isAdmin)
            {
                Controls.Add(SidebarHelper.CreateAdminSidebarPanel("Home"));
                SidebarHelper.WireAdminSidebar(this,
                    (s, e) => Program.SwitchMainForm(new AdminDashboard(_userService)),
                    (s, e) => Program.SwitchMainForm(new ManageTreatments(_userService)),
                    (s, e) => Program.SwitchMainForm(new ManageInventory(_userService)),
                    (s, e) => Program.SwitchMainForm(new ManagePatients(_userService)),
                    (s, e) => { _userService.LogoutUser(); Program.SwitchMainForm(new Login(_userService)); });
            }
            else
            {
                Controls.Add(SidebarHelper.CreateClientSidebarPanel("Home"));
                SidebarHelper.WireClientSidebar(this,
                    (s, e) => Program.SwitchMainForm(new BookAppointment(_userService)),
                    (s, e) => Program.SwitchMainForm(new ClientDashboard(_userService)),
                    (s, e) => Program.SwitchMainForm(new FeedbackForm(_userService)),
                    (s, e) => { _userService.LogoutUser(); Program.SwitchMainForm(new Login(_userService)); });
            }
        }

        private void Home_Load(object sender, EventArgs e)
        {
            var user = _userService.GetLoggedInUserAsync();
            var displayName = user?.FullName ?? user?.Username ?? "User";
            lblWelcome.Text = $"Welcome, {displayName}!";

            if (_isAdmin)
            {
                lblDescription.Text = "Manage your clinic efficiently \u2014 view today's schedule, manage treatments & inventory, oversee patient records, and generate daily reports.";
                btnAction1.Text = "\U0001F4C5\nView Schedule";
                btnAction2.Text = "\U0001F9B7\nManage Treatments";
                btnAction3.Text = "\U0001F465\nView Patients";
            }
            else
            {
                lblDescription.Text = "Book dental appointments, view your history, and share your experience \u2014 all from your personal patient portal.";
                btnAction1.Text = "\U0001F4C5\nBook Appointment";
                btnAction2.Text = "\U0001F4CB\nMy History";
                btnAction3.Text = "\u2B50\nLeave a Review";
            }

            LoadTreatmentCards();

            pnlCardsScroll.VerticalScroll.Maximum = 0;
            pnlCardsScroll.VerticalScroll.Visible = false;
            pnlCardsScroll.AutoScrollMinSize = new Size(0, pnlCardsScroll.Height);

            pnlCardsScroll.MouseWheel += PnlCardsScroll_MouseWheel;
            pnlCards.MouseWheel += PnlCardsScroll_MouseWheel;
        }

        private void PnlCardsScroll_MouseWheel(object sender, MouseEventArgs e)
        {
            int delta = e.Delta > 0 ? -40 : 40;
            int newX = Math.Max(0, Math.Min(
                pnlCardsScroll.HorizontalScroll.Maximum,
                pnlCardsScroll.HorizontalScroll.Value + delta));
            pnlCardsScroll.HorizontalScroll.Value = newX;
            pnlCardsScroll.PerformLayout();
        }

        private void LoadTreatmentCards()
        {
            pnlCards.Controls.Clear();

            var treatments = _treatmentService.GetAllTreatments()
                .Where(t => t.IsActive)
                .Take(8)
                .ToList();

            if (treatments.Count == 0)
            {
                var emptyLabel = new Label
                {
                    Text = "No treatments available yet.",
                    ForeColor = Color.Gray,
                    Font = new Font("Segoe UI", 11F, FontStyle.Italic),
                    AutoSize = true,
                    BackColor = Color.Transparent,
                    Padding = new Padding(10)
                };
                pnlCards.Controls.Add(emptyLabel);
                return;
            }

            foreach (var t in treatments)
            {
                pnlCards.Controls.Add(CreateTreatmentCard(t));
            }
        }

        private Panel CreateTreatmentCard(Treatment treatment)
        {
            var card = new Panel
            {
                Size = new Size(180, 180),
                BackColor = Color.FromArgb(38, 38, 38),
                Margin = new Padding(6),
                Cursor = _isAdmin ? Cursors.Default : Cursors.Hand
            };

            var pic = new PictureBox
            {
                Size = new Size(180, 100),
                Location = new Point(0, 0),
                SizeMode = PictureBoxSizeMode.Zoom,
                BackColor = Color.FromArgb(30, 30, 30)
            };

            if (treatment.Image != null && treatment.Image.Length > 0)
            {
                try
                {
                    using var ms = new MemoryStream(treatment.Image);
                    pic.Image = Image.FromStream(ms);
                }
                catch { }
            }

            var lblTitle = new Label
            {
                Text = treatment.Title,
                Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                ForeColor = Color.White,
                Location = new Point(8, 105),
                Size = new Size(164, 22),
                BackColor = Color.Transparent
            };

            var lblInfo = new Label
            {
                Text = $"{treatment.DurationMinutes} min  \u2022  {treatment.Price:F2} eur",
                Font = new Font("Segoe UI", 8.5F),
                ForeColor = Color.FromArgb(0, 180, 160),
                Location = new Point(8, 128),
                Size = new Size(164, 18),
                BackColor = Color.Transparent
            };

            var lblCat = new Label
            {
                Text = treatment.Category,
                Font = new Font("Segoe UI", 8F, FontStyle.Italic),
                ForeColor = Color.FromArgb(140, 140, 140),
                Location = new Point(8, 150),
                Size = new Size(164, 18),
                BackColor = Color.Transparent
            };

            card.Controls.AddRange(new Control[] { pic, lblTitle, lblInfo, lblCat });

            if (!_isAdmin)
            {
                EventHandler onClick = (s, e) => Program.SwitchMainForm(new BookAppointment(_userService));
                card.Click += onClick;
                pic.Click += onClick;
                lblTitle.Click += onClick;
                lblInfo.Click += onClick;
                lblCat.Click += onClick;
                pic.Cursor = Cursors.Hand;
                lblTitle.Cursor = Cursors.Hand;
            }

            card.MouseEnter += (s, e) => card.BackColor = Color.FromArgb(50, 50, 50);
            card.MouseLeave += (s, e) => card.BackColor = Color.FromArgb(38, 38, 38);

            return card;
        }

        private void btnAction1_Click(object sender, EventArgs e)
        {
            if (_isAdmin)
                Program.SwitchMainForm(new AdminDashboard(_userService));
            else
                Program.SwitchMainForm(new BookAppointment(_userService));
        }

        private void btnAction2_Click(object sender, EventArgs e)
        {
            if (_isAdmin)
                Program.SwitchMainForm(new ManageTreatments(_userService));
            else
                Program.SwitchMainForm(new ClientDashboard(_userService));
        }

        private void btnAction3_Click(object sender, EventArgs e)
        {
            if (_isAdmin)
                Program.SwitchMainForm(new ManagePatients(_userService));
            else
                Program.SwitchMainForm(new FeedbackForm(_userService));
        }

        private void lnkAboutUs_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new AboutUs().ShowDialog();
        }

        private void lnkContactUs_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new ContactUs().ShowDialog();
        }
    }
}
