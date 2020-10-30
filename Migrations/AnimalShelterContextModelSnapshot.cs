﻿// <auto-generated />
using AnimalShelter.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AnimalShelter.Solution.Migrations
{
    [DbContext(typeof(AnimalShelterContext))]
    partial class AnimalShelterContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("AnimalShelter.Models.Animal", b =>
                {
                    b.Property<int>("AnimalId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Age");

                    b.Property<string>("Breed");

                    b.Property<string>("Gender");

                    b.Property<string>("Name");

                    b.Property<string>("Species");

                    b.HasKey("AnimalId");

                    b.ToTable("Animals");

                    b.HasData(
                        new
                        {
                            AnimalId = 1,
                            Age = 5,
                            Breed = "Golden Retriever",
                            Gender = "Male",
                            Name = "Benji",
                            Species = "Dog"
                        },
                        new
                        {
                            AnimalId = 2,
                            Age = 2,
                            Breed = "Chocolate Lab",
                            Gender = "Female",
                            Name = "Holly",
                            Species = "Dog"
                        },
                        new
                        {
                            AnimalId = 3,
                            Age = 2,
                            Breed = "Domestic Long-Hair",
                            Gender = "Female",
                            Name = "Penny",
                            Species = "Cat"
                        },
                        new
                        {
                            AnimalId = 4,
                            Age = 4,
                            Breed = "Domestic Short-Hair",
                            Gender = "Male",
                            Name = "Cookie",
                            Species = "Cat"
                        },
                        new
                        {
                            AnimalId = 5,
                            Age = 8,
                            Breed = "Chihuahua",
                            Gender = "Male",
                            Name = "Krull the Terrible",
                            Species = "Dog"
                        },
                        new
                        {
                            AnimalId = 6,
                            Age = 1,
                            Breed = "Ragdoll",
                            Gender = "Male",
                            Name = "Munchkin",
                            Species = "Cat"
                        },
                        new
                        {
                            AnimalId = 7,
                            Age = 2,
                            Breed = "Terrier",
                            Gender = "Female",
                            Name = "Izzie",
                            Species = "Dog"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
