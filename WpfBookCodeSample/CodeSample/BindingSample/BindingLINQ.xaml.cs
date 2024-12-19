using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows;
using System.Xml.Linq;
using WpfBookCodeSample.Model;
using Path = System.IO.Path;

namespace WpfBookCodeSample.CodeSample.BindingSample
{
    /// <summary>
    /// Interaction logic for BindingLINQ.xaml
    /// </summary>
    public partial class BindingLINQ : Window
    {
        private const string FILE_PATH = @"../../XML/TestData.xml";

        public BindingLINQ()
        {
            InitializeComponent();
            //BindingDataByCollection();
            //BindingDataByDataTable();
            BindingDataByXml();
        }

        private void BindingDataByCollection()
        {
            List<Teacher> infos = new List<Teacher>()
            {
                new Teacher(){Id=1, Age=29, Name="Tim"},
                new Teacher(){Id=1, Age=28, Name="Tom"},
                new Teacher(){Id=1, Age=27, Name="Kyle"},
                new Teacher(){Id=1, Age=26, Name="Tony"},
                new Teacher(){Id=1, Age=25, Name="Vina"},
                new Teacher(){Id=1, Age=24, Name="Mike"}
            };
            listView1.ItemsSource = from teacher in infos where teacher.Name.StartsWith("T") select teacher;
        }

        private void BindingDataByDataTable()
        {
            DataTable dtInfo = CreateDataTable();
            this.listView1.ItemsSource = from row in dtInfo.Rows.Cast<DataRow>()
                where Convert.ToString(row["Name"]).StartsWith("T")
                select new Teacher()
                {
                    Id = Convert.ToInt32(row["Id"]),
                    Name = Convert.ToString(row["Name"]),
                    Age = Convert.ToInt32(row["Age"])
                };

        }

        private void BindingDataByXml()
        {
            var currentPath = Directory.GetCurrentDirectory();

            XDocument xd = XDocument.Load(Path.Combine(@currentPath, FILE_PATH));

            this.listView1.ItemsSource = from element in xd.Descendants("Teacher")
                where element.Attribute("Name").Value.StartsWith("T")
                select new Teacher()
                {
                    Name = element.Attribute("Name").Value,
                    Id = Convert.ToInt32(element.Attribute("Id").Value),
                    Age = Convert.ToInt32(element.Attribute("Age").Value)
                };
        }

        private DataTable CreateDataTable()
        {
            DataTable dt = new DataTable("newtable");

            DataColumn[] columns = new DataColumn[]
            {
                new DataColumn("Id"), 
                new DataColumn("Name"), 
                new DataColumn("Age")
            };
            dt.Columns.AddRange(columns);

            DataRow workRow;

            for (int i = 0; i <= 9; i++)
            {
                workRow = dt.NewRow();
                workRow[0] = i;
                workRow[1] = "Tim" + i;
                workRow[2] = 20 + i;
                dt.Rows.Add(workRow);
            }

            return dt;
        }
    }
}
