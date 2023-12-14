using ExecPetTransportBlazorAPI517.Models;
using Microsoft.EntityFrameworkCore;

namespace ExecPetTransportBlazorAPI517.Data
{
    public class CoyoteQuoteContext: DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=coyote2\\sqlexpress;Initial Catalog=ExecPetTravel2;Integrated Security=True");
        }

        public DbSet<Cat> Cats { get; set; }

        public DbSet<Dog> Dogs { get; set; }

        public DbSet<Owner> Owners { get; set; }

        public DbSet<Quote> Quotes { get; set; }

        public DbSet<Trip> Trips { get; set; }

        public DbSet<TravelType> TravelType { get; set; }

    }
}
