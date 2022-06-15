using Api.DapperTransaction.BLL.Services.Interfaces;
using Api.DapperTransaction.MOD;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.DapperTransaction.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class PessoaController : ControllerBase
	{
		private readonly IPessoaBLL _pessoaBLL;
		private readonly IUnitOfWork _unitOfWork;

		public PessoaController(IPessoaBLL pessoaBLL, IUnitOfWork unitOfWork)
		{
			_pessoaBLL = pessoaBLL;
			_unitOfWork = unitOfWork;
		}

		[HttpPost]
		public IActionResult Post([FromBody] PessoaMOD pessoa)
		{
			try
			{
				_unitOfWork.BeginTransaction();

				int codigoPessoa = _pessoaBLL.Save(pessoa);
				if (codigoPessoa > 0)
				{
					_unitOfWork.Commit();
					return Created("url", codigoPessoa);
				}

				_unitOfWork.Rollback();
			}
			catch (Exception)
			{
				_unitOfWork.Rollback();
			}

			return BadRequest();
		}
	}
}
