using System;
using System.Drawing;
using System.Windows.Forms;
using XO_Game.Properties;

namespace XO_Game
{
    public partial class Form1 : Form
    {
        private enum enPlayer { Player1, Player2 }

        private enPlayer _currentPlayer = enPlayer.Player1;
        private int _moveCount = 0;
        private bool _isGameOver = false;

        private Button[] _boardButtons;

        private readonly int[][] _winningCombinations = new int[][]
        {
            new int[] { 0, 1, 2 },
            new int[] { 3, 4, 5 },
            new int[] { 6, 7, 8 },
            new int[] { 0, 3, 6 },
            new int[] { 1, 4, 7 },
            new int[] { 2, 5, 8 },
            new int[] { 0, 4, 8 },
            new int[] { 2, 4, 6 }
        };

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _boardButtons = new Button[] { btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9 };
            ResetGame();
        }

        private void gbXOBoard_Paint(object sender, PaintEventArgs e)
        {
            using (Pen pen = new Pen(Color.White, 5))
            {
                pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
                pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

                e.Graphics.DrawLine(pen, 200, 50, 200, 400);
                e.Graphics.DrawLine(pen, 350, 50, 350, 400);
                e.Graphics.DrawLine(pen, 50, 170, 500, 170);
                e.Graphics.DrawLine(pen, 50, 300, 500, 300);
            }
        }

        private void gbXOBoard_Enter(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void ResetGame()
        {
            _currentPlayer = enPlayer.Player1;
            _moveCount = 0;
            _isGameOver = false;

            lbPlayer.Text = "Player 1";
            lbWinner.Text = "In Progress";

            foreach (Button btn in _boardButtons)
            {
                btn.Image = Resources.question_mark_96;
                btn.Tag = "?";
                btn.BackColor = Color.Transparent;
                btn.Cursor = Cursors.Hand;
            }
        }

        private void PlayerMove(Button btn)
        {
            if (_isGameOver)
                return;

            if (btn.Tag?.ToString() != "?")
            {
                MessageBox.Show("This cell is already occupied. Please choose another cell.", "Invalid Move", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _moveCount++;

            if (_currentPlayer == enPlayer.Player1)
            {
                btn.Image = Resources.X;
                btn.Tag = "X";

                if (CheckGameStatus("Player 1"))
                    return;

                _currentPlayer = enPlayer.Player2;
                lbPlayer.Text = "Player 2";
            }
            else
            {
                btn.Image = Resources.O;
                btn.Tag = "O";

                if (CheckGameStatus("Player 2"))
                    return;

                _currentPlayer = enPlayer.Player1;
                lbPlayer.Text = "Player 1";
            }
        }

        private bool CheckGameStatus(string lastPlayerName)
        {
            foreach (var combo in _winningCombinations)
            {
                Button b1 = _boardButtons[combo[0]];
                Button b2 = _boardButtons[combo[1]];
                Button b3 = _boardButtons[combo[2]];

                if (b1.Tag?.ToString() != "?" &&
                    b1.Tag?.ToString() == b2.Tag?.ToString() &&
                    b2.Tag?.ToString() == b3.Tag?.ToString())
                {
                    HighlightWinningCells(b1, b2, b3, lastPlayerName);
                    EndGame($"{lastPlayerName} wins!");
                    return true;
                }
            }

            if (_moveCount == 9)
            {
                lbWinner.Text = "Draw";
                EndGame("Game over! It's a draw.");
                return true;
            }

            return false;
        }

        private void HighlightWinningCells(Button b1, Button b2, Button b3, string winner)
        {
            b1.BackColor = Color.Green;
            b2.BackColor = Color.Green;
            b3.BackColor = Color.Green;
            lbWinner.Text = winner;
        }

        private void EndGame(string message)
        {
            _isGameOver = true;
            lbPlayer.Text = "Game Over";

            foreach (Button btn in _boardButtons)
            {
                btn.Cursor = Cursors.Default;
            }

            MessageBox.Show(message, "Game Finished", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_click(object sender, EventArgs e)
        {
            if (sender is Button btn)
            {
                PlayerMove(btn);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ResetGame();
        }
    }
}
