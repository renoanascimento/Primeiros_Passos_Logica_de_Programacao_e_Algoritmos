using System;
using System.Globalization;

namespace URI1017
{
    class Program
    {
        static void Main(string[] args)
        {
            const int consumoCombustivel = 12;
            int tempoEmHorasViagem, velocidadeMedia;
            double combustivelGasto, distanciaPercorrida;

            tempoEmHorasViagem = int.Parse(Console.ReadLine());
            velocidadeMedia = int.Parse(Console.ReadLine());

            distanciaPercorrida = tempoEmHorasViagem * velocidadeMedia;
            combustivelGasto = distanciaPercorrida / consumoCombustivel;

            Console.WriteLine(combustivelGasto.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
