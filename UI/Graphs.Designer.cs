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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            chartArea1.Name = "ChartArea1";
            this.SizeGraph.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.SizeGraph.Legends.Add(legend1);
            this.SizeGraph.Location = new System.Drawing.Point(197, 45);
            this.SizeGraph.Name = "SizeGraph";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Genetic";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Greedy";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "Frequancy";
            this.SizeGraph.Series.Add(series1);
            this.SizeGraph.Series.Add(series2);
            this.SizeGraph.Series.Add(series3);
            this.SizeGraph.Size = new System.Drawing.Size(692, 376);
            this.SizeGraph.TabIndex = 0;
            this.SizeGraph.Text = "chart1";
            // 
            // FirstInputTextBox
            // 
            this.FirstInputTextBox.Location = new System.Drawing.Point(62, 42);
            this.FirstInputTextBox.Name = "FirstInputTextBox";
            this.FirstInputTextBox.Size = new System.Drawing.Size(100, 20);
            this.FirstInputTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Початок";
            // 
            // LastInputTextBox
            // 
            this.LastInputTextBox.Location = new System.Drawing.Point(62, 68);
            this.LastInputTextBox.Name = "LastInputTextBox";
            this.LastInputTextBox.Size = new System.Drawing.Size(100, 20);
            this.LastInputTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Кінець";
            // 
            // StepInputTextBox
            // 
            this.StepInputTextBox.Location = new System.Drawing.Point(62, 103);
            this.StepInputTextBox.Name = "StepInputTextBox";
            this.StepInputTextBox.Size = new System.Drawing.Size(100, 20);
            this.StepInputTextBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Крок";
            // 
            // NumberOfTestInputTextBox
            // 
            this.NumberOfTestInputTextBox.Location = new System.Drawing.Point(62, 142);
            this.NumberOfTestInputTextBox.Name = "NumberOfTestInputTextBox";
            this.NumberOfTestInputTextBox.Size = new System.Drawing.Size(100, 20);
            this.NumberOfTestInputTextBox.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Повтори";
            // 
            // DrawSizeGraph
            // 
            this.DrawSizeGraph.Location = new System.Drawing.Point(15, 217);
            this.DrawSizeGraph.Name = "DrawSizeGraph";
            this.DrawSizeGraph.Size = new System.Drawing.Size(147, 23);
            this.DrawSizeGraph.TabIndex = 3;
            this.DrawSizeGraph.Text = "Визначити точність алгоритмів";
            this.DrawSizeGraph.UseVisualStyleBackColor = true;
            this.DrawSizeGraph.Click += new System.EventHandler(this.DrawSizeGraph_Click);
            // 
            // LoadingBox
            // 
            this.LoadingBox.Location = new System.Drawing.Point(197, 45);
            this.LoadingBox.Name = "LoadingBox";
            this.LoadingBox.Size = new System.Drawing.Size(692, 376);
            this.LoadingBox.TabIndex = 4;
            this.LoadingBox.TabStop = false;
            // 
            // DrawSizeGraphCancel
            // 
            this.DrawSizeGraphCancel.Location = new System.Drawing.Point(15, 257);
            this.DrawSizeGraphCancel.Name = "DrawSizeGraphCancel";
            this.DrawSizeGraphCancel.Size = new System.Drawing.Size(75, 23);
            this.DrawSizeGraphCancel.TabIndex = 3;
            this.DrawSizeGraphCancel.Text = "Відмінити";
            this.DrawSizeGraphCancel.UseVisualStyleBackColor = true;
            this.DrawSizeGraphCancel.Click += new System.EventHandler(this.DrawSizeGraphCancel_Click);
            // 
            // TimeGraph
            // 
            chartArea2.Name = "ChartArea1";
            this.TimeGraph.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.TimeGraph.Legends.Add(legend2);
            this.TimeGraph.Location = new System.Drawing.Point(197, 468);
            this.TimeGraph.Name = "TimeGraph";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Legend = "Legend1";
            series4.Name = "Genetic";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Legend = "Legend1";
            series5.Name = "Greedy";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Legend = "Legend1";
            series6.Name = "Frequancy";
            this.TimeGraph.Series.Add(series4);
            this.TimeGraph.Series.Add(series5);
            this.TimeGraph.Series.Add(series6);
            this.TimeGraph.Size = new System.Drawing.Size(692, 376);
            this.TimeGraph.TabIndex = 0;
            this.TimeGraph.Text = "chart1";
            // 
            // TimeLoadingBox
            // 
            this.TimeLoadingBox.Location = new System.Drawing.Point(197, 468);
            this.TimeLoadingBox.Name = "TimeLoadingBox";
            this.TimeLoadingBox.Size = new System.Drawing.Size(692, 376);
            this.TimeLoadingBox.TabIndex = 4;
            this.TimeLoadingBox.TabStop = false;
            // 
            // DrawTimeGraphButton
            // 
            this.DrawTimeGraphButton.Location = new System.Drawing.Point(15, 468);
            this.DrawTimeGraphButton.Name = "DrawTimeGraphButton";
            this.DrawTimeGraphButton.Size = new System.Drawing.Size(147, 23);
            this.DrawTimeGraphButton.TabIndex = 3;
            this.DrawTimeGraphButton.Text = "Визначити час роботи алгоритмів";
            this.DrawTimeGraphButton.UseVisualStyleBackColor = true;
            this.DrawTimeGraphButton.Click += new System.EventHandler(this.DrawSpeedGraph_Click);
            // 
            // CancelDrawTimeGraphButton
            // 
            this.CancelDrawTimeGraphButton.Location = new System.Drawing.Point(15, 510);
            this.CancelDrawTimeGraphButton.Name = "CancelDrawTimeGraphButton";
            this.CancelDrawTimeGraphButton.Size = new System.Drawing.Size(75, 23);
            this.CancelDrawTimeGraphButton.TabIndex = 3;
            this.CancelDrawTimeGraphButton.Text = "Відмінити";
            this.CancelDrawTimeGraphButton.UseVisualStyleBackColor = true;
            this.CancelDrawTimeGraphButton.Click += new System.EventHandler(this.DrawSpeedGraphCancel_Click);
            // 
            // Graphs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1356, 882);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Graphs";
            this.Text = "Побудова графів";
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