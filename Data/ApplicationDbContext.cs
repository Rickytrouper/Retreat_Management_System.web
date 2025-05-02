using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Retreat_Management_System.web.Models;

namespace Retreat_Management_System.web.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<User> User { get; set; }
        public DbSet<Retreat> Retreat { get; set; }

        public DbSet<Booking> Booking { get; set; }

        public DbSet<Payment> Payment { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Additional configuration can go here, e.g., keyless entity types if needed
        }


    }   
}
