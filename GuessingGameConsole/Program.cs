using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GuessingGameLib;

namespace GuessingGameConsole {
    /// <summary>
    /// Entry point for the console guessing game.
    /// </summary>
    static class Program {
        /// <summary>
        /// The main entry point for the application. Launches a console guessing game with a limited amount of tries and custom range.
        /// </summary>
        static void Main(string[] args) {

            // Allow user to enter range
            Console.WriteLine("You will be asked to select a range. \nIf the range is invalid, a default range is used.\n");
            Console.WriteLine("Enter lower bound: ");
            int lBound = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter upper bound: ");
            int uBound = int.Parse(Console.ReadLine());

            // Validate range and start game
            Range range = new Range(lBound, uBound);
            GameLogic gameLogic = new GameLogic(range);

            // Start Game
            while (gameLogic.GuessLimit >= 1) {

                Console.WriteLine("\nGuess the number between {0} and {1}. You have {2} guesses. \nGuess: ", range.LBound, range.UBound, gameLogic.GuessLimit);
                int guess = int.Parse(Console.ReadLine());

                GameState result = gameLogic.VerifyGuess(guess);

                // Show results based on guess
                switch (result) {
                    case GameState.GUESS_CORRECT:
                        Console.WriteLine("Congratulations, you guessed correctly!", gameLogic.GuessLimit);
                        break;
                    case GameState.TOO_LOW:
                        Console.WriteLine("Your guess was too low. You have {0} guesses left.", gameLogic.GuessLimit);
                        break;
                    case GameState.TOO_HIGH:
                        Console.WriteLine("Your guess was too high. You have {0} guesses left.", gameLogic.GuessLimit);
                        break;
                    case GameState.GAME_OVER:
                        Console.WriteLine("Wrong again! You have no more guesses. Game Over!", gameLogic.GuessLimit);
                        break;
                }
                
                // Exit loop when game is over
                if (result == GameState.GUESS_CORRECT || result == GameState.GAME_OVER) {
                    break;
                }

            }

            // Show Console
            Console.Read();
        }

    }
}
