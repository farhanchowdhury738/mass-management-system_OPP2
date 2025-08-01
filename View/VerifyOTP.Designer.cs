namespace ScholarsNest.View
{
    partial class VerifyOTP
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
            this.submitOTPButton = new System.Windows.Forms.Button();
            this.enterOTPLabel = new System.Windows.Forms.Label();
            this.verifyOTPTextBox = new System.Windows.Forms.TextBox();
            this.verifyOTPTitleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // submitOTPButton
            // 
            this.submitOTPButton.BackColor = System.Drawing.Color.MidnightBlue;
            this.submitOTPButton.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitOTPButton.ForeColor = System.Drawing.Color.White;
            this.submitOTPButton.Location = new System.Drawing.Point(106, 312);
            this.submitOTPButton.Name = "submitOTPButton";
            this.submitOTPButton.Size = new System.Drawing.Size(177, 39);
            this.submitOTPButton.TabIndex = 7;
            this.submitOTPButton.Text = "Submit";
            this.submitOTPButton.UseVisualStyleBackColor = false;
            // 
            // enterOTPLabel
            // 
            this.enterOTPLabel.AutoSize = true;
            this.enterOTPLabel.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterOTPLabel.Location = new System.Drawing.Point(113, 258);
            this.enterOTPLabel.Name = "enterOTPLabel";
            this.enterOTPLabel.Size = new System.Drawing.Size(226, 17);
            this.enterOTPLabel.TabIndex = 6;
            this.enterOTPLabel.Text = "Enter the OTP code sent your E-mail";
            // 
            // verifyOTPTextBox
            // 
            this.verifyOTPTextBox.BackColor = System.Drawing.Color.AliceBlue;
            this.verifyOTPTextBox.Location = new System.Drawing.Point(52, 221);
            this.verifyOTPTextBox.Multiline = true;
            this.verifyOTPTextBox.Name = "verifyOTPTextBox";
            this.verifyOTPTextBox.Size = new System.Drawing.Size(301, 31);
            this.verifyOTPTextBox.TabIndex = 5;
            // 
            // verifyOTPTitleLabel
            // 
            this.verifyOTPTitleLabel.AutoSize = true;
            this.verifyOTPTitleLabel.Font = new System.Drawing.Font("Bahnschrift", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verifyOTPTitleLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.verifyOTPTitleLabel.Location = new System.Drawing.Point(65, 170);
            this.verifyOTPTitleLabel.Name = "verifyOTPTitleLabel";
            this.verifyOTPTitleLabel.Size = new System.Drawing.Size(346, 41);
            this.verifyOTPTitleLabel.TabIndex = 4;
            this.verifyOTPTitleLabel.Text = "OTP Code Verification";
            // 
            // VerifyOTP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(409, 646);
            this.Controls.Add(this.submitOTPButton);
            this.Controls.Add(this.enterOTPLabel);
            this.Controls.Add(this.verifyOTPTextBox);
            this.Controls.Add(this.verifyOTPTitleLabel);
            this.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "VerifyOTP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VerifyOTP";
            this.Load += new System.EventHandler(this.VerifyOTP_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button submitOTPButton;
        private System.Windows.Forms.Label enterOTPLabel;
        private System.Windows.Forms.TextBox verifyOTPTextBox;
        private System.Windows.Forms.Label verifyOTPTitleLabel;
    }
}