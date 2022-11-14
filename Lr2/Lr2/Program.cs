namespace Lr2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DefaultAccount defaultplayer = new DefaultAccount("Vlad");
            EasyAccount easyplayer = new EasyAccount("Artem");
            StreakAccount streakplayer = new StreakAccount("Andrew");

            GameFactory factory = new GameFactory();
            var defaultGame = factory.CreateDefaultGame();
            var trainingGame = factory.CreateTrainingGame();
            var oddGame = factory.CreateOddGame();

            defaultGame.GameImitation(streakplayer, easyplayer);
            trainingGame.GameImitation(streakplayer, defaultplayer);
            oddGame.GameImitation(defaultplayer, easyplayer);

            streakplayer.GetStats(streakplayer.history);
            easyplayer.GetStats(easyplayer.history);
            defaultplayer.GetStats(defaultplayer.history);

        }
    }
}