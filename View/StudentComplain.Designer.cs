namespace ScholarsNest.View
{
    partial class StudentComplain
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
            this.complaindescriptionText = new System.Windows.Forms.TextBox();
            this.backButton = new System.Windows.Forms.Button();
            this.sentButton = new System.Windows.Forms.Button();
            this.complainsubjectText = new System.Windows.Forms.TextBox();
            this.verifyTitleLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // complaindescriptionText
            // 
            this.complaindescriptionText.BackColor = System.Drawing.Color.AliceBlue;
            this.complaindescriptionText.Location = new System.Drawing.Point(27, 266);
            this.complaindescriptionText.Multiline = true;
            this.complaindescriptionText.Name = "complaindescriptionText";
            this.complaindescriptionText.Size = new System.Drawing.Size(413, 118);
            this.complaindescriptionText.TabIndex = 18;
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.MidnightBlue;
            this.backButton.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.ForeColor = System.Drawing.Color.White;
            this.backButton.Location = new System.Drawing.Point(27, 533);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(125, 42);
            this.backButton.TabIndex = 17;
            this.backButton.Text = "BACK";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // sentButton
            // 
            this.sentButton.BackColor = System.Drawing.Color.MidnightBlue;
            this.sentButton.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sentButton.ForeColor = System.Drawing.Color.White;
            this.sentButton.Location = new System.Drawing.Point(219, 533);
            this.sentButton.Name = "sentButton";
            this.sentButton.Size = new System.Drawing.Size(221, 42);
            this.sentButton.TabIndex = 15;
            this.sentButton.Text = "Send";
            this.sentButton.UseVisualStyleBackColor = false;
            this.sentButton.Click += new System.EventHandler(this.sentButton_Click);
            // 
            // complainsubjectText
            // 
            this.complainsubjectText.BackColor = System.Drawing.Color.AliceBlue;
            this.complainsubjectText.Location = new System.Drawing.Point(27, 149);
            this.complainsubjectText.Multiline = true;
            this.complainsubjectText.Name = "complainsubjectText";
            this.complainsubjectText.Size = new System.Drawing.Size(413, 31);
            this.complainsubjectText.TabIndex = 13;
            // 
            // verifyTitleLabel
            // 
            this.verifyTitleLabel.AutoSize = true;
            this.verifyTitleLabel.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verifyTitleLabel.Location = new System.Drawing.Point(21, 113);
            this.verifyTitleLabel.Name = "verifyTitleLabel";
            this.verifyTitleLabel.Size = new System.Drawing.Size(226, 33);
            this.verifyTitleLabel.TabIndex = 12;
            this.verifyTitleLabel.Text = "Complain Subject";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 33);
            this.label1.TabIndex = 21;
            this.label1.Text = "Complain Description";
            // 
            // StudentComplain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 660);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.complaindescriptionText);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.sentButton);
            this.Controls.Add(this.complainsubjectText);
            this.Controls.Add(this.verifyTitleLabel);
            this.Name = "StudentComplain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentComplain";
            this.Load += new System.EventHandler(this.StudentComplain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox complaindescriptionText;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button sentButton;
        private System.Windows.Forms.TextBox complainsubjectText;
        private System.Windows.Forms.Label verifyTitleLabel;
        private System.Windows.Forms.Label label1;
    }
}