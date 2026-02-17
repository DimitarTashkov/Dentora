using Dentora.Models;
using Dentora.Services.Interfaces;
using Dentora.Extensions;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Dentora.Forms
{
    public partial class ManageInventory : Form
    {
        private readonly IInventoryService _service;

        public ManageInventory(IInventoryService service)
        {
            InitializeComponent();
            _service = service;
        }

        private void ManageInventory_Load(object sender, EventArgs e) => LoadData();

        private void LoadData()
        {
            var items = _service.GetAllItems()
                .Select(i => new { i.Id, i.Name, i.Description, i.Quantity, Price = $"{i.Price:F2}" })
                .ToList();
            dgvInventory.DataSource = items;
            dgvInventory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            if (dgvInventory.Columns.Contains("Id")) dgvInventory.Columns["Id"].Visible = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            new AddEditInventoryItem(_service, null).ShowDialog();
            LoadData();
        }

        private void dgvInventory_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var id = (Guid)dgvInventory.Rows[e.RowIndex].Cells["Id"].Value;
            new AddEditInventoryItem(_service, _service.GetItemById(id)).ShowDialog();
            LoadData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvInventory.SelectedRows.Count == 0) return;
            var id = (Guid)dgvInventory.SelectedRows[0].Cells["Id"].Value;
            if (MessageBox.Show("Delete this item?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                _service.DeleteItem(id);
                LoadData();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Program.SwitchMainForm(new AdminDashboard(ServiceLocator.GetService<IUserService>()));
        }
    }
}
