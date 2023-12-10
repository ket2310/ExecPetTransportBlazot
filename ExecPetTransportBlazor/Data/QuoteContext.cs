using ExecPetTransportBlazorAPI517.Models;
using Microsoft.EntityFrameworkCore;

namespace ExecPetTransportBlazor.Data
{
    public class QuoteContext : DbContext
    {
        protected override void  OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=roadrunner2\\sqlexpress;Initial Catalog=ExecPetTravel;Integrated Security=True");
        }

        public DbSet<Quote> Quotes  { get; set; }

        public DbSet<Cat> Cats { get; set; }

        public DbSet<Dog> Dogs { get; set; }
    }
}
