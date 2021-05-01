using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.ClassesEMetodos {
    
    class Produtos {
        public string Nome;
        public double Preco;
        public static double Desconto = 0.1;

        public Produtos() { }

        public Produtos(string nome, double preco, double desconto) {
            Nome = nome;
            Preco = preco;
            Desconto = desconto;
        }

        public double CalcularDesconto() {
            return Preco - Preco * Desconto;
        }
    }

    class AtributosEstaticos {
        public static void Executar() {
            var produto1 = new Produtos("Caneta", 3.2, 0.1);

            var produto2 = new Produtos() {
                Nome = "Borracha",
                Preco = 5.3
            };

            Produtos.Desconto = 0.5;

            Console.WriteLine($"Preço com desconto: {produto1.CalcularDesconto()}");
            Console.WriteLine($"Preço com desconto: {produto2.CalcularDesconto()}");

            Produtos.Desconto = 0.02;

            Console.WriteLine($"Preço com desconto: {produto1.CalcularDesconto()}");
            Console.WriteLine($"Preço com desconto: {produto2.CalcularDesconto()}");
        }
    }
}
