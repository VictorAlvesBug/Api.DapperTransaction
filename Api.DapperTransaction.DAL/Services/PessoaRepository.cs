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
