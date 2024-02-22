using System;
using System.Collections.Generic;
using System.Collections;

namespace Fila
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> fila = new Queue<int>(); //fila
            fila.Enqueue(8);
            fila.Enqueue(9);
            fila.Enqueue(5);
            fila.Enqueue(-80);
            

            List<int> list = new List<int>();
            list.Add(8);
            list.Add(9);
            list.Add(5);
            list.Add(-80);

            list.RemoveAt(0);
        }
    }
}
