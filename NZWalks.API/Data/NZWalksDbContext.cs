using Microsoft.EntityFrameworkCore;
using NZWalks.API.Models.Domain;

namespace NZWalks.API.Data
{
    public class NZWalksDbContext : DbContext
    {
        public NZWalksDbContext(DbContextOptions<NZWalksDbContext> dbContextOptions): base(dbContextOptions)
        {
            
        }

        public DbSet<Difficulty> Difficulties { get; set; }

        public DbSet<Region> Regions { get; set; }

        public DbSet<Walk> Walks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed data for Difficulties
            // Easy, Medium, Hard

            var difficulties = new List<Difficulty>()
           {
               new Difficulty
               {
                   Id = Guid.Parse("76528293-abbd-4d23-a724-32a4eda6a02a") ,
                   Name = "Easy"
               },
                new Difficulty
               {
                   Id = Guid.Parse("a5824ae2-6920-4b90-9487-294f9c01320a"),
                   Name = "Medium"
               },
                 new Difficulty
               {
                   Id = Guid.Parse("32edb915-2275-4100-a29e-586fac4f1033"),
                   Name = "Hard"
               },
           };
            // Seed difficulties to the database    
            modelBuilder.Entity<Difficulty>().HasData(difficulties);


            // Seed data for Regions
            var regions = new List<Region>
            {
                new Region
                {
                    Id = Guid.Parse("b9b2da8d-5e3d-4f7c-b5ce-8b9a924b5c72"),
                    Name = "Auckland",
                    Code = "AKL",
                    RegionImageUrl = "https://images.pexels.com/photos/5169056/pexels-photo-5169056.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1"
                },
                new Region
                {
                    Id = Guid.Parse("932fa4ef-15da-4deb-9812-ce295b51e311"),
                    Name = "Northland",
                    Code = "NTL",
                    RegionImageUrl = null
                },
                new Region
                {
                    Id = Guid.Parse("855890f5-f081-4f9b-a957-376d10f193c7"),
                    Name = "Bay Of Plenty",
                    Code = "BOP",
                    RegionImageUrl = null
                },
                new Region
                {
                    Id = Guid.Parse("b388188e-c702-46fc-939d-01a21ce881d3"),
                    Name = "Wellington",
                    Code = "WGN",
                    RegionImageUrl = "https://images.pexels.com/photos/4350631/pexels-photo-4350631.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1"
                },
                new Region
                {
                    Id = Guid.Parse("030b2621-85c5-4ed6-b8f9-e345c341bb7a"),
                    Name = "Nelson",
                    Code = "NSN",
                    RegionImageUrl = "https://images.pexels.com/photos/13918194/pexels-photo-13918194.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1"
                },
                new Region
                {
                    Id = Guid.Parse("132babb6-406a-4e95-b862-217cb0892cb0"),
                    Name = "Southland",
                    Code = "STL",
                    RegionImageUrl = null
                },
            };

            modelBuilder.Entity<Region>().HasData(regions);

        }




    }
}
