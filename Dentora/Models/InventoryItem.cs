using System;
using System.ComponentModel.DataAnnotations;

namespace Dentora.Models
{
    public class InventoryItem
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [MaxLength(500)]
        public string Description { get; set; }

        public decimal Price { get; set; }

        public int Quantity { get; set; }

        public byte[]? Image { get; set; }

        [MaxLength(200)]
        public string? Supplier { get; set; }
    }
}
