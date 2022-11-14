using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lr2
{
    class GameFactory
    {
        public Game CreateDefaultGame()
        {
            return new DefaultGame();
        }

        public Game CreateTrainingGame()
        {
            return new TrainingGame();
        }

        public Game CreateOddGame()
        {
            return new OddGame();
        }
    }
}
