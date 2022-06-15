using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.DapperTransaction.DAL.DatabaseConnection
{
	public class DbSession : IDisposable
	{
		public IDbConnection Connection { get; set; }
		public IDbTransaction Transaction { get; set; }

		public string guid { get; set; }

	public DbSession()
		{
			guid = Guid.NewGuid().ToString();

			string banco = "master";

			string ip = Environment.GetEnvironmentVariable("DB_ADDRESS");
			string usuario = Environment.GetEnvironmentVariable("DB_USER_ID") ?? "sa";
			string senha = Environment.GetEnvironmentVariable("DB_PASSWORD");

			if (string.IsNullOrEmpty(ip)
				|| string.IsNullOrEmpty(banco)
				|| string.IsNullOrEmpty(usuario)
				|| string.IsNullOrEmpty(senha))
			{
				throw new Exception("Parâmetros inválidos para string de conexão.");
			}

			string connectionString = Settings.GetConnectionString(ip, banco, usuario, senha);

			Connection = new SqlConnection(connectionString);
			Connection.Open();
		}

		public void Dispose() => Connection?.Dispose();
	}
}
