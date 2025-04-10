using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        private int gridSize;
        private int targetTileValue;
        private int[,] board;
        private int[,] previousBoard;
        private int currentScore = 0;
        private int bestScore = 0;
        private Random random = new Random();
        private bool gameWon = false;

        // Constructor to initialize the game with grid size and target tile value
        public Form1(int gridSize, int targetTileValue)
        {
            this.gridSize = gridSize;
            this.targetTileValue = targetTileValue;
            this.board = new int[gridSize, gridSize];
            this.previousBoard = new int[gridSize, gridSize];

            InitializeComponent();
            InitializeBoard();
            GenerateNewTile();
            GenerateNewTile();
            UpdateUI();
        }

        // Initializes the game board and sets up the UI elements
        private void InitializeBoard()
        {
            tableLayoutPanel1.Controls.Clear();
            tableLayoutPanel1.ColumnCount = gridSize;
            tableLayoutPanel1.RowCount = gridSize;

            // Clear existing styles
            tableLayoutPanel1.ColumnStyles.Clear();
            tableLayoutPanel1.RowStyles.Clear();

            for (int i = 0; i < gridSize; i++)
            {
                tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F / gridSize));
                tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F / gridSize));
            }

            for (int row = 0; row < gridSize; row++)
            {
                for (int col = 0; col < gridSize; col++)
                {
                    var label = new Label
                    {
                        Dock = DockStyle.Fill,
                        TextAlign = ContentAlignment.MiddleCenter,
                        Font = new Font("Arial", 24, FontStyle.Bold),
                        BorderStyle = BorderStyle.FixedSingle,
                        BackColor = Color.FromArgb(50, 50, 50),
                        ForeColor = Color.White
                    };
                    tableLayoutPanel1.Controls.Add(label, col, row);
                }
            }
        }

        // Generates a new tile (2 or 4) in a random empty cell
        private void GenerateNewTile()
        {
            var emptyCells = from int row in Enumerable.Range(0, gridSize)
                             from int col in Enumerable.Range(0, gridSize)
                             where board[row, col] == 0
                             select new { row, col };

            if (emptyCells.Any())
            {
                var cell = emptyCells.ElementAt(random.Next(emptyCells.Count()));
                board[cell.row, cell.col] = random.Next(1, 3) * 2; // 2 or 4
                UpdateUI();
            }
        }

        // Updates the UI to reflect the current state of the game board
        private void UpdateUI()
        {
            for (int row = 0; row < gridSize; row++)
            {
                for (int col = 0; col < gridSize; col++)
                {
                    var label = tableLayoutPanel1.GetControlFromPosition(col, row) as Label;
                    label.Text = board[row, col] == 0 ? "" : board[row, col].ToString();
                    label.BackColor = GetColorForValue(board[row, col]);
                    label.ForeColor = board[row, col] > 0 ? Color.Black : Color.White; // Set text color to black for non-zero values
                }
            }
            scoreLabel.Text = $"Score: {currentScore}";
            bestScoreLabel.Text = $"Best: {bestScore}";
        }

        // Returns the color associated with a given tile value
        private Color GetColorForValue(int value)
        {
            switch (value)
            {
                case 0: return Color.FromArgb(50, 50, 50);
                case 2: return Color.Beige;
                case 4: return Color.Bisque;
                case 8: return Color.LightSalmon;
                case 16: return Color.Salmon;
                case 32: return Color.Orange;
                case 64: return Color.DarkOrange;
                case 128: return Color.Gold;
                case 256: return Color.Yellow;
                case 512: return Color.LightGoldenrodYellow;
                case 1024: return Color.Khaki;
                case 2048: return Color.Goldenrod;
                default: return Color.OrangeRed;
            }
        }

        // Processes key presses to move tiles
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (gameWon) return base.ProcessCmdKey(ref msg, keyData); // Prevent further moves after winning

            bool moved = false;

            switch (keyData)
            {
                case Keys.Up:
                    moved = MoveUp();
                    break;
                case Keys.Down:
                    moved = MoveDown();
                    break;
                case Keys.Left:
                    moved = MoveLeft();
                    break;
                case Keys.Right:
                    moved = MoveRight();
                    break;
            }

            if (moved)
            {
                if (CheckForTargetTile())
                {
                    GameOverForm gameOverForm = new GameOverForm();
                    gameOverForm.Show();
                    this.Hide();
                    return base.ProcessCmdKey(ref msg, keyData); // Prevent generating a new tile and further moves
                }

                GenerateNewTile();
                if (IsGameOver())
                {
                    // Show the GameOverForm
                    GameOverForm gameOverForm = new GameOverForm();
                    gameOverForm.Show();
                }
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        // Moves tiles up
        private bool MoveUp()
        {
            bool moved = false;
            SavePreviousState();
            for (int col = 0; col < gridSize; col++)
            {
                int[] column = new int[gridSize];
                for (int row = 0; row < gridSize; row++)
                {
                    column[row] = board[row, col];
                }
                int[] mergedColumn = Merge(column);
                for (int row = 0; row < gridSize; row++)
                {
                    if (board[row, col] != mergedColumn[row])
                    {
                        board[row, col] = mergedColumn[row];
                        moved = true;
                    }
                }
            }
            if (moved)
            {
                UpdateUI();
            }
            return moved;
        }

        // Moves tiles down
        private bool MoveDown()
        {
            bool moved = false;
            SavePreviousState();
            for (int col = 0; col < gridSize; col++)
            {
                int[] column = new int[gridSize];
                for (int row = 0; row < gridSize; row++)
                {
                    column[gridSize - row - 1] = board[row, col];
                }
                int[] mergedColumn = Merge(column);
                for (int row = 0; row < gridSize; row++)
                {
                    if (board[row, col] != mergedColumn[gridSize - row - 1])
                    {
                        board[row, col] = mergedColumn[gridSize - row - 1];
                        moved = true;
                    }
                }
            }
            if (moved)
            {
                UpdateUI();
            }
            return moved;
        }

        // Moves tiles left
        private bool MoveLeft()
        {
            bool moved = false;
            SavePreviousState();
            for (int row = 0; row < gridSize; row++)
            {
                int[] line = new int[gridSize];
                for (int col = 0; col < gridSize; col++)
                {
                    line[col] = board[row, col];
                }
                int[] mergedLine = Merge(line);
                for (int col = 0; col < gridSize; col++)
                {
                    if (board[row, col] != mergedLine[col])
                    {
                        board[row, col] = mergedLine[col];
                        moved = true;
                    }
                }
            }
            if (moved)
            {
                UpdateUI();
            }
            return moved;
        }

        // Moves tiles right
        private bool MoveRight()
        {
            bool moved = false;
            SavePreviousState();
            for (int row = 0; row < gridSize; row++)
            {
                int[] line = new int[gridSize];
                for (int col = 0; col < gridSize; col++)
                {
                    line[gridSize - col - 1] = board[row, col];
                }
                int[] mergedLine = Merge(line);
                for (int col = 0; col < gridSize; col++)
                {
                    if (board[row, col] != mergedLine[gridSize - col - 1])
                    {
                        board[row, col] = mergedLine[gridSize - col - 1];
                        moved = true;
                    }
                }
            }
            if (moved)
            {
                UpdateUI();
            }
            return moved;
        }

        // Merges the tiles and handles the scoring and checking for the target tile value
        private int[] Merge(int[] line)
        {
            int[] newLine = new int[gridSize];
            int index = 0;
            for (int i = 0; i < gridSize; i++)
            {
                if (line[i] != 0)
                {
                    if (index > 0 && newLine[index - 1] == line[i])
                    {
                        newLine[index - 1] *= 2;
                        currentScore += newLine[index - 1];
                        if (currentScore > bestScore)
                        {
                            bestScore = currentScore;
                        }
                    }
                    else
                    {
                        newLine[index++] = line[i];
                    }
                }
            }

            return newLine;
        }

        // Checks if the target tile value is present on the board
        private bool CheckForTargetTile()
        {
            for (int row = 0; row < gridSize; row++)
            {
                for (int col = 0; col < gridSize; col++)
                {
                    if (board[row, col] == targetTileValue)
                    {
                        gameWon = true;
                        UpdateUI(); // Ensure UI is updated before showing the win message
                        MessageBox.Show($"Congratulations! You've reached the target tile value of {targetTileValue}!", "You Win!");
                        return true;
                    }
                }
            }
            return false;
        }

        // Checks if the game is over (no more valid moves)
        private bool IsGameOver()
        {
            for (int row = 0; row < gridSize; row++)
            {
                for (int col = 0; col < gridSize; col++)
                {
                    if (board[row, col] == 0) return false;
                    if (row > 0 && board[row, col] == board[row - 1, col]) return false;
                    if (row < gridSize - 1 && board[row, col] == board[row + 1, col]) return false;
                    if (col > 0 && board[row, col] == board[row, col - 1]) return false;
                    if (col < gridSize - 1 && board[row, col] == board[row, col + 1]) return false;
                }
            }
            return true;
        }

        // Saves the current state of the board to allow undoing the last move
        private void SavePreviousState()
        {
            Array.Copy(board, previousBoard, board.Length);
        }

        // Resets the game to the initial state
        private void ResetGame()
        {
            currentScore = 0;
            gameWon = false;
            Array.Clear(board, 0, board.Length);
            GenerateNewTile();
            GenerateNewTile();
            UpdateUI();
        }

        // Undoes the last move
        private void UndoMove()
        {
            Array.Copy(previousBoard, board, board.Length);
            UpdateUI();
        }

        // Event handler for the Reset button
        private void resetButton_Click(object sender, EventArgs e)
        {
            ResetGame();
        }

        // Event handler for the Undo button
        private void undoButton_Click(object sender, EventArgs e)
        {
            UndoMove();
        }

        // Event handler for the Main Menu button
        private void mainMenuButton_Click(object sender, EventArgs e)
        {
            WelcomeForm welcomeForm = new WelcomeForm();
            welcomeForm.Show();
            this.Close();
        }

        // Event handler for the Exit Game button
        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
