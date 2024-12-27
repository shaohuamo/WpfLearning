using System;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using Path = System.IO.Path;

namespace WpfBookCodeSample.CodeSample.BindingSample
{
    /// <summary>
    /// Interaction logic for BindingXmlData.xaml
    /// </summary>
    public partial class BindingXmlData : Window
    {
        private const string FILE_PATH = @"../../Resources/XML/StudentData.xml";
        public BindingXmlData()
        {
            InitializeComponent();
            BindingInfo();
        }

        private void BindingInfo()
        {
            var xdp = new XmlDataProvider
            {
                Source = new Uri(FILE_PATH,UriKind.Relative),
                // 使用XPath选择需要暴露的数据
                // 现在是需要暴露一组Student
                XPath = @"StudentList/Student"
            };

            listViewStudents.DataContext = xdp;
            listViewStudents.SetBinding(ItemsControl.ItemsSourceProperty, new Binding());
        }
    }
}
