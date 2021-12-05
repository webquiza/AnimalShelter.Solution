using Microsoft.EntityFrameworkCore;

namespace AnimalShelter.Models
{
  public class AnimalShelterContext : DbContext
  {
    public AnimalShelterContext(DbContextOptions<AnimalShelterContext> options)
      : base(options)
      {
      }

      protected override void OnModelCreating(ModelBuilder builder)
      {
        builder.Entity<Animal>()
          .HasData(
            new Animal { AnimalId = 1, Name = "Pepper", Species = "Dog", Gender = "Female", Age = 7 },
            new Animal { AnimalId = 2, Name = "Lucy", Species = "Cat", Gender = "Female", Age = 1 },
            new Animal { AnimalId = 3, Name = "Olive", Species = "Dog", Gender = "Female", Age = 2 },
            new Animal { AnimalId = 4, Name = "Simba", Species = "Cat", Gender = "Male", Age = 4 },
            new Animal { AnimalId = 5, Name = "Duke", Species = "Dog", Gender = "Male", Age = 8 }
          );
      }

      public DbSet<Animal> Animals { get; set; }
  }
}