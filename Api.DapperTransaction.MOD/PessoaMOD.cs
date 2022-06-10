using System;
using System.Collections.Generic;

namespace Api.DapperTransaction.MOD
{
	public class PessoaMOD
	{
		public int Codigo { get; set; }
		public string Nome { get; set; }
		public char Sexo { get; set; }
		public bool Ativo { get; set; }
		public ParentescoMOD Parentesco { get; set; }

		public bool EhValido()
		{
			bool nomeValido = Nome != null && Nome.Length >= 3;

			List<char> sexosPosiveis = new List<char> { 'M', 'F' };
			bool sexoValido = sexosPosiveis.Contains(Sexo);

			return nomeValido && sexoValido;
		}
	}
}
