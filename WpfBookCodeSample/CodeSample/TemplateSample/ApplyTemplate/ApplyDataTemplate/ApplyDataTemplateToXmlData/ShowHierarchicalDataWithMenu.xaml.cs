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
using System.Xml;

namespace WpfBookCodeSample.CodeSample.TemplateSample.ApplyTemplate.ApplyDataTemplate.ApplyDataTemplateToXmlData
{
    /// <summary>
    /// Interaction logic for ShowHierarchicalDataWithMenu.xaml
    /// </summary>
    public partial class ShowHierarchicalDataWithMenu : Window
    {
        public ShowHierarchicalDataWithMenu()
        {
            InitializeComponent();
        }

        private void StackPanel_Click(object sender, RoutedEventArgs e)
        {
            var menu = e.Source as Menu;//Source is Menu Control
            if (e.OriginalSource is MenuItem mi)
            {
                if (mi.Header is XmlElement xe) 
                    MessageBox.Show(xe.Attributes["Name"].Value);
            }
        }
    }
}
