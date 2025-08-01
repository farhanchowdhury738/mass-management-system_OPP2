namespace ScholarsNest.View
{
    partial class VerifyEmail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VerifyEmail));
            this.verifyTitleLabel = new System.Windows.Forms.Label();
            this.verifyEmailTextBox = new System.Windows.Forms.TextBox();
            this.enterEmailLabel = new System.Windows.Forms.Label();
            this.verifyButton = new System.Windows.Forms.Button();
            this.verifyEmailLabel = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.submitOTPButton = new System.Windows.Forms.Button();
            this.enterOTPLabel = new System.Windows.Forms.Label();
            this.verifyOTPTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // verifyTitleLabel
            // 
            this.verifyTitleLabel.AutoSize = true;
            this.verifyTitleLabel.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verifyTitleLabel.Location = new System.Drawing.Point(72, 209);
            this.verifyTitleLabel.Name = "verifyTitleLabel";
            this.verifyTitleLabel.Size = new System.Drawing.Size(343, 33);
            this.verifyTitleLabel.TabIndex = 0;
            this.verifyTitleLabel.Text = "Verify your E-mail Address";
            this.verifyTitleLabel.Click += new System.EventHandler(this.verifyTitleLabel_Click);
            // 
            // verifyEmailTextBox
            // 
            this.verifyEmailTextBox.BackColor = System.Drawing.Color.AliceBlue;
            this.verifyEmailTextBox.Location = new System.Drawing.Point(90, 262);
            this.verifyEmailTextBox.Multiline = true;
            this.verifyEmailTextBox.Name = "verifyEmailTextBox";
            this.verifyEmailTextBox.Size = new System.Drawing.Size(301, 31);
            this.verifyEmailTextBox.TabIndex = 1;
            // 
            // enterEmailLabel
            // 
            this.enterEmailLabel.AutoSize = true;
            this.enterEmailLabel.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterEmailLabel.Location = new System.Drawing.Point(160, 298);
            this.enterEmailLabel.Name = "enterEmailLabel";
            this.enterEmailLabel.Size = new System.Drawing.Size(161, 17);
            this.enterEmailLabel.TabIndex = 2;
            this.enterEmailLabel.Text = "Enter your E-mail address";
            // 
            // verifyButton
            // 
            this.verifyButton.BackColor = System.Drawing.Color.MidnightBlue;
            this.verifyButton.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verifyButton.ForeColor = System.Drawing.Color.White;
            this.verifyButton.Location = new System.Drawing.Point(149, 338);
            this.verifyButton.Name = "verifyButton";
            this.verifyButton.Size = new System.Drawing.Size(177, 39);
            this.verifyButton.TabIndex = 3;
            this.verifyButton.Text = "Send";
            this.verifyButton.UseVisualStyleBackColor = false;
            this.verifyButton.Click += new System.EventHandler(this.verifyButton_Click);
            // 
            // verifyEmailLabel
            // 
            this.verifyEmailLabel.AutoSize = true;
            this.verifyEmailLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verifyEmailLabel.Location = new System.Drawing.Point(34, 389);
            this.verifyEmailLabel.Name = "verifyEmailLabel";
            this.verifyEmailLabel.Size = new System.Drawing.Size(399, 22);
            this.verifyEmailLabel.TabIndex = 4;
            this.verifyEmailLabel.Text = "An OTP code will be sent to your email address.";
            this.verifyEmailLabel.Click += new System.EventHandler(this.verifyEmailLabel_Click);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.MidnightBlue;
            this.backButton.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.ForeColor = System.Drawing.Color.White;
            this.backButton.Location = new System.Drawing.Point(19, 606);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(125, 42);
            this.backButton.TabIndex = 5;
            this.backButton.Text = "BACK";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // submitOTPButton
            // 
            this.submitOTPButton.BackColor = System.Drawing.Color.MidnightBlue;
            this.submitOTPButton.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitOTPButton.ForeColor = System.Drawing.Color.White;
            this.submitOTPButton.Location = new System.Drawing.Point(149, 518);
            this.submitOTPButton.Name = "submitOTPButton";
            this.submitOTPButton.Size = new System.Drawing.Size(177, 39);
            this.submitOTPButton.TabIndex = 11;
            this.submitOTPButton.Text = "Submit";
            this.submitOTPButton.UseVisualStyleBackColor = false;
            this.submitOTPButton.Click += new System.EventHandler(this.submitOTPButton_Click);
            // 
            // enterOTPLabel
            // 
            this.enterOTPLabel.AutoSize = true;
            this.enterOTPLabel.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterOTPLabel.Location = new System.Drawing.Point(129, 468);
            this.enterOTPLabel.Name = "enterOTPLabel";
            this.enterOTPLabel.Size = new System.Drawing.Size(226, 17);
            this.enterOTPLabel.TabIndex = 10;
            this.enterOTPLabel.Text = "Enter the OTP code sent your E-mail";
            // 
            // verifyOTPTextBox
            // 
            this.verifyOTPTextBox.BackColor = System.Drawing.Color.AliceBlue;
            this.verifyOTPTextBox.Location = new System.Drawing.Point(90, 431);
            this.verifyOTPTextBox.Multiline = true;
            this.verifyOTPTextBox.Name = "verifyOTPTextBox";
            this.verifyOTPTextBox.Size = new System.Drawing.Size(301, 31);
            this.verifyOTPTextBox.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(103, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(298, 178);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // VerifyEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(474, 660);
            this.Controls.Add(this.verifyTitleLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.submitOTPButton);
            this.Controls.Add(this.enterOTPLabel);
            this.Controls.Add(this.verifyOTPTextBox);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.verifyEmailLabel);
            this.Controls.Add(this.verifyButton);
            this.Controls.Add(this.enterEmailLabel);
            this.Controls.Add(this.verifyEmailTextBox);
            this.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "VerifyEmail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VerifyEmail";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label verifyTitleLabel;
        private System.Windows.Forms.TextBox verifyEmailTextBox;
        private System.Windows.Forms.Label enterEmailLabel;
        private System.Windows.Forms.Button verifyButton;
        private System.Windows.Forms.Label verifyEmailLabel;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button submitOTPButton;
        private System.Windows.Forms.Label enterOTPLabel;
        private System.Windows.Forms.TextBox verifyOTPTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}