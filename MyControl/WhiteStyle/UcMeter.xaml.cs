using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using System.ComponentModel;
using System.Globalization;

namespace ZMCL.MyControl.WhiteStyle
{
	/// <summary>
	/// UcMeter.xaml 的交互逻辑
	/// </summary>
	public partial class UcMeter : UserControl
	{
		public double Value
		{
			get { return (double)GetValue(ValueProperty); }
			set { SetValue(ValueProperty, value); }
		}

		public static readonly DependencyProperty ValueProperty =
			DependencyProperty.Register("Value", typeof(double), typeof(UcMeter), new PropertyMetadata(0d, new PropertyChangedCallback(Callback)));


		public UcMeter()
		{
			InitializeComponent();
		}

		static void Callback(DependencyObject d, DependencyPropertyChangedEventArgs e)
		{
			double result = (double)e.NewValue;

			UcMeter um = d as UcMeter;

			if (result >= 0d || result <= 100d)
			{
				um.ForegroundGrid.Width = result * 6 + 25;
				//Canvas.SetLeft(um.CursorGrid, result * 6+50);
			}
		}
	}

	public class SetLeft : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			double result = 0d;
			if((double)value < 0d)
			{
				result = 50d;
				//return 
			}
			else if ((double)value > 100d)
			{
				result = 100d;
            }
			else
			{
				result = (double)value * 6 + 50;
			}
			return result;
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException();
		}
	}
}
