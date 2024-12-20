using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfBookCodeSample.Model
{
    public class StudentForAttachedEvent
    {
        //使用自定义的ReSharper template生成，shortcut:routedevent
        public static readonly RoutedEvent NameChangedEvent = EventManager.RegisterRoutedEvent(
            "NameChanged",
            RoutingStrategy.Bubble,
            typeof(RoutedEventHandler),
            typeof(StudentForAttachedEvent));

        //手动添加以下代码

        //为界面元素添加路由事件侦听
        public static void AddNameChangedHandler(DependencyObject d, RoutedEventHandler h)
        {
            if (d is UIElement e)
            {
                e.AddHandler(NameChangedEvent, h);
            }
        }
        //移除侦听
        public static void RemoveNameChangedHandler(DependencyObject d, RoutedEventHandler h)
        {
            if (d is UIElement e)
            {
                e.RemoveHandler(NameChangedEvent, h);
            }
        }

        public int Id { get; set; }
        public string Name { get; set; }
    }
}
