using ShopEstre.Domain.ValueObjects;

namespace ShopEstre.Domain.Entities
{
    public class Team
    {
        public Guid TeamId { get; set; }
        public string Name { get; set; } = string.Empty;
        public Abbreviation Abbreviation { get; set; }
        public string? Photo { get; set; } = string.Empty;
        public List<TournamentTeams> TournamentTeams { get; set; }

        public Team(string name, Abbreviation abbreviation, string photo, List<TournamentTeams> tournamentTeams)
        {
            TeamId = Guid.NewGuid();
            Name = name;
            Abbreviation = abbreviation;
            Photo = photo;
            TournamentTeams = tournamentTeams;
        }

        public Team(string name, Abbreviation abbreviation, string photo)
        {
            Name = name;
            Abbreviation = abbreviation;
            Photo = photo;
        }
        public Team()
        {
            TeamId = Guid.NewGuid();
        }
    }
}



