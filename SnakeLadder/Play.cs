using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeLadder
{
    class Play
    {
        // initialize constants
        const int START_POSITION = 0, END_POSITION = 100, NO_PLAY = 0, LADDER = 1, SNAKE = 2;

        // initialize variables
        int playerPosition = START_POSITION;

        // initialize random number generator
        Random random = new Random();

        // Add rolldie method to generate randome die value
        public int RollDie()
        {
            int playOption = random.Next(3);
            int dieValue = random.Next(1, 7);
            Console.WriteLine($"Rolled Die and got: {dieValue}");
            switch (playOption)
            {
                case LADDER:
                    Console.WriteLine($"Wow! you got Ladder");
                    playerPosition += dieValue;
                    break;
                case SNAKE:
                    Console.WriteLine($"Oh! you got Snake");
                    playerPosition -= dieValue;
                    break;
                default:
                    Console.WriteLine($"Stay safe! you got same position");
                    break;
            }
            Console.WriteLine($"player present position is: {playerPosition}");
            return playerPosition;
        }
    }
}
