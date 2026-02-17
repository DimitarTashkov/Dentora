using Dentora.Models;
using Dentora.Services.Interfaces;
using System;
using System.Windows.Forms;

namespace Dentora.Forms
{
    public partial class AddEditInventoryItem : Form
    {
        private readonly IInventoryService _service;
        private InventoryItem _item;

        public AddEditInventoryItem(IInventoryService service, InventoryItem item)
        {
            InitializeComponent();
            _service = service;
            _item = item;
        }

        private void AddEditInventoryItem_Load(object sender, EventArgs e)
        {
            if (_item != null)
            {
                txtName.Text = _item.Name;
                txtDescription.Text = _item.Description;
                nudQuantity.Value = _item.Quantity;
                nudPrice.Value = _item.Price;
                lblHeader.Text = "Edit Inventory Item";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Name is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (_item == null) _item = new InventoryItem();
            _item.Name = txtName.Text.Trim();
            _item.Description = txtDescription.Text.Trim();
            _item.Quantity = (int)nudQuantity.Value;
            _item.Price = nudPrice.Value;

            if (_item.Id == Guid.Empty) _service.AddItem(_item);
            else _service.UpdateItem(_item);

            MessageBox.Show("Item saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e) => this.Close();
    }
}
