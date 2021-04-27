using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulamento {
    public class AmigoProximo {
        public readonly SubCelebridade amiga = new SubCelebridade(); // Composição

        public void MeusAcessos() {
            Console.WriteLine("AmigoProximo");

            Console.WriteLine(amiga.InfoPublica);
            Console.WriteLine(amiga.NumeroCelular);
            Console.WriteLine(amiga.JeitoDeFalar);
        }
    }
}
