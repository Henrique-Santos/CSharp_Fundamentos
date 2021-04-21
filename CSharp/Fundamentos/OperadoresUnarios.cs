using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.Fundamentos
{
    class OperadoresUnarios
    {
        public static void Executar() {
            var valorNegativo = -5;
            var numero1 = 2;
            var numero2 = 3;
            var boolleano = true;

            Console.WriteLine(-valorNegativo); // Inverte o valor, se é positivo vira negativo, se é negativo vira positivo.
            Console.WriteLine(!boolleano);

            numero1++;
            Console.WriteLine(numero1);

            --numero1;
            Console.WriteLine(numero1);

            Console.WriteLine(numero1++ == --numero2); // O incremento do numero1 só será feito depois da comparação, devido a sua precedência.
            Console.WriteLine($"{numero1} {numero2}");
        }
    }
}
