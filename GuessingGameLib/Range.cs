using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGameLib {

    /// <summary>
    /// Range will create a valid upper and lower bound. Valid means that the upper
    /// bound must be larger than the lower bound.
    /// </summary>
    public struct Range {

        /// <summary>
        /// Lower bound for the range.
        /// </summary>
        public int LBound { get; set; }

        /// <summary>
        /// Upper bound for the range.
        /// </summary>
        public int UBound { get; set; }

        /// <summary>
        /// Constructor that will either use a valid lower and upper bound, 
        /// or use default values if the given values are invalid.
        /// </summary>
        /// <param name="lBound">Given lower bound.</param>
        /// <param name="uBound">Given upper bound.</param>
        public Range(int lBound, int uBound) {

            // Check if given bounds are valid
            if (lBound < uBound) {
                // Range is valid
                LBound = lBound;
                UBound = uBound;
            } else {
                // Range is invalid, use defaults
                LBound = Properties.Settings.Default.DEFAULT_LOWER_BOUND;
                UBound = Properties.Settings.Default.DEFAULT_UPPER_BOUND;
            }
        }
    }
}
