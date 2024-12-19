using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using WpfBookCodeSample.Model;

namespace WpfBookCodeSample.CodeSample.BindingSample
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
