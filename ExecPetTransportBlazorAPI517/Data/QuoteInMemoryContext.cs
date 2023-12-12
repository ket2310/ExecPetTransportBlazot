using ExecPetTransportBlazorAPI517.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.InMemory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExecPetTransportBlazorAPI517.Data
{
    public class QuoteInMemoryContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase(databaseName: "ExecPetDB");
        }

        public DbSet<Quote> Quotes { get; set; }

        public DbSet<Cat> Cats { get; set; }

        public DbSet<Dog> Dogs { get; set; }
    }
}
