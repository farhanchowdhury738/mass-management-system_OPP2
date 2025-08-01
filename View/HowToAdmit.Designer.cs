namespace ScholarsNest
{
    partial class HowToAdmit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HowToAdmit));
            this.HowTo = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.AdmissionButton = new System.Windows.Forms.Button();
            this.Backbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HowTo
            // 
            this.HowTo.Font = new System.Drawing.Font("Bookman Old Style", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HowTo.Location = new System.Drawing.Point(414, 7);
            this.HowTo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HowTo.Name = "HowTo";
            this.HowTo.Size = new System.Drawing.Size(351, 63);
            this.HowTo.TabIndex = 0;
            this.HowTo.Text = "How To Admit";
            this.HowTo.Click += new System.EventHandler(this.HowTo_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.Beige;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(37, 73);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(1090, 420);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // AdmissionButton
            // 
            this.AdmissionButton.BackColor = System.Drawing.Color.White;
            this.AdmissionButton.Font = new System.Drawing.Font("Matura MT Script Capitals", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdmissionButton.Location = new System.Drawing.Point(965, 530);
            this.AdmissionButton.Name = "AdmissionButton";
            this.AdmissionButton.Size = new System.Drawing.Size(147, 46);
            this.AdmissionButton.TabIndex = 3;
            this.AdmissionButton.Text = "Admission";
            this.AdmissionButton.UseVisualStyleBackColor = false;
            this.AdmissionButton.Click += new System.EventHandler(this.AdmissionButton_Click);
            // 
            // Backbutton
            // 
            this.Backbutton.Font = new System.Drawing.Font("Matura MT Script Capitals", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Backbutton.Location = new System.Drawing.Point(37, 530);
            this.Backbutton.Name = "Backbutton";
            this.Backbutton.Size = new System.Drawing.Size(147, 46);
            this.Backbutton.TabIndex = 4;
            this.Backbutton.Text = "Back";
            this.Backbutton.UseVisualStyleBackColor = true;
            this.Backbutton.Click += new System.EventHandler(this.Backbutton_Click);
            // 
            // HowToAdmit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(228)))), ((int)(((byte)(199)))));
            this.ClientSize = new System.Drawing.Size(1154, 588);
            this.Controls.Add(this.Backbutton);
            this.Controls.Add(this.AdmissionButton);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.HowTo);
            this.Font = new System.Drawing.Font("Matura MT Script Capitals", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "HowToAdmit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HowToAdmit";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label HowTo;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button AdmissionButton;
        private System.Windows.Forms.Button Backbutton;
    }
}