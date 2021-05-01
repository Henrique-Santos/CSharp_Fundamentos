using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.API {
    class ExemploTimeSpan {
        public static void Executar() {
            var intervalo = new TimeSpan(days: 0, hours: 20, minutes: 30, seconds: 40);
            Console.WriteLine(intervalo);
            Console.WriteLine("Minutos: " + intervalo.Minutes);
            Console.WriteLine("Intervalo em Minutos: " + intervalo.TotalMinutes);

            var largada = DateTime.Now;
            var chegada = DateTime.Now.AddMinutes(15);
            TimeSpan tempo = largada - chegada;
            Console.WriteLine("Duração: " + tempo);

            Console.WriteLine(intervalo.Add(TimeSpan.FromMinutes(8)));
            Console.WriteLine(intervalo.Subtract(TimeSpan.FromMinutes(8)));
            Console.WriteLine(intervalo);

            Console.WriteLine(intervalo.ToString("g"));
            Console.WriteLine(intervalo.ToString("G"));
            Console.WriteLine(intervalo.ToString("c"));

            // Criando um TimeSpan a partir de uma string
            Console.WriteLine("Parse: " + TimeSpan.Parse("01:02:03").ToString());
        }
    }
}
