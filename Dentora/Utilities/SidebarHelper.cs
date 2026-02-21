using Dentora.Extensions;
using Dentora.Forms;
using Dentora.Services.Interfaces;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Dentora.Utilities
{
    public static class SidebarHelper
    {
        public static void WireAdminSidebar(Form form,
            EventHandler onSchedule, EventHandler onTreatments,
            EventHandler onInventory, EventHandler onPatients,
            EventHandler onLogout)
        {
            WireButton(form, "btnSideHome", (s, e) =>
            {
                if (form.Tag is IUserService us) Program.SwitchMainForm(new Home(us, true));
            });
            WireButton(form, "btnSideSchedule", onSchedule);
            WireButton(form, "btnSideTreatments", onTreatments);
            WireButton(form, "btnSideInventory", onInventory);
            WireButton(form, "btnSidePatients", onPatients);
            WireButton(form, "btnSideLogout", onLogout);
        }

        public static void WireClientSidebar(Form form,
            EventHandler onBook, EventHandler onHistory,
            EventHandler onReview, EventHandler onLogout)
        {
            WireButton(form, "btnSideHome", (s, e) =>
            {
                if (form.Tag is IUserService us) Program.SwitchMainForm(new Home(us, false));
            });
            WireButton(form, "btnSideBook", onBook);
            WireButton(form, "btnSideHistory", onHistory);
            WireButton(form, "btnSideReview", onReview);
            WireButton(form, "btnSideLogout", onLogout);
        }

        private static void WireButton(Form form, string name, EventHandler handler)
        {
            if (handler == null) return;
            var controls = form.Controls.Find(name, true);
            if (controls.Length > 0 && controls[0] is Button btn)
                btn.Click += handler;
        }

        /// <summary>
        /// Creates the full admin sidebar panel with all controls for use in designer InitializeComponent.
        /// Call from designer code to get the sidebar panel pre-built.
        /// </summary>
        public static Panel CreateAdminSidebarPanel(string activeSection)
        {
            var panel = BuildSidebarPanel();
            panel.Controls.AddRange(new Control[]
            {
                MakeLogo(),
                MakeHeaderLabel("\U0001F3E5 Admin Panel"),
                MakeNavButton("btnSideHome", "\U0001F3E0 Home", 145, activeSection == "Home"),
                MakeNavButton("btnSideSchedule", "\U0001F4C5 Schedule", 200, activeSection == "Schedule"),
                MakeNavButton("btnSideTreatments", "\U0001F9B7 Treatments", 255, activeSection == "Treatments"),
                MakeNavButton("btnSideInventory", "\U0001F4E6 Inventory", 310, activeSection == "Inventory"),
                MakeNavButton("btnSidePatients", "\U0001F465 Patients", 365, activeSection == "Patients"),
                MakeLogoutButton("btnSideLogout", 530)
            });
            return panel;
        }

        /// <summary>
        /// Creates the full client sidebar panel with all controls for use in designer InitializeComponent.
        /// </summary>
        public static Panel CreateClientSidebarPanel(string activeSection)
        {
            var panel = BuildSidebarPanel();
            panel.Controls.AddRange(new Control[]
            {
                MakeLogo(),
                MakeHeaderLabel("\U0001F9D1 Patient Portal"),
                MakeNavButton("btnSideHome", "\U0001F3E0 Home", 145, activeSection == "Home"),
                MakeNavButton("btnSideBook", "\U0001F4C5 Book Appointment", 200, activeSection == "Book"),
                MakeNavButton("btnSideHistory", "\U0001F4CB My History", 255, activeSection == "History"),
                MakeNavButton("btnSideReview", "\u2B50 Leave Review", 310, activeSection == "Review"),
                MakeLogoutButton("btnSideLogout", 530)
            });
            return panel;
        }

        private static readonly Color ActiveColor = Color.FromArgb(0, 150, 136);
        private static readonly Color InactiveColor = Color.FromArgb(55, 55, 55);
        private static readonly Color SidebarBg = Color.FromArgb(34, 34, 34);
        private static readonly Color LogoutColor = Color.FromArgb(180, 40, 40);
        private static readonly Color TealText = Color.FromArgb(0, 150, 136);

        private static Panel BuildSidebarPanel()
        {
            return new Panel
            {
                BackColor = SidebarBg,
                Dock = DockStyle.Left,
                Width = 220,
                Name = "pnlSidebar"
            };
        }

        private static PictureBox MakeLogo()
        {
            return new PictureBox
            {
                BackColor = Color.Transparent,
                BackgroundImage = Properties.Resources.dentora_logo,
                BackgroundImageLayout = ImageLayout.Zoom,
                Location = new Point(30, 10),
                Size = new Size(160, 80),
                TabStop = false,
                Name = "picSidebarLogo"
            };
        }

        private static Label MakeHeaderLabel(string text)
        {
            return new Label
            {
                ForeColor = TealText,
                Font = new Font("Segoe UI", 13F, FontStyle.Bold),
                Location = new Point(10, 95),
                Size = new Size(200, 30),
                Text = "  " + text,
                TextAlign = ContentAlignment.MiddleCenter,
                Name = "lblSidebarHeader"
            };
        }

        private static Button MakeNavButton(string name, string text, int y, bool active)
        {
            var btn = new Button
            {
                Name = name,
                BackColor = active ? ActiveColor : InactiveColor,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 11F, FontStyle.Bold),
                ForeColor = Color.White,
                Location = new Point(10, y),
                Size = new Size(200, 45),
                Text = text,
                TextAlign = ContentAlignment.MiddleLeft,
                Cursor = Cursors.Hand
            };
            btn.FlatAppearance.BorderSize = 0;
            return btn;
        }

        private static Button MakeLogoutButton(string name, int y)
        {
            var btn = MakeNavButton(name, "\U0001F6AA Logout", y, false);
            btn.BackColor = LogoutColor;
            return btn;
        }
    }
}
