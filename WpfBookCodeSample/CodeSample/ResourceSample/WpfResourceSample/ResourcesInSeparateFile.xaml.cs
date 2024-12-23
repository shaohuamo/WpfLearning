using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WpfBookCodeSample.Model;

namespace WpfBookCodeSample.CodeSample.ResourceSample.WpfResourceSample
{
    /// <summary>
    /// Interaction logic for ResourcesInSeparateFile.xaml
    /// </summary>
    public partial class ResourcesInSeparateFile : Window
    {
        public ResourcesInSeparateFile()
        {
            InitializeComponent();
            var empList = new List<Employee>()
            {
                new Employee() { Id = 1, Age = 12, Name = "test1" },
                new Employee() { Id = 2, Age = 12, Name = "test2" },
                new Employee() { Id = 3, Age = 12, Name = "test3" },
                new Employee() { Id = 4, Age = 12, Name = "test4" },
                new Employee() { Id = 5, Age = 12, Name = "test5" },
            };

            listBoxEmployee.DisplayMemberPath = "Name";
            listBoxEmployee.SelectedValuePath = "Id";
            listBoxEmployee.ItemsSource = empList;
        }
    }
}
