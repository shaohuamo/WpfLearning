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
    /// Interaction logic for BindingObjectDataProvider.xaml
    /// </summary>
    public partial class BindingObjectDataProvider : Window
    {
        public BindingObjectDataProvider()
        {
            InitializeComponent();
            SetBinding();
        }

        private void SetBinding()
        {
            //create and config ObjectDataProvider
            ObjectDataProvider odp = new ObjectDataProvider
            {
                ObjectInstance = new Calculator(),
                MethodName = "Add"
            };
            odp.MethodParameters.Add("0");
            odp.MethodParameters.Add("0");

            //以ObjectDataProvider为Source创建Binding
            Binding bindingToArg1 = new Binding(path:"MethodParameters[0]")
            {
                Source = odp,
                //Binding对象只负责把从UI元素收集到的数据写入其直接Source，
                //即ObjectDataProvider对象，而不是其中包裹的Calculator对象
                BindsDirectlyToSource = true, 
                //属性值一有更新，即刻将值传回Source
                UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged
            };
            Binding bindingToArg2 = new Binding(path: "MethodParameters[1]")
            {
                Source = odp, 
                BindsDirectlyToSource = true, 
                UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged
            };
            Binding bindToResult = new Binding(path: ".") { Source = odp };

            //将Binding关联到UI元素上
            textBoxArg1.SetBinding(TextBox.TextProperty, bindingToArg1);
            textBoxArg2.SetBinding(TextBox.TextProperty, bindingToArg2);
            textBoxResult.SetBinding(TextBox.TextProperty, bindToResult);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ObjectDataProvider odp = new ObjectDataProvider
            {
                ObjectInstance = new Calculator(),
                MethodName = "Add"
            };
            odp.MethodParameters.Add(textBoxArg1.Text);
            odp.MethodParameters.Add(textBoxArg2.Text);
            MessageBox.Show(odp.Data.ToString());
        }
    }
}
