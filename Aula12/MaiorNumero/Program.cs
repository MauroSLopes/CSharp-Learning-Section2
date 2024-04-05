using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaiorNumero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 0 ;
            int maior = 0;

            Console.Write("Informe o primeiro numero: ");
            maior = Convert.ToInt32(Console.ReadLine());

            Console.Write("Informe o segundo numero: ");
            n = Convert.ToInt32(Console.ReadLine());

            if (maior < n) {
                maior = n;
            } 

            Console.Write("Informe o terceiro numero: ");
            n = Convert.ToInt32(Console.ReadLine());

            if(n > maior)
            {
                maior = n;
            }

            Console.Write("Informe o quarto numero: ");
            n = Convert.ToInt32(Console.ReadLine());

            if (n > maior)
            {
                maior = n;
            }

            Console.Write("Informe o quinto numero: ");
            n = Convert.ToInt32(Console.ReadLine());

            if (n > maior)
            {
                maior = n;
            }

            Console.WriteLine("O maior numero é o {0}", maior);
            Console.ReadLine();
        }
    }
}
