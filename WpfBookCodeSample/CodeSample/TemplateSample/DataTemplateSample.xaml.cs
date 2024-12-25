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

namespace WpfBookCodeSample.CodeSample.TemplateSample
{
    /// <summary>
    /// Interaction logic for DataTemplateSample.xaml
    /// </summary>
    public partial class DataTemplateSample : Window
    {
        public DataTemplateSample()
        {
            InitializeComponent();
            InitialCarList();
        }

        private void InitialCarList()
        {
            List<Car> carList = new List<Car>() {
                new Car(){ Automaker="Lamborghini", Name="Diablo", TopSpeed="200", Year="1990"},
                new Car(){ Automaker="Lamborghini", Name="Murcielago", TopSpeed="250", Year="1998"},
                new Car(){ Automaker="Lamborghini", Name="Gallardo", TopSpeed="300", Year="2002"},
                new Car(){ Automaker="Lamborghini", Name="Reventon", TopSpeed="350", Year="2011"},
            };
            //填充数据源
            listBoxCars.ItemsSource = carList;
        }
    }
}
