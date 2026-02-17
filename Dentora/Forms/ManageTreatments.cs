using Dentora.Models;
using Dentora.Services.Interfaces;
using Dentora.Extensions;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Dentora.Forms
{
    public partial class ManageTreatments : Form
    {
        private readonly ITreatmentService _service;

        public ManageTreatments(ITreatmentService service)
        {
            InitializeComponent();
            _service = service;
        }

        private void ManageTreatments_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            var treatments = _service.GetAllTreatments()
                .Select(t => new
                {
                    t.Id,
                    t.Title,
                    t.Category,
                    Duration = t.DurationMinutes + " min",
                    Price = $"{t.Price:F2}",
                    Active = t.IsActive ? "Yes" : "No"
                }).ToList();

            dgvTreatments.DataSource = treatments;
            dgvTreatments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            if (dgvTreatments.Columns.Contains("Id"))
                dgvTreatments.Columns["Id"].Visible = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var form = new AddEditTreatment(_service, null);
            form.ShowDialog();
            LoadData();
        }

        private void dgvTreatments_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var id = (Guid)dgvTreatments.Rows[e.RowIndex].Cells["Id"].Value;
            var treatment = _service.GetTreatmentById(id);
            var form = new AddEditTreatment(_service, treatment);
            form.ShowDialog();
            LoadData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvTreatments.SelectedRows.Count == 0) return;
            var id = (Guid)dgvTreatments.SelectedRows[0].Cells["Id"].Value;
            if (MessageBox.Show("Delete this treatment?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                _service.DeleteTreatment(id);
                LoadData();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var userService = ServiceLocator.GetService<IUserService>();
            Program.SwitchMainForm(new AdminDashboard(userService));
        }
    }
}
