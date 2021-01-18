using System;
using System.Globalization;

namespace _09
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0, lucroAbaixoDeDez = 0, lucroEntreDezEVinte = 0, lucroAcimaDeVinte = 0;
            double valorTotalDeCompra = 0.0, valorTotalDeVenda = 0.0, lucroTotal = 0.0;
            n = int.Parse(Console.ReadLine());

            string[] nomes = new string[n];
            double[] precoDeCompra = new double[n];
            double[] precoDeVenda = new double[n];
            string[] entradas = new string[2];

            for (int i = 0; i < n; i++)
            {
                entradas = Console.ReadLine().Split(' ');

                nomes[i] = entradas[0];
                precoDeCompra[i] = double.Parse(entradas[1], CultureInfo.InvariantCulture);
                precoDeVenda[i] = double.Parse(entradas[2], CultureInfo.InvariantCulture);

                lucroTotal = lucroTotal + (precoDeVenda[i] - precoDeCompra[i]);

                if ((precoDeVenda[i] - precoDeCompra[i]) < (precoDeCompra[i] * 0.1))
                {
                    lucroAbaixoDeDez++;
                }
                else if ((precoDeVenda[i] - precoDeCompra[i]) > (precoDeCompra[i] * 0.2))
                {
                    lucroAcimaDeVinte++;
                }
                else
                {
                    lucroEntreDezEVinte++;
                }

                valorTotalDeCompra += precoDeCompra[i];
                valorTotalDeVenda += precoDeVenda[i];
            }

            Console.WriteLine("Lucro abaixo de 10%: " + lucroAbaixoDeDez);
            Console.WriteLine("Lucro entre 10% e 20%: " + lucroEntreDezEVinte);
            Console.WriteLine("Lucro acima de 20%: " + lucroAcimaDeVinte);
            Console.WriteLine("Valor total de compra: " + valorTotalDeCompra.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor total de venda: " + valorTotalDeVenda.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Lucro total: " + lucroTotal.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
