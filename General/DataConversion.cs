using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Runtime.InteropServices;

namespace ZMCL.General
{
    public enum CodeFormat
    {
        Default,
        UTF8
    }

   public class DataConversion
   {
      public byte[] StructToBytes(object structObj)
      {
         int size = Marshal.SizeOf(structObj);
         byte[] bytes = new byte[size];
         IntPtr structPtr = Marshal.AllocHGlobal(size);

         Marshal.StructureToPtr(structObj, structPtr, false);

         Marshal.Copy(structPtr, bytes, 0, size);

         Marshal.FreeHGlobal(structPtr);
         return bytes;
      }

      public object ByteToStruct(byte[] bytes, Type type)
      {
         int size = Marshal.SizeOf(type);
         if (size > bytes.Length)
         {
            return null;
         }
         //分配结构体内存空间
         IntPtr structPtr = Marshal.AllocHGlobal(size);
         //将byte数组拷贝到分配好的内存空间
         Marshal.Copy(bytes, 0, structPtr, size);
         //将内存空间转换为目标结构体
         object obj = Marshal.PtrToStructure(structPtr, type);
         //释放内存空间
         Marshal.FreeHGlobal(structPtr);
         return obj;
      }

      /// <summary>
      /// string convert to byte array
      /// </summary>
      /// <param name="text"></param>
      /// <returns></returns>
      public byte[] StringToByteArray(string text,int length,CodeFormat codeFormat)
      {
         byte[] result = new byte[length];
         try
         {
            //byte[] temp = System.Text.Encoding.Default.GetBytes(text);
            //int count = System.Text.Encoding.Default.GetByteCount(text);
             byte[] temp = default(byte[]);
             int count = 0;
             switch (codeFormat)
             {
                 case CodeFormat.Default:
                 {
                     temp = System.Text.Encoding.Default.GetBytes(text);
                     count = System.Text.Encoding.Default.GetByteCount(text);
                     break;
                 }
                 case CodeFormat.UTF8:
                 {
                     temp = System.Text.Encoding.UTF8.GetBytes(text);
                     count = System.Text.Encoding.UTF8.GetByteCount(text);
                     break;
                 }
             }
             

            for (int a = 0; a < count; a++)
            {
               result[a] = temp[a];
            }
         }
         catch
         {
            throw new Exception();
         }
         return result;
      }

      /// <summary>
      /// int32 convert to byte array
      /// </summary>
      /// <param name="number"></param>
      /// <returns></returns>
      public byte[] Int32ToByteArray(Int32 number)
      {
         byte[] result = new byte[4];
         result = System.BitConverter.GetBytes(number);
         return result;
      }

      /// <summary>
      /// int16 convert to byte array
      /// </summary>
      /// <param name="number"></param>
      /// <returns></returns>
      public byte[] Int16ToByteArray(Int16 number)
      {
         byte[] result = new byte[2];
         result = System.BitConverter.GetBytes(number);
         return result;
      }

      /// <summary>
      /// byte array convert to int32
      /// </summary>
      /// <param name="byteArray"></param>
      /// <returns></returns>
      public Int32 ByteArrayToInt32(byte[] byteArray)
      {
         return System.BitConverter.ToInt32(byteArray, 0);
      }

      /// <summary>
      /// byte array convert to string
      /// </summary>
      /// <param name="byteArray"></param>
      /// <returns></returns>
      public string ByteArrayToString(byte[] byteArray)
      {
         return Encoding.Default.GetString(byteArray, 0, byteArray.Length);
      }
   }
}
