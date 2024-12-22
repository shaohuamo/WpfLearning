using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WpfBookCodeSample.CustomUIElementInterface;

namespace WpfBookCodeSample.CustomCommand
{
    //this class is for the use of class derived from IView
    public class ClearCommand : ICommand
    {
        //用来判断命令是否可以执行
        public bool CanExecute(object parameter)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 命令执行，带有与业务相关的Clear逻辑
        /// </summary>
        /// <param name="parameter">parameter is CommandTarget</param>
        public void Execute(object parameter)
        {
            if (parameter is IView view)
            {
                view.Clear();
            }
        }

        //当命令可执行状态发生改变时，应当被激发
        public event EventHandler CanExecuteChanged;
    }
}
