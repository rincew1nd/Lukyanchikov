namespace FileToDB
{
    partial class MainWindow
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
			this.Table = new System.Windows.Forms.DataGridView();
			this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.AddBook_Button = new System.Windows.Forms.Button();
			this.DeleteBook_Button = new System.Windows.Forms.Button();
			this.ModifyBook_Button = new System.Windows.Forms.Button();
			this.LoadBooks_Button = new System.Windows.Forms.Button();
			this.SaveBooks_Button = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.Table)).BeginInit();
			this.SuspendLayout();
			// 
			// Table
			// 
			this.Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.Table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
				this.ColumnName,
				this.ColumnCount,
				this.ColumnPrice
			});
			this.Table.Location = new System.Drawing.Point(12, 12);
			this.Table.Name = "dataGridView1";
			this.Table.Size = new System.Drawing.Size(343, 208);
			this.Table.TabIndex = 0;
			// 
			// Name
			// 
			this.ColumnName.HeaderText = "Name";
			this.ColumnName.Name = "Name";
			this.ColumnName.ReadOnly = true;
			// 
			// Count
			// 
			this.ColumnCount.HeaderText = "Count";
			this.ColumnCount.Name = "Count";
			this.ColumnCount.ReadOnly = true;
			// 
			// Price
			// 
			this.ColumnPrice.HeaderText = "Price";
			this.ColumnPrice.Name = "Price";
			this.ColumnPrice.ReadOnly = true;
			// 
			// button1
			// 
			this.AddBook_Button.Location = new System.Drawing.Point(12, 226);
			this.AddBook_Button.Name = "button1";
			this.AddBook_Button.Size = new System.Drawing.Size(64, 23);
			this.AddBook_Button.TabIndex = 1;
			this.AddBook_Button.Text = "Add";
			this.AddBook_Button.UseVisualStyleBackColor = true;
			this.AddBook_Button.Click += new System.EventHandler(this.AddBook);
			// 
			// button2
			// 
			this.DeleteBook_Button.Location = new System.Drawing.Point(82, 226);
			this.DeleteBook_Button.Name = "button2";
			this.DeleteBook_Button.Size = new System.Drawing.Size(63, 23);
			this.DeleteBook_Button.TabIndex = 2;
			this.DeleteBook_Button.Text = "Delete";
			this.DeleteBook_Button.UseVisualStyleBackColor = true;
			this.DeleteBook_Button.Click += new System.EventHandler(this.DeleteBook);
			// 
			// button3
			// 
			this.ModifyBook_Button.Location = new System.Drawing.Point(151, 226);
			this.ModifyBook_Button.Name = "button3";
			this.ModifyBook_Button.Size = new System.Drawing.Size(64, 23);
			this.ModifyBook_Button.TabIndex = 3;
			this.ModifyBook_Button.Text = "Modify";
			this.ModifyBook_Button.UseVisualStyleBackColor = true;
			this.ModifyBook_Button.Click += new System.EventHandler(this.ModifyBook);
			// 
			// button4
			// 
			this.SaveBooks_Button.Location = new System.Drawing.Point(221, 226);
			this.SaveBooks_Button.Name = "button4";
			this.SaveBooks_Button.Size = new System.Drawing.Size(65, 23);
			this.SaveBooks_Button.TabIndex = 4;
			this.SaveBooks_Button.Text = "Save";
			this.SaveBooks_Button.UseVisualStyleBackColor = true;
			this.SaveBooks_Button.Click += new System.EventHandler(this.SaveBooks);
			// 
			// button5
			// 
			this.LoadBooks_Button.Location = new System.Drawing.Point(292, 226);
			this.LoadBooks_Button.Name = "button5";
			this.LoadBooks_Button.Size = new System.Drawing.Size(63, 23);
			this.LoadBooks_Button.TabIndex = 5;
			this.LoadBooks_Button.Text = "Load";
			this.LoadBooks_Button.UseVisualStyleBackColor = true;
			this.LoadBooks_Button.Click += new System.EventHandler(this.LoadBooks);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(367, 261);
			this.Controls.Add(this.LoadBooks_Button);
			this.Controls.Add(this.SaveBooks_Button);
			this.Controls.Add(this.ModifyBook_Button);
			this.Controls.Add(this.DeleteBook_Button);
			this.Controls.Add(this.AddBook_Button);
			this.Controls.Add(this.Table);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.Table)).EndInit();
			this.ResumeLayout(false);

        }

		#endregion

		private System.Windows.Forms.DataGridView Table;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCount;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPrice;
		private System.Windows.Forms.Button AddBook_Button;
		private System.Windows.Forms.Button DeleteBook_Button;
		private System.Windows.Forms.Button ModifyBook_Button;
		private System.Windows.Forms.Button SaveBooks_Button;
		private System.Windows.Forms.Button LoadBooks_Button;
	}
}

