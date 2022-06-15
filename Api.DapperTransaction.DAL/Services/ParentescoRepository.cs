using Api.DapperTransaction.DAL.DatabaseConnection;
using Api.DapperTransaction.DAL.Services.Interfaces;
using Api.DapperTransaction.MOD;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.DapperTransaction.DAL.Services
{
	public class ParentescoRepository : IParentescoRepository
	{
		private readonly DbSession _session;

		public ParentescoRepository(DbSession session)
		{
			_session = session;
		}

		public bool Save(ParentescoMOD parentesco)
		{
			string query = @"
				INSERT INTO Parentesco
					(CodigoPessoaOrigem,
					CodigoPessoaParente,
					GrauParentesco)
				VALUES
					(@CodigoPessoaOrigem,
					@CodigoPessoaParente,
					@GrauParentesco)
				";

			return _session.Connection.Execute(query, parentesco, _session.Transaction) > 0;

		}
	}
}
