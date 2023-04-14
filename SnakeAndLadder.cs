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
        int playerPosition1 = 0;  //UC1
        int playerPosition2 = 0;
        int currentPlayer = 1;
        int count = 0;
        bool ladder = false;
        
        //UC2
        Random random = new Random();
        public int DieRoll()
        {
            int die = random.Next(1, 7);
            Console.WriteLine("Die value ---->" + die);
            count++;
            return die;
        }
        //UC7
        public void Game()
        {
            while (this.playerPosition1 < WINNING_POSITION && this.playerPosition2 < WINNING_POSITION)
            {
                ladder = false;
                int option = random.Next(0, 2);
                int currentPlayerPosition;
                if (currentPlayer == 1)
                {
                    currentPlayerPosition = this.playerPosition1;
                }else
                {
                    currentPlayerPosition = this.playerPosition2;
                }
                switch (option)
                {
                    case NO_PLAY:
                        break;
                    case LADDER:
                        currentPlayerPosition += DieRoll();
                        Console.WriteLine("Ladder - moved ahead " + DieRoll() + currentPlayer);
                        ladder = true;
                        break;
                    case SNAKE:
                        currentPlayerPosition = DieRoll();
                        if (currentPlayerPosition - DieRoll() > 0)
                            currentPlayerPosition -= DieRoll();
                        else
                            currentPlayerPosition = 0;
                        Console.WriteLine("Snake - move behind " + DieRoll());
                        break;
                }
                Console.WriteLine("You went zero, Restart game from 0");
                if (currentPlayerPosition < 0)
                {
                    Console.WriteLine("Player position--->" + currentPlayer);
                    Console.WriteLine("Die count--->" + count);
                }
                else if (currentPlayerPosition > 100)
                {
                    currentPlayerPosition -= DieRoll();
                    Console.WriteLine("You get number over to 100, so stay in same position");
                }
                if (currentPlayer == 1)
                    playerPosition1 = currentPlayerPosition;
                playerPosition2 = currentPlayerPosition;
                Console.WriteLine("Player 1: " + playerPosition1);
                Console.WriteLine("Player 2: " + playerPosition2);

                if (currentPlayerPosition == 100)
                {
                    Console.WriteLine("Congrats!"+ currentPlayer + "you have reached winning position 100");
                    break; //exit loop
                }

                //if ladder is not obtained, switch to other player
                if (!ladder)
                {
                    currentPlayer = (currentPlayer == 1) ? 2 : 1;
                }
            }

            //check which player won in case game did not end while loop
            if (playerPosition1 == 100 && playerPosition2 == 100)
            {
                Console.WriteLine("It is tie");
            }else if (playerPosition1 == 100)
            {
                Console.WriteLine("Player 1 won the game");
            }else
                Console.WriteLine("Player 2 won the game");
        }
    }
}
