using System;
using System.Collections.Generic;

namespace Fila_Pilha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa FIla Pilha");

            Queue<int> fila = new Queue<int>();
            Stack<int> pilha = new Stack<int>();
            int continuar = 0;

            do
            {
                Console.Write("Informe um numero Inteiro: ");
                fila.Enqueue(int.Parse(Console.ReadLine()));
                Console.Write("Gostaria de continuar? 1 - para sim e 2 - para nao: ");
                continuar = int.Parse(Console.ReadLine());

            }
            while (continuar != 2);

            while (fila.Count > 0)
            {
                pilha.Push(fila.Dequeue());
            }

            while (pilha.Count > 0)
            {
                Console.WriteLine(pilha.Pop());
            }

            /* foreach(int item in fila)
                 pilha.Push(item);

             foreach (int item in pilha)
                 Console.WriteLine(item);
            */
            Console.WriteLine("Prima ENter para sair");
            Console.ReadLine();
        }
    }
}