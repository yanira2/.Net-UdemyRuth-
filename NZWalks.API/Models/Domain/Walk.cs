﻿namespace NZWalks.API.Models.Domain
{
    public class Walk
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double LengthInKm { get; set; }
        public string? RegionImageUrl { get; set; }
        public Guid DifficultyId { get; set; }
        public Guid RegionId { get; set; }

        // Navegation properties
        public Difficulty Difficulty { get; set; }
        public Region Region { get; set; }



    }
}
