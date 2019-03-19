using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGameLib {

    /// <summary>
    /// Hints for whether a guess is correct or not.
    /// </summary>
    public enum GameState {

        /// <summary>
        /// Guess is exactly correct.
        /// </summary>
        GUESS_CORRECT,

        /// <summary>
        /// Guess is too low.
        /// </summary>
        TOO_LOW,

        /// <summary>
        /// Guess is too high.
        /// </summary>
        TOO_HIGH,

        /// <summary>
        /// The user has made too many guesses and lost the game.
        /// </summary>
        GAME_OVER
    }
}
