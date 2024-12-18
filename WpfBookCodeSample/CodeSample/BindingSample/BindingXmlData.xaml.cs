using System;
using System.Collections.Generic;
using System.IO;
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
using Path = System.IO.Path;

namespace WpfBookCodeSample.ControlSample.BindingSample
{
    /// <summary>
    /// Interaction logic for BindingXmlData.xaml
    /// </summary>
    public partial class BindingXmlData : Window
    {
        private const string FILE_PATH = @"../../XML/StudentData.xml";
        public BindingXmlData()
        {
            InitializeComponent();
            BindingInfo();
        }

        private void BindingInfo()
        {
            var currentPath = Directory.GetCurrentDirectory();
            var xdp = new XmlDataProvider
            {
                Source = new Uri(Path.Combine(@currentPath,FILE_PATH)),
                // 使用XPath选择需要暴露的数据
                // 现在是需要暴露一组Student
                XPath = @"StudentList/Student"
            };

            listViewStudents.DataContext = xdp;
            listViewStudents.SetBinding(ItemsControl.ItemsSourceProperty, new Binding());
        }
    }
}
