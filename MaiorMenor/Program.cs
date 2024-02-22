using System;


namespace MaiorMenor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Projeto MaiorMenor--");

            int maior = int.MinValue, menor = int.MaxValue, n = 0, contador=0;
            int[] numeros = new int[100];
            
            do
            {
                Console.WriteLine("Digite um número inteiro qualquer (0 para sair): ");
                numeros[contador] = int.Parse(Console.ReadLine());

                if (numeros[contador] == 0)
                    break;

                if (numeros[contador] > maior)
                    maior = numeros[contador];

                if (numeros[contador] < menor)
                    menor = numeros[contador];
                
                contador++;
            } while(contador < 100);
            if (contador > 0)
            {
                Console.WriteLine($"O maior número é: {maior}");
                Console.WriteLine($"O menor número é: {menor}");

                int indice = 0;
                while (indice < contador)
                {
                    Console.Write($"{numeros[indice]} ");
                    indice++;
                };
            }
            else
                Console.WriteLine("Nenhum número foi informado!");



            //foreach ( var numero in numeros ) 
            //{
            //    if (numero == 0)
            //        break;
            //    Console.Write($"{numero}-");
            //



            Console.WriteLine("\nEnter para finalizar");
            Console.ReadLine();
        }
    }
}
