﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoIdade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int anoAtual = DateTime.Now.Year;
            int anoNascimento = 0;

            Console.Write("Digite seu ano de nascimento: ");
            anoNascimento = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Se você já fez aniversário esse ano, você possui: {0}." +
                "\nSe ainda não fez aniversário esse ano, você possui: {1}.", (anoAtual - anoNascimento),
                (anoAtual - anoNascimento - 1));
            Console.ReadLine();
        }
    }
}
