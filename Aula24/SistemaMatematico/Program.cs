using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaMatematico
{
    internal class Program
    {
        public static int EscolherDoMenu()
        {
            Console.WriteLine("Menu");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");
            Console.WriteLine("5 - Fatorial");
            Console.WriteLine("6 - Primo");
            Console.WriteLine("7 - Sair");
            return Convert.ToInt32(Console.ReadLine());
        }

        public static void somarNumeros()
        {
            Console.WriteLine("1 - Soma");
            int resultadoSoma = 0;
            Console.Write("Digite o primeiro valor: ");
            resultadoSoma += Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o segundo valor: ");
            resultadoSoma += Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(resultadoSoma);
        }

        public static void subtrairNumeros()
        {
            Console.WriteLine("2 - Subtração");
            
            Console.Write("Digite o primeiro valor: ");
            int resultadoSubtracao = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o segundo valor: ");
            resultadoSubtracao -= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(resultadoSubtracao);
        }

        public static void divisaoNumeros()
        {
            Console.WriteLine("3 - Divisão");
            double resultadoDivisao = 0;
            Console.Write("Digite o primeiro valor: ");
            resultadoDivisao = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o segundo valor: ");
            resultadoDivisao /= Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(resultadoDivisao);
        }

        public static void multiplicacaoNumeros()
        {
            Console.WriteLine("4 - Multiplicação");
            int resultadoMultiplicacao = 0;
            Console.Write("Digite o primeiro valor: ");
            resultadoMultiplicacao = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o segundo valor: ");
            resultadoMultiplicacao *= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(resultadoMultiplicacao);
        }

        public static void fatorialNumero()
        {
            Console.WriteLine("5 - fatorial");
            int fatorialNumero = 0;
            int totalFatorial = 1;
            Console.Write("Digite o numero para realizar fatoração: ");
            fatorialNumero = Convert.ToInt32(Console.ReadLine());
            if(fatorialNumero > 0) { 
            for (int i = 1; i <= fatorialNumero; i++)
            {
                    totalFatorial *= i;
            }
                Console.WriteLine(totalFatorial);
            }
            else
            {
                Console.WriteLine("Numero negativo");
            }
        }

        public static void primoNumero()
        {
            Console.WriteLine("6 - Primo");
            int primoNumero = 0;
            int contadorPrimo = 0;
            Console.Write("Digite o numero para verificar se é primo: ");
            primoNumero = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= primoNumero; i++)
            {
                if(primoNumero % i == 0)
                {
                    contadorPrimo++;
                }
            }
            if(contadorPrimo <= 2)
            {
                Console.WriteLine("{0} é primo", primoNumero);
            }
            else
            {
                Console.WriteLine("{0} não é primo", primoNumero);
            }

        }

        static void Main(string[] args)
        {
            int operacaoEscolhida = 0;

            while (operacaoEscolhida != 7) {
                operacaoEscolhida = EscolherDoMenu();
                Console.Clear();
                switch (operacaoEscolhida)
                {
                    case 1:
                        somarNumeros();
                        break;
                    case 2:
                        subtrairNumeros();
                        break;
                    case 3:
                        divisaoNumeros();
                        break;
                    case 4:
                        multiplicacaoNumeros();
                        break;
                    case 5:
                        fatorialNumero();
                        break;
                    case 6:
                        primoNumero();
                        break;
                    case 7:
                        break;
                    default:
                        Console.WriteLine("Invalido");
                        break;
                }
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
