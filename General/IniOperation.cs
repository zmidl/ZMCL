using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Runtime.InteropServices;

namespace ZMCL.General
{
   public class IniOperation
   {
      private string FilePath;

      /// <summary>
      /// 含一个参数的构造方法(参数为ini文件的相对路径)
      /// </summary>
      /// <param name="filePath"></param>
      public IniOperation(string filePath)
      {
         this.FilePath = (new Uri(System.IO.Directory.GetCurrentDirectory() + filePath, UriKind.Relative)).ToString();
      }

      /// <summary>
      /// 读取对应目录下对应节点的数据
      /// </summary>
      /// <param name="root"></param>
      /// <param name="node"></param>
      /// <returns></returns>
      public string ReadData(string root, string node)
      {
         StringBuilder content = new StringBuilder(100);
         WinApi.GetPrivateProfileString(root, node, string.Empty, content, 255, this.FilePath);
         return content.ToString();
      }

      /// <summary>
      /// 向对应目录下对应节点写入数据
      /// </summary>
      /// <param name="root"></param>
      /// <param name="node"></param>
      /// <param name="content"></param>
      public void WriteData(string root, string node, string content)
      {
         WinApi.WritePrivateProfileString(root, node, content, this.FilePath);
      }
   }

   class WinApi
   {
      //向ini文件写入数据
      [DllImport("kernel32")]
      public static extern int WritePrivateProfileString
          (string section, string key, string val, string filePath);

      //读取ini文件中数据
      [DllImport("kernel32")]
      public static extern int GetPrivateProfileString
          (string section, string key, string def, StringBuilder retVal, int size, string filePath);
   }
}
