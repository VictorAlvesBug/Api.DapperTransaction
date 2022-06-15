using Api.DapperTransaction.BLL.Services.Interfaces;
using Api.DapperTransaction.DAL.Services.Interfaces;
using Api.DapperTransaction.MOD;
using System;
using System.Collections.Generic;

namespace Api.DapperTransaction.BLL.Services
{
	public class PessoaBLL : IPessoaBLL
	{
		public readonly IPessoaRepository _pessoaRepository;
		public readonly IParentescoRepository _parentescoRepository;

		public PessoaBLL(IPessoaRepository pessoaRepository, IParentescoRepository parentescoRepository)
		{
			_pessoaRepository = pessoaRepository;
			_parentescoRepository = parentescoRepository;
		}


		public int Save(PessoaMOD pessoa)
		{
			if (pessoa.EhValido())
			{
				int codigoPessoa = _pessoaRepository.Save(pessoa);

				if (pessoa.Parentesco == null)
				{
					return codigoPessoa;
				}

				pessoa.Parentesco.CodigoPessoaOrigem = codigoPessoa;

				if (_parentescoRepository.Save(pessoa.Parentesco))
				{
					return codigoPessoa;
				}
			}

			return 0;
		}
	}
}
