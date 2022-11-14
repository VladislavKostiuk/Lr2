using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lr2
{
    abstract class Game
    {
        public static int gameCount { get; protected set;}
        
        protected virtual GameAccount GetTheWinner (GameAccount p1, GameAccount p2)
        {
            Random random = new Random();
            int i = random.Next(0, 10);
            if (i <= 4)
            {
                return p1;
            } 
            else
            {
                return p2;
            }
        }

        public abstract int DefineTheRating();
        

        public virtual void GameImitation(GameAccount p1, GameAccount p2)
        {
            if (GetTheWinner(p1, p2) == p1)
            {
                p1.WinGame(p2, this);
                p2.LoseGame(p1, this);
            }
            else
            {
                p2.WinGame(p1, this);
                p1.LoseGame(p2, this);
            }
            gameCount++;
        }
    }
}
