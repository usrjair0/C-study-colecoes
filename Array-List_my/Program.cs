using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_List_my
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int QTDNUMEROS = 5;
            int contador = 0;
            ArrayList numeros = new ArrayList();
            List<int> numeros1 = new List<int>();

            numeros1.Add(1);
            numeros1.Add(2);

            numeros1.Insert(1, 90);
            numeros1[0] = 3;

            bool x = numeros1.Remove(1); //remove a primeira ocorrência do valor 1 na minha list

            if (x == true)
                Console.WriteLine("número removido com sucesso");
            else
                Console.WriteLine("não foi encontrado o número!");


            numeros1.RemoveAt(1); //remove o valor no indice 1
            do
            {
                Console.WriteLine("informe um número:");
                numeros1.Add(int.Parse(Console.ReadLine()));

                contador++;
            } while (contador < QTDNUMEROS);

            numeros1.Add(10);

            //for(int i = 0; i < numeros.Count; i++) { }
        }
    }
}
