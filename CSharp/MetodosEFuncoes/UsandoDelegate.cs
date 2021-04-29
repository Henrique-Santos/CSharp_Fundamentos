using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.MetodosEFuncoes {
    class UsandoDelegate {

        delegate double Soma(double a, double b);
        delegate void ImprimirSoma(double a, double b);

        static double MinhaSoma(double a, double b) {
            return a + b;
        }

        static void MeuImprimirSoma(double a, double b) {
            Console.WriteLine(a + b);
        }

        public static void Executar() {
            // Associando uma função pré existente a um delegate, não necessariamente é preciso passar um Lambda
            // A única coisa que precisa é que haja uma compatibilidade entre as assinaturas.
            Soma op1 = MinhaSoma;
            Console.WriteLine(op1(1, 3.9));

            ImprimirSoma op2 = MeuImprimirSoma;
            op2(5.4, 8);

            Func<double, double, double> op3 = MinhaSoma;
            Console.WriteLine(op3(2.5, 3));

            Action<double, double> op4 = MeuImprimirSoma;
            op4(7.7, 23.4);

        }
    }
}
