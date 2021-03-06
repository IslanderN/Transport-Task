﻿namespace UI
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
            this.GraphForm = new System.Windows.Forms.Button();
            this.FrequancyGraph = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // CountManufacturerComboBox
            // 
            this.CountManufacturerComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CountManufacturerComboBox.FormattingEnabled = true;
            this.CountManufacturerComboBox.Location = new System.Drawing.Point(178, 36);
            this.CountManufacturerComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CountManufacturerComboBox.Name = "CountManufacturerComboBox";
            this.CountManufacturerComboBox.Size = new System.Drawing.Size(49, 32);
            this.CountManufacturerComboBox.TabIndex = 0;
            this.CountManufacturerComboBox.SelectedIndexChanged += new System.EventHandler(this.CountManufacturerComboBox_SelectedIndexChanged);
            // 
            // CountClientComboBox
            // 
            this.CountClientComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CountClientComboBox.FormattingEnabled = true;
            this.CountClientComboBox.Location = new System.Drawing.Point(368, 36);
            this.CountClientComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CountClientComboBox.Name = "CountClientComboBox";
            this.CountClientComboBox.Size = new System.Drawing.Size(49, 32);
            this.CountClientComboBox.TabIndex = 1;
            this.CountClientComboBox.SelectedIndexChanged += new System.EventHandler(this.CountClientComboBox_SelectedIndexChanged);
            // 
            // ManufacurerLabel
            // 
            this.ManufacurerLabel.AutoSize = true;
            this.ManufacurerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ManufacurerLabel.Location = new System.Drawing.Point(9, 33);
            this.ManufacurerLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ManufacurerLabel.Name = "ManufacurerLabel";
            this.ManufacurerLabel.Size = new System.Drawing.Size(163, 24);
            this.ManufacurerLabel.TabIndex = 2;
            this.ManufacurerLabel.Text = "К-ть виробництв";
            // 
            // ClientLabel
            // 
            this.ClientLabel.AutoSize = true;
            this.ClientLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClientLabel.Location = new System.Drawing.Point(244, 36);
            this.ClientLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ClientLabel.Name = "ClientLabel";
            this.ClientLabel.Size = new System.Drawing.Size(123, 24);
            this.ClientLabel.TabIndex = 3;
            this.ClientLabel.Text = "К-ть клієнтів";
            // 
            // menuStrip1
            // 
            this.menuStrip1.AccessibleName = "GraphForm";
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(849, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "Графіки";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(624, 71);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Алгоритми";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(605, 110);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(201, 37);
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
            this.dataGridView.Location = new System.Drawing.Point(4, 92);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView.Size = new System.Drawing.Size(555, 303);
            this.dataGridView.TabIndex = 0;
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.dataGridView);
            this.groupBox.ForeColor = System.Drawing.Color.Black;
            this.groupBox.Location = new System.Drawing.Point(9, 71);
            this.groupBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox.Name = "groupBox";
            this.groupBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox.Size = new System.Drawing.Size(578, 400);
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
            this.GenerateRandomButton.Location = new System.Drawing.Point(548, 27);
            this.GenerateRandomButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GenerateRandomButton.Name = "GenerateRandomButton";
            this.GenerateRandomButton.Size = new System.Drawing.Size(226, 32);
            this.GenerateRandomButton.TabIndex = 8;
            this.GenerateRandomButton.Text = "Випадкові значення";
            this.GenerateRandomButton.UseVisualStyleBackColor = true;
            this.GenerateRandomButton.Click += new System.EventHandler(this.GenerateRandomButton_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(605, 151);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(201, 37);
            this.button2.TabIndex = 7;
            this.button2.Text = "Генетичний";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.GeneticAlgorithm_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(605, 192);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(201, 37);
            this.button3.TabIndex = 7;
            this.button3.Text = "Частотний";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.FrequancyAlgorithm_Click);
            // 
            // GraphForm
            // 
            this.GraphForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GraphForm.Location = new System.Drawing.Point(605, 258);
            this.GraphForm.Name = "GraphForm";
            this.GraphForm.Size = new System.Drawing.Size(200, 34);
            this.GraphForm.TabIndex = 13;
            this.GraphForm.Text = "Графіки";
            this.GraphForm.UseVisualStyleBackColor = true;
            this.GraphForm.Click += new System.EventHandler(this.GraphForm_Click);
            // 
            // FrequancyGraph
            // 
            this.FrequancyGraph.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FrequancyGraph.Location = new System.Drawing.Point(605, 320);
            this.FrequancyGraph.Name = "FrequancyGraph";
            this.FrequancyGraph.Size = new System.Drawing.Size(200, 63);
            this.FrequancyGraph.TabIndex = 13;
            this.FrequancyGraph.Text = "Аналіз Частотного алгоритму";
            this.FrequancyGraph.UseVisualStyleBackColor = true;
            this.FrequancyGraph.Click += new System.EventHandler(this.FrequancyGraph_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(849, 550);
            this.Controls.Add(this.FrequancyGraph);
            this.Controls.Add(this.GraphForm);
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.Button GraphForm;
        private System.Windows.Forms.Button FrequancyGraph;
    }
}

