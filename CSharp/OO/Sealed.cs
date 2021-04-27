using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.OO {

    sealed class SemFilho { // Uma classe sealed não pode ser herdada
        public double ValorDaFortuna() {
            return 1_407_033.65;
        }
    }

    class Avo {
        public virtual bool HonrarNomeFamilia() {
            return true;
        }
    }

    class Pai : Avo {
        public override sealed bool HonrarNomeFamilia() { // Um método sealed não pode ser sobreescrito
            return true;
        }
    }

    class FilhoRebelde : Pai { }

    class Sealed {
        public static void Executar() {
            SemFilho semFilho = new SemFilho();
            Console.WriteLine(semFilho.ValorDaFortuna());

            FilhoRebelde filho = new FilhoRebelde();
            Console.WriteLine(filho.HonrarNomeFamilia());
        }
    }
}
