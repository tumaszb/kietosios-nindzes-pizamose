namespace WindowsFormsApp1
{
    partial class CrashGame
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblMultiplier;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.TextBox txtBetAmount;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnCashOut;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Timer gameTimer;

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
            this.components = new System.ComponentModel.Container();
            this.lblMultiplier = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.txtBetAmount = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnCashOut = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblMultiplier
            // 
            this.lblMultiplier.Location = new System.Drawing.Point(47, 50);
            this.lblMultiplier.Name = "lblMultiplier";
            this.lblMultiplier.Size = new System.Drawing.Size(217, 50);
            this.lblMultiplier.TabIndex = 0;
            this.lblMultiplier.Text = "Multiplier: x1.0";
            this.lblMultiplier.Click += new System.EventHandler(this.lblMultiplier_Click);
            // 
            // lblBalance
            // 
            this.lblBalance.Location = new System.Drawing.Point(130, 50);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(200, 50);
            this.lblBalance.TabIndex = 1;
            this.lblBalance.Text = "Balance: $1000";
            // 
            // txtBetAmount
            // 
            this.txtBetAmount.Location = new System.Drawing.Point(50, 80);
            this.txtBetAmount.Name = "txtBetAmount";
            this.txtBetAmount.Size = new System.Drawing.Size(100, 20);
            this.txtBetAmount.TabIndex = 2;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(50, 128);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(77, 25);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnCashOut
            // 
            this.btnCashOut.Location = new System.Drawing.Point(133, 128);
            this.btnCashOut.Name = "btnCashOut";
            this.btnCashOut.Size = new System.Drawing.Size(78, 25);
            this.btnCashOut.TabIndex = 4;
            this.btnCashOut.Text = "Cash Out";
            this.btnCashOut.UseVisualStyleBackColor = true;
            this.btnCashOut.Click += new System.EventHandler(this.btnCashOut_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(217, 128);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(81, 25);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // gameTimer
            // 
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // CrashGame
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnCashOut);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtBetAmount);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.lblMultiplier);
            this.Name = "CrashGame";
            this.Text = "Crash Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}





