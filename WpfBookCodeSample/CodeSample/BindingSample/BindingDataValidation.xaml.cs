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

namespace WpfBookCodeSample.ControlSample.BindingSample
{
    /// <summary>
    /// Interaction logic for BindingDataValidation.xaml
    /// </summary>
    public partial class BindingDataValidation : Window
    {
        public BindingDataValidation()
        {
            InitializeComponent();

            //validate only target data
            Binding binding = new Binding(path:"Value")
            {
                UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged, 
                Source = slider1
            };
            ValidationRule rule = new RangeValidationRule();
            binding.ValidationRules.Add(rule);
            textBox1.SetBinding(TextBox.TextProperty, binding);
        }
    }
}
