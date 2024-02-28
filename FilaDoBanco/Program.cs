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
            Console.WriteLine("--Fila de Banco--");

            Queue<string> fila = new Queue<string>();
            

            Console.WriteLine($"1-Adicionar o nome do cliente");
            Console.WriteLine($"2-Chamar o nome do cliente");
            Console.WriteLine($"3-Imprimir a fila");
            Console.WriteLine($"4-Sair do programa");

            bool sair = false;
            while(!sair){

                Console.Write("\nDigite sua opção: ");
                int opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.Write("Digite o nome do cliente: ");
                        fila.Enqueue(Console.ReadLine());
                        break;

                    case 2:
                        if (fila.Count != 0)
                        {
                            Console.WriteLine($"chamar {fila.Dequeue()}!");
                        }
                        else
                            Console.WriteLine("A fila está vazia!");
                        break;

                    case 3:
                        Console.WriteLine("A fila atual é composta por: ");
                        foreach (string nome in fila)
                        {
                            Console.WriteLine(nome);
                        };
                        break;

                    case 4:
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
            }
            
            Console.WriteLine("Digite Enter para sair");
                Console.ReadLine();

        }
    }
}
