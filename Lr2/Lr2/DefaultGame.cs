using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lr2
{
    class DefaultGame : Game
    {
        public override int DefineTheRating()
        {
            int rating = 20;
            return rating;
        }
    }
}
