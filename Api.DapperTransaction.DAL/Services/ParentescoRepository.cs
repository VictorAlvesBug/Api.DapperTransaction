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

		public IEnumerable<ParentescoMOD> Get()
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

			return _session.Connection.Query<ParentescoMOD>(query, _session.Transaction);
		}

		public ParentescoMOD Get(int codigo)
		{
			string query = @"
				SELECT
					5 AS 'Codigo',
					'Fulano de Tal' AS 'Nome',
					'M' AS 'Sexo',
					1 AS 'Ativo'
				";

			return _session.Connection.QueryFirstOrDefault<ParentescoMOD>(query, _session.Transaction);
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
