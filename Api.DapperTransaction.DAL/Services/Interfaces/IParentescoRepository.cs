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
		bool Save(ParentescoMOD parentesco);
	}
}
