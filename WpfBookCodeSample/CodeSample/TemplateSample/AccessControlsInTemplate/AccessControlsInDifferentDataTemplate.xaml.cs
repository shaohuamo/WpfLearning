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

namespace WpfBookCodeSample.CodeSample.TemplateSample.AccessControlsInTemplate
{
    /// <summary>
    /// Interaction logic for AccessControlsInDifferentDataTemplate.xaml
    /// </summary>
    public partial class AccessControlsInDifferentDataTemplate : Window
    {
        public AccessControlsInDifferentDataTemplate()
        {
            InitializeComponent();
        }

        private void txtBoxName_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox tb = e.OriginalSource as TextBox; //获取事件发起的源头
            //获取模板目标---该模板目标只是名为nameDT的DataTemplate的目标控件
            ContentPresenter cp = tb.TemplatedParent as ContentPresenter;
            Person stu = cp.Content as Person;//获取业务逻辑数据
            listViewStudent.SelectedItem = stu;//设置ListView选中项

            //访问界面元素
            //获得包装指定ItemData的Container————ListViewItem
            ListViewItem lvi = listViewStudent.ItemContainerGenerator.ContainerFromItem(stu) as ListViewItem;
            //ListViewItem中包含了3个不同DataTemplate生成的控件
            CheckBox cb = FindVisualChild<CheckBox>(lvi);
            MessageBox.Show(cb.Name);
        }

        //递归方法——DFS深度优先查询，与树的先序遍历相似
        private ChildType FindVisualChild<ChildType>(DependencyObject obj) where ChildType : DependencyObject
        {
            //因为DataTemplate和ControlTemplate生成的控件在运行时会成为Visual Tree的一部分
            //因此可以使用VisualTreeHelper来检索生成的控件
            for (int i = 0; i < VisualTreeHelper.GetChildrenCount(obj); i++)
            {
                DependencyObject child = VisualTreeHelper.GetChild(obj, i);
                if (child is ChildType childObject)
                {
                    return childObject;
                }
                else
                {
                    //使用递归——递归的原因是在Visual Tree中每个control都会被分解为更细小的组件
                    //会形成Tree结构
                    ChildType childOfChild = FindVisualChild<ChildType>(child);
                    if (childOfChild != null)
                    {
                        return childOfChild;
                    }
                }

            }
            return null;
        }
    }
}
