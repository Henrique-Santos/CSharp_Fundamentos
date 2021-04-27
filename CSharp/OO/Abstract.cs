using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.OO {

    public abstract class Celular { // Uma classe abstrata não pode ser instanciada
        public abstract string Assistente(); // Um método abstrato não pode ser implementado
    
        public string Tocar() {
            return "Trim trim trim...";
        }
    }

    public class Samsung : Celular {
        public override string Assistente() {
            return "Olá! Meu nome é Bixby!";
        }
    }

    public class Iphone : Celular {
        public override string Assistente() {
            return "Olá! Meu nome é Siri!";
        }
    }

    class Abstract {
        public static void Executar() {
            var celulares = new List<Celular> {
                new Iphone(),
                new Samsung()
            };

            foreach (var celular in celulares) {
                Console.WriteLine(celular.Assistente());
            }
        }
    }
}
