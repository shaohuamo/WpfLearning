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

namespace WpfBookCodeSample.ControlSample.BindingSmaple
{
    /// <summary>
    /// Interaction logic for MultiLevelPathSample2_CollectionSource.xaml
    /// </summary>
    public partial class MultiLevelPathSample2_CollectionSource : Window
    {
        public MultiLevelPathSample2_CollectionSource()
        {
            InitializeComponent();
            List<string> infos = new List<string>() { "Jim", "Darren", "Jacky" };

            //textBox1.SetBinding(TextBox.TextProperty, new Binding("/") { Source=infos});
            //textBox1.SetBinding(TextBox.TextProperty, new Binding("[0]") { Source = infos });
            //以上2句代码相等,都是将Jim绑定到TextBox1的Text属性上

            //将Darren到的第3个字符bind到textbox中
            textBox1.SetBinding(TextBox.TextProperty, new Binding("[1].[2]") { Source = infos, Mode = BindingMode.OneWay });
            textBox2.SetBinding(TextBox.TextProperty, new Binding("/[2]") { Source = infos, Mode = BindingMode.OneWay });

            //将Jim的Length属性bind到textbox中
            textBox3.SetBinding(TextBox.TextProperty, new Binding("/Length") { Source = infos, Mode = BindingMode.OneWay });
        }
    }
}
