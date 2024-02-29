using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Função
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inicio");
            pularLinha(2);

            Console.WriteLine("Meio");

            pularLinha(5);

            Console.WriteLine("Fim");
            pularLinha(1);

            Console.WriteLine("Digite Enter para sair");
            Console.ReadLine();

        }

        //Essa função não necessita de retorno então uso void, poderia usar, mas não
        //necessito
        static void pularLinha(int quantidade)
        {
            for (int i = 0; i < quantidade; i++)
            Console.WriteLine();
        }
        
        static int somar(int number1, int number2)
        {
            return number1 + number2;
        }

    }
}
