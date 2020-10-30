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
                new Animal { AnimalId = 1, Name = "Benji", Species = "Dog", Breed = "Golden Retriever", Age = 5, Gender = "Male" },
                new Animal { AnimalId = 2, Name = "Holly", Species = "Dog", Breed = "Chocolate Lab", Age = 2, Gender = "Female" },
                new Animal { AnimalId = 3, Name = "Penny", Species = "Cat", Breed = "Domestic Long-Hair", Age = 2, Gender = "Female" },
                new Animal { AnimalId = 4, Name = "Cookie", Species = "Cat", Breed = "Domestic Short-Hair", Age = 4, Gender = "Male" },
                new Animal { AnimalId = 5, Name = "Krull the Terrible", Species = "Dog", Breed = "Chihuahua", Age = 8, Gender = "Male" },
                new Animal { AnimalId = 6, Name = "Munchkin", Species = "Cat", Breed = "Ragdoll", Age = 1, Gender = "Male" },
                new Animal { AnimalId = 7, Name = "Izzie", Species = "Dog", Breed = "Terrier", Age = 2, Gender = "Female" }
            );
        }
        public DbSet<Animal> Animals { get; set; }
    }
}