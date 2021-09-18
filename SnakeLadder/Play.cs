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

        // roll die method to return random die value 
        public int RollDie()
        {
            int dieValue = random.Next(1, 7);
            return dieValue;
        }

        //Console.WriteLine($"player position is: {playerPosition}");
    }
}
