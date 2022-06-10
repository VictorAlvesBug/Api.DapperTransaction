using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.DapperTransaction.DAL.DatabaseConnection
{
	public static class Settings
	{
		public static string GetConnectionString(string ip, string banco, string usuario, string senha)
		{
			StringBuilder sbConnectionString = new StringBuilder();

			sbConnectionString.Append($"Data Source={ip};");
			sbConnectionString.Append($"Initial Catalog={banco};");
			sbConnectionString.Append($"Persist Security Info=True;");
			sbConnectionString.Append($"User ID={usuario};");
			sbConnectionString.Append($"Password={senha};");

			return sbConnectionString.ToString();
		}
	}
}
