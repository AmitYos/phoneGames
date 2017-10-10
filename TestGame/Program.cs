namespace TestGame
{
    class Program
    {
        static void Main(string[] args)
        {
            GamePlayerFactory gamePlayerFactory = new GamePlayerFactory();
            GamePlayer myGamePlayer = gamePlayerFactory.createGamePlayer();
            myGamePlayer.StartNewGame();
            
        }

    }

}
