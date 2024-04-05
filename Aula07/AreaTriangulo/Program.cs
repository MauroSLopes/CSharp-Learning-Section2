using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaTriangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double baseTriangulo = 0;
            double alturaTriangulo = 0;

            Console.Write("Digite a base do triangulo: ");
            baseTriangulo = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite a altura do triangulo: ");
            alturaTriangulo = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("O triangulo com base {0} e altura {1} tem area igual a {2}.", 
                baseTriangulo, alturaTriangulo, ((baseTriangulo * alturaTriangulo)/2));
            Console.ReadLine();

        }
    }
}
