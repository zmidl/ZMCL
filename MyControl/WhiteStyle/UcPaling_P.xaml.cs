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

namespace ZMCL.MyControl.WhiteStyle
{
	/// <summary>
	/// UcPaling.xaml 的交互逻辑
	/// </summary>
	public partial class UcPaling_P : UserControl,INotifyPropertyChanged
	{
		private static readonly double LongSquare = 3200d;

		public double X1
		{
			get { return (double)GetValue(X1Property); }
			set { SetValue(X1Property, value); }
		}
		// Using a DependencyProperty as the backing store for X1.  This enables animation, styling, binding, etc...
		public static readonly DependencyProperty X1Property =
			DependencyProperty.Register("X1", typeof(double), typeof(UcPaling_P), new PropertyMetadata(0d));



		private double x2;
		public double X2
		{
			get { return  x2; }
			set { x2 = value; this.NotifyPropertyChanged("X2"); }
		}

		public int Count { get; set; }

		public double XLength
		{
			get { return (double)GetValue(XLengthProperty); }
			set { SetValue(XLengthProperty, value); }
		}

		// Using a DependencyProperty as the backing store for X2.  This enables animation, styling, binding, etc...
		public static readonly DependencyProperty XLengthProperty =
			DependencyProperty.Register("XLength", typeof(double), typeof(UcPaling_P), new PropertyMetadata(40d,new PropertyChangedCallback(Callback)));


		private static void Callback(DependencyObject d, DependencyPropertyChangedEventArgs e)
		{
			UcPaling_P up = d as UcPaling_P;
			double value = (double)e.NewValue;
			if(value>20 && value <Math.Sqrt(UcPaling_P.LongSquare)-3)
			{
				up.L1.X2 = up.L2.X2 = value;
				double y = Math.Sqrt(UcPaling_P.LongSquare - (value * value));
				up.L1.Y2 = up.L1.Y1 - y;
				up.L2.Y1 = up.L2.Y2 - y;

				up.X2 =(up.L1.X2 -5)* up.Count;
			}
		}

		public UcPaling_P()
		{
			InitializeComponent();
		}

		public event PropertyChangedEventHandler PropertyChanged;

		public void NotifyPropertyChanged(string propertyName)
		{
			if (PropertyChanged != null)
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
