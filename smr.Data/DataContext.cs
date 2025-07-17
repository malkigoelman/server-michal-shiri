using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using smr.Core.Entitis.smr.Core.Models;
using smr.Entitis;

namespace smr
{
    public class DataContext : DbContext
    {

        public DbSet<Renter> renters { get; set; }
        public DbSet<Tourist> tourists { get; set; }
        public DbSet<Turn> turns { get; set; }
        public DbSet<User>Users{ get; set; }

    private readonly IConfiguration _configuration;

        public DataContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_configuration["ConnectionStrings"]);


            //optionsBuilder.LogTo(m => Console.WriteLine(m));
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(b =>
            {
                b.Property(e => e.Role)
                  .HasConversion(
                    v => v.ToString(),
                    v => Enum.Parse<UserRole>(v));
            });
            modelBuilder.Entity<Renter>()
    .Property(r => r.id)
    .ValueGeneratedOnAdd(); // חשוב מאוד
            modelBuilder.Entity<Tourist>()
         .Property(r => r.id)
         .ValueGeneratedOnAdd(); // חשוב מאוד
            modelBuilder.Entity<Turn>()
         .Property(r => r.id)
         .ValueGeneratedOnAdd(); // חשוב מאוד

        }
    }

    //optionBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=renter_db");

}


