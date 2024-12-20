using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WpfBookCodeSample.Model
{
    public class Student:INotifyPropertyChanged
    {
        private string _name;

        public string Name
        {
            get => _name;
            //我们需要做的只是在Property的set方法中调用SetField方法
            set => SetField(ref _name, value);
        }

        //以下代码都是在实现INotifyPropertyChanged接口时VS帮我们自动生成的
        public event PropertyChangedEventHandler PropertyChanged;

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
