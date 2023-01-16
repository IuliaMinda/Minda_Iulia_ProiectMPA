using Microsoft.EntityFrameworkCore;
using Minda_Iulia_ProiectMPA.Models;

namespace Minda_Iulia_ProiectMPA.Data
{
    public class RentalContext:DbContext
    {
        public RentalContext(DbContextOptions<RentalContext> options) : base(options) { }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Rent> Rents { get; set; }
        public DbSet<Card> Cards { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().ToTable("Customer");
            modelBuilder.Entity<Car>().ToTable("Car");
            modelBuilder.Entity<Rent>().ToTable("Rent");
            modelBuilder.Entity<Card>().ToTable("Card");

        }
    }
}
