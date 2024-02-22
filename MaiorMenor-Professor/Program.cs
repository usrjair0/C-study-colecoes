using System;

/*
 * Faça um programa que determine o maior e o menor entre N números. A condição de parada é
a entrada de um valor 0, ou seja, o programa deve ficar calculando o maior e o menor até que a
entrada seja igual a 0 (ZERO). No entanto, no final deste programa, apresente os números lidos,
o maior e o menor número. O usuário poderá digitar no máximo até 100 números.
 */


/*
 * !!!!!!!!!!!!!!!!!!! CUIDADO !!!!!!!!!!!!!!!!!!!!!!!!!
 * C# => var => definição do tipo de dados em tempo de compilação.
 * JS => var => definição do escopo da variável.
 */

namespace MaiorMenor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Programa Maior Menor--");

            const int QTDENUMEROS = 5; //100
            int[] numeros = new int [QTDENUMEROS];
            int contador = 0;

            int menor = int.MaxValue; //var => definição do tipo de dado em tempo de compilação. (tipo de dado estático)
            int maior = int.MinValue;

            do
            {
                Console.Write("Informe um número:");
                numeros[contador] = int.Parse(Console.ReadLine());
                                
                if (numeros[contador] == 0)
                    break;

                if (numeros[contador] > maior)
                    maior = numeros[contador];

                if (numeros[contador] < menor)
                    menor = numeros[contador];                

                contador++;
            } while (contador < QTDENUMEROS);

            if (contador > 0)
            {
                Console.WriteLine($"Maior:{maior}");
                Console.WriteLine($"Menor:{menor}");

                for (int i = 0; i < contador; i++)
                {
                    Console.Write($"{numeros[i]} ");
                }

                //int indice2 = 0;
                //while (indice2 < contador)
                //{
                //    Console.Write($"{numeros[indice2]} - ");
                //    indice2++;
                //}

            }
            else
                Console.WriteLine("Nenhum valor foi informado.");

            //foreach (var numero in numeros)
            //{
            //    if (numero == 0)
            //        break;

            //    Console.Write($"{numero} - ");                
            //}

            //int indice1 = 0; CUIDADO => SE O USUÁRIO NÃO INFORMAR O 0, CÓDIGO QUEBRA. Poderia colocar um && na decisão, mas........
            //do
            //{

            //    if (numeros[indice1] == 0)
            //        break;

            //    Console.Write($"{numeros[indice1]} - ");
            //    indice1++;

            //} while (true);
                                   

            Console.WriteLine("Pressione ENTER para encerrar");
            Console.ReadLine();
        }
    }
}
