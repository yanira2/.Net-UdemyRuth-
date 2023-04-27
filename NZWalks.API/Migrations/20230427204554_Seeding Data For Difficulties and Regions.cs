using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NZWalks.API.Migrations
{
    /// <inheritdoc />
    public partial class SeedingDataForDifficultiesandRegions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Difficulties",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("32edb915-2275-4100-a29e-586fac4f1033"), "Hard" },
                    { new Guid("76528293-abbd-4d23-a724-32a4eda6a02a"), "Easy" },
                    { new Guid("a5824ae2-6920-4b90-9487-294f9c01320a"), "Medium" }
                });

            migrationBuilder.InsertData(
                table: "Regions",
                columns: new[] { "Id", "Code", "Name", "RegionImageUrl" },
                values: new object[,]
                {
                    { new Guid("030b2621-85c5-4ed6-b8f9-e345c341bb7a"), "NSN", "Nelson", "https://images.pexels.com/photos/13918194/pexels-photo-13918194.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1" },
                    { new Guid("132babb6-406a-4e95-b862-217cb0892cb0"), "STL", "Southland", null },
                    { new Guid("855890f5-f081-4f9b-a957-376d10f193c7"), "BOP", "Bay Of Plenty", null },
                    { new Guid("932fa4ef-15da-4deb-9812-ce295b51e311"), "NTL", "Northland", null },
                    { new Guid("b388188e-c702-46fc-939d-01a21ce881d3"), "WGN", "Wellington", "https://images.pexels.com/photos/4350631/pexels-photo-4350631.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1" },
                    { new Guid("b9b2da8d-5e3d-4f7c-b5ce-8b9a924b5c72"), "AKL", "Auckland", "https://images.pexels.com/photos/5169056/pexels-photo-5169056.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Difficulties",
                keyColumn: "Id",
                keyValue: new Guid("32edb915-2275-4100-a29e-586fac4f1033"));

            migrationBuilder.DeleteData(
                table: "Difficulties",
                keyColumn: "Id",
                keyValue: new Guid("76528293-abbd-4d23-a724-32a4eda6a02a"));

            migrationBuilder.DeleteData(
                table: "Difficulties",
                keyColumn: "Id",
                keyValue: new Guid("a5824ae2-6920-4b90-9487-294f9c01320a"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("030b2621-85c5-4ed6-b8f9-e345c341bb7a"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("132babb6-406a-4e95-b862-217cb0892cb0"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("855890f5-f081-4f9b-a957-376d10f193c7"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("932fa4ef-15da-4deb-9812-ce295b51e311"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("b388188e-c702-46fc-939d-01a21ce881d3"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("b9b2da8d-5e3d-4f7c-b5ce-8b9a924b5c72"));
        }
    }
}
