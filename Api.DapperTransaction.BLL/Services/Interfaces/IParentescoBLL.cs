using Api.DapperTransaction.MOD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.DapperTransaction.BLL.Services.Interfaces
{
	public interface IParentescoBLL
	{
		bool Save(ParentescoMOD parentesco);
	}
}
