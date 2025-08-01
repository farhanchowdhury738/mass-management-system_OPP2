namespace ScholarsNest.View
{
    partial class Deposit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Deposit));
            this.depositLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.paymentMethodLabel = new System.Windows.Forms.Label();
            this.bkashRadioButton = new System.Windows.Forms.RadioButton();
            this.nogodRadioButton = new System.Windows.Forms.RadioButton();
            this.roketRadioButton = new System.Windows.Forms.RadioButton();
            this.upayRadioButton = new System.Windows.Forms.RadioButton();
            this.backButton = new System.Windows.Forms.Button();
            this.confirmButton = new System.Windows.Forms.Button();
            this.invalidPhoneLabel = new System.Windows.Forms.Label();
            this.amountLebel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.paymentdateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.crossPicture2 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.tickPicture2 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.crossPicture2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tickPicture2)).BeginInit();
            this.SuspendLayout();
            // 
            // depositLabel
            // 
            this.depositLabel.AutoSize = true;
            this.depositLabel.Font = new System.Drawing.Font("Trebuchet MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depositLabel.Location = new System.Drawing.Point(328, 32);
            this.depositLabel.Name = "depositLabel";
            this.depositLabel.Size = new System.Drawing.Size(162, 49);
            this.depositLabel.TabIndex = 0;
            this.depositLabel.Text = "Deposit";
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.phoneLabel.Location = new System.Drawing.Point(82, 172);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(101, 26);
            this.phoneLabel.TabIndex = 1;
            this.phoneLabel.Text = "Phone No";
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.BackColor = System.Drawing.Color.AliceBlue;
            this.phoneTextBox.Location = new System.Drawing.Point(258, 162);
            this.phoneTextBox.Multiline = true;
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(358, 36);
            this.phoneTextBox.TabIndex = 2;
            this.phoneTextBox.TextChanged += new System.EventHandler(this.phoneTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(82, 235);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter Amount";
            // 
            // amountTextBox
            // 
            this.amountTextBox.BackColor = System.Drawing.Color.AliceBlue;
            this.amountTextBox.Location = new System.Drawing.Point(258, 223);
            this.amountTextBox.Multiline = true;
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(358, 36);
            this.amountTextBox.TabIndex = 4;
            this.amountTextBox.TextChanged += new System.EventHandler(this.amountTextBox_TextChanged);
            // 
            // paymentMethodLabel
            // 
            this.paymentMethodLabel.AutoSize = true;
            this.paymentMethodLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.paymentMethodLabel.Location = new System.Drawing.Point(82, 296);
            this.paymentMethodLabel.Name = "paymentMethodLabel";
            this.paymentMethodLabel.Size = new System.Drawing.Size(170, 26);
            this.paymentMethodLabel.TabIndex = 5;
            this.paymentMethodLabel.Text = "Payment Method";
            // 
            // bkashRadioButton
            // 
            this.bkashRadioButton.AutoSize = true;
            this.bkashRadioButton.Location = new System.Drawing.Point(258, 294);
            this.bkashRadioButton.Name = "bkashRadioButton";
            this.bkashRadioButton.Size = new System.Drawing.Size(87, 30);
            this.bkashRadioButton.TabIndex = 6;
            this.bkashRadioButton.TabStop = true;
            this.bkashRadioButton.Text = "Bkash";
            this.bkashRadioButton.UseVisualStyleBackColor = true;
            // 
            // nogodRadioButton
            // 
            this.nogodRadioButton.AutoSize = true;
            this.nogodRadioButton.Location = new System.Drawing.Point(349, 294);
            this.nogodRadioButton.Name = "nogodRadioButton";
            this.nogodRadioButton.Size = new System.Drawing.Size(90, 30);
            this.nogodRadioButton.TabIndex = 7;
            this.nogodRadioButton.TabStop = true;
            this.nogodRadioButton.Text = "Nogod";
            this.nogodRadioButton.UseVisualStyleBackColor = true;
            // 
            // roketRadioButton
            // 
            this.roketRadioButton.AutoSize = true;
            this.roketRadioButton.Location = new System.Drawing.Point(456, 294);
            this.roketRadioButton.Name = "roketRadioButton";
            this.roketRadioButton.Size = new System.Drawing.Size(87, 30);
            this.roketRadioButton.TabIndex = 8;
            this.roketRadioButton.TabStop = true;
            this.roketRadioButton.Text = "Roket";
            this.roketRadioButton.UseVisualStyleBackColor = true;
            // 
            // upayRadioButton
            // 
            this.upayRadioButton.AutoSize = true;
            this.upayRadioButton.Location = new System.Drawing.Point(551, 294);
            this.upayRadioButton.Name = "upayRadioButton";
            this.upayRadioButton.Size = new System.Drawing.Size(81, 30);
            this.upayRadioButton.TabIndex = 9;
            this.upayRadioButton.TabStop = true;
            this.upayRadioButton.Text = "Upay";
            this.upayRadioButton.UseVisualStyleBackColor = true;
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.MidnightBlue;
            this.backButton.ForeColor = System.Drawing.Color.White;
            this.backButton.Location = new System.Drawing.Point(50, 391);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(95, 36);
            this.backButton.TabIndex = 10;
            this.backButton.Text = "BACK";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // confirmButton
            // 
            this.confirmButton.BackColor = System.Drawing.Color.MidnightBlue;
            this.confirmButton.ForeColor = System.Drawing.Color.White;
            this.confirmButton.Location = new System.Drawing.Point(583, 391);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(125, 36);
            this.confirmButton.TabIndex = 11;
            this.confirmButton.Text = "CONFIRM";
            this.confirmButton.UseVisualStyleBackColor = false;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // invalidPhoneLabel
            // 
            this.invalidPhoneLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.invalidPhoneLabel.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold);
            this.invalidPhoneLabel.ForeColor = System.Drawing.Color.IndianRed;
            this.invalidPhoneLabel.Location = new System.Drawing.Point(258, 198);
            this.invalidPhoneLabel.Name = "invalidPhoneLabel";
            this.invalidPhoneLabel.Size = new System.Drawing.Size(358, 18);
            this.invalidPhoneLabel.TabIndex = 30;
            this.invalidPhoneLabel.Text = "Invalid phone number";
            this.invalidPhoneLabel.Visible = false;
            // 
            // amountLebel
            // 
            this.amountLebel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.amountLebel.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold);
            this.amountLebel.ForeColor = System.Drawing.Color.IndianRed;
            this.amountLebel.Location = new System.Drawing.Point(255, 262);
            this.amountLebel.Name = "amountLebel";
            this.amountLebel.Size = new System.Drawing.Size(358, 18);
            this.amountLebel.TabIndex = 31;
            this.amountLebel.Text = "Invalid Input Amount";
            this.amountLebel.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(82, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 26);
            this.label2.TabIndex = 32;
            this.label2.Text = "Date";
            // 
            // paymentdateTimePicker
            // 
            this.paymentdateTimePicker.Location = new System.Drawing.Point(258, 107);
            this.paymentdateTimePicker.Name = "paymentdateTimePicker";
            this.paymentdateTimePicker.Size = new System.Drawing.Size(355, 31);
            this.paymentdateTimePicker.TabIndex = 33;
            // 
            // crossPicture2
            // 
            this.crossPicture2.Image = ((System.Drawing.Image)(resources.GetObject("crossPicture2.Image")));
            this.crossPicture2.ImageRotate = 0F;
            this.crossPicture2.Location = new System.Drawing.Point(622, 162);
            this.crossPicture2.Name = "crossPicture2";
            this.crossPicture2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.crossPicture2.Size = new System.Drawing.Size(48, 36);
            this.crossPicture2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.crossPicture2.TabIndex = 34;
            this.crossPicture2.TabStop = false;
            this.crossPicture2.Visible = false;
            // 
            // tickPicture2
            // 
            this.tickPicture2.Image = ((System.Drawing.Image)(resources.GetObject("tickPicture2.Image")));
            this.tickPicture2.ImageRotate = 0F;
            this.tickPicture2.Location = new System.Drawing.Point(622, 162);
            this.tickPicture2.Name = "tickPicture2";
            this.tickPicture2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.tickPicture2.Size = new System.Drawing.Size(40, 27);
            this.tickPicture2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tickPicture2.TabIndex = 35;
            this.tickPicture2.TabStop = false;
            this.tickPicture2.Visible = false;
            // 
            // Deposit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(744, 461);
            this.Controls.Add(this.crossPicture2);
            this.Controls.Add(this.tickPicture2);
            this.Controls.Add(this.paymentdateTimePicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.amountLebel);
            this.Controls.Add(this.invalidPhoneLabel);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.upayRadioButton);
            this.Controls.Add(this.roketRadioButton);
            this.Controls.Add(this.nogodRadioButton);
            this.Controls.Add(this.bkashRadioButton);
            this.Controls.Add(this.paymentMethodLabel);
            this.Controls.Add(this.amountTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.depositLabel);
            this.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Deposit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Deposit";
            this.Load += new System.EventHandler(this.Deposit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.crossPicture2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tickPicture2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label depositLabel;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.Label paymentMethodLabel;
        private System.Windows.Forms.RadioButton bkashRadioButton;
        private System.Windows.Forms.RadioButton nogodRadioButton;
        private System.Windows.Forms.RadioButton roketRadioButton;
        private System.Windows.Forms.RadioButton upayRadioButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.Label invalidPhoneLabel;
        private System.Windows.Forms.Label amountLebel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker paymentdateTimePicker;
        private Guna.UI2.WinForms.Guna2CirclePictureBox crossPicture2;
        private Guna.UI2.WinForms.Guna2CirclePictureBox tickPicture2;
    }
}