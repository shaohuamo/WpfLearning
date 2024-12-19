using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace WpfBookCodeSample.CodeSample.BindingSample
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
