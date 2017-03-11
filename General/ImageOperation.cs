using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZMCL.General
{
   public class ImageOperation
   {
      public static System.Windows.Media.ImageBrush CreateBackground(UriKind uriKind, string imageRelativePath)
      {
         string uri = string.Empty;
         if (uriKind.Equals(UriKind.Relative))
         {
            uri=System.IO.Directory.GetCurrentDirectory();
         }
         return new System.Windows.Media.ImageBrush(
            new System.Windows.Media.Imaging.BitmapImage
               (new Uri(string.Format
                  ("{0}{1}",
                  uri, 
                  imageRelativePath), 
                  UriKind.Absolute)));
      }

      public static System.Windows.Media.Imaging.BitmapImage CreateImageSource(UriKind uriKind,string imageRelativePath)
      {
         string uri = string.Empty;
         if (uriKind.Equals(UriKind.Relative))
         {
            uri = System.IO.Directory.GetCurrentDirectory();
         }
         return new System.Windows.Media.Imaging.BitmapImage
               (new Uri(string.Format
                  ("{0}{1}",
                  uri,
                  imageRelativePath),
                  UriKind.Absolute));
      }
   }
}
