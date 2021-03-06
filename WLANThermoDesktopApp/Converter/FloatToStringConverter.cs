﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace WLANThermoDesktopApp.Converter
{
    class FloatToStringConverter:IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture) => value.ToString();
        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            float temp;
            if (float.TryParse(value.ToString(), out temp))
                return float.Parse(value.ToString());
            else
                return null;
        }
    }
}
