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
using CustomSimpleMVVMDemo.Models;

namespace CustomSimpleMVVMDemo.CustomUserControl
{
    /// <summary>
    /// Interaction logic for OldUIWithMvvm.xaml
    /// </summary>
    public partial class OldUIWithMvvm : UserControl
    {
        public OldUIWithMvvm()
        {
            InitializeComponent();
            DataContext = new CalculatorViewModel();
        }
    }
}
