using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Dentora.Models
{
    public class Role
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public HashSet<UserRole> RolesUsers { get; set; }
        = new HashSet<UserRole>();
    }
}
