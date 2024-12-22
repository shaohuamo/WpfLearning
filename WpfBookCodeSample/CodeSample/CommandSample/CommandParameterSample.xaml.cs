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
using System.Xml.Linq;

namespace WpfBookCodeSample.CodeSample.CommandSample
{
    /// <summary>
    /// Interaction logic for CommandParameterSample.xaml
    /// </summary>
    public partial class CommandParameterSample : Window
    {
        public CommandParameterSample()
        {
            InitializeComponent();
        }

        private void New_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(nameTextBox.Text))
            {
                e.CanExecute = false;
            }
            else
            {
                e.CanExecute = true;
            }
            //路由终止，提高系统性能
            e.Handled = true;
        }

        private void New_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            if (e.Parameter.ToString() == "Student")
            {
                ListBoxNewItems.Items.Add($"New Student:{nameTextBox.Text} 好好学习，天天向上。");
            }
            else if (e.Parameter.ToString() == "Teacher")
            {
                ListBoxNewItems.Items.Add($"New Teacher:{nameTextBox.Text} 学而不厌，诲人不倦。");
            }

            //路由终止，提高系统性能
            e.Handled = true;
        }
    }
}
