using System;

namespace SnakeLadder
{
    class Program
    {
        static void Main(string[] args)
        {
            // Check Whether player Won or not
            int dieRollCount = new Play().IsWon();
            Console.WriteLine($"Hurray! You Won...and taken {dieRollCount} die rolls");
        }
    }
}
