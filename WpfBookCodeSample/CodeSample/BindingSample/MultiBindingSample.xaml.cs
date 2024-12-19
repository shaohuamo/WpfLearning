using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using WpfBookCodeSample.Model;

namespace WpfBookCodeSample.CodeSample.BindingSample
{
    /// <summary>
    /// Interaction logic for MultiBindingSample.xaml
    /// </summary>
    public partial class MultiBindingSample : Window
    {
        public MultiBindingSample()
        {
            InitializeComponent();
            SetMultiBinding();
        }

        private void SetMultiBinding()
        {
            //准备基础Binding
            Binding bind1 = new Binding(path:"Text") { Source = textBox1 };
            Binding bind2 = new Binding(path:"Text") { Source = textBox2 };
            Binding bind3 = new Binding(path:"Text") { Source = textBox3 };
            Binding bind4 = new Binding(path:"Text") { Source = textBox4 };

            //准备MultiBinding
            MultiBinding mb = new MultiBinding() { Mode = BindingMode.OneWay };
            mb.Bindings.Add(bind1);//注意，MultiBinding对子元素的顺序是很敏感的。
            mb.Bindings.Add(bind2);
            mb.Bindings.Add(bind3);
            mb.Bindings.Add(bind4);
            mb.Converter = new MultiBindingConverter();

            //将Binding和MultiBinding关联
            btnSubmit.SetBinding(Button.IsEnabledProperty, mb);
        }
    }
}
