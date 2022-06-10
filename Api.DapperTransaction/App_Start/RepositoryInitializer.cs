using Api.DapperTransaction.DAL.Services;
using Api.DapperTransaction.DAL.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.DapperTransaction.App_Start
{
	public static class RepositoryInitializer
	{
		public static void Initialize(IServiceCollection services)
		{
			services.AddTransient<IPessoaRepository, PessoaRepository>();
			services.AddTransient<IParentescoRepository, ParentescoRepository>();
		}
	}
}
