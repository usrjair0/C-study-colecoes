using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pilha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] z = { 1, 3, 6 };
            Stack<int> pilha = new Stack<int>();//fila
            pilha.Push(8);
            pilha.Push(9);
            pilha.Push(5);
            pilha.Push(-80); 

            int x = pilha.ElementAt(3);
            int y = pilha.Pop();

            List<int> list = new List<int>();
            list.Insert(0, 8);
            list.Insert(0, 9);
            list.Insert(0, 5);
            list.Insert(0, -80);
        }
    }
}
