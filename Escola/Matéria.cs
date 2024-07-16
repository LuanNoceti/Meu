using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Escola
{
    internal class Matéria
    {
        #region Atributos Matéria

        public string Nome_Materia;
        public List<Avaliação> aval;

        #endregion

        #region Métodos Matéria

        public void CriarMateria()
        {
            Console.WriteLine("Qual será o nome da matéria?");
            Nome_Materia = Console.ReadLine();
        }
        

        #endregion

    }
}
