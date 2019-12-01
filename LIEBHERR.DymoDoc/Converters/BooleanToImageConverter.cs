using System;
using System.Globalization;
using System.Windows.Data;

namespace LIEBHERR.DymoDoc.Converters
{
    public class BooleanToImageConverter : IValueConverter
    {
        public string TrueValue { get; set; }
        public string FalseValue { get; set; }

        public BooleanToImageConverter()
        {            
            TrueValue = string.Empty;
            FalseValue = string.Empty;
        }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (!(value is bool?))
            {
                return null;
            }
            return (bool)value ? TrueValue : FalseValue;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (Equals(value, TrueValue))
                return true;
            if (Equals(value, FalseValue))
                return false;
            return null;
        }
    }
}
