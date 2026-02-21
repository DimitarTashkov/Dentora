using Dentora.Models;
using Dentora.Services.Interfaces;
using Dentora.Utilities;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Dentora.Forms
{
    public partial class AddEditInventoryItem : Form
    {
        private readonly IInventoryService _service;
        private InventoryItem _item;
        private byte[] _selectedImage;

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
                lblHeader.Text = "\u270F\uFE0F Edit Inventory Item";

                if (_item.Image != null && _item.Image.Length > 0)
                {
                    _selectedImage = _item.Image;
                    using var ms = new MemoryStream(_item.Image);
                    picImage.Image = Image.FromStream(ms);
                }
            }
        }

        private void btnBrowseImage_Click(object sender, EventArgs e)
        {
            using var ofd = new OpenFileDialog();
            ofd.Title = "Select Item Image";
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
            _item.Image = _selectedImage;

            if (_item.Id == Guid.Empty) _service.AddItem(_item);
            else _service.UpdateItem(_item);

            MessageBox.Show("Item saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e) => this.Close();
    }
}
