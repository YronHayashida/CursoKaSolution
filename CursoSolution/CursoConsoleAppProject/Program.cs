using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoConsoleAppProj
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com o código do curso:");
            int codigo = Int32.Parse(Console.ReadLine());
            string nomeCurso = "Programming C#";
            Console.WriteLine("{0} - {1}", codigo, nomeCurso);
            Console.Read();
        }
    }
}
