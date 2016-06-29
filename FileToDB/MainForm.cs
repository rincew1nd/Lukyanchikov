using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileToDB
{
    public partial class MainForm : Form
    {
        private string _path;
		private FileParser _fileParser;

        public MainForm()
        {
            InitializeComponent();

			_path = Directory.GetCurrentDirectory() + Path.DirectorySeparatorChar + "test.txt";
			_fileParser = FileParser.GetInstance();
			_fileParser.SetDataGridView(Table);
        }

		private void AddBook(object sender, EventArgs e)
		{
			EditForm editForm = new EditForm(false);
			editForm.ShowDialog();
			_fileParser.AddBook(editForm.BookName, editForm.BookCount, editForm.BookPrice);
		}

		private void DeleteBook(object sender, EventArgs e)
		{
			foreach (DataGridViewRow row in Table.SelectedRows)
			{
				var bookName = (string)row.Cells[0].Value;
				_fileParser.DeleteBook(bookName);
			}
		}

		private void ModifyBook(object sender, EventArgs e)
		{
			foreach (DataGridViewRow row in Table.SelectedRows)
			{
				var bookName = (string)row.Cells[0].Value;
				var bookCount = (int)row.Cells[1].Value;
				var bookPrice = (double)row.Cells[2].Value;

				EditForm editForm = new EditForm(true, bookName, bookCount, bookPrice);
				editForm.ShowDialog();
				_fileParser.ModifyBook(bookName, editForm.BookName, editForm.BookCount, editForm.BookPrice);
			}
		}

		private void SaveBooks(object sender, EventArgs e)
		{
			_fileParser.SaveBooks(_path);
		}

		private void LoadBooks(object sender, EventArgs e)
		{
			_fileParser.ParseBooks(_path);
		}

		public static bool IsLinux
		{
			get
			{
				int p = (int)Environment.OSVersion.Platform;
				return (p == 4) || (p == 6) || (p == 128);
			}
		}
	}
}
