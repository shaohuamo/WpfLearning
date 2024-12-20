using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace WpfBookCodeSample.Model
{
    public class TimeButton : Button
    {
        //使用自定义的template创建路由事件及其包装器——shortcut:routedevent

        //声明和注册路由事件

        //RoutingStrategy=RoutingStrategy.Bubble
        public static readonly RoutedEvent ReportTimeEvent = EventManager.RegisterRoutedEvent(
            "ReportTime",
            RoutingStrategy.Bubble,
            typeof(EventHandler<ReportTimeEventArgs>),
            typeof(TimeButton));

        //RoutingStrategy=RoutingStrategy.Tunnel
        //public static readonly RoutedEvent ReportTimeEvent = EventManager.RegisterRoutedEvent(
        //    "ReportTime",
        //    RoutingStrategy.Tunnel,
        //    typeof(EventHandler<ReportTimeEventArgs>),
        //    typeof(TimeButton));

        //CLR事件包装器
        public event EventHandler<ReportTimeEventArgs> ReportTime
        {
            add => AddHandler(ReportTimeEvent, value);
            remove => RemoveHandler(ReportTimeEvent, value);
        }

        //激发路由事件，借用Click事件的激发方法
        protected override void OnClick()
        {
            base.OnClick();//保证Button的原有功可以正常使用、Click事件能被激发。

            ReportTimeEventArgs args = new ReportTimeEventArgs(ReportTimeEvent, this)
            {
                ClickTime = DateTime.Now
            };
            RaiseEvent(args);
        }

    }
}
