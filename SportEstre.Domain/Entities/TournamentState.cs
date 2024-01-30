namespace ShopEstre.Domain.Entities
{
    public class TournamentState
    {
        public Guid TournamentStateId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public TournamentState(string name, string description)
        {
            TournamentStateId = Guid.NewGuid();
            Name = name;
            Description = description;
        }

        public TournamentState()
        {
            TournamentStateId = Guid.NewGuid();
        }
    }
}
