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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ZMCL.MyControl.WhiteStyle
{
	/// <summary>
	/// UcUpdown.xaml 的交互逻辑
	/// </summary>
	public partial class UcUpdown : UserControl
	{


		public List<string> MumberList
		{
			get { return (List<string>)GetValue(MumberListProperty); }
			set { SetValue(MumberListProperty, value); }
		}

		// Using a DependencyProperty as the backing store for MumberList.  This enables animation, styling, binding, etc...
		public static readonly DependencyProperty MumberListProperty =
			DependencyProperty.Register
			("MumberList",
				typeof(List<string>),
				typeof(UcUpdown),
				new PropertyMetadata(new List<string>() { "张无忌", "张翠山", "猪八戒", "司马光", "曹雪芹", "奥巴马", "张无忌", "张翠山", "猪八戒", "司马光", "曹雪芹", "奥巴马" }));

		private DoubleAnimation AnimationObject = new DoubleAnimation();
		private Storyboard StoryboardObject = new Storyboard();
		private double Start { get; set; }
		private double End { get; set; }
		private int Index;

		private readonly double Duration = 0.3d;
		private readonly int InitialPosition = 15;
		private readonly int SingleHeight = 24;

		public UcUpdown()
		{
			InitializeComponent();
			
			this.Init();
		}

		private void Init()
		{

			foreach (string text in MumberList)
			{
				TextBox tbx = new TextBox();
				tbx.Foreground = new SolidColorBrush(Colors.Green);
				tbx.Background = null;
				tbx.BorderThickness = new Thickness(0d,0d, 0d, 0d);
				tbx.Height = this.SingleHeight;
				tbx.Width = this.MainTextBlock.Width;
				tbx.VerticalContentAlignment = VerticalAlignment.Center;
				tbx.HorizontalContentAlignment = HorizontalAlignment.Center;
				tbx.Text = text;
				tbx.FontSize = 20;
				tbx.Foreground = new SolidColorBrush(Color.FromRgb(0, 139, 255));
				tbx.FontWeight = FontWeights.Bold;
				//Canvas.SetZIndex(tbx, 5);
				tbx.Padding = new Thickness(0d, -7d, 0d, 0d);
				tbx.HorizontalAlignment =
				tbx.HorizontalContentAlignment = HorizontalAlignment.Center;
				this.VerticalAlignment =
				tbx.VerticalContentAlignment = VerticalAlignment.Center;
				this.MainTextBlock.Children.Add(tbx);
			}

			this.Start = this.InitialPosition;
			this.Index = 0;
			//this.End = -UcMemberScroll.InitialPosition * 3;
		}


		public void UpDown()
		{
			AnimationObject.From = this.Start;
			AnimationObject.To = this.End;
			AnimationObject.Duration = new Duration(TimeSpan.FromSeconds(this.Duration));
			AnimationObject.SpeedRatio = 1d;
			//animation1.RepeatBehavior = RepeatBehavior.Forever;
			Storyboard.SetTargetName(AnimationObject, this.MainTextBlock.Name);
			Storyboard.SetTargetProperty(AnimationObject, new PropertyPath(Canvas.TopProperty));
			StoryboardObject.Children.Add(AnimationObject);
			StoryboardObject.Begin(this, true);
			this.Start = this.End;
		}

		private void UpClick(object sender, RoutedEventArgs e)
		{

			if (this.Index > 0)
			{
				this.End = this.Start + this.SingleHeight;
				this.UpDown();
				this.Index--;
			}
			//MessageBox.Show((this.MainTextBlock.Children[this.Index] as TextBox).Text);
		}

		private void DownClick(object sender, RoutedEventArgs e)
		{
			if (this.Index < this.MumberList.Count - 1)
			{
				this.End = this.Start - this.SingleHeight;
				this.UpDown();
				this.Index++;
			}
			//MessageBox.Show((this.MainTextBlock.Children[this.Index] as TextBox).Text);
		}
	}
}
