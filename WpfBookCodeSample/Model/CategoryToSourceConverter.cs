using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace WpfBookCodeSample.Model
{
    public class CategoryToSourceConverter : IValueConverter
    {
        //source to target
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value != null)
            {
                Category category = (Category)value;
                switch (category)
                {
                    case Category.Bomber:
                        return @"../../Resources/ICONS/Bomber.png";

                    case Category.Fighter:
                        return @"../../Resources/ICONS/Fighter.png";

                    default:
                        return null;

                }
            }
            return null;
        }

        //target to source
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
