using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.ClassesEMetodos {
    class ParametrosPorReferencia {

        public static void AlterarRef(ref int numero) {
            numero = numero + 1000;
        }

        public static void AlterarOut(out int numero1, out int numero2) {
            numero1 = 0;
            numero2 = 0;
            numero1 = numero1 + 15;
            numero2 = numero2 + 30;
        }

        public static void Executar() {
            int a = 3;
            AlterarRef(ref a); // ref indica que eu estou passando a referencia do objeto/valor na memória, e não o valor em si.
            Console.WriteLine(a);

            AlterarOut(out int b, out int c); // out é unidirecional, você não gera/passa um dado para um parametro do tipo out, ele simplismente gera uma saida.
            Console.WriteLine($"{b} {c}");
        }
    }
}
