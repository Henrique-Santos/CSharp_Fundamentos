using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.ClassesEMetodos {
    class Params {
        // O params, permite por meio de um único parametro, receber mais de um argumto, ele agrupa os valores em um array
        public static void Recepcionar(params string[] pessoas) {
            foreach (var pessoa in pessoas) {
                Console.WriteLine($"Olá {pessoa}");
            }
        }

        public static void Executar() {
            Recepcionar("Pedro", "Manu", "Róger", "Ana", "Bia");
        }
    }
}
