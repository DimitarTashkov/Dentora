using Dentora.Models;
using Dentora.Services.Interfaces;
using Dentora.Extensions;
using Dentora.Utilities;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Dentora.Forms
{
    public partial class ManageInventory : Form
    {
        private readonly IUserService _userService;
        private readonly IInventoryService _service;

        public ManageInventory(IUserService userService)
        {
            InitializeComponent();
            _userService = userService;
            _service = ServiceLocator.GetService<IInventoryService>();
            Tag = _userService;

            SidebarHelper.WireAdminSidebar(this,
                (s, e) => Program.SwitchMainForm(new AdminDashboard(_userService)),
                (s, e) => Program.SwitchMainForm(new ManageTreatments(_userService)),
                (s, e) => { },
                (s, e) => Program.SwitchMainForm(new ManagePatients(_userService)),
                (s, e) => { _userService.LogoutUser(); Program.SwitchMainForm(new Login(_userService)); });
        }

        private void ManageInventory_Load(object sender, EventArgs e)
        {
            LoadData();
        }

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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvInventory.SelectedRows.Count == 0) return;
            var id = (Guid)dgvInventory.SelectedRows[0].Cells["Id"].Value;
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
    }
}
