using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola
{
    internal class Avaliação
    {
        #region

        public required string Nome_Avaliacao;
        public required int Peso_Avaliacao;
        public required string Nome_Aluno;

        #endregion

        public void CriarAvaliacao()
        {
            Console.WriteLine("Qual será o nome da avaliação?");
            Nome_Avaliacao = Console.ReadLine();
        }

    }
}