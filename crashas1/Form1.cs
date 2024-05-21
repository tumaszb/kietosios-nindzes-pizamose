using System;
using System.Windows.Forms;

namespace crashas1
{
    public partial class Form1 : Form
    {
        private double balance = 1000;
        private double currentMultiplier = 1.0;
        private double betAmount = 0;
        private Random random = new Random();
        private bool isGameRunning = false;

        public Form1()
        {
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
                gameTimer.Interval = 200; // Increase the timer interval to slow down the ticks
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
                currentMultiplier += 0.05; // Decrease the increment value to slow down the multiplier increase
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
    }
}

