using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int quantidadeDeNumeros = 0;
            double mediaTotal = 0f;

            Console.Write("Digite a quantidade de notas para o calculo de media: ");
            quantidadeDeNumeros = Convert.ToInt32(Console.ReadLine());
            
            for (int i = 0; i < quantidadeDeNumeros; i++)
            {
                Console.Write("Digite o valor do {0}º numero: ", (i+1));
                mediaTotal += Convert.ToDouble(Console.ReadLine());
            }

            Console.WriteLine("A media dos {0} numeros é: {1}", quantidadeDeNumeros, (mediaTotal / quantidadeDeNumeros));
            Console.ReadLine();
        }
    }
}
