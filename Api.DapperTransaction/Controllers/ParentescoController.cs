using Api.DapperTransaction.BLL.Services.Interfaces;
using Api.DapperTransaction.MOD;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.DapperTransaction.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ParentescoController : ControllerBase
	{
		private readonly IParentescoBLL _parentescoBLL;
		private readonly IUnitOfWork _unitOfWork;

		public ParentescoController(IParentescoBLL parentescoBLL, IUnitOfWork unitOfWork)
		{
			_parentescoBLL = parentescoBLL;
			_unitOfWork = unitOfWork;
		}

		[HttpPost]
		public IActionResult Post([FromBody] ParentescoMOD parentesco)
		{
			try
			{
				_unitOfWork.BeginTransaction();
				if (_parentescoBLL.Save(parentesco))
				{
					_unitOfWork.Commit();
					return Created("url", true);
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
