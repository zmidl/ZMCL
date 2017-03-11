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

namespace ZMCL.MyControl
{
	/// <summary>
	/// UcTextBox.xaml 的交互逻辑
	/// </summary>
	public partial class UcTextBox : TextBox
	{
		public string Watermark
		{
			get { return (string)GetValue(WatermarkProperty); }
			set { SetValue(WatermarkProperty, value); }
		}
		public static readonly DependencyProperty WatermarkProperty =
			DependencyProperty.Register("Watermark", typeof(string), typeof(UcTextBox), new PropertyMetadata(string.Empty));


		public UcTextBox()
		{
			InitializeComponent();
		}
	}
}
