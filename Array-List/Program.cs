using System;
using System.Collections;

namespace Array_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Array / Vetor / Matriz Unidimensional
             * - conjunto de valores adjacentes em memória
             * - stack armazena um endereço
             * - tamanho fixo (alocação estática)
             * - acesso por índice (deslocamento de endereço)
             * - armazenamento de um único tipo de dado mediante sua declaração
             * 
             * Se precisar de mais itens além dos que foram alocados incialmente? :(
             *     Criar um novo conjunto e recuperar os dados do conjunto anterior
             * Se não utilizar todos os itens alocados? :(
             *     Desperdício de espaço de memória.
             */
            
            const int QTDENUMEROS = 5;
            int contador = 0;

            ArrayList numeros = new ArrayList();
            //List => Alocação é dinâmica do ponto de vista (programador) 
            //        Parece dinâmica, mas vou provar que não é.       
            //ArrayList => pode armazenar tipos de dados diferentes :(  (boxing - unboxing) :(
            //   Qual tipo de dado de um ArrayList? Qualquer tipo.. C# - qualquer tipo (object)
            //   1 => int => adicionar no ArrayList => Add(1) => 1 inteiro é convertido para objeto
            //   10.0 => double => adicionar no ArrayList => Add(10.0) => 10 double é convertido para objeto
            //   tipo por valor => tipo por referência (endereço) => BOXING (ímplicta) :(

            do
            {
                
                Console.Write("Informe um número:");
                numeros.Add(int.Parse(Console.ReadLine()));

                contador++;
            } while (contador < QTDENUMEROS); //5 - índices 0 a 4

            numeros.Add(10); // i - 5
            numeros.Add("Texto"); // i - 6
            numeros.Add(10.2); // i - 7
            numeros.Add(null); // i - 8 - qtde 9 -> (exceder o capacity => realocação para 16 blocos)

            numeros.Add('x'); // i - 9 

            //numeros.Capacity = numeros.Count;

            numeros.Add(11);
            numeros.Add(12);
            numeros.Add(13);

            //tamanho do ArrayList para o programador nesse momento? 9

            double x = (double) numeros[7];
            // conversão explícita object => tipo (double) - UNBOXING :(
            // conversão de tipo por referência para tipo valor - UNBOXING :(


            //Processo => BOXING E UNBOXING. CUIDADO!!!!!!! 

            Console.ReadLine();
        }
    }
}
