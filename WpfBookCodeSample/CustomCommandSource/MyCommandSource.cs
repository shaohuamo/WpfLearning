using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace WpfBookCodeSample.CustomCommandSource
{
    public class MyCommandSource : UserControl, ICommandSource
    {
        //继承自ICommand的3个属性
        //每个属性上添加Set方法
        public ICommand Command { get; set; }
        public object CommandParameter { get; set; }
        public IInputElement CommandTarget { get; set; }

        //在组件被单击时执行命令
        protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e)
        {
            base.OnMouseLeftButtonDown(e);

            if (CommandTarget != null)
            {
                //在命令目标上执行命令，或者说让命令作用于命令目标
                Command.Execute(CommandTarget);
            }
        }
    }
}
