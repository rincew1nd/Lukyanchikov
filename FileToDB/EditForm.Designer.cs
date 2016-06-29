namespace FileToDB
{
	partial class EditForm
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.temp_button = new System.Windows.Forms.Button();
			this.cancel_button = new System.Windows.Forms.Button();
			this.bookName = new System.Windows.Forms.TextBox();
			this.bookCount = new System.Windows.Forms.TextBox();
			this.bookPrice = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(35, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Name";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 46);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(35, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Count";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 72);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(31, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Price";
			// 
			// temp_button
			// 
			this.temp_button.Location = new System.Drawing.Point(12, 95);
			this.temp_button.Name = "temp_button";
			this.temp_button.Size = new System.Drawing.Size(75, 23);
			this.temp_button.TabIndex = 3;
			this.temp_button.Text = "temp text";
			this.temp_button.UseVisualStyleBackColor = true;
			this.temp_button.Click += new System.EventHandler(this.temp_button_Click);
			// 
			// cancel_button
			// 
			this.cancel_button.Location = new System.Drawing.Point(106, 95);
			this.cancel_button.Name = "cancel_button";
			this.cancel_button.Size = new System.Drawing.Size(75, 23);
			this.cancel_button.TabIndex = 4;
			this.cancel_button.Text = "Cancel";
			this.cancel_button.UseVisualStyleBackColor = true;
			this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
			// 
			// bookName
			// 
			this.bookName.Location = new System.Drawing.Point(81, 17);
			this.bookName.Name = "bookName";
			this.bookName.Size = new System.Drawing.Size(100, 20);
			this.bookName.TabIndex = 5;
			// 
			// bookCount
			// 
			this.bookCount.Location = new System.Drawing.Point(81, 43);
			this.bookCount.Name = "bookCount";
			this.bookCount.Size = new System.Drawing.Size(100, 20);
			this.bookCount.TabIndex = 6;
			// 
			// bookPrice
			// 
			this.bookPrice.Location = new System.Drawing.Point(81, 69);
			this.bookPrice.Name = "bookPrice";
			this.bookPrice.Size = new System.Drawing.Size(100, 20);
			this.bookPrice.TabIndex = 7;
			// 
			// EditForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(193, 134);
			this.Controls.Add(this.bookPrice);
			this.Controls.Add(this.bookCount);
			this.Controls.Add(this.bookName);
			this.Controls.Add(this.cancel_button);
			this.Controls.Add(this.temp_button);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "EditForm";
			this.Text = "EditForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button temp_button;
		private System.Windows.Forms.Button cancel_button;
		private System.Windows.Forms.TextBox bookName;
		private System.Windows.Forms.TextBox bookCount;
		private System.Windows.Forms.TextBox bookPrice;
	}
}