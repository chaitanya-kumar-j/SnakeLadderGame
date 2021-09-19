using System;

namespace SnakeLadder
{
    class Program
    {
        static void Main(string[] args)
        {
            // Check Whether player Won or not
            var tuple = new Game().Play();
            int dieRollCount = tuple.Item1;
            string player = tuple.Item2;
            Console.WriteLine($"Hurray!... {player} Won in {dieRollCount} die rolls.");
        }
    }
}
