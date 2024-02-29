using System;
using System.Collections.Generic;

namespace MegaSena
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mega Sena");

            Random random = new Random();

            List<int> lista = new List<int>();
            List<int> sorteados = new List<int>();

            for (int i = 1; i < 61; i++)
            {
                lista.Add(i);
            }

            for (int i = 0; i < 6; i++)
            {
                int sorteado = random.Next(1, 61); //primeiro entra, segundo nao

                if (sorteados.Contains(sorteado))
                {
                    i--;
                    continue;
                }
                else
                {
                    sorteados.Add(sorteado);
                    lista.Remove(sorteado);
                }

            }
            Console.Write("Numeros Sorteados: ");
            foreach (var item in sorteados)
            {

                Console.Write($"{item} ");
            }

            Console.WriteLine();

            Console.Write("Numeros não Sorteados: ");
            foreach (var item in lista)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine("\nPressione Enter para sair");
            Console.ReadLine();

           
        }
    }
}