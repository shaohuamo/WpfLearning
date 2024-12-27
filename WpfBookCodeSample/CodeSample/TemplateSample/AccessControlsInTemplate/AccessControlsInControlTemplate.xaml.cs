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

namespace WpfBookCodeSample.CodeSample.TemplateSample.AccessControlsInTemplate
{
    /// <summary>
    /// Interaction logic for AccessControlsInControlTemplate.xaml
    /// </summary>
    public partial class AccessControlsInControlTemplate : Window
    {
        public AccessControlsInControlTemplate()
        {
            InitializeComponent();
        }

        private void Button_CLick(object sender, RoutedEventArgs e)
        {
            //uc是ControlTemplate的目标控件，
            //访问其Template属性即可获取ControlTemplate对象
            //庵后使用FindName方法查询ControlTemplate内部的控件
            if (uc.Template.FindName("textBox1", uc) is TextBox tb)
            {
                tb.Text = "Hello WPF";
                if (tb.Parent is StackPanel sp)
                {
                    ((TextBox)sp.Children[1]).Text = "Hello ControlTemplate";
                    ((TextBox)sp.Children[2]).Text = "I can find you!";
                }
            }
        }
    }
}
