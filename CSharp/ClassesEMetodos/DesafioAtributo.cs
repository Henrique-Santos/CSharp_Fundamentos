using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.ClassesEMetodos {
    class DesafioAtributo {

        int a = 10; // Atributo de instancia

        public static void Executar() { // Método da classe
            DesafioAtributo desafio = new DesafioAtributo();
            Console.WriteLine(desafio.a);
        }
    }
}

/* Um método estatico não tem acesso direto a alguma propriedade que pertence a instacia */