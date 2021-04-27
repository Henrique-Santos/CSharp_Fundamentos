using System;

namespace Encapsulamento {
    public class SubCelebridade {
        public string InfoPublica = "Tenho um instagram!";
        protected string CorDoOlho = "Verde";
        internal long NumeroCelular = 551199999999;
        protected internal string JeitoDeFalar = "Uso muitas gírias";
        private protected string SegredoFamilia = "Bla bla";
        bool UsaMuitoPhotoshop = true;

        public void MeusAcessos() {
            Console.WriteLine("SubCelebridade...");

            Console.WriteLine(InfoPublica);
            Console.WriteLine(CorDoOlho);
            Console.WriteLine(NumeroCelular);
            Console.WriteLine(JeitoDeFalar);
            Console.WriteLine(SegredoFamilia);
            Console.WriteLine(UsaMuitoPhotoshop);
        }
    }
}
