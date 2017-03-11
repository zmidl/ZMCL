using System.ComponentModel;
using System.Windows.Controls;
using System.Windows.Media;

using System.Windows;

namespace ZMCL.MyControl
{
	/// <summary>
	/// UcCompass.xaml 的交互逻辑
	/// </summary>
	public partial class UcCompass : UserControl
	{
	

		public double Value
		{
			get { return (double)GetValue(ValueProperty); }
			set { SetValue(ValueProperty, value); }
		}

		// Using a DependencyProperty as the backing store for Value.  This enables animation, styling, binding, etc...
		public static readonly DependencyProperty ValueProperty =
			DependencyProperty.Register("Value", typeof(double), typeof(UcCompass), new PropertyMetadata(0d,new PropertyChangedCallback(Callback)));

		static void Callback(DependencyObject d, DependencyPropertyChangedEventArgs e)
		{
			double result = (double)e.NewValue;

			UcCompass uc = d as UcCompass;

			if (result >= 0 || result <= 100)
			{
				//TransformGroup transformGroup = new TransformGroup();
				//RotateTransform rotateTransform = new RotateTransform((result - 50) * 2);   //其中180是旋转180度
				//transformGroup.Children.Add(rotateTransform);
				//uc.MainCursor.RenderTransform = transformGroup;

				//TransformGroup transformGroup2 = new TransformGroup();
				//RotateTransform rotateTransform2 = new RotateTransform(50 - (result % 10) * 10);   //其中180是旋转180度
				//transformGroup2.Children.Add(rotateTransform2);
				//uc.DetailCursor.RenderTransform = transformGroup2;

				UcCompass.RotateTrans(uc.MainCursor, (result - 50) * 2);
				UcCompass.RotateTrans(uc.DetailCursor, 50 - (result % 10) * 10);
			}

		}

		public UcCompass()
		{
			InitializeComponent();
		}

		private static void RotateTrans(UIElement d ,double angle)
		{
			TransformGroup transformGroup = new TransformGroup();
			RotateTransform rotateTransform = new RotateTransform(angle);   //其中180是旋转180度
			transformGroup.Children.Add(rotateTransform);
			d.RenderTransform = transformGroup;
		}
	}
}
