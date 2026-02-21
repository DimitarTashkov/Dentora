using Dentora.Models;
using Dentora.Services.Interfaces;
using Dentora.Utilities;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Dentora.Forms
{
    public partial class AddEditTreatment : Form
    {
        private readonly ITreatmentService _service;
        private Treatment _treatment;
        private byte[] _selectedImage;

        public AddEditTreatment(ITreatmentService service, Treatment treatment)
        {
            InitializeComponent();
            _service = service;
            _treatment = treatment;
        }

        private void AddEditTreatment_Load(object sender, EventArgs e)
        {
            if (_treatment != null)
            {
                txtTitle.Text = _treatment.Title;
                txtDescription.Text = _treatment.Description;
                txtCategory.Text = _treatment.Category;
                nudDuration.Value = _treatment.DurationMinutes > 0 ? _treatment.DurationMinutes : 30;
                nudPrice.Value = _treatment.Price;
                chkActive.Checked = _treatment.IsActive;
                lblHeader.Text = "\u270F\uFE0F Edit Treatment";

                if (_treatment.Image != null && _treatment.Image.Length > 0)
                {
                    _selectedImage = _treatment.Image;
                    using var ms = new MemoryStream(_treatment.Image);
                    picImage.Image = Image.FromStream(ms);
                }
            }
        }

        private void btnBrowseImage_Click(object sender, EventArgs e)
        {
            using var ofd = new OpenFileDialog();
            ofd.Title = "Select Treatment Image";
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                _selectedImage = File.ReadAllBytes(ofd.FileName);
                using var ms = new MemoryStream(_selectedImage);
                picImage.Image = Image.FromStream(ms);
            }
        }

        private void btnClearImage_Click(object sender, EventArgs e)
        {
            _selectedImage = null;
            picImage.Image = null;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTitle.Text) || string.IsNullOrWhiteSpace(txtCategory.Text))
            {
                MessageBox.Show("Title and Category are required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (_treatment == null)
            {
                _treatment = new Treatment();
            }

            _treatment.Title = txtTitle.Text.Trim();
            _treatment.Description = txtDescription.Text.Trim();
            _treatment.Category = txtCategory.Text.Trim();
            _treatment.DurationMinutes = (int)nudDuration.Value;
            _treatment.Price = nudPrice.Value;
            _treatment.IsActive = chkActive.Checked;
            _treatment.Image = _selectedImage;

            if (_treatment.Id == Guid.Empty)
                _service.AddTreatment(_treatment);
            else
                _service.UpdateTreatment(_treatment);

            MessageBox.Show("Treatment saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
