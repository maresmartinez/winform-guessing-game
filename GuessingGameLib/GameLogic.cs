using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGameLib {

    /// <summary>
    /// Contains the logic for a game where one must guess a random number between a given range.
    /// </summary>
    public class GameLogic {

        /// <summary>
        /// Random number to be guessed.
        /// </summary>
        readonly int rNum;

        public const int DefaultGuessLimit = 5;

        /// <summary>
        /// Limits the amount of guesses the user can make. Uses the default guess limit.
        /// </summary>
        public int GuessLimit { get; set; }

        /// <summary>
        /// Constructor that generates a random number. Uses default guess limit.
        /// </summary>
        /// <param name="range">Range object used to get upper and lower bounds for random number.</param>
        public GameLogic(Range range) {

            // Generate random number between range
            // Add 1 because second parameter is exclusive, but we want to include upperbound in range
            rNum = new Random().Next(range.LBound, range.UBound + 1);

            // Initialize number of guesses
            GuessLimit = DefaultGuessLimit;
        }

        /// <summary>
        /// Constructor that generates a random number. Allows valid custom guess limit. 
        /// Valid means positive integer that is greater than 1 (so that user has at least one guess). 
        /// If invalid, uses default.
        /// </summary>
        /// <param name="range">Range object used to get upper and lower bounds for random number.</param>
        /// <param name="guessLimit">Maximum number of guesses allowed.</param>
        public GameLogic(Range range, int guessLimit) {

            // Generate random number between range
            // Add 1 because second parameter is exclusive, but we want to include upperbound in range
            rNum = new Random().Next(range.LBound, range.UBound + 1);

            // Initialize number of guesses
            if (guessLimit >= 1) {
                GuessLimit = guessLimit;
            } else {
                GuessLimit = DefaultGuessLimit;
            }
        }

        /// <summary>
        /// Takes uNum and compares it with rNum. If the user has no more guesses, returns game over state.
        /// </summary>
        /// <param name="uNum">The number to compare to the randomly generated number.</param>
        /// <returns>GameState object that gives a hint of the relationship between rNum and uNum, or game over.</returns>
        public GameState VerifyGuess(int uNum) { 
            
            

            GameState result;

            // Compare random to user input
            if (uNum < rNum) {
                result = GameState.TOO_LOW;
            } else if (uNum > rNum) {
                result = GameState.TOO_HIGH;
            } else {
                result = GameState.GUESS_CORRECT;
            }

            GuessLimit--; // Lose one try

            // User is not allowed any more guesses
            if (GuessLimit <= 0 && result != GameState.GUESS_CORRECT) {
                return GameState.GAME_OVER;
            }

            return result;
        }

    }
}
