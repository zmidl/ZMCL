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
   /// UcMessageBox.xaml 的交互逻辑
   /// </summary>
   public partial class UcMessageBox : System.Windows.Window
   {
      public new string Title
      {
         get { return this.lblTitle.Text; }
         set { this.lblTitle.Text = value; }
      }

      public string Message
      {
         get { return this.lblMsg.Text; }
         set { this.lblMsg.Text = value; }
      }

      public UcMessageBox()
      {
         InitializeComponent();
         this.Visibility = Visibility.Hidden;
         this.Topmost = true;
      }

      private void bn1_Click(object sender, RoutedEventArgs e)
      {
         this.Close();
      }

      public void ShowMessageBox(string title, string msg)
      {
         this.Visibility = Visibility.Visible;
         this.lblTitle.Text = title;
         this.lblMsg.Text = msg;
      }
   }
}
