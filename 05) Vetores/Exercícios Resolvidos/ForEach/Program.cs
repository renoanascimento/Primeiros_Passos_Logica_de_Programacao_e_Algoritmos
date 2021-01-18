using System;

namespace ForEach
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            n = int.Parse(Console.ReadLine());

            string[] nomes = new string[n];

            for (int i = 0; i < n; i++)
            {
                nomes[i] = Console.ReadLine();
            }

            Console.WriteLine("Nomes lidos:");

            foreach (string elementos in nomes)
            {
                Console.WriteLine(elementos);
            }
        }
    }
}
