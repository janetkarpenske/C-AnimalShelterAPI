using Microsoft.EntityFrameworkCore.Migrations;

namespace AnimalShelter.Solution.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "AnimalId", "Age", "Breed", "Gender", "Name", "Species" },
                values: new object[,]
                {
                    { 1, 5, "Golden Retriever", "Male", "Benji", "Dog" },
                    { 2, 2, "Chocolate Lab", "Female", "Holly", "Dog" },
                    { 3, 2, "Domestic Long-Hair", "Female", "Penny", "Cat" },
                    { 4, 4, "Domestic Short-Hair", "Male", "Cookie", "Cat" },
                    { 5, 8, "Chihuahua", "Male", "Krull the Terrible", "Dog" },
                    { 6, 1, "Ragdoll", "Male", "Munchkin", "Cat" },
                    { 7, 2, "Terrier", "Female", "Izzie", "Dog" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 7);
        }
    }
}
