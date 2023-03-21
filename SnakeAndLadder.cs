using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadderPlay
{
    public class SnakeAndLadder
    {
        const int NO_PLAY = 0, LADDER = 1, SNAKE = 2, WINNING_POSITION = 100;
        int playerPosition = 0;  //UC1
        int count=0;
        
        //UC2
        Random random = new Random();
        public int DieRoll()
        {
            int die = random.Next(1, 7);
            Console.WriteLine("Die value ---->" + die);
            count++;
            return die;
        }
        //UC3
        public void Game()
        {
            while (this.playerPosition < WINNING_POSITION)
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
                if (this.playerPosition < 0)
                {
                    playerPosition = 0;
                    Console.WriteLine("You went zero, Restart game from 0");
                }
                if (this.playerPosition ==  WINNING_POSITION)
                {
                    Console.WriteLine("Player position--->" + playerPosition);
                }
            }
        }
    }
}
