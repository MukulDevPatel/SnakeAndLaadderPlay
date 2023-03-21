using System;

namespace SnakeAndLadderPlay
{
    class Program
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Welcome to Snake and Ladder play");
            SnakeAndLadder snakeAndLadder = new SnakeAndLadder();
            snakeAndLadder.DieRoll();

        }
    }
}
