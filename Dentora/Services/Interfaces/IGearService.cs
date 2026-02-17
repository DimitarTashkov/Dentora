using Dentora.Models;
using System;
using System.Collections.Generic;

namespace Dentora.Services.Interfaces
{
    public interface IInventoryService
    {
        List<InventoryItem> GetAllItems();
        InventoryItem GetItemById(Guid id);
        void AddItem(InventoryItem item);
        void UpdateItem(InventoryItem item);
        void DeleteItem(Guid id);
        void AdjustQuantity(Guid id, int adjustment);
    }
}
