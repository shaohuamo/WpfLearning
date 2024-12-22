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

namespace WpfBookCodeSample.CodeSample.CommandSample
{
    /// <summary>
    /// Interaction logic for RoutedCommandSample.xaml
    /// </summary>
    public partial class RoutedCommandSample : Window
    {
        //声明并定义命令
        private readonly RoutedCommand clearCommand = new RoutedCommand("Clear", typeof(RoutedCommandSample));

        public RoutedCommandSample()
        {
            InitializeComponent();
            InitializeCommand();
        }

        private void InitializeCommand()
        {
            //把命令赋值给命令源(发送者)
            button1.Command = clearCommand;
            //定义命令的快捷键 Alt+C
            clearCommand.InputGestures.Add(new KeyGesture(Key.C, ModifierKeys.Alt));

            //指定命令目标
            button1.CommandTarget = textBoxA;

            //创建CommandBinding
            var commandBinding = new CommandBinding
            {
                Command = clearCommand //只关注与clearCommand相关的命令
            };
            //绑定命令执行前的Handler
            commandBinding.CanExecute += new CanExecuteRoutedEventHandler(cb_CanExecute);
            //绑定命令执行后的Handler
            commandBinding.Executed += new ExecutedRoutedEventHandler(cb_Execute);

            //把命令关联安置在外围控件上
            stackPanel.CommandBindings.Add(commandBinding);
        }

        //当探测命令是否可执行的时候该方法会被调用
        private void cb_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxA.Text))
            {
                e.CanExecute = false;//此时命令源不可用
            }
            else
            {
                e.CanExecute = true;
            }

            //避免事件继续向上传递而降低程序性能
            e.Handled = true;
        }

        //当命令到达目标之后(命令被执行之后)，此方法被调用
        private void cb_Execute(object sender, ExecutedRoutedEventArgs e)
        {
            textBoxA.Clear();

            //避免事件继续向上传递而降低程序性能
            e.Handled = true;
        }
    }
}
