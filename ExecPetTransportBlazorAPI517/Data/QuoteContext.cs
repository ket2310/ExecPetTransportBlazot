using ExecPetTransportBlazorAPI517.Models;
using Microsoft.EntityFrameworkCore;

namespace ExecPetTransportBlazorAPI517.Data
{
    public class QuoteContext: DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=roadrunner2\\sqlexpress;Initial Catalog=ExecPetTravel2;Integrated Security=True");
        }

        public DbSet<Quote> Quotes { get; set; }
    }
}
