using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Data;

namespace BBP.HOME.Boilerpate.Converters
{
    public class MultiBooleanToBooleanOrConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            IEnumerable<bool> bools = values.Select(value => value is bool toReturn ? toReturn : false).Cast<bool>();
            return bools.Any(val => val);
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
