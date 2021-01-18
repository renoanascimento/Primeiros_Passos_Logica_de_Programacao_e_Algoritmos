using System;

namespace URI1065
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor1, valor2, valor3, valor4, valor5, totalPares;

            valor1 = int.Parse(Console.ReadLine());
            valor2 = int.Parse(Console.ReadLine());
            valor3 = int.Parse(Console.ReadLine());
            valor4 = int.Parse(Console.ReadLine());
            valor5 = int.Parse(Console.ReadLine());
            totalPares = 0;

            if (valor1 % 2 == 0)
            {
                totalPares++;
            }
            if (valor2 % 2 == 0)
            {
                totalPares++;
            }
            if (valor3 % 2 == 0)
            {
                totalPares++;
            }
            if (valor4 % 2 == 0)
            {
                totalPares++;
            }
            if (valor5 % 2 == 0)
            {
                totalPares++;
            }

            Console.WriteLine(totalPares + " valores pares");
        }
    }
}
