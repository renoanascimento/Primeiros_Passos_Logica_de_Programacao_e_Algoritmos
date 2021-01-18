using System;

namespace URI1097
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 9; i += 2)
            {
                for (int diferenca = 6; diferenca >= 4; diferenca--)
                {
                    Console.WriteLine("I=" + i + " " + "J=" + (i + diferenca));
                }
            }
        }
    }
}
