using Api.DapperTransaction.MOD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.DapperTransaction.BLL.Services.Interfaces
{
	public interface IPessoaBLL
	{
		IEnumerable<PessoaMOD> Get();
		PessoaMOD Get(int codigo);
		int Save(PessoaMOD pessoa);
	}
}
