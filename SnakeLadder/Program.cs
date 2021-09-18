using System;

namespace SnakeLadder
{
    class Program
    {
        static void Main(string[] args)
        {
            // Check Whether player Won or not
            new Play().IsWon();
            Console.WriteLine("Hurray! You Won...");
        }
    }
}
