using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace WpfBookCodeSample.ControlSample.BindingSample
{
    /// <summary>
    /// Interaction logic for BindingItemsSourceWithDataTemplate.xaml
    /// </summary>
    public partial class BindingItemsSourceWithDataTemplate : Window
    {
        public BindingItemsSourceWithDataTemplate()
        {
            InitializeComponent();

            var teacherList = new ObservableCollection<Teacher>() {
                new Teacher(){ Id=1, Age=11, Name="Tom"},
                new Teacher(){ Id=2, Age=12, Name="Darren"},
                new Teacher(){ Id=3, Age=13, Name="Jacky"},
                new Teacher(){ Id=4, Age=14, Name="Andy"}
            };

            //为ListBox设置Binding
            listBoxTeachers.ItemsSource = teacherList;
            //listBoxTeachers.DisplayMemberPath = "Name";

            //为TextBox设置Binding
            textTeacherId.SetBinding(TextBox.TextProperty,
                new Binding("SelectedItem.Id") { Source = listBoxTeachers });
        }
    }
}
