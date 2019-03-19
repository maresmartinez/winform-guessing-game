using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GuessingGameLib;

namespace GuessingGameForm {

    /// <summary>
    /// Form for user to specify the lower and upper bounds for their game.
    /// </summary>
    public partial class UserSpecificSettings : Form {

        /// <summary>
        /// Shows the form to change default bounds.
        /// </summary>
        public UserSpecificSettings() {
            InitializeComponent();
        }

        /// <summary>
        /// When the set default button is clicked, the user's upper and lower bounds will be changed.
        /// The upper and lower bounds must be valid, otherwise they will remain unchanged.
        /// </summary>
        /// <param name="sender">Object that raised the event.</param>
        /// <param name="e">Contains data associated with event.</param>
        private void btnDefaults_Click(object sender, EventArgs e) {

            // Use range to validate bounds entered
            int lBound = int.Parse(txtDefaultLBound.Text);
            int uBound = int.Parse(txtDefaultUBound.Text);
            Range range = new Range(lBound, uBound);

            // If invalid bounds, the range will have used the default and nothing changes
            GuessingGameLib.Properties.Settings.Default.DEFAULT_LOWER_BOUND = range.LBound;
            GuessingGameLib.Properties.Settings.Default.DEFAULT_UPPER_BOUND = range.UBound;
            GuessingGameLib.Properties.Settings.Default.Save();
        }
    }
}
