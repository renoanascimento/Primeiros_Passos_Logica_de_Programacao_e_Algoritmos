using System;
using System.Globalization;

namespace URI1018
{
    class Program
    {
        static void Main(string[] args)
        {
            int reais, notas, centavos, moedas, quantidadeNota100, quantidadeNota50, quantidadeNota20, quantidadeNota10, quantidadeNota5, quantidadeNota2, quantidadeMoeda1,
                   quantidadeMoeda50, quantidadeMoeda25, quantidadeMoeda10, quantidadeMoeda5, quantidadeMoeda1Centavo;
            string[] valor;

            valor = Console.ReadLine().ToString().Split('.');
            reais = int.Parse(valor[0], CultureInfo.InvariantCulture);
            centavos = int.Parse(valor[1], CultureInfo.InvariantCulture);
            notas = reais;
            moedas = centavos;

            quantidadeNota100 = reais / 100;
            quantidadeNota50 = reais % 100 / 50;
            reais = notas - quantidadeNota100 * 100 - quantidadeNota50 * 50;
            quantidadeNota20 = reais % 50 / 20;
            reais = notas - quantidadeNota100 * 100 - quantidadeNota50 * 50 - quantidadeNota20 * 20;
            quantidadeNota10 = reais % 20 / 10;
            reais = notas - quantidadeNota100 * 100 - quantidadeNota50 * 50 - quantidadeNota20 * 20 - quantidadeNota10 * 10;
            quantidadeNota5 = reais % 10 / 5;
            reais = notas - quantidadeNota100 * 100 - quantidadeNota50 * 50 - quantidadeNota20 * 20 - quantidadeNota10 * 10 - quantidadeNota5 * 5;
            quantidadeNota2 = reais % 5 / 2;
            reais = notas - quantidadeNota100 * 100 - quantidadeNota50 * 50 - quantidadeNota20 * 20 - quantidadeNota10 * 10 - quantidadeNota5 * 5 - quantidadeNota2 * 2;
            quantidadeMoeda1 = reais % 2 / 1;

            quantidadeMoeda50 = centavos / 50;
            quantidadeMoeda25 = centavos % 50 / 25;
            centavos = moedas - quantidadeMoeda50 * 50 - quantidadeMoeda25 * 25;
            quantidadeMoeda10 = centavos % 25 / 10;
            centavos = moedas - quantidadeMoeda50 * 50 - quantidadeMoeda25 * 25 - quantidadeMoeda10 * 10;
            quantidadeMoeda5 = centavos % 10 / 5;
            centavos = moedas - quantidadeMoeda50 * 50 - quantidadeMoeda25 * 25 - quantidadeMoeda10 * 10 - quantidadeMoeda5 * 5;
            quantidadeMoeda1Centavo = centavos % 5 / 1;

            Console.WriteLine("NOTAS:");
            Console.WriteLine(quantidadeNota100 + " nota(s) de R$ 100.00");
            Console.WriteLine(quantidadeNota50 + " nota(s) de R$ 50.00");
            Console.WriteLine(quantidadeNota20 + " nota(s) de R$ 20.00");
            Console.WriteLine(quantidadeNota10 + " nota(s) de R$ 10.00");
            Console.WriteLine(quantidadeNota5 + " nota(s) de R$ 5.00");
            Console.WriteLine(quantidadeNota2 + " nota(s) de R$ 2.00");
            Console.WriteLine("MOEDAS:");
            Console.WriteLine(quantidadeMoeda1 + " moeda(s) de R$ 1.00");
            Console.WriteLine(quantidadeMoeda50 + " moeda(s) de R$ 0.50");
            Console.WriteLine(quantidadeMoeda25 + " moeda(s) de R$ 0.25");
            Console.WriteLine(quantidadeMoeda10 + " moeda(s) de R$ 0.10");
            Console.WriteLine(quantidadeMoeda5 + " moeda(s) de R$ 0.05");
            Console.WriteLine(quantidadeMoeda1Centavo + " moeda(s) de R$ 0.01");
        }
    }
}
