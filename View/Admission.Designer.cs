namespace ScholarsNest.View
{
    partial class Admission
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admission));
            this.fillFormPanel = new System.Windows.Forms.Panel();
            this.minimumCharacter = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.emailTaken = new System.Windows.Forms.Label();
            this.phoneTaken = new System.Windows.Forms.Label();
            this.crossPicture2 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.confirmButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.showPassCheckBox = new System.Windows.Forms.CheckBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.addressLabel = new System.Windows.Forms.Label();
            this.femaleRadioButton = new System.Windows.Forms.RadioButton();
            this.maleRadioButton = new System.Windows.Forms.RadioButton();
            this.addmissionDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.InstitutionTextBox = new System.Windows.Forms.TextBox();
            this.phonenoTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.genderLabel = new System.Windows.Forms.Label();
            this.dobLabel = new System.Windows.Forms.Label();
            this.institutionLabel = new System.Windows.Forms.Label();
            this.phoneNoLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.fatherNameLabel = new System.Windows.Forms.Label();
            this.fatherNameTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.tickPicture2 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.fillFormPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.crossPicture2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tickPicture2)).BeginInit();
            this.SuspendLayout();
            // 
            // fillFormPanel
            // 
            this.fillFormPanel.AutoScroll = true;
            this.fillFormPanel.BackColor = System.Drawing.Color.White;
            this.fillFormPanel.Controls.Add(this.minimumCharacter);
            this.fillFormPanel.Controls.Add(this.emailTaken);
            this.fillFormPanel.Controls.Add(this.phoneTaken);
            this.fillFormPanel.Controls.Add(this.crossPicture2);
            this.fillFormPanel.Controls.Add(this.confirmButton);
            this.fillFormPanel.Controls.Add(this.backButton);
            this.fillFormPanel.Controls.Add(this.showPassCheckBox);
            this.fillFormPanel.Controls.Add(this.passwordTextBox);
            this.fillFormPanel.Controls.Add(this.passwordLabel);
            this.fillFormPanel.Controls.Add(this.addressTextBox);
            this.fillFormPanel.Controls.Add(this.addressLabel);
            this.fillFormPanel.Controls.Add(this.femaleRadioButton);
            this.fillFormPanel.Controls.Add(this.maleRadioButton);
            this.fillFormPanel.Controls.Add(this.addmissionDateTimePicker);
            this.fillFormPanel.Controls.Add(this.InstitutionTextBox);
            this.fillFormPanel.Controls.Add(this.phonenoTextBox);
            this.fillFormPanel.Controls.Add(this.emailTextBox);
            this.fillFormPanel.Controls.Add(this.genderLabel);
            this.fillFormPanel.Controls.Add(this.dobLabel);
            this.fillFormPanel.Controls.Add(this.institutionLabel);
            this.fillFormPanel.Controls.Add(this.phoneNoLabel);
            this.fillFormPanel.Controls.Add(this.emailLabel);
            this.fillFormPanel.Controls.Add(this.fatherNameLabel);
            this.fillFormPanel.Controls.Add(this.fatherNameTextBox);
            this.fillFormPanel.Controls.Add(this.nameTextBox);
            this.fillFormPanel.Controls.Add(this.nameLabel);
            this.fillFormPanel.Controls.Add(this.titleLabel);
            this.fillFormPanel.Controls.Add(this.tickPicture2);
            this.fillFormPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.fillFormPanel.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fillFormPanel.Location = new System.Drawing.Point(-18, 0);
            this.fillFormPanel.Name = "fillFormPanel";
            this.fillFormPanel.Size = new System.Drawing.Size(1172, 588);
            this.fillFormPanel.TabIndex = 0;
            this.fillFormPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.fillFormPanel_Paint);
            // 
            // minimumCharacter
            // 
            this.minimumCharacter.AutoSize = false;
            this.minimumCharacter.BackColor = System.Drawing.Color.Transparent;
            this.minimumCharacter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.minimumCharacter.ForeColor = System.Drawing.Color.IndianRed;
            this.minimumCharacter.Location = new System.Drawing.Point(435, 542);
            this.minimumCharacter.Name = "minimumCharacter";
            this.minimumCharacter.Size = new System.Drawing.Size(573, 19);
            this.minimumCharacter.TabIndex = 31;
            this.minimumCharacter.Text = "Minimum 8 characters";
            this.minimumCharacter.Click += new System.EventHandler(this.minimumCharacter_Click);
            // 
            // emailTaken
            // 
            this.emailTaken.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.emailTaken.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold);
            this.emailTaken.ForeColor = System.Drawing.Color.IndianRed;
            this.emailTaken.Location = new System.Drawing.Point(432, 236);
            this.emailTaken.Name = "emailTaken";
            this.emailTaken.Size = new System.Drawing.Size(566, 22);
            this.emailTaken.TabIndex = 30;
            this.emailTaken.Text = "Invalid Email address";
            this.emailTaken.Visible = false;
            // 
            // phoneTaken
            // 
            this.phoneTaken.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.phoneTaken.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold);
            this.phoneTaken.ForeColor = System.Drawing.Color.IndianRed;
            this.phoneTaken.Location = new System.Drawing.Point(432, 303);
            this.phoneTaken.Name = "phoneTaken";
            this.phoneTaken.Size = new System.Drawing.Size(600, 18);
            this.phoneTaken.TabIndex = 29;
            this.phoneTaken.Text = "Invalid phone number";
            this.phoneTaken.Visible = false;
            // 
            // crossPicture2
            // 
            this.crossPicture2.Image = ((System.Drawing.Image)(resources.GetObject("crossPicture2.Image")));
            this.crossPicture2.ImageRotate = 0F;
            this.crossPicture2.Location = new System.Drawing.Point(702, 259);
            this.crossPicture2.Name = "crossPicture2";
            this.crossPicture2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.crossPicture2.Size = new System.Drawing.Size(54, 43);
            this.crossPicture2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.crossPicture2.TabIndex = 27;
            this.crossPicture2.TabStop = false;
            this.crossPicture2.Visible = false;
            // 
            // confirmButton
            // 
            this.confirmButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.confirmButton.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmButton.ForeColor = System.Drawing.Color.White;
            this.confirmButton.Location = new System.Drawing.Point(989, 487);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(144, 45);
            this.confirmButton.TabIndex = 26;
            this.confirmButton.Text = "CONFIRM";
            this.confirmButton.UseVisualStyleBackColor = false;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.backButton.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.ForeColor = System.Drawing.Color.White;
            this.backButton.Location = new System.Drawing.Point(887, 487);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(96, 45);
            this.backButton.TabIndex = 25;
            this.backButton.Text = "BACK";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // showPassCheckBox
            // 
            this.showPassCheckBox.AutoSize = true;
            this.showPassCheckBox.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showPassCheckBox.Location = new System.Drawing.Point(256, 537);
            this.showPassCheckBox.Name = "showPassCheckBox";
            this.showPassCheckBox.Size = new System.Drawing.Size(140, 24);
            this.showPassCheckBox.TabIndex = 24;
            this.showPassCheckBox.Text = "Show Password";
            this.showPassCheckBox.UseVisualStyleBackColor = true;
            this.showPassCheckBox.CheckedChanged += new System.EventHandler(this.showPassCheckBox_CheckedChanged);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.passwordTextBox.Location = new System.Drawing.Point(256, 493);
            this.passwordTextBox.Multiline = true;
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(445, 43);
            this.passwordTextBox.TabIndex = 23;
            this.passwordTextBox.TextChanged += new System.EventHandler(this.passwordTextBox_TextChanged);
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(84, 496);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(140, 31);
            this.passwordLabel.TabIndex = 22;
            this.passwordLabel.Text = "PASSWORD";
            // 
            // addressTextBox
            // 
            this.addressTextBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.addressTextBox.Location = new System.Drawing.Point(256, 383);
            this.addressTextBox.Multiline = true;
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(445, 92);
            this.addressTextBox.TabIndex = 20;
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(84, 388);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(117, 31);
            this.addressLabel.TabIndex = 19;
            this.addressLabel.Text = "ADDRESS";
            // 
            // femaleRadioButton
            // 
            this.femaleRadioButton.AutoSize = true;
            this.femaleRadioButton.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.femaleRadioButton.ForeColor = System.Drawing.Color.Black;
            this.femaleRadioButton.Location = new System.Drawing.Point(1010, 142);
            this.femaleRadioButton.Name = "femaleRadioButton";
            this.femaleRadioButton.Size = new System.Drawing.Size(108, 32);
            this.femaleRadioButton.TabIndex = 18;
            this.femaleRadioButton.TabStop = true;
            this.femaleRadioButton.Text = "FEMALE";
            this.femaleRadioButton.UseVisualStyleBackColor = true;
            this.femaleRadioButton.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // maleRadioButton
            // 
            this.maleRadioButton.AutoSize = true;
            this.maleRadioButton.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maleRadioButton.ForeColor = System.Drawing.Color.Black;
            this.maleRadioButton.Location = new System.Drawing.Point(906, 141);
            this.maleRadioButton.Name = "maleRadioButton";
            this.maleRadioButton.Size = new System.Drawing.Size(87, 32);
            this.maleRadioButton.TabIndex = 17;
            this.maleRadioButton.TabStop = true;
            this.maleRadioButton.Text = "MALE";
            this.maleRadioButton.UseVisualStyleBackColor = true;
            // 
            // addmissionDateTimePicker
            // 
            this.addmissionDateTimePicker.CalendarForeColor = System.Drawing.Color.PeachPuff;
            this.addmissionDateTimePicker.CalendarMonthBackground = System.Drawing.Color.PeachPuff;
            this.addmissionDateTimePicker.CalendarTitleForeColor = System.Drawing.Color.SaddleBrown;
            this.addmissionDateTimePicker.CalendarTrailingForeColor = System.Drawing.Color.PeachPuff;
            this.addmissionDateTimePicker.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addmissionDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.addmissionDateTimePicker.Location = new System.Drawing.Point(915, 86);
            this.addmissionDateTimePicker.Name = "addmissionDateTimePicker";
            this.addmissionDateTimePicker.Size = new System.Drawing.Size(176, 34);
            this.addmissionDateTimePicker.TabIndex = 16;
            this.addmissionDateTimePicker.Value = new System.DateTime(2025, 6, 18, 0, 0, 0, 0);
            // 
            // InstitutionTextBox
            // 
            this.InstitutionTextBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.InstitutionTextBox.Location = new System.Drawing.Point(256, 327);
            this.InstitutionTextBox.Multiline = true;
            this.InstitutionTextBox.Name = "InstitutionTextBox";
            this.InstitutionTextBox.Size = new System.Drawing.Size(445, 43);
            this.InstitutionTextBox.TabIndex = 12;
            // 
            // phonenoTextBox
            // 
            this.phonenoTextBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.phonenoTextBox.Location = new System.Drawing.Point(256, 259);
            this.phonenoTextBox.Multiline = true;
            this.phonenoTextBox.Name = "phonenoTextBox";
            this.phonenoTextBox.Size = new System.Drawing.Size(445, 43);
            this.phonenoTextBox.TabIndex = 11;
            this.phonenoTextBox.TextChanged += new System.EventHandler(this.phonenoTextBox_TextChanged);
            // 
            // emailTextBox
            // 
            this.emailTextBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.emailTextBox.Location = new System.Drawing.Point(256, 192);
            this.emailTextBox.Multiline = true;
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(445, 43);
            this.emailTextBox.TabIndex = 10;
            this.emailTextBox.TextChanged += new System.EventHandler(this.emailTextBox_TextChanged);
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.Location = new System.Drawing.Point(726, 138);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(104, 31);
            this.genderLabel.TabIndex = 9;
            this.genderLabel.Text = "GENDER";
            // 
            // dobLabel
            // 
            this.dobLabel.AutoSize = true;
            this.dobLabel.Location = new System.Drawing.Point(726, 86);
            this.dobLabel.Name = "dobLabel";
            this.dobLabel.Size = new System.Drawing.Size(178, 31);
            this.dobLabel.TabIndex = 8;
            this.dobLabel.Text = "DATE OF BIRTH";
            // 
            // institutionLabel
            // 
            this.institutionLabel.AutoSize = true;
            this.institutionLabel.Location = new System.Drawing.Point(81, 332);
            this.institutionLabel.Name = "institutionLabel";
            this.institutionLabel.Size = new System.Drawing.Size(157, 31);
            this.institutionLabel.TabIndex = 7;
            this.institutionLabel.Text = "INSTITUTION";
            // 
            // phoneNoLabel
            // 
            this.phoneNoLabel.AutoSize = true;
            this.phoneNoLabel.Location = new System.Drawing.Point(81, 264);
            this.phoneNoLabel.Name = "phoneNoLabel";
            this.phoneNoLabel.Size = new System.Drawing.Size(134, 31);
            this.phoneNoLabel.TabIndex = 6;
            this.phoneNoLabel.Text = "PHONE NO";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(81, 195);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(92, 31);
            this.emailLabel.TabIndex = 5;
            this.emailLabel.Text = "E-MAIL";
            // 
            // fatherNameLabel
            // 
            this.fatherNameLabel.AutoSize = true;
            this.fatherNameLabel.Location = new System.Drawing.Point(81, 142);
            this.fatherNameLabel.Name = "fatherNameLabel";
            this.fatherNameLabel.Size = new System.Drawing.Size(171, 31);
            this.fatherNameLabel.TabIndex = 4;
            this.fatherNameLabel.Text = "FATHER NAME";
            // 
            // fatherNameTextBox
            // 
            this.fatherNameTextBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.fatherNameTextBox.Location = new System.Drawing.Point(256, 135);
            this.fatherNameTextBox.Multiline = true;
            this.fatherNameTextBox.Name = "fatherNameTextBox";
            this.fatherNameTextBox.Size = new System.Drawing.Size(445, 43);
            this.fatherNameTextBox.TabIndex = 3;
            // 
            // nameTextBox
            // 
            this.nameTextBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.nameTextBox.Location = new System.Drawing.Point(256, 80);
            this.nameTextBox.Multiline = true;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(445, 43);
            this.nameTextBox.TabIndex = 2;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(81, 92);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(82, 31);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "NAME";
            // 
            // titleLabel
            // 
            this.titleLabel.Font = new System.Drawing.Font("Trebuchet MS", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(427, 14);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(288, 54);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "FILL THE FORM";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tickPicture2
            // 
            this.tickPicture2.Image = ((System.Drawing.Image)(resources.GetObject("tickPicture2.Image")));
            this.tickPicture2.ImageRotate = 0F;
            this.tickPicture2.Location = new System.Drawing.Point(702, 259);
            this.tickPicture2.Name = "tickPicture2";
            this.tickPicture2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.tickPicture2.Size = new System.Drawing.Size(46, 34);
            this.tickPicture2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tickPicture2.TabIndex = 28;
            this.tickPicture2.TabStop = false;
            this.tickPicture2.Visible = false;
            this.tickPicture2.Click += new System.EventHandler(this.guna2CirclePictureBox1_Click);
            // 
            // Admission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 588);
            this.Controls.Add(this.fillFormPanel);
            this.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.RoyalBlue;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Admission";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admission";
            this.fillFormPanel.ResumeLayout(false);
            this.fillFormPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.crossPicture2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tickPicture2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel fillFormPanel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label institutionLabel;
        private System.Windows.Forms.Label phoneNoLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label fatherNameLabel;
        private System.Windows.Forms.TextBox fatherNameTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox InstitutionTextBox;
        private System.Windows.Forms.TextBox phonenoTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label genderLabel;
        private System.Windows.Forms.Label dobLabel;
        private System.Windows.Forms.DateTimePicker addmissionDateTimePicker;
        private System.Windows.Forms.RadioButton femaleRadioButton;
        private System.Windows.Forms.RadioButton maleRadioButton;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.CheckBox showPassCheckBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button confirmButton;
        private Guna.UI2.WinForms.Guna2CirclePictureBox crossPicture2;
        private Guna.UI2.WinForms.Guna2CirclePictureBox tickPicture2;
        private System.Windows.Forms.Label phoneTaken;
        private System.Windows.Forms.Label emailTaken;
        private Guna.UI2.WinForms.Guna2HtmlLabel minimumCharacter;
    }
}