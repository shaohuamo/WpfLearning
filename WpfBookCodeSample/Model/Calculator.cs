using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfBookCodeSample.Model
{
    public class Calculator
    {
        public string Add(string arg1, string arg2)
        {
            if (double.TryParse(arg1, out var x) && double.TryParse(arg2, out var y))
            {
                var z = x + y;
                return z.ToString(CultureInfo.InvariantCulture);
            }
            return "Input Error";
        }

    }
}
