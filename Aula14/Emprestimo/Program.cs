using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emprestimo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Boolean empregado = false;
            Boolean fiador = false;
            String entrada = "";
            Console.WriteLine("Possui fiador?: S/N");
            entrada = Console.ReadLine();

            if (entrada.Equals("S") || entrada.Equals("s"))
            {
                fiador = true;
            }

            Console.WriteLine("Está empregado?: S/N");
            entrada = Console.ReadLine();

            if (entrada.Equals("S") || entrada.Equals("s"))
            {
                empregado = true;
            }

            if(fiador || empregado)
            {
                Console.WriteLine("Emprestimo liberado.");
            }
            else
            {
                Console.WriteLine("Emprestimo recusado.");
            }

            Console.ReadLine();

        }
    }
}
