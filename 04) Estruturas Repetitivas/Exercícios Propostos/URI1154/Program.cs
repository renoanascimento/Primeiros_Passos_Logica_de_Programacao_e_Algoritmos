using System;
using System.Globalization;

namespace URI1154
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade, somaIdades = 0;
            double cont = 0.0, media = 0.0;

            idade = int.Parse(Console.ReadLine());

            while (idade > 0)
            {
                somaIdades += idade;
                cont++;
                idade = int.Parse(Console.ReadLine());
            }

            media = somaIdades / cont;

            Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
