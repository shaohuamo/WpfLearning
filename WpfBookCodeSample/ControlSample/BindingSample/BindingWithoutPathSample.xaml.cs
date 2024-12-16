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

namespace WpfBookCodeSample.ControlSample.BindingSample
{
    /// <summary>
    /// Interaction logic for BindingWithoutPathSample.xaml
    /// </summary>
    public partial class BindingWithoutPathSample : Window
    {
        public BindingWithoutPathSample()
        {
            InitializeComponent();
            string myString = "text for text-block3";
            //C#代码中Path不能省略
            textBlock3.SetBinding(TextBlock.TextProperty, new Binding(".") { Source = myString });
        }
    }
}
