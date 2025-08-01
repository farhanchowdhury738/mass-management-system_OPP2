namespace ScholarsNest.View
{
    partial class ShowEmpoyeeOp
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
            this.empScrollPanel = new System.Windows.Forms.Panel();
            this.empAListPanel = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.resetButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.salaryTextBox = new System.Windows.Forms.TextBox();
            this.salaryLabel = new System.Windows.Forms.Label();
            this.roleComboBox = new System.Windows.Forms.ComboBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.empIDTextBox = new System.Windows.Forms.TextBox();
            this.roleLabel = new System.Windows.Forms.Label();
            this.empIDLabel = new System.Windows.Forms.Label();
            this.eNameLabel = new System.Windows.Forms.Label();
            this.employeeListLabel = new System.Windows.Forms.Label();
            this.empAListPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // empScrollPanel
            // 
            this.empScrollPanel.Location = new System.Drawing.Point(800, 12);
            this.empScrollPanel.Name = "empScrollPanel";
            this.empScrollPanel.Size = new System.Drawing.Size(34, 717);
            this.empScrollPanel.TabIndex = 21;
            // 
            // empAListPanel
            // 
            this.empAListPanel.AutoScroll = true;
            this.empAListPanel.AutoSize = true;
            this.empAListPanel.BackColor = System.Drawing.Color.White;
            this.empAListPanel.Controls.Add(this.dataGridView1);
            this.empAListPanel.Controls.Add(this.resetButton);
            this.empAListPanel.Controls.Add(this.updateButton);
            this.empAListPanel.Controls.Add(this.deleteButton);
            this.empAListPanel.Controls.Add(this.addButton);
            this.empAListPanel.Controls.Add(this.backButton);
            this.empAListPanel.Controls.Add(this.passwordTextBox);
            this.empAListPanel.Controls.Add(this.passwordLabel);
            this.empAListPanel.Controls.Add(this.salaryTextBox);
            this.empAListPanel.Controls.Add(this.salaryLabel);
            this.empAListPanel.Controls.Add(this.roleComboBox);
            this.empAListPanel.Controls.Add(this.nameTextBox);
            this.empAListPanel.Controls.Add(this.empIDTextBox);
            this.empAListPanel.Controls.Add(this.roleLabel);
            this.empAListPanel.Controls.Add(this.empIDLabel);
            this.empAListPanel.Controls.Add(this.eNameLabel);
            this.empAListPanel.Controls.Add(this.employeeListLabel);
            this.empAListPanel.Controls.Add(this.empScrollPanel);
            this.empAListPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.empAListPanel.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empAListPanel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.empAListPanel.Location = new System.Drawing.Point(-66, 0);
            this.empAListPanel.Name = "empAListPanel";
            this.empAListPanel.Size = new System.Drawing.Size(837, 605);
            this.empAListPanel.TabIndex = 1;
            this.empAListPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.empAListPanel_Paint);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(133, 64);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(624, 194);
            this.dataGridView1.TabIndex = 50;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // resetButton
            // 
            this.resetButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.resetButton.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetButton.ForeColor = System.Drawing.Color.White;
            this.resetButton.Location = new System.Drawing.Point(547, 296);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(86, 35);
            this.resetButton.TabIndex = 49;
            this.resetButton.Text = "RESET";
            this.resetButton.UseVisualStyleBackColor = false;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.updateButton.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.ForeColor = System.Drawing.Color.White;
            this.updateButton.Location = new System.Drawing.Point(691, 296);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(86, 35);
            this.updateButton.TabIndex = 48;
            this.updateButton.Text = "UPDATE";
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.deleteButton.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.ForeColor = System.Drawing.Color.White;
            this.deleteButton.Location = new System.Drawing.Point(399, 296);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(86, 35);
            this.deleteButton.TabIndex = 47;
            this.deleteButton.Text = "DELETE";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.addButton.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.ForeColor = System.Drawing.Color.White;
            this.addButton.Location = new System.Drawing.Point(257, 296);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(86, 35);
            this.addButton.TabIndex = 46;
            this.addButton.Text = "ADD";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.backButton.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.ForeColor = System.Drawing.Color.White;
            this.backButton.Location = new System.Drawing.Point(123, 296);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(86, 35);
            this.backButton.TabIndex = 45;
            this.backButton.Text = "BACK";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BackColor = System.Drawing.Color.AliceBlue;
            this.passwordTextBox.Location = new System.Drawing.Point(282, 619);
            this.passwordTextBox.Multiline = true;
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(465, 35);
            this.passwordTextBox.TabIndex = 44;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(145, 622);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(100, 28);
            this.passwordLabel.TabIndex = 43;
            this.passwordLabel.Text = "Password";
            // 
            // salaryTextBox
            // 
            this.salaryTextBox.BackColor = System.Drawing.Color.AliceBlue;
            this.salaryTextBox.Location = new System.Drawing.Point(282, 557);
            this.salaryTextBox.Multiline = true;
            this.salaryTextBox.Name = "salaryTextBox";
            this.salaryTextBox.Size = new System.Drawing.Size(465, 35);
            this.salaryTextBox.TabIndex = 42;
            this.salaryTextBox.TextChanged += new System.EventHandler(this.salaryTextBox_TextChanged);
            // 
            // salaryLabel
            // 
            this.salaryLabel.AutoSize = true;
            this.salaryLabel.Location = new System.Drawing.Point(145, 560);
            this.salaryLabel.Name = "salaryLabel";
            this.salaryLabel.Size = new System.Drawing.Size(71, 28);
            this.salaryLabel.TabIndex = 41;
            this.salaryLabel.Text = "Salary";
            this.salaryLabel.Click += new System.EventHandler(this.salaryLabel_Click);
            // 
            // roleComboBox
            // 
            this.roleComboBox.BackColor = System.Drawing.Color.AliceBlue;
            this.roleComboBox.FormattingEnabled = true;
            this.roleComboBox.Items.AddRange(new object[] {
            "Manager",
            "Others"});
            this.roleComboBox.Location = new System.Drawing.Point(399, 381);
            this.roleComboBox.Name = "roleComboBox";
            this.roleComboBox.Size = new System.Drawing.Size(200, 36);
            this.roleComboBox.TabIndex = 39;
            // 
            // nameTextBox
            // 
            this.nameTextBox.BackColor = System.Drawing.Color.AliceBlue;
            this.nameTextBox.Location = new System.Drawing.Point(282, 490);
            this.nameTextBox.Multiline = true;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(465, 35);
            this.nameTextBox.TabIndex = 36;
            // 
            // empIDTextBox
            // 
            this.empIDTextBox.BackColor = System.Drawing.Color.AliceBlue;
            this.empIDTextBox.Location = new System.Drawing.Point(282, 439);
            this.empIDTextBox.Multiline = true;
            this.empIDTextBox.Name = "empIDTextBox";
            this.empIDTextBox.Size = new System.Drawing.Size(465, 35);
            this.empIDTextBox.TabIndex = 35;
            // 
            // roleLabel
            // 
            this.roleLabel.AutoSize = true;
            this.roleLabel.Location = new System.Drawing.Point(337, 384);
            this.roleLabel.Name = "roleLabel";
            this.roleLabel.Size = new System.Drawing.Size(53, 28);
            this.roleLabel.TabIndex = 32;
            this.roleLabel.Text = "Role";
            // 
            // empIDLabel
            // 
            this.empIDLabel.AutoSize = true;
            this.empIDLabel.Location = new System.Drawing.Point(145, 442);
            this.empIDLabel.Name = "empIDLabel";
            this.empIDLabel.Size = new System.Drawing.Size(131, 28);
            this.empIDLabel.TabIndex = 30;
            this.empIDLabel.Text = "Employee ID";
            // 
            // eNameLabel
            // 
            this.eNameLabel.AutoSize = true;
            this.eNameLabel.Location = new System.Drawing.Point(145, 496);
            this.eNameLabel.Name = "eNameLabel";
            this.eNameLabel.Size = new System.Drawing.Size(68, 28);
            this.eNameLabel.TabIndex = 29;
            this.eNameLabel.Text = "Name";
            // 
            // employeeListLabel
            // 
            this.employeeListLabel.AutoSize = true;
            this.employeeListLabel.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeListLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.employeeListLabel.Location = new System.Drawing.Point(311, 9);
            this.employeeListLabel.Name = "employeeListLabel";
            this.employeeListLabel.Size = new System.Drawing.Size(342, 41);
            this.employeeListLabel.TabIndex = 22;
            this.employeeListLabel.Text = "LIST OF ALL EMPLOYEE";
            this.employeeListLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ShowEmpoyeeOp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 605);
            this.Controls.Add(this.empAListPanel);
            this.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ShowEmpoyeeOp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShowEmpoyeeOp";
            this.empAListPanel.ResumeLayout(false);
            this.empAListPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel empScrollPanel;
        private System.Windows.Forms.Panel empAListPanel;
        private System.Windows.Forms.Label employeeListLabel;
        private System.Windows.Forms.Label eNameLabel;
        private System.Windows.Forms.Label roleLabel;
        private System.Windows.Forms.Label empIDLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox empIDTextBox;
        private System.Windows.Forms.ComboBox roleComboBox;
        private System.Windows.Forms.TextBox salaryTextBox;
        private System.Windows.Forms.Label salaryLabel;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}