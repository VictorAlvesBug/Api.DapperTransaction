using Api.DapperTransaction.BLL.Services;
using Api.DapperTransaction.BLL.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.DapperTransaction.App_Start
{
	public static class BusinessLogicLayerInitializer
	{
		public static void Initialize(IServiceCollection services)
		{
			services.AddTransient<IPessoaBLL, PessoaBLL>();
			services.AddTransient<IParentescoBLL, ParentescoBLL>();
		}
	}
}
