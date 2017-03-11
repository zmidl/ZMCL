using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace ZMCL.DataBase
{
   public class SqlServerDB
   {
      public string DbConStr { get; set; }

      public SqlServerDB() { }

      public SqlServerDB(string dbConStr)
      {
         this.DbConStr = dbConStr;
      }

      /// <summary>
      /// read table
      /// </summary>
      /// <param name="cmdStr"></param>
      /// <returns></returns>
      public DataTable GetTableInfo(string cmdStr)
      {
         string localConStr = this.DbConStr;

         // return object
         DataTable resultDataTable = new DataTable();

         // 
         DataRow dataRow;

         // using connection object
         using (SqlConnection conn = new SqlConnection(localConStr))
         {
            conn.Open();
            // 
            using (SqlCommand cmd = conn.CreateCommand())
            {
               cmd.CommandText = cmdStr;

               using (SqlDataReader odr = cmd.ExecuteReader())
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
            }
         }
         return resultDataTable;
      }

		private static void AdapterUpdate(string connectionString)
		{
			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				SqlDataAdapter dataAdpater = new SqlDataAdapter(
				  "SELECT CategoryID, CategoryName FROM Categories",
				  connection);

				dataAdpater.UpdateCommand = new SqlCommand(
				   "UPDATE Categories SET CategoryName = @CategoryName " +
				   "WHERE CategoryID = @CategoryID", connection);

				dataAdpater.UpdateCommand.Parameters.Add(
				   "@CategoryName", SqlDbType.NVarChar, 15, "CategoryName");

				SqlParameter parameter = dataAdpater.UpdateCommand.Parameters.Add(
				  "@CategoryID", SqlDbType.Int);
				parameter.SourceColumn = "CategoryID";
				parameter.SourceVersion = DataRowVersion.Original;

				DataTable categoryTable = new DataTable();
				dataAdpater.Fill(categoryTable);

				DataRow categoryRow = categoryTable.Rows[0];
				categoryRow["CategoryName"] = "New Beverages";

				dataAdpater.Update(categoryTable);

				Console.WriteLine("Rows after update.");
				foreach (DataRow row in categoryTable.Rows)
				{
					{
						Console.WriteLine("{0}: {1}", row[0], row[1]);
					}
				}
			}
		}
	}
}
