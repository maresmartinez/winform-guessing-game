﻿using System;
using System.Windows.Forms;
using GuessingGameLib;

namespace GuessingGameForm {

    /// <summary>
    /// Partial class that holds the view for the guess form. Contains inputs for upper and lower bound of range and allows user to guess random number.
    /// </summary>
    public partial class GuessForm : Form {

        /// <summary>
        /// Generates a random number in a range that the user will try to guess.
        /// </summary>
        GameLogic gameLogic;

        /// <summary>
        /// Constructor that will initialize the form to play the guessing game.
        /// </summary>
        public GuessForm() {
            InitializeComponent();
        }

        /// <summary>
        /// When the user clicks the start button, the user's upper and lower bounds
        /// are used to generate a random number. The form elements to guess the 
        /// random number are then enabled.
        /// </summary>
        /// <param name="sender">Object that raised the event.</param>
        /// <param name="e">Contains data associated with event.</param>
        private void BtnStart_Click(object sender, EventArgs e) {

            // Convert user's values for bounds to int
            int lBound = int.Parse(txtLBound.Text);
            int uBound = int.Parse(txtUBound.Text); 

            // Use range object to validate user entries
            Range range = new Range(lBound, uBound);
            gameLogic = new GameLogic(range);

            // Disable bounds from being changed and enable guess to be entered
            // Change design to reflect whether enabled/disabled
            txtLBound.ReadOnly = true;
            txtLBound.BackColor = System.Drawing.Color.Gray;
            txtUBound.ReadOnly = true;
            txtUBound.BackColor = System.Drawing.Color.Gray;
            txtGuess.ReadOnly = false;
            txtGuess.BackColor = System.Drawing.Color.White;

            // Disable start button and enable check button
            btnStart.BackColor = System.Drawing.Color.DarkGray;
            btnStart.Enabled = false;
            btnGuess.BackColor = System.Drawing.Color.LightGray;
            btnGuess.Enabled = true;

            // Change text for outcome to reflect range
            lblOutcome.Text = "Enter a range between " + range.LBound 
                + " and " + range.UBound + ". You have " + gameLogic.GuessLimit 
                + " guesses.";
        }

        /// <summary>
        /// When the user clicks the guess button, the user's guess is
        /// taken from the text box and compared with the random number
        /// that was generated by gameLogic. The user is either correct 
        /// and the game ends, or incorrect and they can continue entering 
        /// guesses.
        /// </summary>
        /// <param name="sender">Object that raised the event.</param>
        /// <param name="e">Contains data associated with event.</param>
        private void BtnGuess_Click(object sender, EventArgs e) {

            // Check if the user's guess was correct or not
            int uNum = int.Parse(txtGuess.Text);
            GameState state = gameLogic.VerifyGuess(uNum);

            // Change text and color based on guess
            switch (state) {
                case GameState.GUESS_CORRECT:
                    // Show winning text
                    lblOutcome.ForeColor = System.Drawing.Color.Green;
                    lblOutcome.Text = "Congratulations, you guessed correctly!";

                    // Disable check button to end game
                    btnGuess.BackColor = System.Drawing.Color.DarkGray;
                    btnGuess.Enabled = false;
                    break;

                case GameState.TOO_LOW:
                    lblOutcome.Text = "Your guess was too low! You have " + gameLogic.GuessLimit + " guesses left.";
                    break;

                case GameState.TOO_HIGH:
                    lblOutcome.Text = "Your guess was too high! You have " + gameLogic.GuessLimit + " guesses left.";
                    break;

                case GameState.GAME_OVER:
                    // Show losing text
                    lblOutcome.ForeColor = System.Drawing.Color.Red;
                    lblOutcome.Text = "Wrong again! \nYou have no more guesses. \nGame Over!";

                    // Disable check button to end game
                    btnGuess.BackColor = System.Drawing.Color.DarkGray;
                    btnGuess.Enabled = false;
                    break;
            }

        }

        /// <summary>
        /// Shows the form to specify default ranges for user.
        /// </summary>
        /// <param name="sender">Object that raised the event.</param>
        /// <param name="e">Contains data associated with event.</param>
        private void BtnSetDefaults_Click(object sender, EventArgs e) {
            UserSpecificSettings defaultForm = new UserSpecificSettings();
            defaultForm.Show();
        }
    }
}
