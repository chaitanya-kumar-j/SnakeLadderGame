using System;

namespace SnakeLadder
{
    class Program
    {
        static void Main(string[] args)
        {
            int dieValue = new Play().RollDie();
            Console.WriteLine($"Rolled die and got: {dieValue}");
        }
    }
}
