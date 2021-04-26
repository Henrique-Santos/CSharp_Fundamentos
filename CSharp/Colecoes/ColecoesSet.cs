using System;
using System.Collections.Generic;
using System.Text;

using static CSharp.Colecoes.ColecoesList;

namespace CSharp.Colecoes {
    class ColecoesSet {

        public static void Executar() {
            var livro = new Produto("Código Limpo", 69.9);

            var carrinho = new HashSet<Produto>(); // HashSet não é uma estrutura indexada, e não aceita repetição.
            carrinho.Add(livro);

            var combo = new HashSet<Produto> { 
                new Produto("Camisa", 55.8),
                new Produto("Short", 30.9),
                new Produto("Chinelo", 22.8),
            };
            carrinho.UnionWith(combo);

            Console.WriteLine(carrinho.Count);

            foreach (var item in carrinho) {
                Console.WriteLine($"{item.Nome} {item.Preco}");
            }

            Console.WriteLine(carrinho.Count);
            carrinho.Add(livro);
            Console.WriteLine(carrinho.Count);
        }
    }
}
