﻿using System;
using System.Globalization;
using Xamarin.Forms;
namespace ToDo
{
	public class DateTimeConverter : IValueConverter
	{
		public DateTimeConverter()
		{
		}

		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			var Time = (DateTime)value;
			return Time.ToString("M/d/yyyy h:mm:tt");
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException();
		}
	}
}
