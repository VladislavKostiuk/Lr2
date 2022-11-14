using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lr2
{
    class OddGame : Game
    {
        public override void GameImitation(GameAccount p1, GameAccount p2)
        {
            TrainingGame withoutRating = new TrainingGame();
            if (GetTheWinner(p1, p2) == p1)
            {
                p1.WinGame(p2, withoutRating);
                p2.LoseGame(p1, this);
            }
            else
            {
                p2.WinGame(p1, this);
                p1.LoseGame(p2, withoutRating);
            }
            gameCount++;
        }

        public override int DefineTheRating()
        {
            int rating = 20;
            return rating;
        }
    }
}
