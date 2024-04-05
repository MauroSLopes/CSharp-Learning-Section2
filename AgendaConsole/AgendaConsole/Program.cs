using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaConsole
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            string[] nome = new string[100];
            string[] email = new string[100];

            int tamanhoAtual = 0;
            int opcaoAtual = 0;

            BackupAgenda.RestaurarDados(ref nome, ref email, ref tamanhoAtual);
            while(opcaoAtual != 6)
            {
                opcaoAtual = AbrirMenu();
                Console.Clear();
                switch (opcaoAtual)
                {
                    case 1:
                        CriarContato(ref nome, ref email, ref tamanhoAtual);
                        break;
                    case 2:
                        LocalizarContato(nome, tamanhoAtual);
                        break;
                    case 3:
                        AlterarContato(ref nome, ref email, tamanhoAtual);
                        break;
                    case 4:
                        DeletarContato(ref nome, ref email, ref tamanhoAtual);
                        break;
                    case 5:
                        MostrarContatos(nome, email, tamanhoAtual);
                        break;
                }
            }
            BackupAgenda.SalvarDados(nome, email, tamanhoAtual);
        }

        static int AbrirMenu()
        {
            Console.Clear();
            Console.WriteLine("- Menu Agenda -");
            Console.WriteLine("1 - Criar Contato.");
            Console.WriteLine("2 - Localizar Contato.");
            Console.WriteLine("3 - Alterar Contato.");
            Console.WriteLine("4 - Excluir Contato.");
            Console.WriteLine("5 - Mostrar todos os Contatos.");
            Console.WriteLine("6 - Sair");
            return Convert.ToInt32(Console.ReadLine());
        }

        static void CriarContato(ref String[] nome, ref String[] email, ref int tamanhoAtual)
        {
            Console.WriteLine("- Criar contatos -");
            Console.Write("Digite o nome do contato: ");
            nome[tamanhoAtual] = Console.ReadLine().ToUpper();
            Console.Write("Digite o email do contato: ");
            email[tamanhoAtual] = Console.ReadLine().ToUpper();
            tamanhoAtual++;
        }

        static int LocalizarContato(String[] nome, int tamanhoAtual)
        {
            string localizarNome = "";
            int posicaoDeEncontro = -1;
            Console.WriteLine("- Localizar contatos -");
            Console.Write("Digite o nome do contato: ");
            localizarNome = Console.ReadLine().ToUpper();
            int i = 0;

            while (i < tamanhoAtual && posicaoDeEncontro == -1)
            {
                if (nome[i] == localizarNome)
                {
                    Console.WriteLine("O contato {0} foi encontrado na posição {1} da agenda.", localizarNome, i);
                    posicaoDeEncontro = i;
                }
                i++;
            }

            if (posicaoDeEncontro == -1)
            {
                Console.WriteLine("Contato não encontrado.");
            }
            Console.ReadLine();
            return posicaoDeEncontro;
        }

        static void AlterarContato(ref string[] nome, ref string[] email, int tamanhoAtual)
        {
            int posicaoUsuario = 0;
            Console.WriteLine("- Alterar Contato -");
            posicaoUsuario = LocalizarContato(nome, tamanhoAtual);
            Console.Write("Digite o novo nome para o usuario: ");
            nome[posicaoUsuario] = Console.ReadLine().ToUpper();
            Console.Write("Digite o novo email para o usuario: ");
            email[posicaoUsuario] = Console.ReadLine().ToUpper();
        }

        static void DeletarContato(ref String[] nome, ref String[] email, ref int tamanhoAtual)
        {
            Console.WriteLine("- Deletar Contato -");
            int posicaoContato = LocalizarContato(nome, tamanhoAtual);

            for(int i = posicaoContato; i < tamanhoAtual; i++)
            {
                nome[i] = nome[(i + 1)];
                email[i] = email[(i + 1)];
            }
            tamanhoAtual--;
        }

        static void MostrarContatos(String[] nome, String[] email, int tamanhoAtual)
        {
            Console.WriteLine("- Mostrar Contatos -");
            for(int i = 0; i < tamanhoAtual; i++) 
            { 
                Console.WriteLine("{0} - Nome: {1}. Email: {2}.", i, nome[i], email[i]);
            }
            Console.ReadLine();
        }

    }
}
