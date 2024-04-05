using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipoEleitor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                Eleitor Valido
                Ter entre 16 e 18 - Voto é Facultativo
                Ter entre 18 e 65 - Voto obrigatorio.
                Ter mais que 65 - Facultativo
             */

            int idadeUsuario = 0;
            String nomeUsuario = "";

            Console.Write("Por favor, informe o seu nome: ");
            nomeUsuario = Console.ReadLine();

            Console.Write("Por favor, informe sua idade: ");
            idadeUsuario = Convert.ToInt32(Console.ReadLine());

            if (idadeUsuario < 16)
            {
                Console.WriteLine("{0} não é um eleitor valido.", nomeUsuario);
            }
            else if (idadeUsuario < 18 || idadeUsuario > 65)
            {
                Console.WriteLine("{0} é um eleitor Facultativo.", nomeUsuario);
            }
            else Console.WriteLine("{0} é um eleitor Obrigatorio.", nomeUsuario);

            Console.ReadLine();
        }
    }
}
