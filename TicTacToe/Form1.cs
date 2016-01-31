using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    /// <summary>
    /// Classic game of Tick Tack Toe by Seniority Labs.
    /// Coded by Anthony Senior II, 11/19/2015.
    /// </summary>
    public partial class Form1 : Form
    {
        bool turn = true; // True is X's turn. False is O's turn.
        int turn_count = 0; // Keeps track of how many turns have occurred.
        bool haveWinner = false; // If haveWinner is true, that means there is a winner. False means there is no winner yet.
        static String player1, player2;

        public Form1()
        {
            InitializeComponent();
        }

        /******************************* Player Names Form ************************************/
        private void Form1_Load(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();

            label1.Text = player1 + " (X)";
            label3.Text = player2 + " (O)";
        }

        public static void SetPlayerNames(String name1, String name2)
        {
            player1 = name1;
            player2 = name2;            
        }


        /********************************** Menu Strip ****************************************/
        private void newGameToolStripMenuItem_Click(object sender, EventArgs e) // File>New Game
        {
            turn = true;
            turn_count = 0;
            haveWinner = false;

            foreach (Control c in Controls)
            {
                try
                {
                    Button b = (Button)c;
                    b.Enabled = true;
                    b.Text = "";
                    b.BackColor = SystemColors.Control;
                }
                catch { }
            }

            newGameButton.Text = "New Game";
        }

        private void changePlayersToolStripMenuItem_Click(object sender, EventArgs e) // File>Change Players
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();

            label1.Text = player1 + "(X)";
            label3.Text = player2 + "(O)";
            o_win_count.Text = "0";
            x_win_count.Text = "0";
            draw_count.Text = "0";
            turn = true;
            turn_count = 0;
            haveWinner = false;

            foreach (Control c in Controls)
            {
                try
                {
                    Button b = (Button)c;
                    b.Enabled = true;
                    b.Text = "";
                    b.BackColor = SystemColors.Control;
                }
                catch { }
            }

            newGameButton.Text = "New Game";
        }

        private void resetScoreboardToolStripMenuItem_Click(object sender, EventArgs e) // File>Reset Scoreboard
        {
            o_win_count.Text = "0";
            x_win_count.Text = "0";
            draw_count.Text = "0";
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) // File>Exit
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e) // Help>About
        {
            string about_message = "";
            about_message += "Welcome to Tic Tac Toe by Seniority Labs\n\n";
            about_message += "This is the classic game of Tic Tac Toe in wich two\n";
            about_message += "players take turns marking either \"X\" or \"O\" on\n";
            about_message += "the game's boxes. The first player to make a line of \n";
            about_message += "three X's or O's will win the game. The line of marks \n";
            about_message += "may be vertical, horizontal, or diagonal. If neither \n";
            about_message += "player is able to make a line of three marks before all\n";
            about_message += "of the boxes are filled, the game will be a draw and \n";
            about_message += "nobody wins the game. Have fun!";            

            MessageBox.Show(about_message, "About Tic Tac Toe");
        }


        /*************************************** Buttons ****************************************/
        private void newGameButton_Click(object sender, EventArgs e) //New Game button
        {
            turn = true;
            turn_count = 0;
            haveWinner = false;

                foreach (Control c in Controls)
                {
                    try {
                        Button b = (Button)c;
                        b.Enabled = true;
                        b.Text = "";
                        b.BackColor = SystemColors.Control;
                    }
                    catch { }
                }   
                        
            newGameButton.Text = "New Game";
        }

        private void button_click(object sender, EventArgs e) // Game buttons for the X and O marks
        {
            Button b = (Button)sender;
            if (turn)
            {
                b.Text = "X";
            }
            else
            {
                b.Text = "O";
            }

            b.Enabled = false; // Disables the button after it is clicked
            turn = !turn; // Switches turn. If the last button text said "X" then the next one will say "O".
            turn_count++;
            checkForWinner();
        }

        private void checkForWinner() // Checks to see if there is a line of three matching marks (a winner)
        {
            // Horizontal mark checks
            if ((A1.Text == A2.Text) && (A2.Text == A3.Text) && (!A1.Enabled))
            {
                haveWinner = true;
                A1.BackColor = SystemColors.ActiveCaption;
                A2.BackColor = SystemColors.ActiveCaption;
                A3.BackColor = SystemColors.ActiveCaption;
            }
            else if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && (!B1.Enabled))
            {
                haveWinner = true;
                B1.BackColor = SystemColors.ActiveCaption;
                B2.BackColor = SystemColors.ActiveCaption;
                B3.BackColor = SystemColors.ActiveCaption;
            }
            else if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && (!C1.Enabled))
            {
                haveWinner = true;
                C1.BackColor = SystemColors.ActiveCaption;
                C2.BackColor = SystemColors.ActiveCaption;
                C3.BackColor = SystemColors.ActiveCaption;
            }

            // Vertical mark checks
            if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && (!A1.Enabled))
            {
                haveWinner = true;
                A1.BackColor = SystemColors.ActiveCaption;
                B1.BackColor = SystemColors.ActiveCaption;
                C1.BackColor = SystemColors.ActiveCaption;
            }
            else if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && (!A2.Enabled))
            {
                haveWinner = true;
                A2.BackColor = SystemColors.ActiveCaption;
                B2.BackColor = SystemColors.ActiveCaption;
                C2.BackColor = SystemColors.ActiveCaption;
            }
            else if ((A3.Text == B3.Text) && (B3.Text == C3.Text) && (!A3.Enabled))
            {
                haveWinner = true;
                A3.BackColor = SystemColors.ActiveCaption;
                B3.BackColor = SystemColors.ActiveCaption;
                C3.BackColor = SystemColors.ActiveCaption;
            }

            // Diagonal mark checks
            if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && (!A1.Enabled))
            {
                haveWinner = true;
                A1.BackColor = SystemColors.ActiveCaption;
                B2.BackColor = SystemColors.ActiveCaption;
                C3.BackColor = SystemColors.ActiveCaption;
            }
            else if ((A3.Text == B2.Text) && (B2.Text == C1.Text) && (!C1.Enabled))
            {
                haveWinner = true;
                A3.BackColor = SystemColors.ActiveCaption;
                B2.BackColor = SystemColors.ActiveCaption;
                C1.BackColor = SystemColors.ActiveCaption;
            }

            if (haveWinner) // Execute this code if there is a winner
            {
                disableButtons();
                string winner = "";
                if (turn)
                {
                    winner = player2;
                    o_win_count.Text = (Int32.Parse(o_win_count.Text) + 1).ToString();
                }
                else
                {
                    winner = player1;
                    x_win_count.Text = (Int32.Parse(x_win_count.Text) + 1).ToString();
                }
                MessageBox.Show(winner + " wins!", "WINNER!");
            }
            else // Execute this code if all boxes were filled with marks, but no winner was found
            {
                if (turn_count == 9)
                {
                    draw_count.Text = (Int32.Parse(draw_count.Text) + 1).ToString();
                    MessageBox.Show("The game was a draw!", "Draw");
                }
            }
        }

        private void disableButtons() // Disable the buttons after a game is won or draw
        {
                foreach (Control c in Controls)
                {
                    try
                    {
                        Button b = (Button)c;
                        b.Enabled = false;
                    }
                    catch { }                    
                }
            
            newGameButton.Enabled = true; // Re-enable the New Game button
        }            

        private void button_enter(object sender, EventArgs e) //Display's the player's mark if the mouse is hovering over the button
        {
            Button b = (Button)sender;
            if (b.Enabled)
            {
                if (turn)
                {
                    b.Text = "X";
                }
                else
                {
                    b.Text = "O";
                }
            }
        }

        private void button_leave(object sender, EventArgs e) //Clear's the player's mark once the mouse leaves the button
        {
            Button b = (Button)sender;
            if (b.Enabled)
            {
                if (turn)
                {
                    b.Text = "";
                }
                else
                {
                    b.Text = "";
                }
            }
        }

        ToolTip tt_newGameButton = new ToolTip();
        private void newGameButton_MouseHover(object sender, EventArgs e)
        {
            tt_newGameButton.Show("Begins a new game", newGameButton);
        }

        
    }// end class
}// end namespace
