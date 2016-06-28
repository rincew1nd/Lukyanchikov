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
    public partial class Form1 : Form
    {
        private string _path;

        public Form1()
        {
            InitializeComponent();

            _path = Directory.GetCurrentDirectory() + @"\test.txt";
            var file = FileParser.GetInstance();
            file.ParseBooks(_path);
            file.AddBook("test", 1, 23);
            file.SaveBooks(_path);
        }
    }
}
