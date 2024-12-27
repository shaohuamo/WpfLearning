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

namespace WpfBookCodeSample.CodeSample.TemplateSample.AccessControlsInTemplate
{
    /// <summary>
    /// Interaction logic for AccessControlsInDataTemplate.xaml
    /// </summary>
    public partial class AccessControlsInDataTemplate : Window
    {
        public AccessControlsInDataTemplate()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //DataTemplate的目标控件是ContentPresenter
            //根据目标控件的ContentTemplate属性获取DataTemplate对象
            //然后使用取DataTemplate对象的FindName查询DataTemplate内部的控件
            if (cp.ContentTemplate.FindName("textBlockName", cp) is TextBlock tb)
            {
                //获取DataTemplate的目标控件
                var targetControl = tb.TemplatedParent;
                //使用这种方式一般为了获取控件的长度、宽度等与业务逻辑无关的数据
                MessageBox.Show($"Height of second TexBlock is {tb.Height} px");
            }

            //若想访问DataTemplate内部与业务逻辑相关的数据，
            //则应使用这样的底层数据,但是一般应该使用Binding
            //需要先获取DataTemplate的目标控件
            //if (cp.Content is Student stu)
            //    MessageBox.Show(stu.Name);
        }
    }
}
