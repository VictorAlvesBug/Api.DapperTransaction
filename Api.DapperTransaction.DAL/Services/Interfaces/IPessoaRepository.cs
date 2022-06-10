using Api.DapperTransaction.MOD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.DapperTransaction.DAL.Services.Interfaces
{
	public interface IPessoaRepository
	{
		IEnumerable<PessoaMOD> Get();
		PessoaMOD Get(int codigo);
		int Save(PessoaMOD pessoa);
	}
}
