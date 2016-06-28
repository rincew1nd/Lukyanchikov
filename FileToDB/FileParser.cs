using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileToDB
{
    class FileParser
    {
        //При работе со списками структурированной информацией использовать контейнер QMap
        //и сохранять всю информацию в текстовый файл произвольного вида

        private Dictionary<string, Book> _books;

        private static FileParser instance;
        private FileParser()
        {
            _books = new Dictionary<string, Book>();
        }
        public static FileParser GetInstance()
        {
            if (instance == null)
                instance = new FileParser();
            return instance;
        }

        public void ParseBooks(string path)
        {
            foreach (var line in File.ReadAllLines(path))
            {
                var elements = line.Split(';');
                this.AddBook(
                    elements[0],
                    int.Parse(elements[1]),
                    double.Parse(elements[2])
                );
            }
        }

        public void SaveBooks(string path)
        {
            var books = _books.Values.ToList().ConvertAll(z => z.ToString());
            File.WriteAllLines(path, books);
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
        }

        public void DeleteBook(string name)
        {
            if (_books.ContainsKey(name))
                _books.Remove(name);
        }

        public void ModifyBook(string name, int count, double price)
        {
            if (_books.ContainsKey(name))
            {
                _books.Remove(name);
                AddBook(name, count, price);
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
