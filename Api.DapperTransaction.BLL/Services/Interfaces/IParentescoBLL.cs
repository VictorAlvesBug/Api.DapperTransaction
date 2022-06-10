﻿using Api.DapperTransaction.MOD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.DapperTransaction.BLL.Services.Interfaces
{
	public interface IParentescoBLL
	{
		IEnumerable<ParentescoMOD> Get();
		ParentescoMOD Get(int codigo);
		bool Save(ParentescoMOD parentesco);
	}
}