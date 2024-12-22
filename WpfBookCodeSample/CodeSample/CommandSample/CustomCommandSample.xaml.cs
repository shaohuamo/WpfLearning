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
using WpfBookCodeSample.CommandHelper;
using WpfBookCodeSample.CustomCommand;

namespace WpfBookCodeSample.CodeSample.CommandSample
{
    /// <summary>
    /// Interaction logic for CustomCommandSample.xaml
    /// </summary>
    public partial class CustomCommandSample : Window
    {
        public CustomCommandSample()
        {
            InitializeComponent();

            ClearCommand clearCommand = new ClearCommand();
            //将clearCommand关联到命令源的Command属性上
            ctrlClear.Command = CustomCommandHelper.ClearCommand;
            //将miniView绑定到命令源的CommandTarget属性上
            ctrlClear.CommandTarget = miniView;
        }
    }
}
