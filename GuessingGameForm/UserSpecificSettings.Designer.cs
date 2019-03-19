namespace GuessingGameForm {
    partial class UserSpecificSettings {
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
            this.txtDefaultLBound = new System.Windows.Forms.TextBox();
            this.txtDefaultUBound = new System.Windows.Forms.TextBox();
            this.btnDefaults = new System.Windows.Forms.Button();
            this.lblLBound = new System.Windows.Forms.Label();
            this.lblUBound = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtDefaultLBound
            // 
            this.txtDefaultLBound.Location = new System.Drawing.Point(116, 19);
            this.txtDefaultLBound.Name = "txtDefaultLBound";
            this.txtDefaultLBound.Size = new System.Drawing.Size(100, 20);
            this.txtDefaultLBound.TabIndex = 0;
            // 
            // txtDefaultUBound
            // 
            this.txtDefaultUBound.Location = new System.Drawing.Point(116, 61);
            this.txtDefaultUBound.Name = "txtDefaultUBound";
            this.txtDefaultUBound.Size = new System.Drawing.Size(100, 20);
            this.txtDefaultUBound.TabIndex = 1;
            // 
            // btnDefaults
            // 
            this.btnDefaults.Location = new System.Drawing.Point(141, 101);
            this.btnDefaults.Name = "btnDefaults";
            this.btnDefaults.Size = new System.Drawing.Size(75, 23);
            this.btnDefaults.TabIndex = 2;
            this.btnDefaults.Text = "Set Defaults";
            this.btnDefaults.UseVisualStyleBackColor = true;
            this.btnDefaults.Click += new System.EventHandler(this.btnDefaults_Click);
            // 
            // lblLBound
            // 
            this.lblLBound.AutoSize = true;
            this.lblLBound.Location = new System.Drawing.Point(23, 22);
            this.lblLBound.Name = "lblLBound";
            this.lblLBound.Size = new System.Drawing.Size(70, 13);
            this.lblLBound.TabIndex = 3;
            this.lblLBound.Text = "Lower Bound";
            // 
            // lblUBound
            // 
            this.lblUBound.AutoSize = true;
            this.lblUBound.Location = new System.Drawing.Point(23, 64);
            this.lblUBound.Name = "lblUBound";
            this.lblUBound.Size = new System.Drawing.Size(70, 13);
            this.lblUBound.TabIndex = 4;
            this.lblUBound.Text = "Upper Bound";
            // 
            // UserSpecificSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 142);
            this.Controls.Add(this.lblUBound);
            this.Controls.Add(this.lblLBound);
            this.Controls.Add(this.btnDefaults);
            this.Controls.Add(this.txtDefaultUBound);
            this.Controls.Add(this.txtDefaultLBound);
            this.Name = "UserSpecificSettings";
            this.Text = "UserSpecificSettings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDefaultLBound;
        private System.Windows.Forms.TextBox txtDefaultUBound;
        private System.Windows.Forms.Button btnDefaults;
        private System.Windows.Forms.Label lblLBound;
        private System.Windows.Forms.Label lblUBound;
    }
}