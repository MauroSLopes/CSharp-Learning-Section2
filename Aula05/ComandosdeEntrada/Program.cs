using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComandosdeEntrada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome = "";

            Console.WriteLine("Olá, por favor informe seu nome.");
            nome = Console.ReadLine();
            Console.WriteLine("Olá {0}, Seja bem vindo!", nome);
            Console.ReadKey();
        }
    }
}
