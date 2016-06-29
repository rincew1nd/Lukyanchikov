using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileToDB
{
	public partial class EditForm : Form
	{
		public string Name;
		public int Count;
		public double Price;

		public EditForm(bool isEdit, string name = "", int count = 0, double price = 0)
		{
			InitializeComponent();

			if (isEdit)
				temp_button.Text = "Edit";
			else
				temp_button.Text = "Add";

			bookName.Text = name;
			bookCount.Text = count.ToString();
			bookPrice.Text = price.ToString();
		}

		private void temp_button_Click(object sender, EventArgs e)
		{
			if (bookName.Text != "" &&
				int.TryParse(bookCount.Text, out Count) &&
				double.TryParse(bookPrice.Text, out Price))
			{
				Name = bookName.Text;
				this.Close();
			}
			else
				MessageBox.Show("Неправильно заполнены поля!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		private void cancel_button_Click(object sender, EventArgs e)
		{
			bookName.Text = "";
			bookCount.Text = "0";
			bookPrice.Text = "0";
			this.Close();
		}
	}
}
