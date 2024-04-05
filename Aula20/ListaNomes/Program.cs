 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaNomes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] lista = new string[10];
            
            for (int i = 0; i < lista.Length; i++)
            {
                Console.Write("Digite o nome na posição {0}: ",i+1);
                lista[i] = Console.ReadLine();
            }
            for(int i = 0;i < lista.Length;i++)
            {
                Console.WriteLine(lista[i]);
            }
            Console.ReadLine();
        }
    }
}
