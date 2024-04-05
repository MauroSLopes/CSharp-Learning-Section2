using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace TextEditor
{
    internal class Program
    {
        public static int AbrirMenu()
        {
            Console.Clear();
            Console.WriteLine("- Menu -");
            Console.WriteLine("1 - Abrir um Arquivo.");
            Console.WriteLine("2 - Exibir texto do Arquivo.");
            Console.WriteLine("3 - Criar um novo Arquivo com um novo texto.");
            Console.WriteLine("4 - Adicionar um novo texto no Arquivo.");
            Console.WriteLine("5 - Sair");
            Console.Write("Opção: ");
            return Convert.ToInt32(Console.ReadLine());
        }
        public static string AbrirArquivo()
        {
            Console.Write("Digite o local do arquivo: ");
            return Console.ReadLine();
        }

        public static void ExibirArquivo(string arquivo)
        {
            string line = "";
            try
            {
                StreamReader sr = new StreamReader(arquivo);
                line = sr.ReadLine();
                while (line != null)
                {
                    Console.WriteLine(line);
                    line = sr.ReadLine();
                }
                sr.Close();
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro: Arquivo em branco ou não existe.");
            }
        }
        public static void GravarTexto(string arquivo, string mensagem, Boolean novaLinha)
        {
            try
            {
                StreamWriter wr = new StreamWriter(arquivo, novaLinha);
                wr.WriteLine(mensagem);
                wr.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro: "+ e.Message);
                Console.ReadLine();
            }
        }
        static void Main(string[] args)
        {
            int opcaoMenu = 0;
            string arquivo = "";
            string mensagem = "";
            while (opcaoMenu != 5)
            {
                opcaoMenu = AbrirMenu();

                switch(opcaoMenu)
                {
                    case 1:
                        arquivo = AbrirArquivo();
                        break;
                    case 2:
                        ExibirArquivo(arquivo);
                        break;
                    case 3:
                        Console.Write("Digite a linha que gostaria no arquivo: ");
                        mensagem = Console.ReadLine();
                        GravarTexto(arquivo, mensagem, false);
                        ExibirArquivo(arquivo);
                        break;
                    case 4:
                        Console.Write("Digite a linha que gostaria de adicionar ao arquivo: ");
                        mensagem = Console.ReadLine();
                        GravarTexto(arquivo, mensagem, true);
                        ExibirArquivo(arquivo);
                        break;

                }
            }

        }
    }
}
