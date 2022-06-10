﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.DapperTransaction.BLL.Services.Interfaces
{
	public interface IUnitOfWork : IDisposable
	{
		void BeginTransaction();
		void Commit();
		void Rollback();
	}
}
