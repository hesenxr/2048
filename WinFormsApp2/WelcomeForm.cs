using System;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();
        }

        // Event handler for the Normal Game button
        private void normalGameButton_Click(object sender, EventArgs e)
        {
            Form1 gameForm = new Form1(4, 2048);
            gameForm.Show();
            this.Hide();
        }

        // Event handler for the Customizable Game button
        private void customizableGameButton_Click(object sender, EventArgs e)
        {
            CustomGameForm customGameForm = new CustomGameForm();
            customGameForm.Show();
            this.Hide();
        }

        // Event handler for the Exit button
        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
