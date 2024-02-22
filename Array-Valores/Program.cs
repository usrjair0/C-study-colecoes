using System;

namespace ArrayValores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Projeto ArrayValores--");

            int[] valores = new int[8];
            valores[0] = 10;
            int soma = 10;

            for (int i = 1; i < valores.Length; i++)
            {
                valores[i] = valores[i - 1] * 2;
                soma += valores[i];
            }

            int ultimoValor = valores[valores.Length -1];

            Console.WriteLine($"O ultimo valor é {ultimoValor} e a soma é {soma}");
            Console.WriteLine("Enter para finalizar");
            Console.ReadLine();
        }
    }
}
