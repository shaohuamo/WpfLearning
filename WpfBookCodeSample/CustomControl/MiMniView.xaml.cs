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
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfBookCodeSample.CustomUIElementInterface;

namespace WpfBookCodeSample.CustomControl
{
    /// <summary>
    /// Interaction logic for MniView.xaml
    /// </summary>
    public partial class MiMniView : UserControl, IView
    {
        public MiMniView()
        {
            InitializeComponent();
        }

        public bool IsChanged { get; set; }
        public void SetBinding()
        {
            throw new NotImplementedException();
        }

        public void Refresh()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 用于清除内容的业务逻辑
        /// </summary>
        public void Clear()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }
    }
}
