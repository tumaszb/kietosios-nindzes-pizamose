using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class CrashGame : Form
    {
        private MainMenu mainMenu;
        private double balance = 1000;
        private double currentMultiplier = 1.0;
        private double betAmount = 0;
        private Random random = new Random();
        private bool isGameRunning = false;

        public CrashGame(MainMenu menu)
        {
            mainMenu = menu;
            InitializeComponent();
            lblBalance.Text = $"Balance: ${balance}";
            lblMultiplier.Text = $"Multiplier: x{currentMultiplier}";
            btnCashOut.Enabled = false;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtBetAmount.Text, out betAmount) && betAmount > 0 && betAmount <= balance)
            {
                balance -= betAmount;
                lblBalance.Text = $"Balance: ${balance}";
                currentMultiplier = 1.0;
                lblMultiplier.Text = $"Multiplier: x{currentMultiplier}";
                isGameRunning = true;
                gameTimer.Interval = 200;
                gameTimer.Start();
                btnCashOut.Enabled = true;
            }
            else
            {
                MessageBox.Show("Invalid bet amount.");
            }
        }

        private void btnCashOut_Click(object sender, EventArgs e)
        {
            if (isGameRunning)
            {
                gameTimer.Stop();
                isGameRunning = false;
                balance += betAmount * currentMultiplier;
                lblBalance.Text = $"Balance: ${balance}";
                MessageBox.Show($"You cashed out at x{currentMultiplier:F1} and won ${betAmount * currentMultiplier}!");
                btnCashOut.Enabled = false;
            }
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            if (isGameRunning)
            {
                currentMultiplier += 0.05;
                lblMultiplier.Text = $"Multiplier: x{currentMultiplier:F1}";

                if (random.NextDouble() < 0.05)
                {
                    gameTimer.Stop();
                    isGameRunning = false;
                    MessageBox.Show($"Game crashed at x{currentMultiplier:F1}. You lost your bet.");
                    btnCashOut.Enabled = false;
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainMenu.Show();
        }

        private void lblMultiplier_Click(object sender, EventArgs e)
        {

        }

        private void panelGame_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblMultiplier_Click_1(object sender, EventArgs e)
        {

        }
    }
}



