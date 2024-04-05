using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstruturaFOR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            Console.WriteLine("Por favor digite o numero que gostaria de ver a tabuada: ");
            int numeroTabuada = Convert.ToInt32(Console.ReadLine());
            for(int i = 1; i <= 10; i++, num +=i)
            {
                Console.WriteLine("{0} * {1} = {2}", numeroTabuada, i, (numeroTabuada*i));
            }
            Console.ReadKey();
        }
    }
}
