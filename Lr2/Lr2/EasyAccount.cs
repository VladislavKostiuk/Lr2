using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lr2
{
    class EasyAccount : GameAccount
    {
        public EasyAccount(string UserName) : base(UserName: UserName)
        {
            this.UserName = UserName;
        }

        public override void LoseGame(GameAccount opponent, Game game)
        {
            int rating = Rating(game) / 2;
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
    }
}
