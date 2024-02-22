using System;
using System.Collections;

/*
 * Faça um programa que construa um vetor (array) de 10 posições de números inteiros armazenando em
sua primeira posição o valor 10, na segunda posição, o dobro do valor da primeira posição, 20,
na terceira posição, o dobro do valor da segunda posição, 40, e assim por diante. Ao final,
mostre o valor armazenado na 8ª posição e a soma de todos os valores armazenados no vetor. * 
 */

namespace ArrayValores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Programa Array Valores--");

            //const int QTDEVALORES = 10;

            //int[] numeros = new int[QTDEVALORES];
            int[] numeros = new int[10];

            numeros[0] = 10;
            int soma = numeros[0];

            Console.WriteLine($"Índice:0 = {numeros[0]}");

            //for (int i = 1; i < QTDEVALORES; i++)
            for (int i = 1; i < numeros.Length; i++)            
            {
                numeros[i] = numeros[i - 1] * 2;                
                soma += numeros[i];

                Console.WriteLine($"Índice:{i} = {numeros[i]}");
            }

            //int iDo = 1;
            //do
            //{
            //    numeros[iDo] = numeros[iDo - 1] * 2;
            //    soma += numeros[iDo];
            //    iDo++;
            //} while (iDo < numeros.Length);

            //Console.WriteLine($"Valor da última posição:{numeros[QTDEVALORES - 1]}");
            Console.WriteLine($"Valor da última posição:{numeros[numeros.Length - 1]}");
            Console.WriteLine($"Soma de todos os valores:{soma}");


            int y = 1;
            int z = y;

            int[] numerosB = new int[10];
            for (int i = 0; i < 10; i++)
            {
                numerosB[i] = numeros[i];
            }

            numerosB[0] = 50;

            int[] numerosC = numerosB; // Cuidado (duas variáveis apontando para o mesmo endereço => endereço inicial de numerosB)
            numerosB[0] = 80;
            numerosC[0] = 70;


            Console.WriteLine("Pressione ENTER para encerrar");
            Console.ReadLine();
        }
    }
}
