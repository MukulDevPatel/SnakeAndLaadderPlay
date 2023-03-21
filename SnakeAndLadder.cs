using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadderPlay
{
    public class SnakeAndLadder
    {
        const int NO_PLAY = 0, LADDER = 1, SNAKE = 2;
        int playerPosition = 0;  //UC1
        
        //UC2
        Random random = new Random();
        public int DieRoll()
        {
            int die = random.Next(1, 7);
            return die;
        }
        //UC3
        public void Game()
        {
            int option = random.Next(1, 3);
            switch (option)
            {
                case NO_PLAY:
                    break;
                case LADDER:
                    this.playerPosition += DieRoll();
                    Console.WriteLine("Ladder - moved ahead" + DieRoll());
                    break;
                case SNAKE:
                    this.playerPosition -= DieRoll();
                    Console.WriteLine("Snake - move behind" + DieRoll());
                    break;
            }
        }
    }
}
