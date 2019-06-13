namespace UI
{
    partial class AlgorithmForm
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
            this.OriginMatrix = new System.Windows.Forms.DataGridView();
            this.ResultMatrix = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TimeWork = new System.Windows.Forms.Label();
            this.FunctionResult = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.OriginMatrix)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResultMatrix)).BeginInit();
            this.SuspendLayout();
            // 
            // OriginMatrix
            // 
            this.OriginMatrix.AllowUserToAddRows = false;
            this.OriginMatrix.AllowUserToDeleteRows = false;
            this.OriginMatrix.AllowUserToResizeColumns = false;
            this.OriginMatrix.AllowUserToResizeRows = false;
            this.OriginMatrix.BackgroundColor = System.Drawing.Color.White;
            this.OriginMatrix.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OriginMatrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OriginMatrix.Location = new System.Drawing.Point(1, 100);
            this.OriginMatrix.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.OriginMatrix.Name = "OriginMatrix";
            this.OriginMatrix.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.OriginMatrix.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.OriginMatrix.Size = new System.Drawing.Size(740, 373);
            this.OriginMatrix.TabIndex = 0;
            // 
            // ResultMatrix
            // 
            this.ResultMatrix.AllowUserToAddRows = false;
            this.ResultMatrix.AllowUserToDeleteRows = false;
            this.ResultMatrix.AllowUserToResizeColumns = false;
            this.ResultMatrix.AllowUserToResizeRows = false;
            this.ResultMatrix.BackgroundColor = System.Drawing.Color.White;
            this.ResultMatrix.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ResultMatrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ResultMatrix.Location = new System.Drawing.Point(1, 625);
            this.ResultMatrix.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ResultMatrix.Name = "ResultMatrix";
            this.ResultMatrix.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.ResultMatrix.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.ResultMatrix.Size = new System.Drawing.Size(740, 373);
            this.ResultMatrix.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(762, 100);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Час роботи";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(762, 139);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(319, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Значення цільової функції";
            // 
            // TimeWork
            // 
            this.TimeWork.AutoSize = true;
            this.TimeWork.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TimeWork.Location = new System.Drawing.Point(1094, 99);
            this.TimeWork.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TimeWork.Name = "TimeWork";
            this.TimeWork.Size = new System.Drawing.Size(0, 29);
            this.TimeWork.TabIndex = 1;
            // 
            // FunctionResult
            // 
            this.FunctionResult.AutoSize = true;
            this.FunctionResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FunctionResult.Location = new System.Drawing.Point(1094, 139);
            this.FunctionResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FunctionResult.Name = "FunctionResult";
            this.FunctionResult.Size = new System.Drawing.Size(0, 29);
            this.FunctionResult.TabIndex = 1;
            // 
            // AlgorithmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1248, 998);
            this.Controls.Add(this.FunctionResult);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TimeWork);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ResultMatrix);
            this.Controls.Add(this.OriginMatrix);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AlgorithmForm";
            this.Text = "AlgorithmForm";
            ((System.ComponentModel.ISupportInitialize)(this.OriginMatrix)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResultMatrix)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView OriginMatrix;
        private System.Windows.Forms.DataGridView ResultMatrix;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label TimeWork;
        private System.Windows.Forms.Label FunctionResult;
    }
}