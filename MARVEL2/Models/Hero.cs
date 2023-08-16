namespace MARVEL2.Models
{
    public class Hero 
    {
        public Guid Id { get; set; }
        public string? HeroName { get; set; }
        public string? RealIdentity { get; set; }
        public string? OriginPlanet { get; set; }
        public string? Nemisis { get; set; }
    }
}
