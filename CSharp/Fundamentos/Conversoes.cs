using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.Fundamentos
{
    class Conversoes
    {
        public static void Executar() {
            int inteiro = 10;
            double quebrado = inteiro;
            Console.WriteLine(quebrado);

            double nota = 9.7;
            int notaTruncada = (int) nota; // Realizando um casting para fazer a conversão explicita
            Console.WriteLine("Nota Truncada: {0}", notaTruncada);

            Console.WriteLine("Digite a sua idade: ");
            string idadeString = Console.ReadLine();
            int idadeInteiro = int.Parse(idadeString);
            Console.WriteLine("Idade inserida {0}", idadeInteiro);

            idadeInteiro = Convert.ToInt32(idadeString); // Usando a classe Convert para realizar a conversão
            Console.WriteLine("Resultado {0}", idadeInteiro);

            Console.Write("Digite um número: ");
            string palavra = Console.ReadLine();
            int.TryParse(palavra, out int numero);
            Console.WriteLine("Resultado {0}", numero);
        }
    }
}
