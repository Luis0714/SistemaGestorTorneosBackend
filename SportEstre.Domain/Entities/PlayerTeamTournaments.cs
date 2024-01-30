namespace ShopEstre.Domain.Entities
{
    public class PlayerTeamTournaments
    {
        public Guid PlayerTeamTournamentId { get; set; }
        public Guid TournamentTeamId { get; set; }
        public Guid PlayerId { get; set; }
        public bool IsActive { get; set; }
        public Player Player { get; set; }
        public TournamentTeams TournamentTeam { get; set; }

        public PlayerTeamTournaments(Player player, TournamentTeams tournamentTeams, bool isActive)
        {
            PlayerTeamTournamentId = Guid.NewGuid();
            Player = player;
            TournamentTeam = tournamentTeams;
            IsActive = isActive;
        }

        public PlayerTeamTournaments(bool isActive)
        {
            IsActive = isActive;
        }

        public PlayerTeamTournaments()
        {
            PlayerTeamTournamentId = Guid.NewGuid();
        }
    }
}
