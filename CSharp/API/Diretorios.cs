using System;
using System.IO;

namespace CSharp.API {
    class Diretorios {
        public static void Executar() {
            var novoDir = @"~/PastaCSharp".ParseHome();
            var novoDirDestino = @"~/PastaCSharpDestino".ParseHome();
            var dirProjeto = @"~/source/repos/CSharp/CSharp".ParseHome();

            if (Directory.Exists(novoDir))
                Directory.Delete(novoDir, true); // O valor true, exclui o diretório de forma recursiva, ou seja todas as subpastas que o diretorio possui dentro de si serão apagadas.

            if (Directory.Exists(novoDirDestino))
                Directory.Delete(novoDirDestino, true);

            Directory.CreateDirectory(novoDir);
            Console.WriteLine(Directory.GetCreationTime(novoDir));

            Console.WriteLine("=== Pastas ===");
            var pastas = Directory.GetDirectories(dirProjeto);
            foreach (var pasta in pastas) {
                Console.WriteLine(pasta);
            }

            Console.WriteLine("\n\n === Arquivos ===");
            var arquivos = Directory.GetFiles(dirProjeto);
            foreach (var arquivo in arquivos) {
                Console.WriteLine(arquivo);
            }

            Console.WriteLine("\n\n === Raiz ===");
            Console.WriteLine(Directory.GetDirectoryRoot(novoDir));

            Directory.Move(novoDir, novoDirDestino);
        }
    }
}
