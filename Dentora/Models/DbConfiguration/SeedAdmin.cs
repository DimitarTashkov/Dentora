using Microsoft.EntityFrameworkCore;
using Dentora.Data;
using System;
using System.Threading.Tasks;

namespace Dentora.Models.DbConfiguration
{
    public static class SeedAdmin
    {
        public static async Task SeedAdminUserAsync()
        {
            using (var context = new DentoraDbContext())
            {
                await context.Database.EnsureCreatedAsync();

                var adminRole = await context.Roles.FirstOrDefaultAsync(r => r.Name == "Admin");

                if (adminRole == null)
                {
                    adminRole = new Role { Id = Guid.NewGuid(), Name = "Admin" };
                    context.Roles.Add(adminRole);
                    await context.SaveChangesAsync();
                }

                var clientRole = await context.Roles.FirstOrDefaultAsync(r => r.Name == "Client");
                if (clientRole == null)
                {
                    clientRole = new Role { Id = Guid.NewGuid(), Name = "Client" };
                    context.Roles.Add(clientRole);
                    await context.SaveChangesAsync();
                }

                var existingAdmin = await context.Users.FirstOrDefaultAsync(u => u.Username == "admin");

                if (existingAdmin == null)
                {
                    var adminUser = new User
                    {
                        Id = Guid.NewGuid(),
                        Username = "admin",
                        Password = "password123",
                        FullName = "Dr. Admin",
                        Phone = "+359000000000",
                        Email = "admin@dentora.com",
                        AvatarUrl = Path.Combine(Application.StartupPath, "Resources", "admin_avatar")
                    };

                    context.Users.Add(adminUser);
                    await context.SaveChangesAsync();

                    var adminUserRole = new UserRole
                    {
                        UserId = adminUser.Id,
                        RoleId = adminRole.Id
                    };

                    context.UserRoles.Add(adminUserRole);
                    await context.SaveChangesAsync();
                }
            }
        }
    }
}
