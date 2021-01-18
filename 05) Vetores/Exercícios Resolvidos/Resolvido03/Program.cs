using System;
using System.Globalization;

namespace Resolvido03
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            double somaAlturaMedia = 0.0, contMenorDe16 = 0.0, alturaMedia = 0.0, porcentagemMenorDe16 = 0.0;

            n = int.Parse(Console.ReadLine());

            string[] nomes = new string[n];
            int[] idades = new int[n];
            double[] alturas = new double[n];

            for (int i = 0; i < n; i++)
            {
                string[] entradas = new string[3];
                entradas = Console.ReadLine().Split(' ');

                nomes[i] = entradas[0];
                idades[i] = int.Parse(entradas[1]);
                alturas[i] = double.Parse(entradas[2], CultureInfo.InvariantCulture);

                somaAlturaMedia += alturas[i];

                if (idades[i] < 16)
                {
                    contMenorDe16++;
                }
            }

            alturaMedia = somaAlturaMedia / n;
            porcentagemMenorDe16 = contMenorDe16 / n * 100.0;

            Console.WriteLine("Altura média: " + alturaMedia.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Pessoas com menos de 16 anos: " + porcentagemMenorDe16.ToString("F1", CultureInfo.InvariantCulture) + "%");
        }
    }
}
