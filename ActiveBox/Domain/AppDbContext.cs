using System.Linq;
using ActiveBox.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ActiveBox.Domain
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        
        public DbSet<Type> Types { get; set; }
        public DbSet<OurTeam> OurTeams { get; set; }
        public DbSet<EntityBase> Contents { get; set; }
        public DbSet<Link> Links { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = "1",
                Name = "admin",
                NormalizedName = "ADMIN"
            });

            builder.Entity<IdentityUser>().HasData(new IdentityUser
            {
              Id = "1",
              UserName = "admin",
              NormalizedUserName = "ADMIN",
              Email ="my@email.com",
              NormalizedEmail = "MY@EMAIL.COM",
              EmailConfirmed = true,
              PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null,"admin"),
              SecurityStamp = string.Empty
            });

            builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = "1",
                UserId = "1"
            });
            
            
        }
    }
}