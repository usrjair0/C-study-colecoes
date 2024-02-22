using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Lista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List => Alocação é dinâmica do ponto de vista(programador)
            //Capacity e Count é exatamente a mesma do ArrayList :)
            //Não tem Boxing e Unboxing => pois o tipo de dados está definido. :)

            List<int> numeros = new List<int>();

            numeros.Add(1);
            numeros.Add(2);

            numeros.Insert(1, 90);

            numeros.Add(1);

            if (numeros.Remove(1))
                Console.Write("Número removido com sucesso");
            else
                Console.Write("Número não foi encontrado");

            numeros.RemoveAt(80);
            
            const int QTDENUMEROS = 5;
            int contador = 0;

            do
            {

                Console.Write("Informe um número:");
                numeros.Add(int.Parse(Console.ReadLine()));

                contador++;
            } while (contador < QTDENUMEROS);

            //int x = numeros[0];
        }        
    }
}
