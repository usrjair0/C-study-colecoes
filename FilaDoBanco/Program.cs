using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Channels;

namespace FilaDoBanco
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Projeto: FilaDoBanco
            Console.WriteLine("--Fila de Banco--");
            Console.WriteLine($"{ADICIONAR}-Adicionar o nome do cliente");
            Console.WriteLine($"{CHAMAR}-Chamar o nome do cliente");
            Console.WriteLine($"{IMPRIMIR}-Imprimir a fila");
            Console.WriteLine($"{SAIR}-Sair do programa");
            Só posso sair do programa quando a fila acabar.
            */

            /*
             Array => problema é o limite
             ArrayList => problema é o boxing e o unboxing
             List<t> => manipular posição sem seguir o algoritimo FIFO (first in first out)
             queue => Segue o algoritmo FIFO, mas cuidado com box e unboxing;
             queue<t> => ideal para esse caso, pois segue o algoritmo fifo e por ser tipado
             não faz o Boxing e unboxing.
             stack => não pois segue o algoritmo LIFO - Last in first out, além disso faz o 
             boxing e unboxing.
             stack <t> => não pois segue o algoritmo LIFO
             */

            Console.WriteLine("--Fila de Banco--");

            const int ADICIONAR = 1, CHAMAR = 2, IMPRIMIR = 3, SAIRPROGRAMA = 4;

            Queue<string> fila = new Queue<string>();
            

            Console.WriteLine($"{ADICIONAR}-Adicionar o nome do cliente");
            Console.WriteLine($"{CHAMAR}-Chamar o nome do cliente");
            Console.WriteLine($"{IMPRIMIR}-Imprimir a fila");
            Console.WriteLine($"{SAIRPROGRAMA}-Sair do programa");
            

            bool sair = false;
            while(!sair){

                Console.Write("\nDigite sua opção: ");
                int opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case ADICIONAR:
                        Console.Write("Digite o nome do cliente: ");
                        fila.Enqueue(Console.ReadLine());
                        break;

                    case CHAMAR:
                        if (fila.Count != 0)
                        {
                            Console.WriteLine($"chamar {fila.Dequeue()}!");
                        }
                        else
                            Console.WriteLine("A fila está vazia!");
                        break;

                    case IMPRIMIR:
                        if(fila.Count > 0){
                            Console.WriteLine("A fila atual é composta por: ");
                            foreach (string nome in fila)
                            {
                                Console.WriteLine(nome);
                            };
                        }else {
                            Console.WriteLine("A fila está vazia.");
                        }
                        
                        break;

                    case SAIRPROGRAMA:
                        if (fila.Count == 0)
                        {
                            Console.WriteLine("Você irá sair do programa");
                            sair = true;
                        }
                        else
                            Console.WriteLine("Você não pode sair");
                        break;

                    
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }

                Console.WriteLine("Digite Enter para continuar");
                Console.ReadLine();
                Console.Clear();
            }
            
            Console.WriteLine("Digite Enter para sair");
            Console.ReadLine();

        }
    }
}
