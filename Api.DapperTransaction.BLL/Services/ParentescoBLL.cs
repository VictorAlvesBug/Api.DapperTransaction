using Api.DapperTransaction.BLL.Services.Interfaces;
using Api.DapperTransaction.DAL.Services.Interfaces;
using Api.DapperTransaction.MOD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.DapperTransaction.BLL.Services
{
	public class ParentescoBLL : IParentescoBLL
	{
		public readonly IParentescoRepository _parentescoRepository;

		public ParentescoBLL(IParentescoRepository parentencoRepository)
		{
			_parentescoRepository = parentencoRepository;
		}

		public IEnumerable<ParentescoMOD> Get()
		{
			return _parentescoRepository.Get();
		}

		public ParentescoMOD Get(int codigo)
		{
			return _parentescoRepository.Get(codigo);
		}

		public bool Save(ParentescoMOD parentesco)
		{
			return _parentescoRepository.Save(parentesco);
		}
	}
}
