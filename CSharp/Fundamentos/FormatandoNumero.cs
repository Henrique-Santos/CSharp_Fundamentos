using System;
using System.Globalization;

namespace CSharp.Fundamentos
{
    class FormatandoNumero
    {
        public static void Executar () {
            double valor = 15.175;
            Console.WriteLine(valor.ToString("F1")); // Uma casa depois da virgula
            Console.WriteLine(valor.ToString("C")); // Adiciona simbolo monetário
            Console.WriteLine(valor.ToString("P")); // Porcentagem
            Console.WriteLine(valor.ToString("#.##")); // Duas casas decimais (F2)

            CultureInfo cultura = new CultureInfo("pt-BR");
            Console.WriteLine(valor.ToString("C0", cultura));

            int inteiro = 256;
            Console.WriteLine(inteiro.ToString("D10")); // Adicionando zeros a esquerda
        }
    }
}
