using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace Wpf.BindToEnum
{
    public class RankingTypeToStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (string.IsNullOrEmpty(value.ToString()))  
                return RankingType.Month;

            return (StringToEnum<RankingType>(value.ToString())).GetDescription(); 
        }
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (string.IsNullOrEmpty(value.ToString())) 
                return RankingType.Month;

            return StringToEnum<RankingType>(value.ToString());
        }

        public static T StringToEnum<T>(string name)
        {
            return (T)Enum.Parse(typeof(T), name);
        }


    }
}
