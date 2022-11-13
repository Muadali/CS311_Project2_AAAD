namespace CS311_Project2_AAAD
{
    partial class FrmCraps
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblDie1 = new System.Windows.Forms.Label();
            this.lblDie2 = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.txtBet = new System.Windows.Forms.TextBox();
            this.btnRoll = new System.Windows.Forms.Button();
            this.lblOutcome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDie1
            // 
            this.lblDie1.AutoSize = true;
            this.lblDie1.Image = global::CS311_Project2_AAAD.Properties.Resources.face4;
            this.lblDie1.Location = new System.Drawing.Point(67, 145);
            this.lblDie1.Name = "lblDie1";
            this.lblDie1.Size = new System.Drawing.Size(42, 20);
            this.lblDie1.TabIndex = 0;
            this.lblDie1.Text = "Die1";
            this.lblDie1.Click += new System.EventHandler(this.lblDie1_Click);
            // 
            // lblDie2
            // 
            this.lblDie2.AutoSize = true;
            this.lblDie2.Image = global::CS311_Project2_AAAD.Properties.Resources.face2;
            this.lblDie2.Location = new System.Drawing.Point(213, 145);
            this.lblDie2.Name = "lblDie2";
            this.lblDie2.Size = new System.Drawing.Size(42, 20);
            this.lblDie2.TabIndex = 1;
            this.lblDie2.Text = "Die2";
            this.lblDie2.Click += new System.EventHandler(this.lblDie2_Click);
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Location = new System.Drawing.Point(503, 84);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(133, 20);
            this.lblBalance.TabIndex = 2;
            this.lblBalance.Text = "Balance: $100.00";
            this.lblBalance.Click += new System.EventHandler(this.lblBalance_Click);
            // 
            // txtBet
            // 
            this.txtBet.Location = new System.Drawing.Point(103, 294);
            this.txtBet.Name = "txtBet";
            this.txtBet.Size = new System.Drawing.Size(187, 26);
            this.txtBet.TabIndex = 3;
            this.txtBet.Text = "Enter your bet";
            this.txtBet.TextChanged += new System.EventHandler(this.txtBet_TextChanged);
            // 
            // btnRoll
            // 
            this.btnRoll.Location = new System.Drawing.Point(373, 294);
            this.btnRoll.Name = "btnRoll";
            this.btnRoll.Size = new System.Drawing.Size(75, 38);
            this.btnRoll.TabIndex = 4;
            this.btnRoll.Text = "Roll";
            this.btnRoll.UseVisualStyleBackColor = true;
            this.btnRoll.Click += new System.EventHandler(this.btnRoll_Click);
            // 
            // lblOutcome
            // 
            this.lblOutcome.AutoSize = true;
            this.lblOutcome.Location = new System.Drawing.Point(99, 418);
            this.lblOutcome.Name = "lblOutcome";
            this.lblOutcome.Size = new System.Drawing.Size(74, 20);
            this.lblOutcome.TabIndex = 5;
            this.lblOutcome.Text = "Outcome";
            // 
            // FrmCraps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblOutcome);
            this.Controls.Add(this.btnRoll);
            this.Controls.Add(this.txtBet);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.lblDie2);
            this.Controls.Add(this.lblDie1);
            this.Name = "FrmCraps";
            this.Text = "Craps";
            this.Load += new System.EventHandler(this.FrmCraps_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDie1;
        private System.Windows.Forms.Label lblDie2;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.TextBox txtBet;
        private System.Windows.Forms.Button btnRoll;
        private System.Windows.Forms.Label lblOutcome;
    }
}

