namespace WindowsFormsApp1
{
    partial class CrashGame
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel panelGame;
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
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.panelGame = new System.Windows.Forms.Panel();
            this.lblMultiplier = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.txtBetAmount = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnCashOut = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.panelGame.SuspendLayout();
            this.SuspendLayout();
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 200;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // panelGame
            // 
            this.panelGame.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelGame.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.crash_gambling_games_2;
            this.panelGame.Controls.Add(this.lblMultiplier);
            this.panelGame.Controls.Add(this.lblBalance);
            this.panelGame.Controls.Add(this.txtBetAmount);
            this.panelGame.Controls.Add(this.btnStart);
            this.panelGame.Controls.Add(this.btnCashOut);
            this.panelGame.Controls.Add(this.btnBack);
            this.panelGame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGame.Location = new System.Drawing.Point(0, 0);
            this.panelGame.Name = "panelGame";
            this.panelGame.Size = new System.Drawing.Size(800, 450);
            this.panelGame.TabIndex = 0;
            this.panelGame.Paint += new System.Windows.Forms.PaintEventHandler(this.panelGame_Paint);
            // 
            // lblMultiplier
            // 
            this.lblMultiplier.AutoSize = true;
            this.lblMultiplier.BackColor = System.Drawing.SystemColors.ControlText;
            this.lblMultiplier.Font = new System.Drawing.Font("Avengeance Mightiest Avenger", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMultiplier.ForeColor = System.Drawing.SystemColors.Control;
            this.lblMultiplier.Location = new System.Drawing.Point(20, 19);
            this.lblMultiplier.Name = "lblMultiplier";
            this.lblMultiplier.Size = new System.Drawing.Size(147, 19);
            this.lblMultiplier.TabIndex = 0;
            this.lblMultiplier.Text = "Multiplier: x1";
            this.lblMultiplier.Click += new System.EventHandler(this.lblMultiplier_Click_1);
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.BackColor = System.Drawing.SystemColors.ControlText;
            this.lblBalance.Font = new System.Drawing.Font("Avengeance Mightiest Avenger", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.ForeColor = System.Drawing.SystemColors.Control;
            this.lblBalance.Location = new System.Drawing.Point(20, 60);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(100, 19);
            this.lblBalance.TabIndex = 1;
            this.lblBalance.Text = "Balance: ";
            // 
            // txtBetAmount
            // 
            this.txtBetAmount.Font = new System.Drawing.Font("Avengeance Mightiest Avenger", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBetAmount.Location = new System.Drawing.Point(20, 100);
            this.txtBetAmount.Name = "txtBetAmount";
            this.txtBetAmount.Size = new System.Drawing.Size(130, 24);
            this.txtBetAmount.TabIndex = 2;
            // 
            // btnStart
            // 
            this.btnStart.BackgroundImage = global::WindowsFormsApp1.Properties.Resources._360_F_263131939_YV0i6j7Gd1JghYiW2g6NIVXBgxk2YoQw1;
            this.btnStart.Font = new System.Drawing.Font("Avengeance Mightiest Avenger", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.SystemColors.Control;
            this.btnStart.Location = new System.Drawing.Point(20, 150);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(115, 60);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnCashOut
            // 
            this.btnCashOut.BackgroundImage = global::WindowsFormsApp1.Properties.Resources._360_F_263131939_YV0i6j7Gd1JghYiW2g6NIVXBgxk2YoQw1;
            this.btnCashOut.Font = new System.Drawing.Font("Avengeance Mightiest Avenger", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCashOut.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCashOut.Location = new System.Drawing.Point(141, 150);
            this.btnCashOut.Name = "btnCashOut";
            this.btnCashOut.Size = new System.Drawing.Size(118, 60);
            this.btnCashOut.TabIndex = 4;
            this.btnCashOut.Text = "Cash Out";
            this.btnCashOut.UseVisualStyleBackColor = true;
            this.btnCashOut.Click += new System.EventHandler(this.btnCashOut_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackgroundImage = global::WindowsFormsApp1.Properties.Resources._360_F_263131939_YV0i6j7Gd1JghYiW2g6NIVXBgxk2YoQw1;
            this.btnBack.Font = new System.Drawing.Font("Avengeance Mightiest Avenger", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.Control;
            this.btnBack.Location = new System.Drawing.Point(265, 150);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(117, 60);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // CrashGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelGame);
            this.Name = "CrashGame";
            this.Text = "Crash Game";
            this.panelGame.ResumeLayout(false);
            this.panelGame.PerformLayout();
            this.ResumeLayout(false);

        }
    }
}






