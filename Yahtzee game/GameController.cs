using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yahtzee_game
{
    class GameController
    {
        const int TURNS = 13;
        List<Player> playerList = new List<Player>();
        Cup cup;
        public GameController(int numPlayers) {
            for(int i = 1; i <= numPlayers; i++)
            {
                playerList.Add(new Player(i));
            }
            StartGame();
        }

        private void StartGame()
        {
            cup = new Cup();
        }
        private void PassCup()
        {

        }
    }
}
