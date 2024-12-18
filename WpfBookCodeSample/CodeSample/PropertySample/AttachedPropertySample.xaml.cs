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

namespace WpfBookCodeSample.CodeSample.PropertySample
{
    /// <summary>
    /// Interaction logic for AttachedPropertySample.xaml
    /// </summary>
    public partial class AttachedPropertySample : Window
    {
        public AttachedPropertySample()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var human = new DependencyObjectHuman();
            //将依赖属性Grade附加到human实例中
            DependencyObjectSchool.SetGrade(human, 6);
            MessageBox.Show(DependencyObjectSchool.GetGrade(human).ToString());
        }
    }
}
