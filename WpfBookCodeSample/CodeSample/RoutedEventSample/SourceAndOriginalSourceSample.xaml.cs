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
    /// Interaction logic for SourceAndOriginalSourceSample.xaml
    /// </summary>
    public partial class SourceAndOriginalSourceSample : Window
    {
        public SourceAndOriginalSourceSample()
        {
            InitializeComponent();

            //为主窗体添加对Button.Click事件的侦听
            AddHandler(ButtonBase.ClickEvent, new RoutedEventHandler(ButtonClick));
        }

        //路由事件处理器
        private void ButtonClick(object sender, RoutedEventArgs e)
        {
            //innerButton
            string strOriginSource =
                $"VisualTree StartPoint:{(e.OriginalSource as FrameworkElement)?.Name},type is {e.OriginalSource.GetType().Name}";

            //myUserControl
            string stringSource =
                $"LogicTree startPoint:{(e.Source as FrameworkElement)?.Name},Type is {e.Source.GetType().Name}";
            MessageBox.Show(strOriginSource + "\r\n" + stringSource);
        }
    }
}
