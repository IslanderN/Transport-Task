namespace UI
{
    partial class Graphs
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.SizeGraph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.FirstInputTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LastInputTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.StepInputTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.NumberOfTestInputTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DrawSizeGraph = new System.Windows.Forms.Button();
            this.LoadingBox = new System.Windows.Forms.PictureBox();
            this.DrawSizeGraphCancel = new System.Windows.Forms.Button();
            this.TimeGraph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.TimeLoadingBox = new System.Windows.Forms.PictureBox();
            this.DrawTimeGraphButton = new System.Windows.Forms.Button();
            this.CancelDrawTimeGraphButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SizeGraph)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoadingBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimeGraph)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimeLoadingBox)).BeginInit();
            this.SuspendLayout();
            // 
            // SizeGraph
            // 
            chartArea3.Name = "ChartArea1";
            this.SizeGraph.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.SizeGraph.Legends.Add(legend3);
            this.SizeGraph.Location = new System.Drawing.Point(263, 55);
            this.SizeGraph.Margin = new System.Windows.Forms.Padding(4);
            this.SizeGraph.Name = "SizeGraph";
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series7.Legend = "Legend1";
            series7.Name = "Genetic";
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series8.Legend = "Legend1";
            series8.Name = "Greedy";
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series9.Legend = "Legend1";
            series9.Name = "Frequancy";
            this.SizeGraph.Series.Add(series7);
            this.SizeGraph.Series.Add(series8);
            this.SizeGraph.Series.Add(series9);
            this.SizeGraph.Size = new System.Drawing.Size(923, 463);
            this.SizeGraph.TabIndex = 0;
            this.SizeGraph.Text = "chart1";
            // 
            // FirstInputTextBox
            // 
            this.FirstInputTextBox.Location = new System.Drawing.Point(83, 52);
            this.FirstInputTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.FirstInputTextBox.Name = "FirstInputTextBox";
            this.FirstInputTextBox.Size = new System.Drawing.Size(132, 22);
            this.FirstInputTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Початок";
            // 
            // LastInputTextBox
            // 
            this.LastInputTextBox.Location = new System.Drawing.Point(83, 84);
            this.LastInputTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.LastInputTextBox.Name = "LastInputTextBox";
            this.LastInputTextBox.Size = new System.Drawing.Size(132, 22);
            this.LastInputTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 87);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Кінець";
            // 
            // StepInputTextBox
            // 
            this.StepInputTextBox.Location = new System.Drawing.Point(83, 127);
            this.StepInputTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.StepInputTextBox.Name = "StepInputTextBox";
            this.StepInputTextBox.Size = new System.Drawing.Size(132, 22);
            this.StepInputTextBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 130);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Крок";
            // 
            // NumberOfTestInputTextBox
            // 
            this.NumberOfTestInputTextBox.Location = new System.Drawing.Point(83, 175);
            this.NumberOfTestInputTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.NumberOfTestInputTextBox.Name = "NumberOfTestInputTextBox";
            this.NumberOfTestInputTextBox.Size = new System.Drawing.Size(132, 22);
            this.NumberOfTestInputTextBox.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 178);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Повтори";
            // 
            // DrawSizeGraph
            // 
            this.DrawSizeGraph.Location = new System.Drawing.Point(20, 267);
            this.DrawSizeGraph.Margin = new System.Windows.Forms.Padding(4);
            this.DrawSizeGraph.Name = "DrawSizeGraph";
            this.DrawSizeGraph.Size = new System.Drawing.Size(196, 28);
            this.DrawSizeGraph.TabIndex = 3;
            this.DrawSizeGraph.Text = "Визначити точність алгоритмів";
            this.DrawSizeGraph.UseVisualStyleBackColor = true;
            this.DrawSizeGraph.Click += new System.EventHandler(this.DrawSizeGraph_Click);
            // 
            // LoadingBox
            // 
            this.LoadingBox.Location = new System.Drawing.Point(263, 55);
            this.LoadingBox.Margin = new System.Windows.Forms.Padding(4);
            this.LoadingBox.Name = "LoadingBox";
            this.LoadingBox.Size = new System.Drawing.Size(923, 463);
            this.LoadingBox.TabIndex = 4;
            this.LoadingBox.TabStop = false;
            // 
            // DrawSizeGraphCancel
            // 
            this.DrawSizeGraphCancel.Location = new System.Drawing.Point(20, 316);
            this.DrawSizeGraphCancel.Margin = new System.Windows.Forms.Padding(4);
            this.DrawSizeGraphCancel.Name = "DrawSizeGraphCancel";
            this.DrawSizeGraphCancel.Size = new System.Drawing.Size(100, 28);
            this.DrawSizeGraphCancel.TabIndex = 3;
            this.DrawSizeGraphCancel.Text = "Відмінити";
            this.DrawSizeGraphCancel.UseVisualStyleBackColor = true;
            this.DrawSizeGraphCancel.Click += new System.EventHandler(this.DrawSizeGraphCancel_Click);
            // 
            // TimeGraph
            // 
            chartArea4.Name = "ChartArea1";
            this.TimeGraph.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.TimeGraph.Legends.Add(legend4);
            this.TimeGraph.Location = new System.Drawing.Point(263, 576);
            this.TimeGraph.Margin = new System.Windows.Forms.Padding(4);
            this.TimeGraph.Name = "TimeGraph";
            series10.ChartArea = "ChartArea1";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series10.Legend = "Legend1";
            series10.Name = "Genetic";
            series11.ChartArea = "ChartArea1";
            series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series11.Legend = "Legend1";
            series11.Name = "Greedy";
            series12.ChartArea = "ChartArea1";
            series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series12.Legend = "Legend1";
            series12.Name = "Frequancy";
            this.TimeGraph.Series.Add(series10);
            this.TimeGraph.Series.Add(series11);
            this.TimeGraph.Series.Add(series12);
            this.TimeGraph.Size = new System.Drawing.Size(923, 463);
            this.TimeGraph.TabIndex = 0;
            this.TimeGraph.Text = "chart1";
            // 
            // TimeLoadingBox
            // 
            this.TimeLoadingBox.Location = new System.Drawing.Point(263, 576);
            this.TimeLoadingBox.Margin = new System.Windows.Forms.Padding(4);
            this.TimeLoadingBox.Name = "TimeLoadingBox";
            this.TimeLoadingBox.Size = new System.Drawing.Size(923, 463);
            this.TimeLoadingBox.TabIndex = 4;
            this.TimeLoadingBox.TabStop = false;
            // 
            // DrawTimeGraphButton
            // 
            this.DrawTimeGraphButton.Location = new System.Drawing.Point(20, 576);
            this.DrawTimeGraphButton.Margin = new System.Windows.Forms.Padding(4);
            this.DrawTimeGraphButton.Name = "DrawTimeGraphButton";
            this.DrawTimeGraphButton.Size = new System.Drawing.Size(196, 28);
            this.DrawTimeGraphButton.TabIndex = 3;
            this.DrawTimeGraphButton.Text = "Визначити час роботи алгоритмів";
            this.DrawTimeGraphButton.UseVisualStyleBackColor = true;
            this.DrawTimeGraphButton.Click += new System.EventHandler(this.DrawSpeedGraph_Click);
            // 
            // CancelDrawTimeGraphButton
            // 
            this.CancelDrawTimeGraphButton.Location = new System.Drawing.Point(20, 628);
            this.CancelDrawTimeGraphButton.Margin = new System.Windows.Forms.Padding(4);
            this.CancelDrawTimeGraphButton.Name = "CancelDrawTimeGraphButton";
            this.CancelDrawTimeGraphButton.Size = new System.Drawing.Size(100, 28);
            this.CancelDrawTimeGraphButton.TabIndex = 3;
            this.CancelDrawTimeGraphButton.Text = "Відмінити";
            this.CancelDrawTimeGraphButton.UseVisualStyleBackColor = true;
            this.CancelDrawTimeGraphButton.Click += new System.EventHandler(this.DrawSpeedGraphCancel_Click);
            // 
            // Graphs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1006, 559);
            this.Controls.Add(this.TimeLoadingBox);
            this.Controls.Add(this.LoadingBox);
            this.Controls.Add(this.CancelDrawTimeGraphButton);
            this.Controls.Add(this.DrawTimeGraphButton);
            this.Controls.Add(this.DrawSizeGraphCancel);
            this.Controls.Add(this.DrawSizeGraph);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NumberOfTestInputTextBox);
            this.Controls.Add(this.StepInputTextBox);
            this.Controls.Add(this.LastInputTextBox);
            this.Controls.Add(this.FirstInputTextBox);
            this.Controls.Add(this.TimeGraph);
            this.Controls.Add(this.SizeGraph);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Graphs";
            this.Text = "Побудова графіків";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Graphs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SizeGraph)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoadingBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimeGraph)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimeLoadingBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart SizeGraph;
        private System.Windows.Forms.TextBox FirstInputTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox LastInputTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox StepInputTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NumberOfTestInputTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button DrawSizeGraph;
        private System.Windows.Forms.PictureBox LoadingBox;
        private System.Windows.Forms.Button DrawSizeGraphCancel;
        private System.Windows.Forms.DataVisualization.Charting.Chart TimeGraph;
        private System.Windows.Forms.PictureBox TimeLoadingBox;
        private System.Windows.Forms.Button DrawTimeGraphButton;
        private System.Windows.Forms.Button CancelDrawTimeGraphButton;
    }
}