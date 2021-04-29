using System;
using System.IO;

namespace CSharp.API {

    public static class ExtensaoString {
        // Verifica o SO da máquina, e ajusta para a pasta /HOME do usuário
        public static string ParseHome(this string path) {
            string home = (Environment.OSVersion.Platform == PlatformID.Unix ||
                Environment.OSVersion.Platform == PlatformID.MacOSX)
                ? Environment.GetEnvironmentVariable("HOME")
                : Environment.ExpandEnvironmentVariables("%HOMEDRIVE%%HOMEPATH%");

            return path.Replace("~", home);
        }
    }

    class PrimeiroArquivo {
        public static void Executar() {
            var path = @"~/primeiro_arquivo.txt".ParseHome();

            if (!File.Exists(path)) { 
                using (StreamWriter sw = File.CreateText(path)) { //CreateText, cria um novo arquivo
                    sw.WriteLine("Esse é"); // Escreve em uma linha, tendo como base a string passada
                    sw.WriteLine("o nosso");
                    sw.WriteLine("primeiro");
                    sw.WriteLine("arquivo!");
                }
            }

            // Em uma escrita de arquivos, é aberto recursos que precisam após o seu uso/execusão
            // serem fechados no momento em que a tarefa for concluida, por isso é usado o bloco using
            // no momento de conclusao o C# fecha todos os recursos que ele usou para escrever no disco.
            using (StreamWriter sw = File.AppendText(path)) { // AppendText, escreve em um arquivo já existente
                sw.WriteLine("");
                sw.WriteLine("É possível");
                sw.WriteLine("adicionar");
                sw.WriteLine("mais texto!");
            }
        }
    }
}
