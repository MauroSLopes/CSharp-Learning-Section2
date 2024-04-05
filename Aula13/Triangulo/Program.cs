using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Triangulo - lado < (soma dos lados opostos);

            int ladoA = 0;
            int ladoB = 0;
            int ladoC = 0;

            Console.Write("Informe o valor do lado A: ");
            ladoA = Convert.ToInt32(Console.ReadLine());

            Console.Write("Informe o valor do lado B: ");
            ladoB = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Informe o valor do lado C: ");
            ladoC = Convert.ToInt32(Console.ReadLine());

            if(ladoA < ladoB + ladoC && ladoB < ladoA + ladoC && ladoC < ladoA + ladoB) {

                Console.WriteLine("Os valores representam os lados de um triângulo valido.");
            } else
            {
                Console.WriteLine("Os valores informados não representam um triângulo valido.");
            }

            Console.ReadLine();
        }
    }
}
