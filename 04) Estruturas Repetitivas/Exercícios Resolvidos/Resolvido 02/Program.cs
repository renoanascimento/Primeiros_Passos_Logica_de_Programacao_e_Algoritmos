using System;
using System.Globalization;

namespace Resolvido_02
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade, quantidade;
            double somaIdades, media;
            somaIdades = 0.0;
            quantidade = 0;
            media = 0.0;

            idade = int.Parse(Console.ReadLine());

            if (idade < 0)
            {
                Console.WriteLine("impossivel calcular");
            }
            else
            {
                while (idade > 0)
                {
                    somaIdades += idade;
                    quantidade++;
                    media = somaIdades / quantidade;
                    idade = int.Parse(Console.ReadLine());
                }
                Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
