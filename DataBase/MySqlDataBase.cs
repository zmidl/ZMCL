using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;
using System.Data;

namespace ZMCL.DataBase
{
	public class MySqlDB
	{
		public string DbConStr { get; set; }

		public MySqlDB() { }

		public MySqlDB(string dbConStr)
		{
			this.DbConStr = dbConStr;
		}

		/// <summary>
		/// 通过参数新建一个数据库对象
		/// </summary>
		/// <param name="dbConStr">连接字符串</param>
		/// <returns>返回结果true表示成功然则失败</returns>
		public bool CreateNewObject(string dbConStr)
		{
			bool result = false;
			try
			{
				this.DbConStr = dbConStr;
				result = true;
			}
			catch
			{
				//throw;
			}
			return result;
		}

		/// <summary>
		/// 访问数据库
		/// </summary>
		/// <param name="cmdStr">sql命令字符串</param>
		/// <returns>返回结果得到一个表结构对象</returns>
		public DataTable GetTableInfo(string cmdStr)
		{
			string dbConStr = this.DbConStr;

			// return object
			DataTable resultDataTable = new DataTable();

			// 
			DataRow dataRow;

			// using connection object
			using (MySqlConnection conn = new MySqlConnection(dbConStr))
			{
				conn.Open();
				// 
				using (MySqlCommand cmd = conn.CreateCommand())
				{
					cmd.CommandText = cmdStr;

					using (MySqlDataReader odr = cmd.ExecuteReader())
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

		/// <summary>
		/// 检查当前数据库对象是否有效
		/// </summary>
		/// <returns>返回结果true表示有效然则无效</returns>
		public bool CheckDataBase()
		{
			bool result = false;
			string localConStr = this.DbConStr;
			using (MySqlConnection conn = new MySqlConnection(localConStr))
			{
				try
				{
					conn.Open();
					if (conn.State == ConnectionState.Open)
					{
						result = true;
					}
				}
				catch
				{
					//System.Windows.MessageBox.Show("buxing");
				}
				finally
				{
					if (conn != null)
					{
						conn.Dispose();
					}
					else
					{
						conn.Close();
					}
				}
			}
			return result;
		}
		
	}
}
