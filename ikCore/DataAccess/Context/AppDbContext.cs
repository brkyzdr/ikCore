using System.Data.Entity;
using ikCore.Entities.Models;

namespace ikCore.DataAccess.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base("name=AppDbContext") { }

        public DbSet<User> Users { get; set; }
        public DbSet<Company> Companies { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // İlişki ve kısıtlama örneği:
            modelBuilder.Entity<User>()
                        .HasRequired(u => u.Company)
                        .WithMany(c => c.Users)
                        .HasForeignKey(u => u.CompanyId)
                        .WillCascadeOnDelete(false);
        }
    }
}
