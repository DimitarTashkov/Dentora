using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Dentora.Models
{
    public class Treatment
    {
        public Treatment()
        {
            this.Appointments = new HashSet<Appointment>();
        }

        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Title { get; set; }

        [MaxLength(500)]
        public string Description { get; set; }

        [Required]
        [MaxLength(50)]
        public string Category { get; set; }

        public int DurationMinutes { get; set; }

        public byte[] Image { get; set; }

        public decimal Price { get; set; }

        public bool IsActive { get; set; } = true;

        public virtual ICollection<Appointment> Appointments { get; set; }
    }
}
