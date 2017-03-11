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
   /// UcImageButton.xaml 的交互逻辑
   /// </summary>
   public partial class UcImageButton : System.Windows.Controls.Button
   {
      Rectangle rec;
      public string Text { get; set; }
      public UcImageButton()
      {
         InitializeComponent();
      }

      private void grid1_Loaded(object sender, RoutedEventArgs e)
      {
         rec = this.Template.FindName("innerRectangle", this) as Rectangle;
         rec.Stroke = new SolidColorBrush(Colors.Transparent);
      }

      private void innerRectangle_MouseEnter(object sender, MouseEventArgs e)
      {
         LinearGradientBrush brush = new LinearGradientBrush();
         brush.EndPoint = new Point(0.5, 1);
         brush.StartPoint = new Point(0.5, 0);
         //EndPoint="0.5,1" StartPoint="0.5,0"
         GradientStop gradientStop1 = new GradientStop();
         gradientStop1.Offset = 1;
         gradientStop1.Color = Color.FromArgb(100, 238, 222, 180);
         brush.GradientStops.Add(gradientStop1);

         GradientStop gradientStop2 = new GradientStop();
         gradientStop2.Offset = 0;
         gradientStop2.Color = Color.FromArgb(100, 135, 98, 0);
         brush.GradientStops.Add(gradientStop2);

         rec.Stroke = brush;
      }

      private void innerRectangle_MouseLeave(object sender, MouseEventArgs e)
      {
         rec.Stroke = new SolidColorBrush(Colors.Transparent);
      }
   }
}
