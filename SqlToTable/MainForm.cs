using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace SqlToTable
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            QueryString.Text = "SELECT * FROM items WHERE characterId = 3";
        }

        private void Execute_ButtonClick(object sender, EventArgs e)
        {
            var msql = new MySql(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + Path.DirectorySeparatorChar + "settings.xml");
            msql.ExecuteToTable(QueryString.Text, ResultTable);
        }
    }
}
