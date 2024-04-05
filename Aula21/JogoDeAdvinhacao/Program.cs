using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDeAdvinhacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] perguntas = 
                {
                    "Se o dia anterior a ontem é o dia 21, que dia é o dia depois de amanhã?",
                    "Eu pertenço ao mês de dezembro, e não a qualquer outro mês. Eu não sou um feriado. O que eu sou?",
                    "Quantas patas têm um casal de patos?"
                };

            string[] respostas = 
                {
                    "25",
                    "d",
                    "5"
                };

            string jogar = "s";
            string respostaUsuario = "";
            int perguntaAtual = 0;
            while (jogar == "s")
            {
                Random randomico = new Random();
                perguntaAtual = randomico.Next(0, perguntas.Length);

                Console.WriteLine("Pergunta: \n{0}", perguntas[perguntaAtual]);
                respostaUsuario = Console.ReadLine();

                if(respostaUsuario.ToUpper() == respostas[perguntaAtual].ToUpper()) {
                    Console.WriteLine("Acertou! :)");
                } else
                {
                    Console.WriteLine("Errou! :(");
                }

                Console.Write("Deseja continuar jogando? s/n: ");
                jogar = Console.ReadLine();
            }


        }
    }
}
