using System;
using System.Globalization;

namespace _08
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0, totalMulheres = 0;
            double menorAltura = 50.0, maiorAltura = 0.0, totalAlturaMulheres = 0.0, mediaAlturaMulheres = 0.0;
            n = int.Parse(Console.ReadLine());

            double[] alturas = new double[n];
            char[] sexo = new char[n];
            string[] entradas = new string[1];

            for (int i = 0; i < n; i++)
            {
                entradas = Console.ReadLine().Split(' ');

                alturas[i] = double.Parse(entradas[0], CultureInfo.InvariantCulture);
                sexo[i] = char.Parse(entradas[1]);

                if (alturas[i] < menorAltura)
                {
                    menorAltura = alturas[i];
                }

                if (alturas[i] > maiorAltura)
                {
                    maiorAltura = alturas[i];
                }

                if (sexo[i] == 'F')
                {
                    totalAlturaMulheres += alturas[i];
                    totalMulheres++;
                }
            }

            mediaAlturaMulheres = totalAlturaMulheres / totalMulheres;

            Console.WriteLine("Menor altura: " + menorAltura.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Maior altura: " + maiorAltura.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Média das alturas das mulheres: " + mediaAlturaMulheres.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Número de homens: " + (n - totalMulheres));
        }
    }
}
