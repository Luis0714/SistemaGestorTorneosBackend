namespace ShopEstre.Domain.Entities
{
    public class PlayerGameStatistics
    {
        public Guid PlayerGameStatisticsId { get; set; }
        public Guid PlayerGameId { get; set; }
        public int Scores { get; set; }
        public int YellowCards { get; set; }
        public int RedCards { get; set; }
        public PlayerGame PlayerGame { get; set; }

        public PlayerGameStatistics(PlayerGame playerGame, int scores, int yellowCards, int redCards)
        {
            PlayerGameStatisticsId = Guid.NewGuid();
            PlayerGame = playerGame;
            Scores = scores;
            YellowCards = yellowCards;
            RedCards = redCards;
        }

        public PlayerGameStatistics(int scores, int yellowCards, int redCards)
        {
            Scores = scores;
            YellowCards = yellowCards;
            RedCards = redCards;
        }
        public PlayerGameStatistics()
        {
            PlayerGameStatisticsId = Guid.NewGuid();
        }
    }
}
