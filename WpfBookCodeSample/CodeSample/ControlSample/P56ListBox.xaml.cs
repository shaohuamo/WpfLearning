using System.Collections.Generic;
using System.Windows;
using WpfBookCodeSample.Model;

namespace WpfBookCodeSample.CodeSample.ControlSample
{
    /// <summary>
    /// Interaction logic for P56ListBox.xaml
    /// </summary>
    public partial class P56ListBox : Window
    {
        public P56ListBox()
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
