using System;

namespace SnakeAndLadderPlay
{
    class Program
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Welcome to Snake and Ladder play");
            if (args.Length==1)
            {
                SnakeAndLadder snakeAndLadder = new SnakeAndLadder();
                snakeAndLadder.DieRoll();
                snakeAndLadder.Game();
            }
            else
            {
                Console.WriteLine("No player for game");
            }

        }
    }
}
