using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lr2
{
    class StreakAccount : GameAccount
    {
        private static int countStreak = 0;
        public StreakAccount(string UserName) : base(UserName: UserName)
        {
            this.UserName = UserName;
        }

        public override void WinGame(GameAccount opponent, Game game)
        { 
            int rating = Rating(game);

            if ( rating != 0)
            {
                countStreak++;
            }

            if (countStreak == 3)
            {
                rating += 15;
                countStreak = 0;
            }

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
    }
}
