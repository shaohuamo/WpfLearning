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

namespace WpfBookCodeSample.ControlSample
{
    /// <summary>
    /// Binding source from code behind
    /// </summary>
    public partial class binding_samp1 : Window
    {
        private Student stu;
        public binding_samp1()
        {
            InitializeComponent();

            stu = new Student();
            //stu.test += test1;

            //Binding对象的Mode property的default value是BindingMode.Default
            //对于不同的控件，BindingMode.Default是不同的
            //可以参考官网文档
            Binding b = new Binding();
            b.Source = stu;
            b.Path = new PropertyPath("Name");

            //在SetBinding方法中为stu中的PropertyChanged事件订阅了某个方法
            BindingOperations.SetBinding(textBoxName, TextBox.TextProperty, b);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            stu.Name += "Name";
        }

    }
}
