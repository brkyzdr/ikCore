using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class AppDbContext : DbContext
{
    public AppDbContext() : base("name=DefaultConnection") { }

    //public DbSet<User> Users { get; set; }
    //public DbSet<Company> Companies { get; set; }
    // Diğer DbSet'ler eklenecek...

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        // Fluent API ayarları buraya
    }
}

