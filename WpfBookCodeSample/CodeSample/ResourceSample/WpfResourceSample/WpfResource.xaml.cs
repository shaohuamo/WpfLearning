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

namespace WpfBookCodeSample.CodeSample.ResourceSample.WpfResourceSample
{
    /// <summary>
    /// Interaction logic for WpfResource.xaml
    /// </summary>
    public partial class WpfResource : Window
    {
        public WpfResource()
        {
            InitializeComponent();
        }

        //Window loaded event handler
        //通过在xaml中的Window.Loaded属性绑定Handler
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //按照
            //控件本身的Resource属性->逻辑树向上的控件的Resource属性->最后在Application.Resources
            //这样的顺序查找"str"对应的value
            TextBlock3.Text = (string)FindResource("str");
            //明确知道"str"的键值对存储在Window这个控件中
            //则使用索引器的方式访问
            TextBlock4.Text = (string)Resources["str"];
        }
    }
}
