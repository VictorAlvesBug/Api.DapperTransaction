using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.DapperTransaction.MOD
{
	public class ParentescoMOD
	{
		public int Codigo { get; set; }
		public int CodigoPessoaOrigem { get; set; }
		public int CodigoPessoaParente { get; set; }
		public string GrauParentesco { get; set; }
		public bool Ativo { get; set; }
	}
}
