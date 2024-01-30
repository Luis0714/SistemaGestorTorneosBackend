namespace ShopEstre.Domain.Entities
{
    public class PlayerGame
    {
        public Guid PlayerGameId { get; set; }
        public Guid PlayerTeamTournamentId { get; set; }
        public Guid GameId{ get; set; }
        public PlayerTeamTournaments PlayerTeamTournament { get; set; }
        public List<PlayerGameStatistics> PlayerGameStatistics { get; set; }
        public Game Game { get; set; }
        public bool IsStarter { get; set; }

        public PlayerGame(Game game, PlayerTeamTournaments playerTeamTournament, List<PlayerGameStatistics> playerGameStatistics, bool isStarter)
        {
            PlayerGameId = Guid.NewGuid();
            Game = game;
            PlayerTeamTournament = playerTeamTournament;
            PlayerGameStatistics = playerGameStatistics;
            IsStarter = isStarter;
        }

        public PlayerGame(bool isStarter)
        {
            IsStarter = isStarter;
        }
        public PlayerGame()
        {
            PlayerGameId = Guid.NewGuid();
        }
    }
}
