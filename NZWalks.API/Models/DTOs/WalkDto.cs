namespace NZWalks.API.Models.DTOs
{
    public class WalkDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int LengthInKm { get; set; }
        public string? RegionImageUrl { get; set; }


        public RegionDto Region { get; set; }
        public DifficultyDto Difficulty { get; set; }
    }
}
