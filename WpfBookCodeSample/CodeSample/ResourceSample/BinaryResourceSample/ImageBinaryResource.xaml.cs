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

namespace WpfBookCodeSample.CodeSample.ResourceSample.BinaryResourceSample
{
    /// <summary>
    /// Interaction logic for ImageBinaryResource.xaml
    /// </summary>
    public partial class ImageBinaryResource : Window
    {
        private const string RELATIVE_PATH = @"../../../Resources/Images/tulip_farm.jpg";
        private const string ABSOLUTE_PATH = @"pack://application:,,,/Resources/Images/tulip_farm.jpg";
        public ImageBinaryResource()
        {
            InitializeComponent();

            var imgUri3 = new Uri(RELATIVE_PATH, UriKind.Relative);
            var imgUri4 = new Uri(ABSOLUTE_PATH, UriKind.Absolute);

            Image3.Source = new BitmapImage(imgUri3);
            Image4.Source = new BitmapImage(imgUri4);
        }
    }
}
