using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fila
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> fila1 = new Queue<int>();
            fila1.Enqueue(8);
            fila1.Enqueue(9);
            fila1.Enqueue(5);
            fila1.Enqueue(-80);
                        
            int x = fila1.ElementAt(3);
            int y = fila1.Dequeue();                      

            List<int> lista1 = new List<int>();
            lista1.Add(8);
            lista1.Add(9);
            lista1.Add(5);
            lista1.Add(-80);

            lista1.RemoveAt(0);
        }
    }
}
