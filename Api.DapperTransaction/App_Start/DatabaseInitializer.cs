using Api.DapperTransaction.BLL.Services;
using Api.DapperTransaction.BLL.Services.Interfaces;
using Api.DapperTransaction.DAL.DatabaseConnection;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.DapperTransaction.App_Start
{
	public static class DatabaseInitializer
	{
		public static void Initialize(IServiceCollection services)
		{
			services.AddScoped<DbSession>();
			services.AddTransient<IUnitOfWork, UnitOfWork>();
		}
	}
}
