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
            this.OriginMatrix.Location = new System.Drawing.Point(1, 81);
            this.OriginMatrix.Name = "OriginMatrix";
            this.OriginMatrix.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.OriginMatrix.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.OriginMatrix.Size = new System.Drawing.Size(555, 303);
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
            this.ResultMatrix.Location = new System.Drawing.Point(1, 508);
            this.ResultMatrix.Name = "ResultMatrix";
            this.ResultMatrix.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.ResultMatrix.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.ResultMatrix.Size = new System.Drawing.Size(555, 303);
            this.ResultMatrix.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(630, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Час роботи";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(630, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Значення цільофої функції";
            // 
            // TimeWork
            // 
            this.TimeWork.AutoSize = true;
            this.TimeWork.Location = new System.Drawing.Point(786, 81);
            this.TimeWork.Name = "TimeWork";
            this.TimeWork.Size = new System.Drawing.Size(0, 13);
            this.TimeWork.TabIndex = 1;
            // 
            // FunctionResult
            // 
            this.FunctionResult.AutoSize = true;
            this.FunctionResult.Location = new System.Drawing.Point(786, 114);
            this.FunctionResult.Name = "FunctionResult";
            this.FunctionResult.Size = new System.Drawing.Size(0, 13);
            this.FunctionResult.TabIndex = 1;
            // 
            // AlgorithmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(936, 811);
            this.Controls.Add(this.FunctionResult);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TimeWork);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ResultMatrix);
            this.Controls.Add(this.OriginMatrix);
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