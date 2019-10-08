using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Vidly.Models
{
    public class ApplicationDBContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Customer> Customers { get; set; } // My domain models
        public DbSet<Movie> Movies { get; set; }// My domain models
        public DbSet<MembershipType> MembershipTypes { get; set; }
        public DbSet<Genre> Genres { get; set; }

        public ApplicationDBContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDBContext Create()
        {
            return new ApplicationDBContext();
        }
    }
}