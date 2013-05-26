using System;
using System.Globalization;

#if IOS 
namespace System.Windows.Data
{
	public interface IValueConverter
	{
		object Convert(object value, Type targetType, object parameter, CultureInfo culture);
		object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture);
	}
}
#endif
