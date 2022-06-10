using Api.DapperTransaction.MOD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.DapperTransaction.DAL.Services.Interfaces
{
	public interface IParentescoRepository
	{
		IEnumerable<ParentescoMOD> Get();
		ParentescoMOD Get(int codigo);
		bool Save(ParentescoMOD parentesco);
	}
}
