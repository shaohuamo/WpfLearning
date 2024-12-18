using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfBookCodeSample.Model
{
    public class DependencyObjectSchool:DependencyObject
    {
        //use ReSharper shortcut "attachedProperty" create AttachedProperty

        public static readonly DependencyProperty GradeProperty = DependencyProperty.RegisterAttached(
            "Grade", typeof(int), typeof(DependencyObjectSchool), new PropertyMetadata(default(int)));

        //注意方法的参数类型是DependencyObject，不是DependencyProperty
        public static void SetGrade(DependencyObject element, int value)
        {
            element.SetValue(GradeProperty, value);
        }

        public static int GetGrade(DependencyObject element)
        {
            return (int)element.GetValue(GradeProperty);
        }
    }
}
