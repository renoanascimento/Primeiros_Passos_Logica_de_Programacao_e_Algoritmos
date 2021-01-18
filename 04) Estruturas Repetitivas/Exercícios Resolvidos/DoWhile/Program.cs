using System;
using System.Globalization;

namespace DoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            double celsius, farenheit = 0.0;
            char repetir;

            do
            {
                Console.Write("Digite a temperatura em Celsius: ");
                celsius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                farenheit = 9.0 * celsius / 5.0 + 32.0;
                Console.WriteLine("Equivalente em Farenheit: " + farenheit.ToString("F1", CultureInfo.InvariantCulture));
                Console.Write("Deseja repetir (s/n)? ");
                repetir = char.Parse(Console.ReadLine());
            }
            while (repetir == 's');
        }
    }
}
