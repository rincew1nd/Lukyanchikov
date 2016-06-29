using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace SqlToTable
{
    class MySql
    {
        //Настройки подключения к БД хранят в файле формата *.xml
        //для работы с которым используется класс QDomDocument
        private XmlSettings _settings;
        
        public MySql(string path)
        {
            var formatter = new XmlSerializer(typeof(XmlSettings));
            using (var fs = new FileStream(path, FileMode.OpenOrCreate))
                _settings = (XmlSettings)formatter.Deserialize(fs);
        }

        public void ExecuteToTable(string query, DataGridView table)
        {
            var test = RunSomething(query);

            table.AutoGenerateColumns = true;
            table.DataSource = test;
            table.DataMember = "Table";
        }

        private DataSet RunSomething(string queryd)
        {
            try
            {
                using (var cnn = new SqlConnection(
                    "Data Source=" + _settings.Host +
                    "; User ID=" + _settings.User +
                    "; Password=" + _settings.Password +
                    "; Connection Timeout=120;"))
                {
                    var dataAdapter = new SqlDataAdapter();
                    var command = new SqlCommand(queryd, cnn);
                    var dataSet = new DataSet();

                    command.CommandText = queryd;
                    dataAdapter.SelectCommand = command;
                    dataAdapter.Fill(dataSet);

                    return dataSet;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
    }
}
