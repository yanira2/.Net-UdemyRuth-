namespace NZWalks.API.Models.DTOs
{
    public class UpdateWalkRequestDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int LengthInKm { get; set; }
        public string? RegionImageUrl { get; set; }
        public Guid DifficultyId { get; set; }
        public Guid RegionId { get; set; }
    }
}
