using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeLadder
{
    class Game
    {
        // initialize constants
        const int START_POSITION = 0, END_POSITION = 100, LADDER = 0, SNAKE = 1;

        // initialize variables
        int playerPosition = 0, player1Position = 0, player2Position = 0,
            dieRollCount = 0, dieRollCount1 = 0, dieRollCount2 = 0;
        string player = "Player1";
        bool playerIndicator = true;

        // initialize random number generator
        Random random = new Random();

        // switch player
        public Tuple<int, int, string> SwitchPlayer(bool Indicator, int Position, int Count)
        {
            if (Indicator == true)
            {
                player = "Player1";
                dieRollCount2 = Count+1;
                Count = dieRollCount1;
                player2Position = Position;
                Position = player1Position;
            }
            else
            {
                player = "Player2";
                dieRollCount1 = Count+1;
                Count = dieRollCount2;
                player1Position = Position;
                Position = player2Position;
            }
            return new Tuple<int, int, string>(Count, Position, player);
        }

        // Add is won method to check player won or not
        public Tuple<int, string> Play()
        {
            Console.WriteLine($"{player} will start game.");
            while (playerPosition < END_POSITION)
            {
                int playOption = random.Next(3);
                int dieValue = random.Next(1, 7);
                Console.WriteLine($"{player} rolled Die and got: {dieValue}");
                switch (playOption)
                {
                    case LADDER:
                        dieRollCount++;
                        playerPosition += dieValue;
                        if (playerPosition > END_POSITION)
                        {
                            playerPosition -= dieValue;
                            Console.WriteLine($"Oho!... {player}, you need {END_POSITION - playerPosition} but got {dieValue}.So roll again...");
                            break;
                        }
                        Console.WriteLine($"Wow!... {player}, you got Ladder.");
                        Console.WriteLine($"{player}, Your present position is: {playerPosition}\n");
                        break;
                    case SNAKE:
                        Console.WriteLine($"Oho!... {player}, you got Snake");
                        playerPosition -= dieValue;
                        if (playerPosition < START_POSITION)
                        {
                            Console.WriteLine($"{player}, Don't Worry!... you will be at {START_POSITION} only.");
                            playerPosition = START_POSITION;
                        }
                        Console.WriteLine($"{player}, Your present position is: {playerPosition}\n");
                        playerIndicator = !playerIndicator;
                        var tuple = SwitchPlayer(playerIndicator, playerPosition, dieRollCount);
                        dieRollCount = tuple.Item1;
                        playerPosition = tuple.Item2;
                        player = tuple.Item3;
                        break;
                    default:
                        Console.WriteLine($"{player}, Stay safe!... you got same position.");
                        Console.WriteLine($"{player}, Your present position is: {playerPosition}\n");
                        playerIndicator = !playerIndicator;
                        var tuple1 = SwitchPlayer(playerIndicator, playerPosition, dieRollCount);
                        dieRollCount = tuple1.Item1;
                        playerPosition = tuple1.Item2;
                        player = tuple1.Item3;
                        break;
                }
            }
            return new Tuple<int, string>(dieRollCount, player);
        }
    }
}
