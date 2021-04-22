using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.ClassesEMetodos {
    class ParametrosNomeados {

        public static void Formatar(int dia, int mes, int ano) {
            Console.WriteLine("{0:D2}/{1:D2}/{2}", dia, mes, ano);
        }

        public static void Executar() {
            // Ao usar parâmetros nomeados, não é necessário seguir a ordem declarada no método
            Formatar(mes: 1, dia: 6, ano: 1996);
        }
    }
}
