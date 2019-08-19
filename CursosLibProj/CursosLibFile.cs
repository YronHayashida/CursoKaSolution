using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursosLibNS
{
    public class CursosClass
    {
        public string ExibirNomeCurso(int cod)
        {
            string nome = "curso desconhecido";
            if (cod == 20483)
            {
                nome = "programmimg C#";
            }
            return nome;
        }
    }
}
