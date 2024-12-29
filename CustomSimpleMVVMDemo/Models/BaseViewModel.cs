using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CustomSimpleMVVMDemo.Models
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        //在将Property绑定到UI Element之后，Binding就会监听PropertyChangedEvent
        public event PropertyChangedEventHandler PropertyChanged;

        //通知Binding，propertyName对应的值发生了变化
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value)) return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
    }
}
