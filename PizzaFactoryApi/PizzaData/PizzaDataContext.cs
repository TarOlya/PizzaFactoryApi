using Microsoft.EntityFrameworkCore;
using PizzaData.Models;

namespace PizzaData
{
    public class PizzaContext: DbContext
    {
        public DbSet<Pizza> Pizza { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=Pizza;Username=postgres;Password=561750");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasSequence<int>("Id")
                .StartsAt(1)
                .IncrementsBy(1);

            modelBuilder.Entity<PizzaIngredient>()
                .HasKey(e => new {e.IngredientId, e.PizzaId});
        }
    }
}