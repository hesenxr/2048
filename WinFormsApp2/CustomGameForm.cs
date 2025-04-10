using System;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class CustomGameForm : Form
    {
        public CustomGameForm()
        {
            InitializeComponent();
        }

        // Event handler for the Start Custom Game button
        private void startCustomGameButton_Click(object sender, EventArgs e)
        {
            // Parse the board size and target value from the input text boxes
            if (int.TryParse(boardSizeTextBox.Text, out int boardSize) && int.TryParse(targetValueTextBox.Text, out int targetValue))
            {
                if (boardSize >= 3 && boardSize <= 10 && targetValue > 0)
                {
                    Form1 gameForm = new Form1(boardSize, targetValue);
                    gameForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Please enter a valid board size (3-10) and a positive target value.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter valid integers for board size and target value.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
