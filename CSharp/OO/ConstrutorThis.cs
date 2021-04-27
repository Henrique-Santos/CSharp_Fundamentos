using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.OO {

    class Animal {
        public string Nome { get; set; }

        public Animal(string nome) {
            Nome = nome;
        }
    }

    class Cachorro : Animal {
        public double Altura { get; set; }

        public Cachorro(string nome) : base(nome) {
            Console.WriteLine($"Cachorro {nome} inicializado");
        }

        public Cachorro(string nome, double altura) : this(nome) { // O this, referencia ao outro construtor dessa mesma classe.
            Altura = altura;
        }

        public override string ToString() {
            return $"{Nome} tem {Altura}cm de altura!";
        }
    }
    class ConstrutorThis {
        public static void Executar() {
            var spike = new Cachorro("Spike");
            var max = new Cachorro("Max", 40);

            Console.WriteLine(spike); // Chama o toString() implicitamente.
            Console.WriteLine(max);
        }
    }
}
