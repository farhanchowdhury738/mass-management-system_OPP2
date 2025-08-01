namespace ScholarsNest.View
{
    partial class Facilities
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Facilities));
            this.facilitiesRichTextBox = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.facilitiesLabel = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.tackAddmissionButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // facilitiesRichTextBox
            // 
            this.facilitiesRichTextBox.Location = new System.Drawing.Point(27, 59);
            this.facilitiesRichTextBox.Name = "facilitiesRichTextBox";
            this.facilitiesRichTextBox.Size = new System.Drawing.Size(841, 469);
            this.facilitiesRichTextBox.TabIndex = 0;
            this.facilitiesRichTextBox.Text = resources.GetString("facilitiesRichTextBox.Text");
            this.facilitiesRichTextBox.TextChanged += new System.EventHandler(this.facilitiesRichTextBox_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // facilitiesLabel
            // 
            this.facilitiesLabel.AutoSize = true;
            this.facilitiesLabel.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.facilitiesLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.facilitiesLabel.Location = new System.Drawing.Point(264, 9);
            this.facilitiesLabel.Name = "facilitiesLabel";
            this.facilitiesLabel.Size = new System.Drawing.Size(410, 46);
            this.facilitiesLabel.TabIndex = 2;
            this.facilitiesLabel.Text = "Facilities at Scolar\'s Nest";
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.backButton.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.ForeColor = System.Drawing.Color.White;
            this.backButton.Location = new System.Drawing.Point(27, 549);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(86, 35);
            this.backButton.TabIndex = 25;
            this.backButton.Text = "BACK";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // tackAddmissionButton
            // 
            this.tackAddmissionButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.tackAddmissionButton.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tackAddmissionButton.ForeColor = System.Drawing.Color.White;
            this.tackAddmissionButton.Location = new System.Drawing.Point(621, 549);
            this.tackAddmissionButton.Name = "tackAddmissionButton";
            this.tackAddmissionButton.Size = new System.Drawing.Size(210, 35);
            this.tackAddmissionButton.TabIndex = 26;
            this.tackAddmissionButton.Text = "TAKE ADDMISSION";
            this.tackAddmissionButton.UseVisualStyleBackColor = false;
            this.tackAddmissionButton.Click += new System.EventHandler(this.tackAddmissionButton_Click);
            // 
            // Facilities
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(880, 600);
            this.Controls.Add(this.tackAddmissionButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.facilitiesLabel);
            this.Controls.Add(this.facilitiesRichTextBox);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Facilities";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facilities";
            this.Load += new System.EventHandler(this.Facilities_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox facilitiesRichTextBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label facilitiesLabel;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button tackAddmissionButton;
    }
}