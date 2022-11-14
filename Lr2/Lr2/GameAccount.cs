using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lr2
{
    abstract class GameAccount
    {
        public GameAccount(string UserName)
        {
            this.UserName = UserName;
        }
        public string UserName { get; set; }
        protected int currentRating = 100;
        public int CurrentRating { get; protected set; }
        public int GamesCount { get; protected set; }

        public List<GameHistory> history = new List<GameHistory>();
        protected string gameId;

        public virtual void WinGame(GameAccount opponent, Game game)
        {
            int rating = Rating(game);
            if (rating < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(rating), "Помилка, рейтинг на який грають не може бути від'ємним");
            }
            else
            {

                CurrentRating = currentRating + rating;
                currentRating = CurrentRating;
                gameId = Game.gameCount.ToString();

                history.Add(new GameHistory(UserName, opponent.UserName, "Перемога", rating, gameId));

                GamesCount++;
                
            }
        }


        public virtual void LoseGame(GameAccount opponent, Game game)
        {
            int rating = Rating(game);
            if (rating < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(rating), "Помилка, рейтинг на який грають не може бути від'ємним");
            }
            else
            {
                CurrentRating = currentRating - rating;
                if (CurrentRating < 1)
                {
                    CurrentRating = 1;
                }
                currentRating = CurrentRating;
                gameId = Game.gameCount.ToString();

                history.Add(new GameHistory(UserName, opponent.UserName, "Поразка", rating, gameId));


                GamesCount++;
                
            }
        }

        protected int Rating(Game game)
        {
            return game.DefineTheRating();
        }

        public void GetStats(List<GameHistory> playerHistoryOfGames)
        {
            Console.WriteLine("Статистика гравця " + playerHistoryOfGames[0].PlayerName + ":");
            Console.WriteLine("Кiлькiсть зиграних iгор: " + GamesCount);
            foreach (GameHistory game in playerHistoryOfGames)
            {
                game.PrintInfo();
            }
            Console.WriteLine("Поточний рейтинг: " + CurrentRating);
            Console.WriteLine();
        }

    }
}
