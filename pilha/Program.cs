using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> pilha1 = new Stack<int>();
            pilha1.Push(8);
            pilha1.Push(9);
            pilha1.Push(5);
            pilha1.Push(-80);

            int x = pilha1.ElementAt(3);
            int y = pilha1.Pop();

            List<int> lista1 = new List<int>();
            lista1.Insert(0, 8);
            lista1.Insert(0, 9);
            lista1.Insert(0, 5);
            lista1.Insert(0, -80);

            lista1.RemoveAt(0);
        }
    }
}
