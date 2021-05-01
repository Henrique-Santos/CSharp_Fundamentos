using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.TopicosAvancados {
    class Nullables {

        // Propriedades de uma classe, são inicializadas automaticamente com seus
        // respectivos valores padrão
        static int num3; 

        public static void Executar() {
            // Duas maneiras de criar Nullables
            Nullable<int> num1 = null;
            int? num2 = null;

            // Pra usalá é necessario inicializar a variavel com algum valor
            int num4; 

            if (num1.HasValue)
                Console.WriteLine("Valor de num: {0}", num1);
            else
                Console.WriteLine("A variavel não possui valor");

            int valor = num1 ?? 1000;
            Console.WriteLine(valor);

            bool? booleana = null;
            bool resultado = booleana.GetValueOrDefault();
            Console.WriteLine(resultado);

            try {
                int x = num1.Value;
                int y = num2.Value;
            } catch(Exception ex) {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
