namespace ScholarsNest.View
{
    partial class UpdateMealManager
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.resetButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.mealListLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BFood = new System.Windows.Forms.TextBox();
            this.LFood = new System.Windows.Forms.TextBox();
            this.DFood = new System.Windows.Forms.TextBox();
            this.DPrice = new System.Windows.Forms.TextBox();
            this.LPrice = new System.Windows.Forms.TextBox();
            this.BPrice = new System.Windows.Forms.TextBox();
            this.Price = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.MealidText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dayText = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(32, 64);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(765, 182);
            this.dataGridView1.TabIndex = 57;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // resetButton
            // 
            this.resetButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.resetButton.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetButton.ForeColor = System.Drawing.Color.White;
            this.resetButton.Location = new System.Drawing.Point(493, 280);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(86, 35);
            this.resetButton.TabIndex = 56;
            this.resetButton.Text = "RESET";
            this.resetButton.UseVisualStyleBackColor = false;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.updateButton.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.ForeColor = System.Drawing.Color.White;
            this.updateButton.Location = new System.Drawing.Point(657, 280);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(100, 35);
            this.updateButton.TabIndex = 55;
            this.updateButton.Text = "UPDATE";
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.deleteButton.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.ForeColor = System.Drawing.Color.White;
            this.deleteButton.Location = new System.Drawing.Point(342, 280);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(86, 35);
            this.deleteButton.TabIndex = 54;
            this.deleteButton.Text = "DELETE";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.addButton.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.ForeColor = System.Drawing.Color.White;
            this.addButton.Location = new System.Drawing.Point(196, 280);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(86, 35);
            this.addButton.TabIndex = 53;
            this.addButton.Text = "ADD";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.backButton.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.ForeColor = System.Drawing.Color.White;
            this.backButton.Location = new System.Drawing.Point(56, 280);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(86, 35);
            this.backButton.TabIndex = 52;
            this.backButton.Text = "BACK";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // mealListLabel
            // 
            this.mealListLabel.AutoSize = true;
            this.mealListLabel.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mealListLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.mealListLabel.Location = new System.Drawing.Point(325, 9);
            this.mealListLabel.Name = "mealListLabel";
            this.mealListLabel.Size = new System.Drawing.Size(167, 41);
            this.mealListLabel.TabIndex = 51;
            this.mealListLabel.Text = "MEAL LIST";
            this.mealListLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 396);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 36);
            this.label1.TabIndex = 58;
            this.label1.Text = "Breakfast";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 458);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 36);
            this.label2.TabIndex = 59;
            this.label2.Text = "Lunch";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 517);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 36);
            this.label3.TabIndex = 60;
            this.label3.Text = "Dinner";
            // 
            // BFood
            // 
            this.BFood.Location = new System.Drawing.Point(125, 396);
            this.BFood.Multiline = true;
            this.BFood.Name = "BFood";
            this.BFood.Size = new System.Drawing.Size(276, 36);
            this.BFood.TabIndex = 61;
            // 
            // LFood
            // 
            this.LFood.Location = new System.Drawing.Point(125, 461);
            this.LFood.Multiline = true;
            this.LFood.Name = "LFood";
            this.LFood.Size = new System.Drawing.Size(276, 36);
            this.LFood.TabIndex = 62;
            // 
            // DFood
            // 
            this.DFood.Location = new System.Drawing.Point(125, 517);
            this.DFood.Multiline = true;
            this.DFood.Name = "DFood";
            this.DFood.Size = new System.Drawing.Size(276, 36);
            this.DFood.TabIndex = 63;
            // 
            // DPrice
            // 
            this.DPrice.Location = new System.Drawing.Point(521, 516);
            this.DPrice.Multiline = true;
            this.DPrice.Name = "DPrice";
            this.DPrice.Size = new System.Drawing.Size(276, 36);
            this.DPrice.TabIndex = 69;
            // 
            // LPrice
            // 
            this.LPrice.Location = new System.Drawing.Point(521, 461);
            this.LPrice.Multiline = true;
            this.LPrice.Name = "LPrice";
            this.LPrice.Size = new System.Drawing.Size(276, 36);
            this.LPrice.TabIndex = 68;
            // 
            // BPrice
            // 
            this.BPrice.Location = new System.Drawing.Point(521, 395);
            this.BPrice.Multiline = true;
            this.BPrice.Name = "BPrice";
            this.BPrice.Size = new System.Drawing.Size(276, 36);
            this.BPrice.TabIndex = 67;
            // 
            // Price
            // 
            this.Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Price.Location = new System.Drawing.Point(419, 516);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(113, 36);
            this.Price.TabIndex = 66;
            this.Price.Text = "Price";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(419, 457);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 36);
            this.label5.TabIndex = 65;
            this.label5.Text = "Price";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(419, 395);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 36);
            this.label6.TabIndex = 64;
            this.label6.Text = "Price";
            // 
            // MealidText
            // 
            this.MealidText.Location = new System.Drawing.Point(125, 338);
            this.MealidText.Multiline = true;
            this.MealidText.Name = "MealidText";
            this.MealidText.Size = new System.Drawing.Size(276, 36);
            this.MealidText.TabIndex = 71;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 338);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 36);
            this.label4.TabIndex = 70;
            this.label4.Text = "Meal-Id";
            // 
            // dayText
            // 
            this.dayText.Location = new System.Drawing.Point(521, 338);
            this.dayText.Multiline = true;
            this.dayText.Name = "dayText";
            this.dayText.Size = new System.Drawing.Size(276, 36);
            this.dayText.TabIndex = 73;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(428, 338);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 36);
            this.label7.TabIndex = 72;
            this.label7.Text = "day";
            // 
            // UpdateMealManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 623);
            this.Controls.Add(this.dayText);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.MealidText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DPrice);
            this.Controls.Add(this.LPrice);
            this.Controls.Add(this.BPrice);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DFood);
            this.Controls.Add(this.LFood);
            this.Controls.Add(this.BFood);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.mealListLabel);
            this.Name = "UpdateMealManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateMealManager";
            this.Load += new System.EventHandler(this.UpdateMealManager_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label mealListLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox BFood;
        private System.Windows.Forms.TextBox LFood;
        private System.Windows.Forms.TextBox DFood;
        private System.Windows.Forms.TextBox DPrice;
        private System.Windows.Forms.TextBox LPrice;
        private System.Windows.Forms.TextBox BPrice;
        private System.Windows.Forms.Label Price;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox MealidText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox dayText;
        private System.Windows.Forms.Label label7;
    }
}