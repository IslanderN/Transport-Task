namespace UI
{
    partial class Main
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
            this.CountManufacturerComboBox = new System.Windows.Forms.ComboBox();
            this.CountClientComboBox = new System.Windows.Forms.ComboBox();
            this.ManufacurerLabel = new System.Windows.Forms.Label();
            this.ClientLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.label22 = new System.Windows.Forms.Label();
            this.GenerateRandomButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.GreedyResult = new System.Windows.Forms.Label();
            this.GeneticResult = new System.Windows.Forms.Label();
            this.FrequancyResult = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // CountManufacturerComboBox
            // 
            this.CountManufacturerComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CountManufacturerComboBox.FormattingEnabled = true;
            this.CountManufacturerComboBox.Location = new System.Drawing.Point(237, 44);
            this.CountManufacturerComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CountManufacturerComboBox.Name = "CountManufacturerComboBox";
            this.CountManufacturerComboBox.Size = new System.Drawing.Size(64, 37);
            this.CountManufacturerComboBox.TabIndex = 0;
            this.CountManufacturerComboBox.SelectedIndexChanged += new System.EventHandler(this.CountManufacturerComboBox_SelectedIndexChanged);
            // 
            // CountClientComboBox
            // 
            this.CountClientComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CountClientComboBox.FormattingEnabled = true;
            this.CountClientComboBox.Location = new System.Drawing.Point(491, 44);
            this.CountClientComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CountClientComboBox.Name = "CountClientComboBox";
            this.CountClientComboBox.Size = new System.Drawing.Size(64, 37);
            this.CountClientComboBox.TabIndex = 1;
            this.CountClientComboBox.SelectedIndexChanged += new System.EventHandler(this.CountClientComboBox_SelectedIndexChanged);
            // 
            // ManufacurerLabel
            // 
            this.ManufacurerLabel.AutoSize = true;
            this.ManufacurerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ManufacurerLabel.Location = new System.Drawing.Point(12, 41);
            this.ManufacurerLabel.Name = "ManufacurerLabel";
            this.ManufacurerLabel.Size = new System.Drawing.Size(208, 29);
            this.ManufacurerLabel.TabIndex = 2;
            this.ManufacurerLabel.Text = "К-ть виробництв";
            // 
            // ClientLabel
            // 
            this.ClientLabel.AutoSize = true;
            this.ClientLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClientLabel.Location = new System.Drawing.Point(325, 44);
            this.ClientLabel.Name = "ClientLabel";
            this.ClientLabel.Size = new System.Drawing.Size(159, 29);
            this.ClientLabel.TabIndex = 3;
            this.ClientLabel.Text = "К-ть клієнтів";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1108, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(832, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Алгоритми";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(807, 135);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(268, 46);
            this.button1.TabIndex = 7;
            this.button1.Text = "Жадібний";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.GreedyAlgorithm_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToResizeColumns = false;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(5, 113);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView.Size = new System.Drawing.Size(740, 373);
            this.dataGridView.TabIndex = 0;
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.dataGridView);
            this.groupBox.ForeColor = System.Drawing.Color.Black;
            this.groupBox.Location = new System.Drawing.Point(12, 87);
            this.groupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox.Name = "groupBox";
            this.groupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox.Size = new System.Drawing.Size(771, 492);
            this.groupBox.TabIndex = 4;
            this.groupBox.TabStop = false;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.Black;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label22.Location = new System.Drawing.Point(10, 17);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(0, 29);
            this.label22.TabIndex = 8;
            // 
            // GenerateRandomButton
            // 
            this.GenerateRandomButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GenerateRandomButton.Location = new System.Drawing.Point(731, 33);
            this.GenerateRandomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GenerateRandomButton.Name = "GenerateRandomButton";
            this.GenerateRandomButton.Size = new System.Drawing.Size(301, 39);
            this.GenerateRandomButton.TabIndex = 8;
            this.GenerateRandomButton.Text = "Випадкові значення";
            this.GenerateRandomButton.UseVisualStyleBackColor = true;
            this.GenerateRandomButton.Click += new System.EventHandler(this.GenerateRandomButton_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(807, 186);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(268, 46);
            this.button2.TabIndex = 7;
            this.button2.Text = "Генетичний";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.GeneticAlgorithm_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(807, 236);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(268, 46);
            this.button3.TabIndex = 7;
            this.button3.Text = "Частотний";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.FrequancyAlgorithm_Click);
            // 
            // GreedyResult
            // 
            this.GreedyResult.AutoSize = true;
            this.GreedyResult.BackColor = System.Drawing.Color.White;
            this.GreedyResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GreedyResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GreedyResult.Location = new System.Drawing.Point(974, 418);
            this.GreedyResult.Name = "GreedyResult";
            this.GreedyResult.Size = new System.Drawing.Size(2, 31);
            this.GreedyResult.TabIndex = 9;
            // 
            // GeneticResult
            // 
            this.GeneticResult.AutoSize = true;
            this.GeneticResult.BackColor = System.Drawing.Color.White;
            this.GeneticResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GeneticResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GeneticResult.Location = new System.Drawing.Point(974, 474);
            this.GeneticResult.Name = "GeneticResult";
            this.GeneticResult.Size = new System.Drawing.Size(2, 31);
            this.GeneticResult.TabIndex = 9;
            // 
            // FrequancyResult
            // 
            this.FrequancyResult.AutoSize = true;
            this.FrequancyResult.BackColor = System.Drawing.Color.White;
            this.FrequancyResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FrequancyResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FrequancyResult.Location = new System.Drawing.Point(974, 526);
            this.FrequancyResult.Name = "FrequancyResult";
            this.FrequancyResult.Size = new System.Drawing.Size(2, 31);
            this.FrequancyResult.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(802, 420);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 29);
            this.label2.TabIndex = 10;
            this.label2.Text = "Жадібний";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(802, 476);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 29);
            this.label3.TabIndex = 11;
            this.label3.Text = "Генетичний";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(802, 528);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 29);
            this.label4.TabIndex = 12;
            this.label4.Text = "Частотний";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1108, 594);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FrequancyResult);
            this.Controls.Add(this.GeneticResult);
            this.Controls.Add(this.GreedyResult);
            this.Controls.Add(this.GenerateRandomButton);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.ClientLabel);
            this.Controls.Add(this.ManufacurerLabel);
            this.Controls.Add(this.CountClientComboBox);
            this.Controls.Add(this.CountManufacturerComboBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Main";
            this.Text = "Курсова робота";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.groupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CountManufacturerComboBox;
        private System.Windows.Forms.ComboBox CountClientComboBox;
        private System.Windows.Forms.Label ManufacurerLabel;
        private System.Windows.Forms.Label ClientLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button GenerateRandomButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label GreedyResult;
        private System.Windows.Forms.Label GeneticResult;
        private System.Windows.Forms.Label FrequancyResult;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

