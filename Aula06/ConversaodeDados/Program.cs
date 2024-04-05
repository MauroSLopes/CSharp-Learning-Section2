using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversaodeDados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numTabuada = 0;

            Console.WriteLine("Por favor digite o valor que gostaria de ver a tabuada");
            numTabuada = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Tabuada do {0}", numTabuada);
            Console.WriteLine("{0} x 1 = " + (numTabuada * 1), numTabuada);
            Console.WriteLine("{0} x 2 = " + (numTabuada * 2), numTabuada);
            Console.WriteLine("{0} x 3 = " + (numTabuada * 3), numTabuada);
            Console.WriteLine("{0} x 4 = " + (numTabuada * 4), numTabuada);
            Console.WriteLine("{0} x 5 = " + (numTabuada * 5), numTabuada);
            Console.WriteLine("{0} x 6 = " + (numTabuada * 6), numTabuada);
            Console.WriteLine("{0} x 7 = " + (numTabuada * 7), numTabuada);
            Console.WriteLine("{0} x 8 = " + (numTabuada * 8), numTabuada);
            Console.WriteLine("{0} x 9 = " + (numTabuada * 9), numTabuada);
            Console.WriteLine("{0} x 10 = " + (numTabuada * 10), numTabuada);
            Console.ReadKey();

        }
    }
}
