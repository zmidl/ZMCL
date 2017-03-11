using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZMCL.General
{
   public class GeneralMethod
   {
      /// <summary>
      /// 判断字符串是否是数字
      /// </summary>
      /// <param name="text"></param>
      /// <returns></returns>
      public bool IsDigit(string text)
      {
         float a = 0;
         if (float.TryParse(text, out a))
         {
            return true;
         }
         else
         {
            return false;
         }
      }
   }
}
