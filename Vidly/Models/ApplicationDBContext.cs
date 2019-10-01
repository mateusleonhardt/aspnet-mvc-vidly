using System.Data.Entity;

namespace Vidly.Models
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext()
        {

        }
        public DbSet<Customer> Customers { get; set; } // My domain models
        public DbSet<Movie> Movies { get; set; }// My domain models
        public DbSet<MembershipType> MembershipTypes { get; set; }
        public DbSet<Genre> Genres { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<ApplicationDBContext>(null);
            base.OnModelCreating(modelBuilder);
        }
    }
}