using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZMCL.Algorithm
{
   public class BfsAlgorithm
   {
      private int HorizontalNumber_int;

      private int VerticalNumber_int;

      public int[,] MapArray_int;

      /// <summary>
      /// 类构造方法
      /// </summary>
      /// <param name="hSize"></param>
      /// <param name="vSize"></param>
      public BfsAlgorithm(int hSize, int vSize)
      {
         this.HorizontalNumber_int = hSize;
         this.VerticalNumber_int = vSize;
         this.MapArray_int = new int[hSize, vSize];
      }

      /// <summary>
      /// 最短路径计算方法
      /// </summary>
      public void RouteCalc(int startX,int startY)
      {
         List<int> tempMap = new List<int>(this.HorizontalNumber_int * this.VerticalNumber_int);

         int target = startY * this.HorizontalNumber_int + startX;

         tempMap.Add(target);

         while (tempMap.Count > 0)
         {
            int currentX = tempMap[0] % this.HorizontalNumber_int;
            int currentY = tempMap[0] / this.HorizontalNumber_int;
            int currentIndex = 0;

            // 向右遍历
            if (this.IsRoute(currentX + 1, currentY))
            {
               this.MapArray_int[currentX + 1, currentY] = this.MapArray_int[currentX, currentY] + 1;
               currentIndex = currentY * this.HorizontalNumber_int + currentX + 1;
               if (tempMap.Contains(currentIndex) == false)
               {
                  tempMap.Add(currentIndex);
               }
            }
            // 向下遍历
            if (this.IsRoute(currentX, currentY + 1))
            {
               this.MapArray_int[currentX, currentY + 1] = this.MapArray_int[currentX, currentY] + 1;
               currentIndex = (currentY + 1) * this.HorizontalNumber_int + currentX;
               if (tempMap.Contains(currentIndex) == false)
               {
                  tempMap.Add(currentIndex);
               }
            }

            // 向左遍历
            if (this.IsRoute(currentX - 1, currentY))
            {
               this.MapArray_int[currentX - 1, currentY] = this.MapArray_int[currentX, currentY] + 1;
               currentIndex = currentY * this.HorizontalNumber_int + currentX - 1;
               if (tempMap.Contains(currentIndex) == false)
               {
                  tempMap.Add(currentIndex);
               }
            }

            // 向上遍历
            if (this.IsRoute(currentX, currentY - 1))
            {
               this.MapArray_int[currentX, currentY - 1] = this.MapArray_int[currentX, currentY] + 1;
               currentIndex = (currentY - 1) * this.HorizontalNumber_int + currentX;
               if (tempMap.Contains(currentIndex) == false)
               {
                  tempMap.Add(currentIndex);
               }
            }

            tempMap.RemoveAt(0);
         }
         this.MapArray_int[startX, startY] = 0;
      }

      /// <summary>
      /// 有效路径判断方法
      /// </summary>
      /// <param name="targetX"></param>
      /// <param name="targetY"></param>
      /// <returns></returns>
      public bool IsRoute(int targetX, int targetY)
      {
         bool result = true;
         if (targetX < 0 || targetX >= this.HorizontalNumber_int
            || targetY < 0 || targetY >= this.VerticalNumber_int)
         {
            result = false;
         }
         else
         {
            if (this.MapArray_int[targetX, targetY] != 0)
            {
               result = false;
            }
         }
         return result;
      }

      /// <summary>
      /// 结算路径点
      /// </summary>
      /// <param name="endX"></param>
      /// <param name="endY"></param>
      /// <returns></returns>
      public List<int> GetRoute(int endX,int endY)
      {
         List<int> result = default(List<int>);
         int x = endX;
         int y = endY;
         int i = this.MapArray_int[x, y];
         
         if (i == 0)
         {
            result.Add(-1);
         }
         else
         {
            result = new List<int>(i);
            result.Add(this.HorizontalNumber_int * y + x);
            while (i >= 0)
            {
               if (x + 1 < this.HorizontalNumber_int && this.MapArray_int[x + 1, y] == i)
               {
                  result.Add(y * this.HorizontalNumber_int + x + 1);
                  x += 1;
               }
               else if (y + 1 < this.VerticalNumber_int && this.MapArray_int[x, y + 1] == i)
               {
                  result.Add((y + 1) * this.HorizontalNumber_int + x);
                  y += 1;
               }
               else if (x - 1 >= 0 && this.MapArray_int[x - 1, y] == i)
               {
                  result.Add(y * this.HorizontalNumber_int + x - 1);
                  x -= 1;
               }
               else if (y - 1 >= 0 && this.MapArray_int[x, y - 1] == i)
               {
                  result.Add((y - 1) * this.HorizontalNumber_int + x);
                  y -= 1;
               }
               i--;
            }
         }
         return result;
      }

      /// <summary>
      /// 指定法设置障碍物
      /// </summary>
      /// <param name="targetX"></param>
      /// <param name="targetY"></param>
      /// <param name="targetSwitch"></param>
      public void ObstacleCtl(int targetX,int targetY,bool targetSwitch)
      {
         if (targetSwitch == true)
         {
            this.MapArray_int[targetX, targetY] = -1;
         }
         else
         {
            this.MapArray_int[targetX, targetY] = 0;
         }
      }

      /// <summary>
      /// 互斥法设置障碍物
      /// </summary>
      /// <param name="targetX"></param>
      /// <param name="targetY"></param>
      /// <returns></returns>
      public bool ObstacleCtl(int targetX, int targetY)
      {
         if (this.MapArray_int[targetX, targetY] >= 0)
         {
            this.MapArray_int[targetX, targetY] = -1;
            return true;
         }
         else
         {
            this.MapArray_int[targetX, targetY] = 0;
            return false;
         }
      }
   }
}
