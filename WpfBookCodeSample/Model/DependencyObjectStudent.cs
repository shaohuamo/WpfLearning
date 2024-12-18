using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace WpfBookCodeSample.Model
{
    public class DependencyObjectStudent:DependencyObject
    {
        //use ReSharper shortcut "dependencyProperty" create DependencyProperty

        //依赖属性
        public static readonly DependencyProperty NameProperty = DependencyProperty.Register(
            nameof(Name), typeof(string), typeof(DependencyObjectStudent),
            new PropertyMetadata(default(string)));

        //CLR属性包装器
        public string Name
        {
            get => (string)GetValue(NameProperty);
            set => SetValue(NameProperty, value);
        }

        //SetBinding包装
        public BindingExpressionBase SetBinding(DependencyProperty dp, BindingBase binding)
        {
            return BindingOperations.SetBinding(this, dp, binding);
        }

    }
}
