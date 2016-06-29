using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileToDB
{
    class FileParser
    {
        //При работе со списками структурированной информацией использовать контейнер QMap
        //и сохранять всю информацию в текстовый файл произвольного вида

        private Dictionary<string, Book> _books;
		private DataGridView _table;

        private static FileParser instance;
        private FileParser()
        {
            _books = new Dictionary<string, Book>();
        }

		internal void SetDataGridView(DataGridView table)
		{
			_table = table;
        }

		public static FileParser GetInstance()
        {
            if (instance == null)
                instance = new FileParser();
            return instance;
        }

        public void ParseBooks(string path)
        {
			_table.Rows.Clear();
			_books.Clear();
            foreach (var line in File.ReadAllLines(path))
            {
                var elements = line.Split(';');
                this.AddBook(
                    elements[0],
                    int.Parse(elements[1]),
                    double.Parse(
						(IsLinux) ?
						elements[2].Replace(',', '.') :
						elements[2].Replace('.', ',')
					)
                );
			}
			FillDataGridView();
		}

        public void SaveBooks(string path)
        {
            var books = _books.Values.ToList().ConvertAll(z => z.ToString());
            File.WriteAllLines(path, books);
			FillDataGridView();
		}

        public void AddBook(string name, int count, double price)
        {
            if(!_books.ContainsKey(name))
                _books.Add(
                    name,
                    new Book()
                    {
                        Name = name,
                        Count = count,
                        Price = price
                    }
                );
			else
				MessageBox.Show("Книга с таким названием уже существует", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			FillDataGridView();
		}

        public void DeleteBook(string name)
        {
            if (_books.ContainsKey(name))
                _books.Remove(name);
			else
				MessageBox.Show("Книги с таким названием не существует", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			FillDataGridView();
		}

        public void ModifyBook(string oldName, string name, int count, double price)
        {
            if (!_books.ContainsKey(oldName))
				MessageBox.Show("Изменяемой книги не найдено", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			else if (_books.ContainsKey(name) && name != oldName)
				MessageBox.Show("Попытка изменить книгу на уже существующую", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			else
			{
				_books.Remove(oldName);
				AddBook(name, count, price);
			}
			FillDataGridView();
        }

		public void FillDataGridView()
		{
			_table.Rows.Clear();
			int i = 0;
			foreach(var book in _books.Values)
			{
				_table.Rows.Insert(i, book.Name, book.Count, book.Price);
				i++;
			}
		}

		public bool IsLinux
		{
			get
			{
				int p = (int)Environment.OSVersion.Platform;
				return (p == 4) || (p == 6) || (p == 128);
			}
		}
	}

    class Book
    {
        public string Name;
        public int Count;
        public double Price;

        public override string ToString()
        {
            return Name + ";" + Count + ";" + Price;
        }
    }
}
