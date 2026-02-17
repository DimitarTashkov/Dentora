using Dentora.Models;
using Dentora.Services.Interfaces;
using System;
using System.Windows.Forms;

namespace Dentora.Forms
{
    public partial class AddEditTreatment : Form
    {
        private readonly ITreatmentService _service;
        private Treatment _treatment;

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
                lblHeader.Text = "Edit Treatment";
            }
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
