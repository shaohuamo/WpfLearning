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

namespace WpfBookCodeSample.CodeSample.RoutedEventSample
{
    /// <summary>
    /// Interaction logic for AttachedEvent.xaml
    /// </summary>
    public partial class AttachedEvent : Window
    {
        public AttachedEvent()
        {
            InitializeComponent();

            //为外层Grid添加路由事件侦听器
            //本质上是通过NameChangedEvent路由事件的包装器——AddNameChangedHandle方法
            //将NameChangedEvent路由事件附加到UI元素Grid上
            StudentForAttachedEvent.AddNameChangedHandler(gridMain, new RoutedEventHandler(StudentNameChangedHandler));
        }

        //Click事件处理器
        private void Button_OnClick(object sender, RoutedEventArgs e)
        {
            var stu = new StudentForAttachedEvent
            {
                Id = 0,
                Name = "Darren"
            };

            //准备事件消息并发送路由事件
            RoutedEventArgs arg = new RoutedEventArgs(StudentForAttachedEvent.NameChangedEvent, stu);
            //由于StudentForAttachedEvent不是UI Element，所以借助Button发送
            button1.RaiseEvent(arg);
        }

        //Grid捕捉到NameChangedEvent后的处理器
        private void StudentNameChangedHandler(object obj, RoutedEventArgs e)
        {
            MessageBox.Show((e.OriginalSource as StudentForAttachedEvent)?.Name);
        }
    }
}
