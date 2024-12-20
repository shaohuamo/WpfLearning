using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfBookCodeSample.CodeSample.RoutedEventSample
{
    /// <summary>
    /// Interaction logic for WpfInnerRoutedEvent.xaml
    /// </summary>
    public partial class WpfInnerRoutedEvent : Window
    {
        public WpfInnerRoutedEvent()
        {
            InitializeComponent();

            //在code behind为gridRoot添加Button.Click事件的侦听器

            //可以注释掉这行代码，因为在xaml中已经为gridRoot添加Button.Click事件的侦听器
            //在code behind使用的是Button.ClickEvent，而在xaml中使用的是Button.Click
            //Button.Click相当于Button.ClickEvent的包装器
            gridRoot.AddHandler(ButtonBase.ClickEvent, new RoutedEventHandler(ButtonClicked));

            //↓代码与↑代码等价，因为Button is derived form ButtonBase
            //gridRoot.AddHandler(Button.ClickEvent, new RoutedEventHandler(ButtonClicked));
        }

        private void ButtonClicked(object obj, RoutedEventArgs e)
        {
            MessageBox.Show((e.OriginalSource as FrameworkElement)?.Name);
        }
    }
}
