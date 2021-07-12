using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YT_Tic_Tac_Toe
{
    public partial class TicTacToe : Form
    {
        public TicTacToe()
        {
            InitializeComponent();
        }

        private void TicTacToe_Load(object sender, EventArgs e)
        {
          
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void restartGame()
        {
            a1.Text = "";
            a2.Text = "";
            a3.Text = "";
            b1.Text = "";
            b2.Text = "";
            b3.Text = "";
            c1.Text = "";
            c2.Text = "";
            c3.Text = "";

            a1.Enabled = true;
            a2.Enabled = true;
            a3.Enabled = true;
            b1.Enabled = true;
            b2.Enabled = true;
            b3.Enabled = true;
            c1.Enabled = true;
            c2.Enabled = true;
            c3.Enabled = true;

            changePlayer.Enabled = true;
            changePlayer.Checked = false;

            playerTurnLbl.Text = "Player X Turn";
            MessageBox.Show("Game Restarted!");
        }

        private void checkForWinner()
        {
            #region check for X winner Horizontal 
            if (a1.Text == "X" && a2.Text == "X" && a3.Text == "X")
            {
                MessageBox.Show("X is the winner");
                restartGame();
                logsBox.Items.Add("X is the winner");
            }

            if (b1.Text == "X" && b2.Text == "X" && b3.Text == "X")
            {
                MessageBox.Show("X is the winner");
                restartGame();
                logsBox.Items.Add("X is the winner");
            }

            if (c1.Text == "X" && c2.Text == "X" && c3.Text == "X")
            {
                MessageBox.Show("X is the winner");
                restartGame();
                logsBox.Items.Add("X is the winner");
            }
            #endregion

            #region check for O winner Horizontal 
            if (a1.Text == "O" && a2.Text == "O" && a3.Text == "O")
            {
                MessageBox.Show("O is the winner");
                restartGame();
                logsBox.Items.Add("O is the winner");
            }

            if (b1.Text == "O" && b2.Text == "O" && b3.Text == "O")
            {
                MessageBox.Show("O is the winner");
                restartGame();
                logsBox.Items.Add("O is the winner");
            }

            if (c1.Text == "O" && c2.Text == "O" && c3.Text == "O")
            {
                MessageBox.Show("O is the winner");
                restartGame();
                logsBox.Items.Add("O is the winner");
            }
            #endregion

            #region check for X winner Vertical
            if (a1.Text == "X" && b1.Text == "X" && c1.Text == "X")
            {
                MessageBox.Show("X is the winner");
                restartGame();
                logsBox.Items.Add("X is the winner");
            }

            if (a2.Text == "X" && b2.Text == "X" && c2.Text == "X")
            {
                MessageBox.Show("X is the winner");
                restartGame();
                logsBox.Items.Add("X is the winner");
            }

            if (a3.Text == "X" && b3.Text == "X" && c3.Text == "X")
            {
                MessageBox.Show("X is the winner");
                restartGame();
                logsBox.Items.Add("X is the winner");
            }
            #endregion

            #region check for O winner Vertical
            if (a1.Text == "O" && b1.Text == "O" && c1.Text == "O")
            {
                MessageBox.Show("O is the winner");
                restartGame();
                logsBox.Items.Add("O is the winner");
            }

            if (a2.Text == "O" && b2.Text == "O" && c2.Text == "O")
            {
                MessageBox.Show("O is the winner");
                restartGame();
                logsBox.Items.Add("O is the winner");
            }

            if (a3.Text == "O" && b3.Text == "O" && c3.Text == "O")
            {
                MessageBox.Show("O is the winner");
                restartGame();
                logsBox.Items.Add("O is the winner");
            }
            #endregion

            #region check X winner Dia
            if (a1.Text == "X" && b2.Text == "X" && c3.Text == "X")
            {
                MessageBox.Show("X is the winner!");
                restartGame();
                logsBox.Items.Add("X is the winner");
            }

            if (c1.Text == "X" && b2.Text == "X" && a3.Text == "X")
            {
                MessageBox.Show("X is the winner!");
                restartGame();
                logsBox.Items.Add("X is the winner");
            }
            #endregion

            #region check O winner Dia
            if (a1.Text == "O" && b2.Text == "O" && c3.Text == "O")
            {
                MessageBox.Show("O is the winner!");
                restartGame();
                logsBox.Items.Add("O is the winner");
            }

            if (c1.Text == "O" && b2.Text == "O" && a3.Text == "O")
            {
                MessageBox.Show("O is the winner!");
                restartGame();
                logsBox.Items.Add("O is the winner");
            }
            #endregion
        }

        #region a Class
        private void a1_Click(object sender, EventArgs e)
        {
            checkPlayerStatus();
            if (playerTurnLbl.Text == "Player X Turn")
            {
                playerTurnLbl.Text = "Player O Turn";
                a1.Text = "X";
                a1.Enabled = false;
                checkForWinner();
            }
            else if (playerTurnLbl.Text == "Player O Turn")
            {
                playerTurnLbl.Text = "Player X Turn";
                a1.Text = "O";
                a1.Enabled = false;
                checkForWinner();
            }
        }

        private void a2_Click(object sender, EventArgs e)
        {
            checkPlayerStatus();
            if (playerTurnLbl.Text == "Player X Turn")
            {
                playerTurnLbl.Text = "Player O Turn";
                a2.Text = "X";
                a2.Enabled = false;
                checkForWinner();
            }
            else if (playerTurnLbl.Text == "Player O Turn")
            {
                playerTurnLbl.Text = "Player X Turn";
                a2.Text = "O";
                a2.Enabled = false;
                checkForWinner();
            }
        }

        private void a3_Click(object sender, EventArgs e)
        {
            checkPlayerStatus();
            if (playerTurnLbl.Text == "Player X Turn")
            {
                playerTurnLbl.Text = "Player O Turn";
                a3.Text = "X";
                a3.Enabled = false;
                checkForWinner();
            }
            else if (playerTurnLbl.Text == "Player O Turn")
            {
                playerTurnLbl.Text = "Player X Turn";
                a3.Text = "O";
                a3.Enabled = false;
                checkForWinner();
            }
        }
        #endregion

        #region b Class
        private void b1_Click(object sender, EventArgs e)
        {
            checkPlayerStatus();
            if (playerTurnLbl.Text == "Player X Turn")
            {
                playerTurnLbl.Text = "Player O Turn";
                b1.Text = "X";
                b1.Enabled = false;
                checkForWinner();
            }
            else if (playerTurnLbl.Text == "Player O Turn")
            {
                playerTurnLbl.Text = "Player X Turn";
                b1.Text = "O";
                b1.Enabled = false;
                checkForWinner();
            }
        }

        private void b2_Click(object sender, EventArgs e)
        {
            checkPlayerStatus();
            if (playerTurnLbl.Text == "Player X Turn")
            {
                playerTurnLbl.Text = "Player O Turn";
                b2.Text = "X";
                b2.Enabled = false;
                checkForWinner();
            }
            else if (playerTurnLbl.Text == "Player O Turn")
            {
                playerTurnLbl.Text = "Player X Turn";
                b2.Text = "O";
                b2.Enabled = false;
                checkForWinner();
            }
        }

        private void b3_Click(object sender, EventArgs e)
        {
            checkPlayerStatus();
            if (playerTurnLbl.Text == "Player X Turn")
            {
                playerTurnLbl.Text = "Player O Turn";
                b3.Text = "X";
                b3.Enabled = false;
                checkForWinner();
            }
            else if (playerTurnLbl.Text == "Player O Turn")
            {
                playerTurnLbl.Text = "Player X Turn";
                b3.Text = "O";
                b3.Enabled = false;
                checkForWinner();
            }
        }

        #endregion

        #region c Class
        private void c1_Click(object sender, EventArgs e)
        {
            checkPlayerStatus();
            if (playerTurnLbl.Text == "Player X Turn")
            {
                playerTurnLbl.Text = "Player O Turn";
                c1.Text = "X";
                c1.Enabled = false;
                checkForWinner();
            }
            else if (playerTurnLbl.Text == "Player O Turn")
            {
                playerTurnLbl.Text = "Player X Turn";
                c1.Text = "O";
                c1.Enabled = false;
                checkForWinner();
            }
        }

        private void c2_Click(object sender, EventArgs e)
        {
            checkPlayerStatus();
            if (playerTurnLbl.Text == "Player X Turn")
            {
                playerTurnLbl.Text = "Player O Turn";
                c2.Text = "X";
                c2.Enabled = false;
                checkForWinner();
            }
            else if (playerTurnLbl.Text == "Player O Turn")
            {
                playerTurnLbl.Text = "Player X Turn";
                c2.Text = "O";
                c2.Enabled = false;
                checkForWinner();
            }
        }

        private void c3_Click(object sender, EventArgs e)
        {
            checkPlayerStatus();
            if (playerTurnLbl.Text == "Player X Turn")
            {
                playerTurnLbl.Text = "Player O Turn";
                c3.Text = "X";
                c3.Enabled = false;
                checkForWinner();
            }
            else if (playerTurnLbl.Text == "Player O Turn")
            {
                playerTurnLbl.Text = "Player X Turn";
                c3.Text = "O";
                c3.Enabled = false;
                checkForWinner();
            }
        }
        #endregion

        private void checkPlayerStatus()
        {
            if (changePlayer.Checked == true)
            {
                changePlayer.Enabled = false;
            }
        }

        private void changePlayer_CheckedChanged(object sender, EventArgs e)
        {
            if (changePlayer.Checked == true)
            {
                playerTurnLbl.Text = "Player O Turn";
            }
            else
            {
                playerTurnLbl.Text = "Player X Turn";
            }
        }
    }
}
