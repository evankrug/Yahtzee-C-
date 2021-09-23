using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yahtzee_game
{
    public class Die
    {
        private Random random;
        public Die()
        {
            random = new Random();
        }
        public int RollDie()
        {
            return random.Next(1, 6);
        }
    }
}
