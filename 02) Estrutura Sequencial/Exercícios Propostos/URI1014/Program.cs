using System;
using System.Globalization;

namespace URI1014
{
    class Program
    {
        static void Main(string[] args)
        {
            int distanciaPercorrida;
            double combustivelGasto, consumoMedio;

            distanciaPercorrida = int.Parse(Console.ReadLine());
            combustivelGasto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            consumoMedio = distanciaPercorrida / combustivelGasto;

            Console.WriteLine(consumoMedio.ToString("F3", CultureInfo.InvariantCulture) + " km/l");
        }
    }
}
