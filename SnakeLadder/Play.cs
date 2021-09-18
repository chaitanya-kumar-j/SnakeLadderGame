using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeLadder
{
    class Play
    {
        // initialize constants
        const int START_POSITION = 0, END_POSITION = 100, LADDER = 0, SNAKE = 1;

        // initialize variables
        int playerPosition = START_POSITION;

        // initialize random number generator
        Random random = new Random();

        // Add is won method to check player won or not
        public void IsWon()
        {
            while (playerPosition < END_POSITION)
            {
                int playOption = random.Next(3);
                int dieValue = random.Next(1, 7);
                Console.WriteLine($"Rolled Die and got: {dieValue}.");
                switch (playOption)
                {
                    case LADDER:
                        playerPosition += dieValue;
                        Console.WriteLine($"Wow! you got Ladder.");
                        break;
                    case SNAKE:
                        Console.WriteLine($"Oho! you got Snake");
                        playerPosition -= dieValue;
                        if (playerPosition < START_POSITION)
                        {
                            Console.WriteLine($"Don't Worry! you will be at {START_POSITION} only.");
                            playerPosition += dieValue;
                        }                            
                        break;
                    default:
                        Console.WriteLine($"Stay safe! you got same position.");
                        break;
                }
                Console.WriteLine($"Your present position is: {playerPosition}\n");
            }
        }
    }
}
