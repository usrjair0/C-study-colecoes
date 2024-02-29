using System;
using System.Collections.Generic;


namespace MegaSena_Hashset
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mega Sena");

            Random random = new Random();

            List<int> naoSorteados = new List<int>(); 

            HashSet<int> sorteados = new HashSet<int>();//HasheSet não adiciona numeros repetidos

            for (int i = 1; i < 61; i++)
            {
                naoSorteados.Add(i);
            }
            
            for (int i = 0; i < 6; i++)
            {
                int sorteado = random.Next(1, 61); //primeiro entra, segundo nao

                if (sorteados.Add(sorteado))
                {
                    i--;
                    continue;
                }
                sorteados.Add(sorteado);
            }

            Console.Write("Numeros Sorteados: ");

            foreach (var item in sorteados)
            {

                Console.Write($"{item} ");
            }

            Console.WriteLine();

            Console.Write("Numeros não Sorteados: ");
            foreach (var item in naoSorteados)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine("\nPressione Enter para sair");
            Console.ReadLine();
        }
    }
}
