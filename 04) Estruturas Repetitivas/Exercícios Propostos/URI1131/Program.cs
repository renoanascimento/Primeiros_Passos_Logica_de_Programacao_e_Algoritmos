using System;

namespace URI1131
{
    class Program
    {
        static void Main(string[] args)
        {
            int golsInter, golsGremio, novoGreNal = 1, vitoriasInter = 0, vitoriasGremio = 0, empates = 0, quantidadeGreNais = 0;

            string[] placar = Console.ReadLine().Split(' ');
            golsInter = int.Parse(placar[0]);
            golsGremio = int.Parse(placar[1]);
            quantidadeGreNais++;

            if (golsInter > golsGremio)
            {
                vitoriasInter++;
            }
            else if (golsGremio > golsInter)
            {
                vitoriasGremio++;
            }
            else
            {
                empates++;
            }

            Console.WriteLine("Novo grenal (1-sim 2-nao)");
            novoGreNal = int.Parse(Console.ReadLine());

            while (novoGreNal == 1)
            {
                placar = Console.ReadLine().Split(' ');
                golsInter = int.Parse(placar[0]);
                golsGremio = int.Parse(placar[1]);
                quantidadeGreNais++;

                if (golsInter > golsGremio)
                {
                    vitoriasInter++;
                }
                else if (golsGremio > golsInter)
                {
                    vitoriasGremio++;
                }
                else
                {
                    empates++;
                }

                Console.WriteLine("Novo grenal (1-sim 2-nao)");
                novoGreNal = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(quantidadeGreNais + " grenais");
            Console.WriteLine("Inter:" + vitoriasInter);
            Console.WriteLine("Gremio:" + vitoriasGremio);
            Console.WriteLine("Empates:" + empates);

            if (vitoriasInter > vitoriasGremio)
            {
                Console.WriteLine("Inter venceu mais");
            }
            else if (vitoriasGremio > vitoriasInter)
            {
                Console.WriteLine("Gremio venceu mais");
            }
            else
            {
                Console.WriteLine("Nao houve vencedor");
            }
        }
    }
}
