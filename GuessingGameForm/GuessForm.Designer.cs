namespace GuessingGameForm {
    partial class GuessForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.lblGuess = new System.Windows.Forms.Label();
            this.txtGuess = new System.Windows.Forms.TextBox();
            this.btnGuess = new System.Windows.Forms.Button();
            this.lblOutcome = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblLBound = new System.Windows.Forms.Label();
            this.lblUBound = new System.Windows.Forms.Label();
            this.txtUBound = new System.Windows.Forms.TextBox();
            this.txtLBound = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSetDefaults = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblGuess
            // 
            this.lblGuess.AutoSize = true;
            this.lblGuess.Location = new System.Drawing.Point(15, 212);
            this.lblGuess.Name = "lblGuess";
            this.lblGuess.Size = new System.Drawing.Size(37, 13);
            this.lblGuess.TabIndex = 0;
            this.lblGuess.Text = "Guess";
            // 
            // txtGuess
            // 
            this.txtGuess.BackColor = System.Drawing.Color.Gray;
            this.txtGuess.Location = new System.Drawing.Point(59, 209);
            this.txtGuess.Name = "txtGuess";
            this.txtGuess.ReadOnly = true;
            this.txtGuess.Size = new System.Drawing.Size(243, 20);
            this.txtGuess.TabIndex = 3;
            // 
            // btnGuess
            // 
            this.btnGuess.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnGuess.Enabled = false;
            this.btnGuess.Location = new System.Drawing.Point(313, 207);
            this.btnGuess.Name = "btnGuess";
            this.btnGuess.Size = new System.Drawing.Size(97, 23);
            this.btnGuess.TabIndex = 4;
            this.btnGuess.Text = "Enter Guess";
            this.btnGuess.UseVisualStyleBackColor = false;
            this.btnGuess.Click += new System.EventHandler(this.BtnGuess_Click);
            // 
            // lblOutcome
            // 
            this.lblOutcome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOutcome.Location = new System.Drawing.Point(16, 241);
            this.lblOutcome.Name = "lblOutcome";
            this.lblOutcome.Size = new System.Drawing.Size(394, 176);
            this.lblOutcome.TabIndex = 3;
            this.lblOutcome.Text = "Enter a range above.";
            this.lblOutcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(101, 115);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(99, 28);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start Game";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // lblLBound
            // 
            this.lblLBound.AutoSize = true;
            this.lblLBound.Location = new System.Drawing.Point(15, 56);
            this.lblLBound.Name = "lblLBound";
            this.lblLBound.Size = new System.Drawing.Size(70, 13);
            this.lblLBound.TabIndex = 5;
            this.lblLBound.Text = "Lower Bound";
            // 
            // lblUBound
            // 
            this.lblUBound.AutoSize = true;
            this.lblUBound.Location = new System.Drawing.Point(15, 88);
            this.lblUBound.Name = "lblUBound";
            this.lblUBound.Size = new System.Drawing.Size(70, 13);
            this.lblUBound.TabIndex = 6;
            this.lblUBound.Text = "Upper Bound";
            // 
            // txtUBound
            // 
            this.txtUBound.Location = new System.Drawing.Point(101, 85);
            this.txtUBound.Name = "txtUBound";
            this.txtUBound.Size = new System.Drawing.Size(276, 20);
            this.txtUBound.TabIndex = 1;
            // 
            // txtLBound
            // 
            this.txtLBound.Location = new System.Drawing.Point(101, 53);
            this.txtLBound.Name = "txtLBound";
            this.txtLBound.Size = new System.Drawing.Size(276, 20);
            this.txtLBound.TabIndex = 0;
            // 
            // lblInstructions
            // 
            this.lblInstructions.Location = new System.Drawing.Point(15, 16);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(362, 31);
            this.lblInstructions.TabIndex = 9;
            this.lblInstructions.Text = "Enter the range for the random number to start the game. If an invalid range is g" +
    "iven, they will be replaced by valid default values.";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblInstructions);
            this.panel1.Controls.Add(this.lblLBound);
            this.panel1.Controls.Add(this.txtLBound);
            this.panel1.Controls.Add(this.lblUBound);
            this.panel1.Controls.Add(this.btnStart);
            this.panel1.Controls.Add(this.txtUBound);
            this.panel1.Location = new System.Drawing.Point(16, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(394, 159);
            this.panel1.TabIndex = 2;
            // 
            // btnSetDefaults
            // 
            this.btnSetDefaults.Location = new System.Drawing.Point(16, 8);
            this.btnSetDefaults.Name = "btnSetDefaults";
            this.btnSetDefaults.Size = new System.Drawing.Size(119, 23);
            this.btnSetDefaults.TabIndex = 1;
            this.btnSetDefaults.Text = "Set Default Range";
            this.btnSetDefaults.UseVisualStyleBackColor = true;
            this.btnSetDefaults.Click += new System.EventHandler(this.BtnSetDefaults_Click);
            // 
            // GuessForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 431);
            this.Controls.Add(this.btnSetDefaults);
            this.Controls.Add(this.lblOutcome);
            this.Controls.Add(this.btnGuess);
            this.Controls.Add(this.txtGuess);
            this.Controls.Add(this.lblGuess);
            this.Controls.Add(this.panel1);
            this.Name = "GuessForm";
            this.Text = "Guessing Game V 2.0";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGuess;
        private System.Windows.Forms.Button btnGuess;
        private System.Windows.Forms.Label lblOutcome;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblLBound;
        private System.Windows.Forms.Label lblUBound;
        private System.Windows.Forms.TextBox txtUBound;
        private System.Windows.Forms.TextBox txtLBound;
        private System.Windows.Forms.TextBox txtGuess;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSetDefaults;
    }
}

