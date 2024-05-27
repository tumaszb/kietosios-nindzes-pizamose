using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private int balance = 1000;
        private int betAmount = 0;
        private int playerHandValue = 0;
        private int dealerHandValue = 0;

        private Random random = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateBalance();
        }

        private void btnDeal_Click(object sender, EventArgs e)
        {
            betAmount = (int)numericUpDownBetAmount.Value;
            if (betAmount > balance)
            {
                MessageBox.Show("Insufficient balance.");
                return;
            }

            balance -= betAmount;
            UpdateBalance();

            playerHandValue = DealCard();
            dealerHandValue = DealCard();

            lblPlayerHand.Text = "Player Hand: " + playerHandValue;
            lblDealerHand.Text = "Dealer Hand: " + dealerHandValue;

            btnDeal.Enabled = false;
            btnHit.Enabled = true;
            btnStand.Enabled = true;
        }

        private void btnHit_Click(object sender, EventArgs e)
        {
            int cardValue = DealCard();
            playerHandValue += cardValue;
            lblPlayerHand.Text = "Player Hand: " + playerHandValue;

            if (playerHandValue > 21)
            {
                MessageBox.Show("You bust! Dealer wins.");
                EndRound();
            }
        }

        private void btnStand_Click(object sender, EventArgs e)
        {
            while (dealerHandValue < 17)
            {
                dealerHandValue += DealCard();
                lblDealerHand.Text = "Dealer Hand: " + dealerHandValue;
            }

            if (dealerHandValue > 21 || dealerHandValue < playerHandValue)
            {
                MessageBox.Show("Player wins!");
                balance += betAmount * 2;
            }
            else if (dealerHandValue == playerHandValue)
            {
                MessageBox.Show("It's a draw!");
                balance += betAmount;
            }
            else
            {
                MessageBox.Show("Dealer wins!");
            }

            EndRound();
        }

        private void EndRound()
        {
            UpdateBalance();
            btnDeal.Enabled = true;
            btnHit.Enabled = false;
            btnStand.Enabled = false;
        }

        private int DealCard()
        {
            return random.Next(1, 11);
        }

        private void UpdateBalance()
        {
            lblBalance.Text = "Balance: $" + balance;
        }
    }
}
