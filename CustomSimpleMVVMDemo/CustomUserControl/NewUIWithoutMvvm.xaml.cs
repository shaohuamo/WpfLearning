using Microsoft.Win32;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CustomSimpleMVVMDemo.CustomUserControl
{
    /// <summary>
    /// Interaction logic for NewUIWithoutMvvm.xaml
    /// </summary>
    public partial class NewUIWithoutMvvm : UserControl
    {
        public NewUIWithoutMvvm()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            slider3.Value = slider1.Value + slider2.Value;
        }

        private void saveMenuItem_Click(object sender, RoutedEventArgs e)
        {
            var dlg = new SaveFileDialog();
            dlg.ShowDialog();
        }
    }
}
