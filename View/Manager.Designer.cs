namespace ScholarsNest.View
{
    partial class Manager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manager));
            this.showEmployeeListButton = new System.Windows.Forms.Button();
            this.showStudentListButton = new System.Windows.Forms.Button();
            this.managerTitleLabel = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // showEmployeeListButton
            // 
            this.showEmployeeListButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showEmployeeListButton.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showEmployeeListButton.ForeColor = System.Drawing.Color.DarkBlue;
            this.showEmployeeListButton.Location = new System.Drawing.Point(414, 323);
            this.showEmployeeListButton.Name = "showEmployeeListButton";
            this.showEmployeeListButton.Size = new System.Drawing.Size(227, 46);
            this.showEmployeeListButton.TabIndex = 1;
            this.showEmployeeListButton.Text = "MEAL OPERATION";
            this.showEmployeeListButton.UseVisualStyleBackColor = true;
            this.showEmployeeListButton.Click += new System.EventHandler(this.showEmployeeListButton_Click);
            // 
            // showStudentListButton
            // 
            this.showStudentListButton.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showStudentListButton.ForeColor = System.Drawing.Color.DarkBlue;
            this.showStudentListButton.Location = new System.Drawing.Point(52, 323);
            this.showStudentListButton.Name = "showStudentListButton";
            this.showStudentListButton.Size = new System.Drawing.Size(227, 46);
            this.showStudentListButton.TabIndex = 0;
            this.showStudentListButton.Text = "SHOW STUDENT LIST";
            this.showStudentListButton.UseVisualStyleBackColor = true;
            this.showStudentListButton.Click += new System.EventHandler(this.showStudentListButton_Click);
            // 
            // managerTitleLabel
            // 
            this.managerTitleLabel.AutoSize = true;
            this.managerTitleLabel.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.managerTitleLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.managerTitleLabel.Location = new System.Drawing.Point(233, 30);
            this.managerTitleLabel.Name = "managerTitleLabel";
            this.managerTitleLabel.Size = new System.Drawing.Size(408, 46);
            this.managerTitleLabel.TabIndex = 3;
            this.managerTitleLabel.Text = "MANAGER DESHBOARD";
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.backButton.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.ForeColor = System.Drawing.Color.White;
            this.backButton.Location = new System.Drawing.Point(12, 414);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(117, 35);
            this.backButton.TabIndex = 6;
            this.backButton.Text = "SIGN OUT";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox2.Image")));
            this.guna2PictureBox2.ImageRotate = 0F;
            this.guna2PictureBox2.Location = new System.Drawing.Point(43, 89);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.Size = new System.Drawing.Size(255, 228);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox2.TabIndex = 7;
            this.guna2PictureBox2.TabStop = false;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(402, 89);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(255, 228);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 8;
            this.guna2PictureBox1.TabStop = false;
            // 
            // Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(744, 461);
            this.Controls.Add(this.showEmployeeListButton);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.guna2PictureBox2);
            this.Controls.Add(this.showStudentListButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.managerTitleLabel);
            this.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.RoyalBlue;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Manager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manager";
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button showEmployeeListButton;
        private System.Windows.Forms.Button showStudentListButton;
        private System.Windows.Forms.Label managerTitleLabel;
        private System.Windows.Forms.Button backButton;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
    }
}