using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace CustomSimpleMVVMDemo.ViewModels
{
    public class NotificationObject : INotifyPropertyChanged
    {
        //在将Property绑定到UI Element之后，Binding就会监听PropertyChangedEvent
        public event PropertyChangedEventHandler PropertyChanged;

        //通知Binding，propertyName对应的值发生了变化
        public void RaisePropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
