using System;

namespace URI1018
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, quantidadeNota100, quantidadeNota50, quantidadeNota20, quantidadeNota10, quantidadeNota5, quantidadeNota2, quantidadeNota1, valor;

            N = int.Parse(Console.ReadLine());
            valor = N;

            quantidadeNota100 = N / 100;
            quantidadeNota50 = N % 100 / 50;
            N = valor - quantidadeNota100 * 100 - quantidadeNota50 * 50;
            quantidadeNota20 = N % 50 / 20;
            N = valor - quantidadeNota100 * 100 - quantidadeNota50 * 50 - quantidadeNota20  * 20;
            quantidadeNota10 = N % 20 / 10;
            N = valor - quantidadeNota100 * 100 - quantidadeNota50 * 50 - quantidadeNota20 * 20 - quantidadeNota10 * 10;
            quantidadeNota5 = N % 10 / 5;
            N = valor - quantidadeNota100 * 100 - quantidadeNota50 * 50 - quantidadeNota20 * 20 - quantidadeNota10 * 10 - quantidadeNota5 * 5;
            quantidadeNota2 = N % 5 / 2;
            N = valor - quantidadeNota100 * 100 - quantidadeNota50 * 50 - quantidadeNota20 * 20 - quantidadeNota10 * 10 - quantidadeNota5 * 5 - quantidadeNota2 * 2;
            quantidadeNota1 = N % 2 / 1;

            Console.WriteLine(valor);
            Console.WriteLine(quantidadeNota100 + " nota(s) de R$ 100,00");
            Console.WriteLine(quantidadeNota50 + " nota(s) de R$ 50,00");
            Console.WriteLine(quantidadeNota20 + " nota(s) de R$ 20,00");
            Console.WriteLine(quantidadeNota10 + " nota(s) de R$ 10,00");
            Console.WriteLine(quantidadeNota5 + " nota(s) de R$ 5,00");
            Console.WriteLine(quantidadeNota2 + " nota(s) de R$ 2,00");
            Console.WriteLine(quantidadeNota1 + " nota(s) de R$ 1,00");
        }
    }
}
