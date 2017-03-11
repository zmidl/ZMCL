using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OracleClient;
using System.Data;

namespace ZMCL.DataBase
{
   public class OracleDB
   {
      public string ConStr { get; set; }

      /// <summary>
      /// constructed function
      /// </summary>
      public OracleDB() { }

      /// <summary>
      /// constructed function
      /// </summary>
      /// <param name="conStr"></param>
      public OracleDB(string conStr)
      {
         this.ConStr = conStr;
      }

      /// <summary>
      /// select operation
      /// </summary>
      /// <param name="cmdStr"></param>
      /// <returns></returns>
      public DataTable GetTableInfo(string cmdStr)
      {
         string conStr = this.ConStr;

         // return object
         DataTable resultDataTable = new DataTable();

         // 
         DataRow dataRow;

         //
         OracleString rowId = string.Empty;

         // using connection object
         using (OracleConnection conn = new OracleConnection(conStr))
         {
            //  the connection object open method 
            conn.Open();

            // 
            using (OracleCommand cmd = conn.CreateCommand())
            {
               cmd.CommandText = cmdStr;

               using (OracleDataReader odr = cmd.ExecuteReader())
               {
                  // get field count
                  int size = odr.FieldCount;

                  for (int i = 0; i < size; i++)
                  {
                     DataColumn dataColumn;
                     dataColumn = new DataColumn(odr.GetName(i), odr.GetName(i).GetType());
                     resultDataTable.Columns.Add(dataColumn);
                  }

                  while (odr.Read())
                  {
                     dataRow = resultDataTable.NewRow();
                     for (int i = 0; i < size; i++)
                     {
                        dataRow[odr.GetName(i)] = odr[odr.GetName(i)].ToString();
                     }
                     resultDataTable.Rows.Add(dataRow);
                  }
               }
               cmd.ExecuteOracleNonQuery(out rowId);
            }
         }
         return resultDataTable;
      }

      public bool CheckDataBase(string conStr)
      {
         bool result = false;
         using (OracleConnection conn = new OracleConnection(conStr))
         {
            try
            {
               conn.Open();
               if (conn.State == ConnectionState.Open)
               {
                  result = true;
                  conn.Close();
               }
               else
               {
                  result = false;
               }
            }
            catch (OracleException ex)
            {
               System.Diagnostics.Debug.WriteLine(ex.ToString());
               result = false;
            }
            finally
            {
               if (conn != null)
               {
                  conn.Dispose();
               }
            }
         }
         return result;
      }

      public bool CheckDataBase()
      {
         return this.CheckDataBase(this.ConStr);
      }
   }
}
