using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variaveis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string texto = "Variaveis";
            int n1 = 2;
            int n2 = 3;
            float divisao = ((float)n1 / (float)n2);
            Boolean menorque = n1 < n2;

            Console.WriteLine(texto);
            Console.WriteLine("Os numeros "+ n1 +" e "+ n2 +" tem divisão igual a "
                + divisao +"\nSoma igual a "+ (n1+n2) +" \ne a constatação de que "+n1+" é menor que "+n2+" é "+ menorque);

            Console.ReadKey();
        }
    }       
}
