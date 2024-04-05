using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TabuadaComWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroTabuada = 0;
            int i = 1;

            Console.Write("Informe o numero que gostaria de ver a tabuada: ");
            numeroTabuada = Convert.ToInt32(Console.ReadLine());

            while(i <= 10){
                Console.WriteLine("{0} x {1} = {2};", numeroTabuada, i, (numeroTabuada * i));
                i++;
            }

            Console.ReadLine();

        }
    }
}
