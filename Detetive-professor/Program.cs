using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Detetive
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Detetive--");

            string[] perguntinhas = {
                "Telefonou para a vítima? | SIM = 1 NÃO = 0:",
                "Esteve no local do crime? | SIM = 1 NÃO = 0:",
                "Mora perto da vítima? | SIM = 1 NÃO = 0:",
                "Devia para a vítima? | SIM = 1 NÃO = 0:",
                "Já trabalhou com a vítima? | SIM = 1 NÃO = 0:"
            };

            string[] veredicto = {
                "Inocente",
                "Inocente",
                "Suspeito",
                "Cumplice",
                "Cumplice",
                "Assasino"
            };

            int contadorRespostas = 0;

            for (int i = 0; i < perguntinhas.Length; i++)
            {                
                Console.Write($"{perguntinhas[i]}");
                contadorRespostas += int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"{veredicto[contadorRespostas]}");

            Console.WriteLine("--Pressione ENTER para encerrar--");
            Console.ReadLine();
        }
    }
}
