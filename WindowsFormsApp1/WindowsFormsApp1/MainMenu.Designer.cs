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
            this.btnCrash.Location = new System.Drawing.Point(50, 50);
            this.btnCrash.Name = "btnCrash";
            this.btnCrash.Size = new System.Drawing.Size(73, 34);
            this.btnCrash.TabIndex = 0;
            this.btnCrash.Text = "Crash";
            this.btnCrash.UseVisualStyleBackColor = true;
            this.btnCrash.Click += new System.EventHandler(this.btnCrash_Click);
            // 
            // btnRoulette
            // 
            this.btnRoulette.Location = new System.Drawing.Point(148, 50);
            this.btnRoulette.Name = "btnRoulette";
            this.btnRoulette.Size = new System.Drawing.Size(79, 34);
            this.btnRoulette.TabIndex = 1;
            this.btnRoulette.Text = "Roulette";
            this.btnRoulette.UseVisualStyleBackColor = true;
            this.btnRoulette.Click += new System.EventHandler(this.btnRoulette_Click);
            // 
            // btnJackbox
            // 
            this.btnJackbox.Location = new System.Drawing.Point(254, 50);
            this.btnJackbox.Name = "btnJackbox";
            this.btnJackbox.Size = new System.Drawing.Size(89, 34);
            this.btnJackbox.TabIndex = 2;
            this.btnJackbox.Text = "Jackbox";
            this.btnJackbox.UseVisualStyleBackColor = true;
            this.btnJackbox.Click += new System.EventHandler(this.btnJackbox_Click);
            // 
            // btnMines
            // 
            this.btnMines.Location = new System.Drawing.Point(375, 50);
            this.btnMines.Name = "btnMines";
            this.btnMines.Size = new System.Drawing.Size(85, 34);
            this.btnMines.TabIndex = 3;
            this.btnMines.Text = "Mines";
            this.btnMines.UseVisualStyleBackColor = true;
            this.btnMines.Click += new System.EventHandler(this.btnMines_Click);
            // 
            // btnPlinko
            // 
            this.btnPlinko.Location = new System.Drawing.Point(495, 50);
            this.btnPlinko.Name = "btnPlinko";
            this.btnPlinko.Size = new System.Drawing.Size(90, 34);
            this.btnPlinko.TabIndex = 4;
            this.btnPlinko.Text = "Plinko";
            this.btnPlinko.UseVisualStyleBackColor = true;
            this.btnPlinko.Click += new System.EventHandler(this.btnPlinko_Click);
            // 
            // MainMenu
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCrash);
            this.Controls.Add(this.btnRoulette);
            this.Controls.Add(this.btnJackbox);
            this.Controls.Add(this.btnMines);
            this.Controls.Add(this.btnPlinko);
            this.Name = "MainMenu";
            this.Text = "Main Menu";
            this.ResumeLayout(false);

        }
    }
}




