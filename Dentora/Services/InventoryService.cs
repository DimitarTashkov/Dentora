using Microsoft.EntityFrameworkCore;
using Dentora.Data;
using Dentora.Models;
using Dentora.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Dentora.Services
{
    public class InventoryService : IInventoryService
    {
        private DentoraDbContext CreateContext() => new DentoraDbContext();

        public List<InventoryItem> GetAllItems()
        {
            using var context = CreateContext();
            return context.InventoryItems.ToList();
        }

        public InventoryItem GetItemById(Guid id)
        {
            using var context = CreateContext();
            return context.InventoryItems.Find(id);
        }

        public void AddItem(InventoryItem item)
        {
            using var context = CreateContext();
            if (item.Id == Guid.Empty) item.Id = Guid.NewGuid();
            context.InventoryItems.Add(item);
            context.SaveChanges();
        }

        public void UpdateItem(InventoryItem item)
        {
            using var context = CreateContext();
            var existing = context.InventoryItems.Find(item.Id);
            if (existing != null)
            {
                existing.Name = item.Name;
                existing.Description = item.Description;
                existing.Price = item.Price;
                existing.Quantity = item.Quantity;
                existing.Image = item.Image;
                existing.Supplier = item.Supplier;
                context.SaveChanges();
            }
        }

        public void DeleteItem(Guid id)
        {
            using var context = CreateContext();
            var item = context.InventoryItems.Find(id);
            if (item != null)
            {
                context.InventoryItems.Remove(item);
                context.SaveChanges();
            }
        }

        public void AdjustQuantity(Guid id, int adjustment)
        {
            using var context = CreateContext();
            var item = context.InventoryItems.Find(id);
            if (item != null)
            {
                item.Quantity += adjustment;
                if (item.Quantity < 0) item.Quantity = 0;
                context.SaveChanges();
            }
        }
    }
}
