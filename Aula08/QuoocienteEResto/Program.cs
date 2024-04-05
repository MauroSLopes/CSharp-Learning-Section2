using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuoocienteEResto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double numero1 = 0;
            double numero2 = 0;

            Console.Write("Digite o dividendo: ");
            numero1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o divisor: ");
            numero2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Divisão: {0} / {1} ",numero1, numero2);
            Console.WriteLine("Resto: {0} \nQuociente: {1}", (numero1 % numero2), (numero1 / numero2));
            Console.ReadLine();


        }
    }
}
