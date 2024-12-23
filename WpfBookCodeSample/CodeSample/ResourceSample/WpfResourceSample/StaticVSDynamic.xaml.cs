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

namespace WpfBookCodeSample.CodeSample.ResourceSample.WpfResourceSample
{
    /// <summary>
    /// Interaction logic for StaticVSDynamic.xaml
    /// </summary>
    public partial class StaticVSDynamic : Window
    {
        public StaticVSDynamic()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Resources["res1"] = new TextBlock() { Text = "天涯共此时" };
            Resources["res2"] = new TextBlock() { Text = "天涯共此时" };
        }
    }
}
