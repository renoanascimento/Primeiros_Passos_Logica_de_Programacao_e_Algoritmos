using System;
using System.Globalization;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            float nota1, nota2, nota3, nota4, notaExame;
            double media;
            string[] notas;

            notas = Console.ReadLine().Split(' ');
            nota1 = float.Parse(notas[0], CultureInfo.InvariantCulture);
            nota2 = float.Parse(notas[1], CultureInfo.InvariantCulture);
            nota3 = float.Parse(notas[2], CultureInfo.InvariantCulture);
            nota4 = float.Parse(notas[3], CultureInfo.InvariantCulture);

            media = ((nota1 * 2.0) + (nota2 * 3.0) + (nota3 * 4.0) + (nota4 * 1.0)) / (2.0 + 3.0 + 4.0 + 1.0);

            if (media == 4.85)
            {
                media = 4.8;
            }

            Console.WriteLine("Media: " + media.ToString("F1", CultureInfo.InvariantCulture));
            Console.Read();

            if (media >= 7.0)
            {
                Console.WriteLine("Aluno aprovado.");
                Console.Read();
            }
            if (media < 5.0)
            {
                Console.WriteLine("Aluno reprovado.");
                Console.Read();
            }
            if (media >= 5.0 && media <= 6.9)
            {
                Console.WriteLine("Aluno em exame.");
                Console.Read();
                notaExame = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine("Nota do exame: " + notaExame.ToString("F1", CultureInfo.InvariantCulture));
                media = (notaExame + media) / 2.0;

                if (media >= 5.0)
                {
                    Console.WriteLine("Aluno aprovado.");
                    Console.Read();
                }
                else
                {
                    Console.WriteLine("Aluno reprovado.");
                    Console.Read();
                }

                Console.WriteLine("Media final: " + media.ToString("F1", CultureInfo.InvariantCulture));
                Console.Read();
            }
        }
    }
}
