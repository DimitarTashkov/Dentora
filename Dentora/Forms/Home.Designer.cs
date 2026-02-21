using Dentora.Utilities;

namespace Dentora.Forms
{
    partial class Home
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing) { if (disposing && (components != null)) components.Dispose(); base.Dispose(disposing); }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            pnlContent = new Panel();
            pnlHero = new Panel();
            picHeroLogo = new PictureBox();
            lblWelcome = new Label();
            lblSubtitle = new Label();
            lblDescription = new Label();
            lblFeatured = new Label();
            pnlCardsScroll = new Panel();
            pnlCards = new FlowLayoutPanel();
            pnlActions = new Panel();
            lblQuickActions = new Label();
            btnAction1 = new Button();
            btnAction2 = new Button();
            btnAction3 = new Button();
            pnlFooter = new Panel();
            lnkAboutUs = new LinkLabel();
            lblFooterSep = new Label();
            lnkContactUs = new LinkLabel();
            lblCopyright = new Label();
            pnlContent.SuspendLayout();
            pnlHero.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picHeroLogo).BeginInit();
            pnlCardsScroll.SuspendLayout();
            pnlActions.SuspendLayout();
            pnlFooter.SuspendLayout();
            SuspendLayout();
            // 
            // pnlContent
            // 
            pnlContent.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlContent.AutoScroll = true;
            pnlContent.BackgroundImage = Properties.Resources.app_backround;
            pnlContent.BackgroundImageLayout = ImageLayout.Stretch;
            pnlContent.Controls.Add(pnlHero);
            pnlContent.Controls.Add(lblFeatured);
            pnlContent.Controls.Add(pnlCardsScroll);
            pnlContent.Controls.Add(pnlActions);
            pnlContent.Controls.Add(pnlFooter);
            pnlContent.Location = new Point(220, 0);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(830, 650);
            pnlContent.TabIndex = 0;
            // 
            // pnlHero
            // 
            pnlHero.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlHero.BackColor = Color.FromArgb(25, 25, 25);
            pnlHero.Controls.Add(picHeroLogo);
            pnlHero.Controls.Add(lblWelcome);
            pnlHero.Controls.Add(lblSubtitle);
            pnlHero.Controls.Add(lblDescription);
            pnlHero.Location = new Point(0, 0);
            pnlHero.Name = "pnlHero";
            pnlHero.Size = new Size(830, 140);
            pnlHero.TabIndex = 0;
            // 
            // picHeroLogo
            // 
            picHeroLogo.BackColor = Color.Transparent;
            picHeroLogo.BackgroundImage = Properties.Resources.dentora_logo;
            picHeroLogo.BackgroundImageLayout = ImageLayout.Zoom;
            picHeroLogo.Location = new Point(25, 15);
            picHeroLogo.Name = "picHeroLogo";
            picHeroLogo.Size = new Size(100, 55);
            picHeroLogo.TabIndex = 0;
            picHeroLogo.TabStop = false;
            // 
            // lblWelcome
            // 
            lblWelcome.BackColor = Color.Transparent;
            lblWelcome.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblWelcome.ForeColor = Color.FromArgb(0, 150, 136);
            lblWelcome.Location = new Point(140, 10);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(650, 40);
            lblWelcome.TabIndex = 1;
            lblWelcome.Text = "Welcome to Dentora";
            // 
            // lblSubtitle
            // 
            lblSubtitle.BackColor = Color.Transparent;
            lblSubtitle.Font = new Font("Segoe UI", 11F, FontStyle.Italic);
            lblSubtitle.ForeColor = Color.FromArgb(180, 180, 180);
            lblSubtitle.Location = new Point(140, 50);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(650, 25);
            lblSubtitle.TabIndex = 2;
            lblSubtitle.Text = "Your smile, our priority.";
            // 
            // lblDescription
            // 
            lblDescription.BackColor = Color.Transparent;
            lblDescription.Font = new Font("Segoe UI", 10F);
            lblDescription.ForeColor = Color.FromArgb(160, 160, 160);
            lblDescription.Location = new Point(25, 82);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(780, 50);
            lblDescription.TabIndex = 3;
            lblDescription.Text = "Dentora streamlines your entire dental clinic workflow in one place.";
            // 
            // lblFeatured
            // 
            lblFeatured.BackColor = Color.Transparent;
            lblFeatured.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblFeatured.ForeColor = Color.FromArgb(0, 150, 136);
            lblFeatured.Location = new Point(25, 150);
            lblFeatured.Name = "lblFeatured";
            lblFeatured.Size = new Size(400, 32);
            lblFeatured.TabIndex = 1;
            lblFeatured.Text = "\U0001f9b7 Our Treatments";
            // 
            // pnlCardsScroll
            // 
            pnlCardsScroll.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlCardsScroll.AutoScroll = true;
            pnlCardsScroll.BackColor = Color.Transparent;
            pnlCardsScroll.Controls.Add(pnlCards);
            pnlCardsScroll.Location = new Point(25, 185);
            pnlCardsScroll.Name = "pnlCardsScroll";
            pnlCardsScroll.Size = new Size(780, 200);
            pnlCardsScroll.TabIndex = 2;
            // 
            // pnlCards
            // 
            pnlCards.AutoSize = true;
            pnlCards.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            pnlCards.BackColor = Color.Transparent;
            pnlCards.Location = new Point(0, 0);
            pnlCards.Name = "pnlCards";
            pnlCards.Size = new Size(0, 0);
            pnlCards.TabIndex = 0;
            pnlCards.WrapContents = false;
            // 
            // pnlActions
            // 
            pnlActions.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlActions.BackColor = Color.FromArgb(35, 35, 35);
            pnlActions.Controls.Add(lblQuickActions);
            pnlActions.Controls.Add(btnAction1);
            pnlActions.Controls.Add(btnAction2);
            pnlActions.Controls.Add(btnAction3);
            pnlActions.Location = new Point(25, 390);
            pnlActions.Name = "pnlActions";
            pnlActions.Size = new Size(780, 150);
            pnlActions.TabIndex = 3;
            // 
            // lblQuickActions
            // 
            lblQuickActions.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblQuickActions.ForeColor = Color.FromArgb(0, 150, 136);
            lblQuickActions.Location = new Point(15, 10);
            lblQuickActions.Name = "lblQuickActions";
            lblQuickActions.Size = new Size(400, 30);
            lblQuickActions.TabIndex = 0;
            lblQuickActions.Text = "⚡ Quick Actions";
            // 
            // btnAction1
            // 
            btnAction1.BackColor = Color.FromArgb(0, 150, 136);
            btnAction1.Cursor = Cursors.Hand;
            btnAction1.FlatAppearance.BorderSize = 0;
            btnAction1.FlatStyle = FlatStyle.Flat;
            btnAction1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnAction1.ForeColor = Color.White;
            btnAction1.Location = new Point(15, 50);
            btnAction1.Name = "btnAction1";
            btnAction1.Size = new Size(240, 80);
            btnAction1.TabIndex = 1;
            btnAction1.UseVisualStyleBackColor = false;
            btnAction1.Click += btnAction1_Click;
            // 
            // btnAction2
            // 
            btnAction2.BackColor = Color.FromArgb(0, 150, 136);
            btnAction2.Cursor = Cursors.Hand;
            btnAction2.FlatAppearance.BorderSize = 0;
            btnAction2.FlatStyle = FlatStyle.Flat;
            btnAction2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnAction2.ForeColor = Color.White;
            btnAction2.Location = new Point(270, 50);
            btnAction2.Name = "btnAction2";
            btnAction2.Size = new Size(240, 80);
            btnAction2.TabIndex = 2;
            btnAction2.UseVisualStyleBackColor = false;
            btnAction2.Click += btnAction2_Click;
            // 
            // btnAction3
            // 
            btnAction3.BackColor = Color.FromArgb(0, 150, 136);
            btnAction3.Cursor = Cursors.Hand;
            btnAction3.FlatAppearance.BorderSize = 0;
            btnAction3.FlatStyle = FlatStyle.Flat;
            btnAction3.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnAction3.ForeColor = Color.White;
            btnAction3.Location = new Point(525, 50);
            btnAction3.Name = "btnAction3";
            btnAction3.Size = new Size(240, 80);
            btnAction3.TabIndex = 3;
            btnAction3.UseVisualStyleBackColor = false;
            btnAction3.Click += btnAction3_Click;
            // 
            // pnlFooter
            // 
            pnlFooter.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlFooter.BackColor = Color.FromArgb(22, 22, 22);
            pnlFooter.Controls.Add(lnkAboutUs);
            pnlFooter.Controls.Add(lblFooterSep);
            pnlFooter.Controls.Add(lnkContactUs);
            pnlFooter.Controls.Add(lblCopyright);
            pnlFooter.Location = new Point(0, 555);
            pnlFooter.Name = "pnlFooter";
            pnlFooter.Size = new Size(830, 50);
            pnlFooter.TabIndex = 4;
            // 
            // lnkAboutUs
            // 
            lnkAboutUs.ActiveLinkColor = Color.FromArgb(0, 200, 180);
            lnkAboutUs.AutoSize = true;
            lnkAboutUs.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lnkAboutUs.LinkColor = Color.FromArgb(0, 150, 136);
            lnkAboutUs.Location = new Point(20, 14);
            lnkAboutUs.Name = "lnkAboutUs";
            lnkAboutUs.Size = new Size(113, 23);
            lnkAboutUs.TabIndex = 0;
            lnkAboutUs.TabStop = true;
            lnkAboutUs.Text = "ℹ️ About Us";
            lnkAboutUs.VisitedLinkColor = Color.FromArgb(0, 150, 136);
            lnkAboutUs.LinkClicked += lnkAboutUs_LinkClicked;
            // 
            // lblFooterSep
            // 
            lblFooterSep.AutoSize = true;
            lblFooterSep.Font = new Font("Segoe UI", 10F);
            lblFooterSep.ForeColor = Color.Gray;
            lblFooterSep.Location = new Point(125, 14);
            lblFooterSep.Name = "lblFooterSep";
            lblFooterSep.Size = new Size(14, 23);
            lblFooterSep.TabIndex = 1;
            lblFooterSep.Text = "|";
            // 
            // lnkContactUs
            // 
            lnkContactUs.ActiveLinkColor = Color.FromArgb(0, 200, 180);
            lnkContactUs.AutoSize = true;
            lnkContactUs.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lnkContactUs.LinkColor = Color.FromArgb(0, 150, 136);
            lnkContactUs.Location = new Point(145, 14);
            lnkContactUs.Name = "lnkContactUs";
            lnkContactUs.Size = new Size(125, 23);
            lnkContactUs.TabIndex = 2;
            lnkContactUs.TabStop = true;
            lnkContactUs.Text = "📧 Contact Us";
            lnkContactUs.VisitedLinkColor = Color.FromArgb(0, 150, 136);
            lnkContactUs.LinkClicked += lnkContactUs_LinkClicked;
            // 
            // lblCopyright
            // 
            lblCopyright.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblCopyright.AutoSize = true;
            lblCopyright.Font = new Font("Segoe UI", 8.5F, FontStyle.Italic);
            lblCopyright.ForeColor = Color.FromArgb(100, 100, 100);
            lblCopyright.Location = new Point(540, 16);
            lblCopyright.Name = "lblCopyright";
            lblCopyright.Size = new Size(279, 20);
            lblCopyright.TabIndex = 3;
            lblCopyright.Text = "© 2026 Dentora Clinic. All rights reserved.";
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1050, 650);
            Controls.Add(pnlContent);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dentora - Home";
            Load += Home_Load;
            pnlContent.ResumeLayout(false);
            pnlHero.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picHeroLogo).EndInit();
            pnlCardsScroll.ResumeLayout(false);
            pnlCardsScroll.PerformLayout();
            pnlActions.ResumeLayout(false);
            pnlFooter.ResumeLayout(false);
            pnlFooter.PerformLayout();
            ResumeLayout(false);
        }
        #endregion

        private Panel pnlContent;
        private Panel pnlHero;
        private PictureBox picHeroLogo;
        private Label lblWelcome;
        private Label lblSubtitle;
        private Label lblDescription;
        private Label lblFeatured;
        private Panel pnlCardsScroll;
        private FlowLayoutPanel pnlCards;
        private Panel pnlActions;
        private Label lblQuickActions;
        private Button btnAction1;
        private Button btnAction2;
        private Button btnAction3;
        private Panel pnlFooter;
        private LinkLabel lnkAboutUs;
        private Label lblFooterSep;
        private LinkLabel lnkContactUs;
        private Label lblCopyright;
    }
}
