using System;
using System.Collections.Generic;
using System.Globalization;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Win32;

namespace CustomSimpleMVVMDemo.CustomUserControl
{
    /// <summary>
    /// Interaction logic for OldUIWithoutMvvm.xaml
    /// </summary>
    public partial class OldUIWithoutMvvm : UserControl
    {
        public OldUIWithoutMvvm()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            var d1 = double.Parse(tb1.Text);
            var d2 = double.Parse(tb2.Text);
            tb3.Text = (d1 + d2).ToString(CultureInfo.InvariantCulture);
        }

        private void saveButton_Click(object sender, RoutedEventArgs e)
        {
            var dlg = new SaveFileDialog();
            dlg.ShowDialog();
        }
    }
}
