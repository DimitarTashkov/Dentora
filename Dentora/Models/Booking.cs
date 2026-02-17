using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dentora.Models
{
    public class Appointment
    {
        [Key]
        public Guid Id { get; set; }

        [ForeignKey(nameof(User))]
        public Guid UserId { get; set; }
        public virtual User User { get; set; }

        [ForeignKey(nameof(Treatment))]
        public Guid TreatmentId { get; set; }
        public virtual Treatment Treatment { get; set; }

        public DateTime AppointmentDate { get; set; }

        public decimal TotalPrice { get; set; }

        [Required]
        [MaxLength(20)]
        public string Status { get; set; } = "Pending";
    }
}
