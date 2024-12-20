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
    /// Interaction logic for CustomRoutedEvent.xaml
    /// </summary>
    public partial class CustomRoutedEvent : Window
    {
        public CustomRoutedEvent()
        {
            InitializeComponent();
        }

        private void ReportTimeHandle(object sender, ReportTimeEventArgs e)
        {
            FrameworkElement element = sender as FrameworkElement;
            
            string timeStr = e.ClickTime.ToLongTimeString();

            if (element != null)
            {
                string content = $"{timeStr}到达{element.Name}";
                listBox.Items.Add(content);
            }

            if (element == gd_2)
            {
                //停止传递路由事件
                e.Handled = true;
            }
        }
    }
}
