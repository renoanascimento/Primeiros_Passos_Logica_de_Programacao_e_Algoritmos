using System;

namespace URI1150
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0, z = 0, soma = 0, cont = 0;

            x = int.Parse(Console.ReadLine());
            z = int.Parse(Console.ReadLine());

            while (z <= x)
            {
                z = int.Parse(Console.ReadLine());
            }

            for (int i = x; soma < z; i++)
            {
                soma += i;
                cont++;
            }

            Console.WriteLine(cont);

        }
    }
}
