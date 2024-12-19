using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using WpfBookCodeSample.Model;

namespace WpfBookCodeSample.CodeSample.BindingSample
{
    /// <summary>
    /// Interaction logic for BindingItemsSource.xaml
    /// </summary>
    public partial class BindingItemsSource : Window
    {
        public BindingItemsSource()
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
            listBoxTeachers.DisplayMemberPath = "Name";

            //为TextBox设置Binding
            textTeacherId.SetBinding(TextBox.TextProperty, 
                new Binding("SelectedItem.Id") { Source = listBoxTeachers});
        }
    }
}
