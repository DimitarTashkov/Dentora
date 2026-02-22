using Microsoft.EntityFrameworkCore;
using Dentora.Models;
using Dentora.Models.DbConfiguration;

namespace Dentora.Data
{
    public class DentoraDbContext : DbContext
    {
        public DentoraDbContext()
        {
        }

        public DentoraDbContext(DbContextOptions<DentoraDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<UserRole> UserRoles { get; set; }
        public virtual DbSet<Treatment> Treatments { get; set; }
        public virtual DbSet<Appointment> Appointments { get; set; }
        public virtual DbSet<InventoryItem> InventoryItems { get; set; }
        public virtual DbSet<Review> Reviews { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(Configuration.ConnectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // UserRole (Many-to-Many)
            modelBuilder.Entity<UserRole>()
                .HasOne(ur => ur.User)
                .WithMany(u => u.UserRoles)
                .HasForeignKey(ur => ur.UserId);

            modelBuilder.Entity<UserRole>()
                .HasOne(ur => ur.Role)
                .WithMany(r => r.RolesUsers)
                .HasForeignKey(ur => ur.RoleId);

            // Treatment -> Appointments (One-to-Many)
            modelBuilder.Entity<Appointment>()
                .HasOne(a => a.Treatment)
                .WithMany(t => t.Appointments)
                .HasForeignKey(a => a.TreatmentId);

            // User -> Appointments (One-to-Many)
            modelBuilder.Entity<Appointment>()
                .HasOne(a => a.User)
                .WithMany(u => u.Appointments)
                .HasForeignKey(a => a.UserId)
                .OnDelete(DeleteBehavior.NoAction);

            // Doctor -> Appointments (One-to-Many, optional)
            modelBuilder.Entity<Appointment>()
                .HasOne(a => a.Doctor)
                .WithMany()
                .HasForeignKey(a => a.DoctorId)
                .OnDelete(DeleteBehavior.NoAction);

            // User -> Reviews (One-to-Many)
            modelBuilder.Entity<Review>()
                .HasOne(r => r.User)
                .WithMany(u => u.Reviews)
                .HasForeignKey(r => r.UserId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Review>()
                .HasOne(r => r.Appointment)
                .WithMany()
                .HasForeignKey(r => r.AppointmentId)
                .OnDelete(DeleteBehavior.NoAction);

            // Decimal precision
            modelBuilder.Entity<Treatment>()
                .Property(t => t.Price)
                .HasColumnType("decimal(18,2)");

            modelBuilder.Entity<Appointment>()
                .Property(a => a.TotalPrice)
                .HasColumnType("decimal(18,2)");

            modelBuilder.Entity<InventoryItem>()
                .Property(i => i.Price)
                .HasColumnType("decimal(18,2)");
        }
    }
}
