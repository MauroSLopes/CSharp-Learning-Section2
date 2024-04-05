using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcao
{
    internal class Program
    {
        public static void ExibirData()
        {
            Console.WriteLine(DateTime.Now.ToString());
        }
        public static void ExibirMensagem(string nome)
        {
            Console.WriteLine("Olá {0}!", nome);
        }
        public static int CalcularIdadeAtual(int anoNascimento)
        {
            int anoAtual = DateTime.Now.Year;
            return (anoAtual - anoNascimento);
        }

        public static double SomarValores(double numero1, double numero2)
        {
            return numero1 + numero2;
        }
        static void Main(string[] args)
        {
            ExibirMensagem("Mauro");
            ExibirData();
            Console.WriteLine(CalcularIdadeAtual(2003));
            Console.WriteLine(SomarValores(2, 2));
            Console.ReadLine();
        }
    }
}
