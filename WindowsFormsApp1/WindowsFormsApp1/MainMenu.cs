using WindowsFormsApp1;
using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void btnCrash_Click(object sender, EventArgs e)
        {
            this.Hide();
            var crashGame = new CrashGame(this);
            crashGame.Show();
        }

        private void btnRoulette_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Roulette game is not yet implemented.");
        }

        private void btnJackbox_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Jackbox game is not yet implemented.");
        }

        private void btnMines_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mines game is not yet implemented.");
        }

        private void btnPlinko_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Plinko game is not yet implemented.");
        }
    }
}




