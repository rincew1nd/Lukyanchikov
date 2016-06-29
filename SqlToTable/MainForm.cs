using System;
using System.IO;
using System.Windows.Forms;

namespace SqlToTable
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            QueryString.Text = "SELECT * FROM Test WHERE ID = '3'";
        }

        private void Execute_ButtonClick(object sender, EventArgs e)
        {
            var msql = new MySql(Directory.GetCurrentDirectory() + Path.DirectorySeparatorChar + "settings.xml");
            msql.ExecuteToTable(QueryString.Text, ResultTable);
        }
    }
}
