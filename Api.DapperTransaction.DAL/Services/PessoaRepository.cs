using Api.DapperTransaction.DAL.DatabaseConnection;
using Api.DapperTransaction.DAL.Services.Interfaces;
using Api.DapperTransaction.MOD;
using Dapper;
using System;
using System.Collections.Generic;

namespace Api.DapperTransaction.DAL.Services
{
	public class PessoaRepository : IPessoaRepository
	{
		private readonly DbSession _session;

		public PessoaRepository(DbSession session)
		{
			_session = session;
		}

		public IEnumerable<PessoaMOD> Get()
		{
			string query = @"
				SELECT
					5 AS 'Codigo',
					'Fulano de Tal' AS 'Nome',
					'M' AS 'Sexo',
					1 AS 'Ativo'
				UNION
				SELECT
					7 AS 'Codigo',
					'Ciclana da Silva' AS 'Nome',
					'F' AS 'Sexo',
					1 AS 'Ativo'
				";

			return _session.Connection.Query<PessoaMOD>(query, _session.Transaction);
		}

		public PessoaMOD Get(int codigo)
		{
			string query = @"
				SELECT
					5 AS 'Codigo',
					'Fulano de Tal' AS 'Nome',
					'M' AS 'Sexo',
					1 AS 'Ativo'
				";

			return _session.Connection.QueryFirstOrDefault<PessoaMOD>(query, _session.Transaction);
		}

		public int Save(PessoaMOD pessoa)
		{
			string query = @"
				INSERT INTO Pessoa
					(Nome,
					Sexo)
				VALUES
					(@Nome,
					@Sexo);
				SELECT @@IDENTITY;
				";

			return _session.Connection.QueryFirstOrDefault<int>(query, pessoa, _session.Transaction);

		}
	}
}
