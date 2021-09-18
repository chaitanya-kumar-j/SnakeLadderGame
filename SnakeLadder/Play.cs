using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeLadder
{
    class Play
    {
        // initialize constants
        const int START_POSITION = 0, END_POSITION = 100;

        // initialize variables
        int playerPosition = START_POSITION;

        // initialize random number generator
        Random random = new Random();

        // Add rolldie method to generate randome die value
        public int RollDie()
        {
            int dieValue = random.Next(1, 7);
            Console.WriteLine($"Rolled Die and got: {dieValue}");
            return dieValue;
        }
    }
}
