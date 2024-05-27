namespace WindowsFormsApp1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblBalance = new System.Windows.Forms.Label();
            this.numericUpDownBetAmount = new System.Windows.Forms.NumericUpDown();
            this.btnDeal = new System.Windows.Forms.Button();
            this.btnHit = new System.Windows.Forms.Button();
            this.btnStand = new System.Windows.Forms.Button();
            this.lblPlayerHand = new System.Windows.Forms.Label();
            this.lblDealerHand = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBetAmount)).BeginInit();
            this.SuspendLayout();
            this.lblBalance.AutoSize = true;
            this.lblBalance.Location = new System.Drawing.Point(13, 13);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(64, 13);
            this.lblBalance.TabIndex = 0;
            this.lblBalance.Text = "Balance: $0";
            this.numericUpDownBetAmount.Location = new System.Drawing.Point(16, 43);
            this.numericUpDownBetAmount.Name = "numericUpDownBetAmount";
            this.numericUpDownBetAmount.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownBetAmount.TabIndex = 1;
            this.btnDeal.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnDeal.Location = new System.Drawing.Point(12, 82);
            this.btnDeal.Name = "btnDeal";
            this.btnDeal.Size = new System.Drawing.Size(75, 23);
            this.btnDeal.TabIndex = 2;
            this.btnDeal.Text = "Deal";
            this.btnDeal.UseVisualStyleBackColor = false;
            this.btnDeal.Click += new System.EventHandler(this.btnDeal_Click);
            this.btnHit.Enabled = false;
            this.btnHit.Location = new System.Drawing.Point(97, 82);
            this.btnHit.Name = "btnHit";
            this.btnHit.Size = new System.Drawing.Size(75, 23);
            this.btnHit.TabIndex = 3;
            this.btnHit.Text = "Hit";
            this.btnHit.UseVisualStyleBackColor = true;
            this.btnHit.Click += new System.EventHandler(this.btnHit_Click);
            this.btnStand.Enabled = false;
            this.btnStand.Location = new System.Drawing.Point(178, 82);
            this.btnStand.Name = "btnStand";
            this.btnStand.Size = new System.Drawing.Size(75, 23);
            this.btnStand.TabIndex = 4;
            this.btnStand.Text = "Stand";
            this.btnStand.UseVisualStyleBackColor = true;
            this.btnStand.Click += new System.EventHandler(this.btnStand_Click);
            this.lblPlayerHand.AutoSize = true;
            this.lblPlayerHand.Location = new System.Drawing.Point(13, 125);
            this.lblPlayerHand.Name = "lblPlayerHand";
            this.lblPlayerHand.Size = new System.Drawing.Size(77, 13);
            this.lblPlayerHand.TabIndex = 5;
            this.lblPlayerHand.Text = "Player Hand: 0";
            this.lblDealerHand.AutoSize = true;
            this.lblDealerHand.Location = new System.Drawing.Point(13, 147);
            this.lblDealerHand.Name = "lblDealerHand";
            this.lblDealerHand.Size = new System.Drawing.Size(79, 13);
            this.lblDealerHand.TabIndex = 6;
            this.lblDealerHand.Text = "Dealer Hand: 0";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(601, 352);
            this.Controls.Add(this.lblDealerHand);
            this.Controls.Add(this.lblPlayerHand);
            this.Controls.Add(this.btnStand);
            this.Controls.Add(this.btnHit);
            this.Controls.Add(this.btnDeal);
            this.Controls.Add(this.numericUpDownBetAmount);
            this.Controls.Add(this.lblBalance);
            this.Name = "Form1";
            this.Text = "Blackjack Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBetAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.NumericUpDown numericUpDownBetAmount;
        private System.Windows.Forms.Button btnDeal;
        private System.Windows.Forms.Button btnHit;
        private System.Windows.Forms.Button btnStand;
        private System.Windows.Forms.Label lblPlayerHand;
        private System.Windows.Forms.Label lblDealerHand;
    }
}
