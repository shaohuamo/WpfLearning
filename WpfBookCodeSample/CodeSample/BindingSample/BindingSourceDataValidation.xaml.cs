﻿using System;
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
    /// Interaction logic for BindingSourceDataValidation.xaml
    /// </summary>
    public partial class BindingSourceDataValidation : Window
    {
        public BindingSourceDataValidation()
        {
            InitializeComponent();

            //validate target and source data
            Binding binding = new Binding(path: "Value")
            {
                UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged,
                Source = slider1
            };
            ValidationRule rule = new RangeValidationRule();

            //enable source data validation
            rule.ValidatesOnTargetUpdated = true;

            binding.ValidationRules.Add(rule);

            //enable notify function when error
            binding.NotifyOnValidationError = true;

            textBox1.SetBinding(TextBox.TextProperty, binding);

            //add validation error event
            textBox1.AddHandler(Validation.ErrorEvent, new RoutedEventHandler(ValidationError));
        }

        private void ValidationError(object sender, RoutedEventArgs e)
        {
            if (Validation.GetErrors(textBox1).Count > 0)
            {
                //ToolTip shows when hover mouse to the control
                textBox1.ToolTip = Validation.GetErrors(textBox1)[0].ErrorContent.ToString();
            }
        }
    }
}