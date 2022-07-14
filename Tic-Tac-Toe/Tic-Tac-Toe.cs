namespace Tic_Tac_Toe
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using Tic_Tac_Toe.Properties;

    public partial class TicTacToe : Form
    {
        // True = player X : False = player O.
        bool playerTurn = true;

        // Counter for how many turns have been played. The maximum is 9.
        int turnsPlayed = 0;

        public TicTacToe()
        {
            InitializeComponent();
        }

        /// <summary>
        /// On button click, carry out logic.
        /// </summary>
        /// <param name="sender">Microsoft stuff.</param>
        /// <param name="e">Microsoft stuff.</param>
        private void buttonClick(object sender, EventArgs e)
        {
            // gets the button which invoked the method.
            Button button = (Button)sender;

            if (playerTurn)
            {
                button.Text = "X";
                label1.Text = "O Goes Next!";
            }
            else
            {
                button.Text = "O";
                label1.Text = "X Goes Next!";
            }

            // Disable the button.
            button.Enabled = false;

            // Change which players turn it is.
            playerTurn = !playerTurn;

            turnsPlayed++;

            // Check for winner if more than 4 turns have been played.
            if (turnsPlayed > 4)
            {
                CheckForWinner(playerTurn, turnsPlayed);
            }
        }

        /// <summary>
        /// Check to see if there is a valid winner.
        /// </summary>
        /// <param name="playerTurn">Which players turn it is.</param>
        /// <param name="turnsPlayed">How many turns have been played.</param>
        private void CheckForWinner(bool playerTurn, int turnsPlayed)
        {
            bool winner = false;

            // Logic to check if there are 3 X's or O's in a row.
            if ((button1.Text == button2.Text) && (button2.Text == button3.Text) && (!button2.Enabled))
            {
                winner = true;
            }
            else if ((button4.Text == button5.Text) && (button5.Text == button6.Text) && (!button5.Enabled))
            {
                winner = true;
            }
            else if ((button1.Text == button8.Text) && (button8.Text == button9.Text) && (!button8.Enabled))
            {
                winner = true;
            }
            else if ((button3.Text == button4.Text) && (button4.Text == button5.Text) && (!button4.Enabled))
            {
                winner = true;
            }
            else if ((button2.Text == button5.Text) && (button5.Text == button8.Text) && (!button5.Enabled))
            {
                winner = true;
            }
            else if ((button3.Text == button6.Text) && (button6.Text == button9.Text) && (!button6.Enabled))
            {
                winner = true;
            }
            else if ((button1.Text == button5.Text) && (button5.Text == button9.Text) && (!button5.Enabled))
            {
                winner = true;
            }
            else if ((button3.Text == button5.Text) && (button5.Text == button7.Text) && (!button5.Enabled))
            {
                winner= true;
            }

            if (winner)
            {
                playerTurn = !playerTurn;
                ThereIsAWinner(playerTurn);
                DisableAllButtons();
            }

            // This is a draw situation.
            if (winner == false && turnsPlayed == 9)
            {
                DisableAllButtons();
                ThereIsNoWinner();
            }
        }

        /// <summary>
        /// Disables all buttons within the control.
        /// </summary>
        private void DisableAllButtons()
        {
            foreach (Control c in Controls)
            {
                if (c is Button b && b != playAgainButton)
                {
                    b.Enabled = false;
                }
            }
        }

        /// <summary>
        /// In event of a draw, mock the players and make the play again button visible.
        /// </summary>
        private void ThereIsNoWinner()
        {
            label1.Text = "It's a draw! (booooo) ";
            playAgainButton.Visible = true;
        }

        /// <summary>
        /// In even that there is a winner, declare the winner and display the play again button.
        /// </summary>
        /// <param name="playerTurn">Which player has won.</param>
        private void ThereIsAWinner(bool playerTurn)
        {
            if (playerTurn)
            {
                label1.Text = "Player X has won! ";
            }
            else
            {
                label1.Text = "Player O has won! ";
            }

            playAgainButton.Visible = true;
        }

        /// <summary>
        /// On click, restart the game.
        /// </summary>
        /// <param name="sender">Microsoft stuff.</param>
        /// <param name="e">Microsoft stuff.</param>
        private void playAgainButton_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
