namespace SqlToTable
{
    partial class MainForm
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
            this.ResultTable = new System.Windows.Forms.DataGridView();
            this.QueryString = new System.Windows.Forms.TextBox();
            this.Execute = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ResultTable)).BeginInit();
            this.SuspendLayout();
            // 
            // ResultTable
            // 
            this.ResultTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ResultTable.Location = new System.Drawing.Point(12, 12);
            this.ResultTable.Name = "ResultTable";
            this.ResultTable.Size = new System.Drawing.Size(671, 149);
            this.ResultTable.TabIndex = 0;
            // 
            // QueryString
            // 
            this.QueryString.Location = new System.Drawing.Point(12, 170);
            this.QueryString.Name = "QueryString";
            this.QueryString.Size = new System.Drawing.Size(590, 20);
            this.QueryString.TabIndex = 1;
            // 
            // Execute
            // 
            this.Execute.Location = new System.Drawing.Point(608, 168);
            this.Execute.Name = "Execute";
            this.Execute.Size = new System.Drawing.Size(75, 23);
            this.Execute.TabIndex = 2;
            this.Execute.Text = "Execute";
            this.Execute.UseVisualStyleBackColor = true;
            this.Execute.Click += new System.EventHandler(this.Execute_ButtonClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 201);
            this.Controls.Add(this.Execute);
            this.Controls.Add(this.QueryString);
            this.Controls.Add(this.ResultTable);
            this.Name = "Form1";
            this.Text = "Sql to table";
            ((System.ComponentModel.ISupportInitialize)(this.ResultTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView ResultTable;
        private System.Windows.Forms.TextBox QueryString;
        private System.Windows.Forms.Button Execute;
    }
}

