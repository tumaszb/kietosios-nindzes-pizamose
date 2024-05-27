namespace WindowsFormsApp2
{
    partial class CoinFlipGame
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.PictureBox CoinImage;
        private System.Windows.Forms.Label HeadsLabel;
        private System.Windows.Forms.Label TailsLabel;
        private System.Windows.Forms.Label BalanceLabel;
        private System.Windows.Forms.TextBox BetAmountTextBox;
        private System.Windows.Forms.Button CoinFlipButton;
        private System.Windows.Forms.RadioButton HeadsRadioButton;
        private System.Windows.Forms.RadioButton TailsRadioButton;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CoinFlipGame));
            this.CoinImage = new System.Windows.Forms.PictureBox();
            this.HeadsLabel = new System.Windows.Forms.Label();
            this.TailsLabel = new System.Windows.Forms.Label();
            this.BalanceLabel = new System.Windows.Forms.Label();
            this.BetAmountTextBox = new System.Windows.Forms.TextBox();
            this.CoinFlipButton = new System.Windows.Forms.Button();
            this.HeadsRadioButton = new System.Windows.Forms.RadioButton();
            this.TailsRadioButton = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.CoinImage)).BeginInit();
            this.SuspendLayout();
            // 
            // CoinImage
            // 
            this.CoinImage.BackColor = System.Drawing.Color.Transparent;
            this.CoinImage.Location = new System.Drawing.Point(16, 15);
            this.CoinImage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CoinImage.Name = "CoinImage";
            this.CoinImage.Size = new System.Drawing.Size(341, 315);
            this.CoinImage.TabIndex = 0;
            this.CoinImage.TabStop = false;
            // 
            // HeadsLabel
            // 
            this.HeadsLabel.AutoSize = true;
            this.HeadsLabel.BackColor = System.Drawing.Color.Transparent;
            this.HeadsLabel.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeadsLabel.ForeColor = System.Drawing.Color.White;
            this.HeadsLabel.Location = new System.Drawing.Point(16, 345);
            this.HeadsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HeadsLabel.Name = "HeadsLabel";
            this.HeadsLabel.Size = new System.Drawing.Size(86, 20);
            this.HeadsLabel.TabIndex = 1;
            this.HeadsLabel.Text = "Skaicius: ";
            this.HeadsLabel.Click += new System.EventHandler(this.HeadsLabel_Click);
            // 
            // TailsLabel
            // 
            this.TailsLabel.AutoSize = true;
            this.TailsLabel.BackColor = System.Drawing.Color.Transparent;
            this.TailsLabel.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TailsLabel.ForeColor = System.Drawing.Color.White;
            this.TailsLabel.Location = new System.Drawing.Point(16, 382);
            this.TailsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TailsLabel.Name = "TailsLabel";
            this.TailsLabel.Size = new System.Drawing.Size(76, 20);
            this.TailsLabel.TabIndex = 2;
            this.TailsLabel.Text = "Herbas: ";
            // 
            // BalanceLabel
            // 
            this.BalanceLabel.AutoSize = true;
            this.BalanceLabel.BackColor = System.Drawing.Color.Transparent;
            this.BalanceLabel.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BalanceLabel.ForeColor = System.Drawing.Color.White;
            this.BalanceLabel.Location = new System.Drawing.Point(16, 418);
            this.BalanceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BalanceLabel.Name = "BalanceLabel";
            this.BalanceLabel.Size = new System.Drawing.Size(90, 20);
            this.BalanceLabel.TabIndex = 3;
            this.BalanceLabel.Text = "Balansas: ";
            // 
            // BetAmountTextBox
            // 
            this.BetAmountTextBox.Location = new System.Drawing.Point(20, 455);
            this.BetAmountTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BetAmountTextBox.Name = "BetAmountTextBox";
            this.BetAmountTextBox.Size = new System.Drawing.Size(132, 22);
            this.BetAmountTextBox.TabIndex = 4;
            // 
            // CoinFlipButton
            // 
            this.CoinFlipButton.Location = new System.Drawing.Point(161, 453);
            this.CoinFlipButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CoinFlipButton.Name = "CoinFlipButton";
            this.CoinFlipButton.Size = new System.Drawing.Size(100, 28);
            this.CoinFlipButton.TabIndex = 5;
            this.CoinFlipButton.Text = "Flip Coin";
            this.CoinFlipButton.UseVisualStyleBackColor = true;
            this.CoinFlipButton.Click += new System.EventHandler(this.CoinFlipButton_Click);
            // 
            // HeadsRadioButton
            // 
            this.HeadsRadioButton.AutoSize = true;
            this.HeadsRadioButton.BackColor = System.Drawing.Color.Transparent;
            this.HeadsRadioButton.Font = new System.Drawing.Font("Modern No. 20", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeadsRadioButton.ForeColor = System.Drawing.Color.White;
            this.HeadsRadioButton.Location = new System.Drawing.Point(251, 345);
            this.HeadsRadioButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.HeadsRadioButton.Name = "HeadsRadioButton";
            this.HeadsRadioButton.Size = new System.Drawing.Size(89, 21);
            this.HeadsRadioButton.TabIndex = 6;
            this.HeadsRadioButton.TabStop = true;
            this.HeadsRadioButton.Text = "Skaicius";
            this.HeadsRadioButton.UseVisualStyleBackColor = false;
            // 
            // TailsRadioButton
            // 
            this.TailsRadioButton.AutoSize = true;
            this.TailsRadioButton.BackColor = System.Drawing.Color.Transparent;
            this.TailsRadioButton.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TailsRadioButton.ForeColor = System.Drawing.Color.White;
            this.TailsRadioButton.Location = new System.Drawing.Point(251, 382);
            this.TailsRadioButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TailsRadioButton.Name = "TailsRadioButton";
            this.TailsRadioButton.Size = new System.Drawing.Size(86, 24);
            this.TailsRadioButton.TabIndex = 7;
            this.TailsRadioButton.TabStop = true;
            this.TailsRadioButton.Text = "Herbas";
            this.TailsRadioButton.UseVisualStyleBackColor = false;
            // 
            // CoinFlipGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(379, 494);
            this.Controls.Add(this.TailsRadioButton);
            this.Controls.Add(this.HeadsRadioButton);
            this.Controls.Add(this.CoinFlipButton);
            this.Controls.Add(this.BetAmountTextBox);
            this.Controls.Add(this.BalanceLabel);
            this.Controls.Add(this.TailsLabel);
            this.Controls.Add(this.HeadsLabel);
            this.Controls.Add(this.CoinImage);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CoinFlipGame";
            this.Text = "Coin Flip Game";
            ((System.ComponentModel.ISupportInitialize)(this.CoinImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}

