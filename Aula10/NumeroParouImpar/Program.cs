using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumeroParouImpar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroIdentificar = 0;
            
            Console.Write("Digite o numero que gostaria de saber se é par ou impar: ");
            numeroIdentificar = Convert.ToInt32(Console.ReadLine());

            if ((numeroIdentificar % 2) == 0)
            {
                Console.WriteLine("{0} é par.", numeroIdentificar);
            }
            else Console.WriteLine("{0} é impar.", numeroIdentificar);

            Console.ReadLine();
        }
    }
}
