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

namespace WpfBookCodeSample.CodeSample.PropertySample
{
    /// <summary>
    /// Interaction logic for DependencyPropertySample.xaml
    /// </summary>
    public partial class DependencyPropertySample : Window
    {
        public DependencyPropertySample()
        {
            InitializeComponent();

            //测试button时，注释掉↓行代码或者手动删除textBox2中的内容
            SetBindingMethod();
        }

        private void SetBindingMethod()
        {
            var dpStudent = new DependencyObjectStudent();

            //将dpStudent的依赖属性NameProperty作为Target，将textBox1的Text作为Source
            dpStudent.SetBinding(DependencyObjectStudent.NameProperty, new Binding("Text") { Source = textBox1 });

            //将textBox2的依赖属性TextProperty作为Target，将dpStudent的依赖属性NameProperty的包装器——Name属性作为Source
            textBox2.SetBinding(TextBox.TextProperty, new Binding("Name") { Source = dpStudent });
        }

        //直接访问依赖属性
        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            var dpStudent = new DependencyObjectStudent();
            //set dependency property value
            dpStudent.SetValue(DependencyObjectStudent.NameProperty, textBox1.Text);
            //get dependency property value
            textBox2.Text = (string)dpStudent.GetValue(DependencyObjectStudent.NameProperty);
        }

        //通过CLR属性包装器访问依赖属性
        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            var dpStudent = new DependencyObjectStudent();
            dpStudent.Name=textBox1.Text;
            textBox2.Text = dpStudent.Name;
        }
    }
}
