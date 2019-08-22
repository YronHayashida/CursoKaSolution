using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second
{
    public class SecondFile
    {

        public string validarNome(string nome)
        {
            string name = nome;

            if (nome == string.Empty)
            {
                return "campo nome não pode estar vazio";
            }
            return name;
        }

        public string validarCelular(int? cell)
        {
            if (cell == null)
            {
                return "campo Celular não pode estar vazio";
            }
            return Convert.ToString(cell);
        }
    }
}
