using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumeroPrimoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int numeroEscolhido = 0;
            int numeroPrimo = 0;
            int contador = 1;

            int comandoSaida = 1;
            while (comandoSaida != 0) {

                Console.Write("Digite o numero que deseja saber se é primo: ");
                numeroEscolhido = Convert.ToInt32(Console.ReadLine());
                
                numeroPrimo = 0;
                contador = 1;

                while (contador <= numeroEscolhido)
                {
                    if (numeroEscolhido % contador == 0)
                    {
                        numeroPrimo++;
                    }
                    contador++;
                }
                 
                if (numeroPrimo == 2)
                {
                    Console.WriteLine("{0} é primo.", numeroEscolhido);
                }
                else
                {
                    Console.WriteLine("{0} não é primo", numeroEscolhido);
                }
                Console.Write("Digite 0 para sair: ");
                comandoSaida = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
