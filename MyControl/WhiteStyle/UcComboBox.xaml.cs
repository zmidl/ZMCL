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

namespace ZMCL.MyControl.WhiteStyle
{
	/// <summary>
	/// UcComboBox.xaml 的交互逻辑
	/// </summary>
	public partial class UcComboBox : UserControl
	{
		//public List<string> ItemsSource { get; set; }
		public bool IsDropDown { get; set; }

		public UcComboBox()
		{
			InitializeComponent();
			this.IsDropDown = false;
			this.DropStatus(this.IsDropDown);
			this.FatherGrid.MouseLeftButtonUp += FatherGrid_MouseLeftButtonUp;
		}

		private void FatherGrid_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
		{
			this.IsDropDown = !this.IsDropDown;
			this.DropStatus(this.IsDropDown);
			//throw new NotImplementedException();
		}

		private void DropStatus(bool isDropDown)
		{
			if (isDropDown)
			{
				this.ContentBorder.Height = 80;
				Canvas.SetTop(this.Bottom1, 92);
				Canvas.SetTop(this.Bottom2, 94);
				this.ContentTextBox.Visibility = Visibility.Hidden;
				this.ContentScrollViewer.Visibility = Visibility.Visible;

			}
			else
			{
				this.ContentBorder.Height = 30;
				Canvas.SetTop(this.Bottom1, 42);
				Canvas.SetTop(this.Bottom2, 44);
				this.ContentScrollViewer.Visibility = Visibility.Hidden;
				this.ContentTextBox.Visibility = Visibility.Visible;
				//string result = string.Empty;

			}

			int index = this.ContentListBox.SelectedIndex;
			if (index >= 0)
			{
				this.ContentTextBox.Text = this.ContentListBox.SelectedValue.ToString().Split(':')[1];
			}
			this.ContentListBox.SelectedIndex = -1;
		}

		public void UpdateItemsSource(List<string> itemsSource)
		{
			if (itemsSource != null)
			{
				foreach (string content in itemsSource)
				{
					ListBoxItem lbi = new ListBoxItem();
					lbi.Content = content;
					lbi.Background = null;
					this.ContentListBox.Items.Add(lbi);
				}
			}
		}
	}
}
