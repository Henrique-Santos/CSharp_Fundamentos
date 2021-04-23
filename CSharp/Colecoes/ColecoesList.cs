using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.Colecoes {
    class ColecoesList {

        public class Produto {
            public string Nome;
            public double Preco;

            public Produto(string nome, double preco) {
                Nome = nome;
                Preco = preco;
            }
        }

        public static void Executar() {
            var livro = new Produto("Código Limpo", 69.9);

            var carrinho = new List<Produto>();
            carrinho.Add(livro);

            var combo = new List<Produto> { 
                new Produto("Camisa", 55.8),
                new Produto("Short", 30.9),
                new Produto("Chinelo", 22.8),
            };
            carrinho.AddRange(combo);

            Console.WriteLine(carrinho.Count);
            carrinho.RemoveAt(3);

            foreach (var item in carrinho) {
                Console.WriteLine(carrinho.IndexOf(item));
                Console.WriteLine($"{item.Nome} {item.Preco}");
            }
        }
    }
}
