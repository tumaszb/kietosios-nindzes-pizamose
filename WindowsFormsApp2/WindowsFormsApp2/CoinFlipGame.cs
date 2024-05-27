using System;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class CoinFlipGame : Form
    {
        int heads = 0;
        int tails = 0;
        decimal balance = 1000; 

        public CoinFlipGame()
        {
            InitializeComponent();
            UpdateBalanceLabel();
        }

        private void CoinFlipButton_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(BetAmountTextBox.Text, out decimal betAmount))
            {
                if (betAmount > 0 && betAmount <= balance)
                {
                    Random coinFlip = new Random();
                    int result = coinFlip.Next(1, 3);

                    bool userGuessIsHeads = HeadsRadioButton.Checked;

                    // rezultatas yra skaicius
                    if (result == 1)
                    {
                        CoinImage.ImageLocation = @"C:\Users\kajus\Downloads\pxArt (1).png";
                        CoinImage.SizeMode = PictureBoxSizeMode.StretchImage;
                        heads++;
                        HeadsLabel.Text = "Skaicius: " + heads.ToString();

                        if (userGuessIsHeads)
                        {
                            balance += betAmount;
                        }
                        else
                        {
                            balance -= betAmount;
                        }
                    }
                    // rezultatas yra herbas
                    else
                    {
                        CoinImage.ImageLocation = @"C:\Users\kajus\Downloads\pxArt.png";
                        CoinImage.SizeMode = PictureBoxSizeMode.StretchImage;
                        tails++;
                        TailsLabel.Text = "Herbas: " + tails.ToString();

                        if (userGuessIsHeads)
                        {
                            balance -= betAmount;
                        }
                        else
                        {
                            balance += betAmount;
                        }
                    }

                    UpdateBalanceLabel();
                }
                else
                {
                    MessageBox.Show("Invalid bet amount. Please enter a value greater than 0 and less than or equal to your current balance.");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid bet amount.");
            }
        }

        private void UpdateBalanceLabel()
        {
            BalanceLabel.Text = "Balance: $" + balance.ToString("0.00");
        }

        private void HeadsLabel_Click(object sender, EventArgs e)
        {
         
        }
    }
}
