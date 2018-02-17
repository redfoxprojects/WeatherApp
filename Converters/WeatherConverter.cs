using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Data;
using Windows.UI.Xaml.Data;

namespace WeatherApp.Converters
{
    public class WeatherConverter : IValueConverter
    {
        object IValueConverter.Convert(object value, Type targetType, object parameter, string language)
        {
            switch (parameter.ToString())
            {
                case "Temperature":
                    return ToDegrees(decimal.Parse(value.ToString()));
                case "WindSpeed":
                    return ToMPH(decimal.Parse(value.ToString()));

                default:
                    return null;
            }
        }

        object IValueConverter.ConvertBack(object value, Type targetType, object parameter, string language)
        {
            return null;
        }

        private string ToDegrees(decimal temp)
        {
            return temp.ToString() + '\u00b0';
        }

        private string ToMPH(decimal wind)
        {
            return wind.ToString() + " MPH";
        }
    }
}
