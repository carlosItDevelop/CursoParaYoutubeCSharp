using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comandos_While_E_Do
{
    class Program
    {
        static void Main(string[] args)
        {
            int k;
            do
            {
                Console.WriteLine("Escreva um n�mero na tela: ");
                k = int.Parse(Console.ReadLine());
                Console.WriteLine("N�mero Digitado: {0}", k);
                Console.WriteLine();
                Console.WriteLine();
            } while (k != 10);
        }
    }
}
