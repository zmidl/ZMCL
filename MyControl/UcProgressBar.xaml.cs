
namespace ZMCL.MyControl
{
	/// <summary>
	/// UcProgressBar.xaml 的交互逻辑
	/// </summary>
	public partial class UcProgressBar : System.Windows.Controls.UserControl
	{
		public double Value
		{
			get { return this.HP6.Width; }
			
			set { this.HP6.Width = value; }
		}

		public UcProgressBar()
		{
			InitializeComponent();
		}

		private void UserControl_Loaded(object sender, System.Windows.RoutedEventArgs e)
		{


			//string uri = string.Empty;

			//uri = System.IO.Directory.GetCurrentDirectory();

			//this.BgImg.Source = new System.Windows.Media.Imaging.BitmapImage
			//	  (new System.Uri(string.Format
			//		 ("pack://application:,,,/ZMCL;component/Resources/a.jpg", System.UriKind.Absolute)));
		}
	}
}
