using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace WPFSpinnerControl.Converters
{
    public class MultiplyValueConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            double value0 = System.Convert.ToDouble(values[0]);
            double value1 = System.Convert.ToDouble(values[1]);

            return value0 * value1;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    public class AddValueConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            double value0 = System.Convert.ToDouble(values[0]);
            double value1 = System.Convert.ToDouble(values[1]);

            return value0 + value1;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    public class PointConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            double width = (double)values[0];
            double height = (double)values[1];
            double ratio = (double)values[2];
            string PointType = (string)values[3];

            if (PointType == "StartPoint")
            {
                return new Point(width/2, height*ratio/2);
            }
            else if (PointType == "Point")
            {
                return new Point(width - (width*ratio/2),height/2);
            }
            else if (PointType == "Size")
            {
                return new Size((width - width * ratio) / 2, (height - height * ratio) / 2);
            }
            else
            {
                return new Point(0,0);
            }
            
        }
        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

}
