using System;

namespace URI1153
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0, fatorial = 1;
            n = int.Parse(Console.ReadLine());

            while (n > 0)
            {
                fatorial *= n;
                n--;
            }

            Console.WriteLine(fatorial);
        }
    }
}
