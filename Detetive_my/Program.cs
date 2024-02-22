using System;
namespace Detetive_my
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool[] resposta = new bool[5];

            Console.WriteLine("Projeto Detetive");
            Console.WriteLine("Telefonou para a vítima?");
            resposta[0] = Console.ReadLine().ToLower() == "sim";
            Console.WriteLine("Esteve no local do crime?");
            resposta[1] = Console.ReadLine().ToLower() == "sim";
            Console.WriteLine("Mora perto da vítima?");
            resposta[2] = Console.ReadLine().ToLower() == "sim";
            Console.WriteLine("Devia para a vítima?");
            resposta[3] = Console.ReadLine().ToLower() == "sim";
            Console.WriteLine("Já trabalhou com a vítima?");
            resposta[4] = Console.ReadLine().ToLower() == "sim";
            int cont = 0;
            for (int i = 0; i < resposta.Length; i++)
            {
                if (resposta[i]) { cont++; }
            }
            switch (cont)
            {
                case 0:
                case 1:
                    Console.WriteLine("inocente");
                    break;
                case 2:
                    Console.WriteLine("suspeita");
                    break;
                case 3:
                case 4:
                    Console.WriteLine("cumplice");
                    break;
                case 5:
                    Console.WriteLine("assassino");
                    break;
            }
            Console.Write("Pressione qqer tecla para encerrar");
            Console.ReadKey();
        }
    }
}
