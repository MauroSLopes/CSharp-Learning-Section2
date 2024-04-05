using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaConsole
{
    internal class BackupAgenda
    {
        static public string nomeArquivo = "dados.txt";

        static public void SalvarDados(string[] nome, string[] email,int tamanhoAtual)
        {
            StreamWriter sw = new StreamWriter(nomeArquivo);
            for(int i = 0; i < tamanhoAtual; i++)
            {
                sw.WriteLine(nome[i] + ":" + email[i]);
            }
            sw.Close();
        }

        static public void RestaurarDados(ref string[] nome, ref string[] email, ref int tamanhoAtual)
        {
            tamanhoAtual = 0;
            StreamReader sr = new StreamReader(nomeArquivo);
            string line = sr.ReadLine();
            while(line != null)
            {
                int pos = line.IndexOf(":");
                nome[tamanhoAtual] = line.Substring(0, pos);
                email[tamanhoAtual] = line.Substring(pos + 1);
                line = sr.ReadLine();
                tamanhoAtual++;
            }
            sr.Close();
        }
    }
}
