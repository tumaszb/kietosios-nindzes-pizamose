namespace WindowsFormsApp1
{
    partial class MainMenu
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnCrash;
        private System.Windows.Forms.Button btnRoulette;
        private System.Windows.Forms.Button btnJackbox;
        private System.Windows.Forms.Button btnMines;
        private System.Windows.Forms.Button btnPlinko;

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
            this.btnCrash = new System.Windows.Forms.Button();
            this.btnRoulette = new System.Windows.Forms.Button();
            this.btnJackbox = new System.Windows.Forms.Button();
            this.btnMines = new System.Windows.Forms.Button();
            this.btnPlinko = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCrash
            // 
            this.btnCrash.BackgroundImage = global::WindowsFormsApp1.Properties.Resources._360_F_263131939_YV0i6j7Gd1JghYiW2g6NIVXBgxk2YoQw1;
            this.btnCrash.Font = new System.Drawing.Font("Avengeance Mightiest Avenger", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrash.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCrash.Location = new System.Drawing.Point(38, 120);
            this.btnCrash.Name = "btnCrash";
            this.btnCrash.Size = new System.Drawing.Size(137, 60);
            this.btnCrash.TabIndex = 0;
            this.btnCrash.Text = "Crash";
            this.btnCrash.UseVisualStyleBackColor = true;
            this.btnCrash.Click += new System.EventHandler(this.btnCrash_Click);
            // 
            // btnRoulette
            // 
            this.btnRoulette.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnRoulette.BackgroundImage = global::WindowsFormsApp1.Properties.Resources._360_F_263131939_YV0i6j7Gd1JghYiW2g6NIVXBgxk2YoQw;
            this.btnRoulette.Font = new System.Drawing.Font("Avengeance Mightiest Avenger", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoulette.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRoulette.Location = new System.Drawing.Point(685, 120);
            this.btnRoulette.Name = "btnRoulette";
            this.btnRoulette.Size = new System.Drawing.Size(125, 64);
            this.btnRoulette.TabIndex = 1;
            this.btnRoulette.Text = "Roulette";
            this.btnRoulette.UseVisualStyleBackColor = false;
            this.btnRoulette.Click += new System.EventHandler(this.btnRoulette_Click);
            // 
            // btnJackbox
            // 
            this.btnJackbox.BackgroundImage = global::WindowsFormsApp1.Properties.Resources._360_F_263131939_YV0i6j7Gd1JghYiW2g6NIVXBgxk2YoQw;
            this.btnJackbox.Font = new System.Drawing.Font("Avengeance Mightiest Avenger", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJackbox.ForeColor = System.Drawing.SystemColors.Control;
            this.btnJackbox.Location = new System.Drawing.Point(202, 119);
            this.btnJackbox.Name = "btnJackbox";
            this.btnJackbox.Size = new System.Drawing.Size(133, 62);
            this.btnJackbox.TabIndex = 2;
            this.btnJackbox.Text = "Jackbox";
            this.btnJackbox.UseVisualStyleBackColor = true;
            this.btnJackbox.Click += new System.EventHandler(this.btnJackbox_Click);
            // 
            // btnMines
            // 
            this.btnMines.BackgroundImage = global::WindowsFormsApp1.Properties.Resources._360_F_263131939_YV0i6j7Gd1JghYiW2g6NIVXBgxk2YoQw;
            this.btnMines.Font = new System.Drawing.Font("Avengeance Mightiest Avenger", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMines.ForeColor = System.Drawing.SystemColors.Control;
            this.btnMines.Location = new System.Drawing.Point(364, 117);
            this.btnMines.Name = "btnMines";
            this.btnMines.Size = new System.Drawing.Size(130, 64);
            this.btnMines.TabIndex = 3;
            this.btnMines.Text = "Mines";
            this.btnMines.UseVisualStyleBackColor = true;
            this.btnMines.Click += new System.EventHandler(this.btnMines_Click);
            // 
            // btnPlinko
            // 
            this.btnPlinko.BackgroundImage = global::WindowsFormsApp1.Properties.Resources._360_F_263131939_YV0i6j7Gd1JghYiW2g6NIVXBgxk2YoQw;
            this.btnPlinko.Font = new System.Drawing.Font("Avengeance Mightiest Avenger", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlinko.ForeColor = System.Drawing.SystemColors.Control;
            this.btnPlinko.Location = new System.Drawing.Point(519, 119);
            this.btnPlinko.Name = "btnPlinko";
            this.btnPlinko.Size = new System.Drawing.Size(144, 65);
            this.btnPlinko.TabIndex = 4;
            this.btnPlinko.Text = "Plinko";
            this.btnPlinko.UseVisualStyleBackColor = true;
            this.btnPlinko.Click += new System.EventHandler(this.btnPlinko_Click);
            // 
            // MainMenu
            // 
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources._360_F_443793206_5DbZ7GUSS2ezOSRrE8kJRthp6S0ynAal;
            this.ClientSize = new System.Drawing.Size(838, 333);
            this.Controls.Add(this.btnCrash);
            this.Controls.Add(this.btnRoulette);
            this.Controls.Add(this.btnJackbox);
            this.Controls.Add(this.btnMines);
            this.Controls.Add(this.btnPlinko);
            this.Name = "MainMenu";
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.ResumeLayout(false);

        }
    }
}




