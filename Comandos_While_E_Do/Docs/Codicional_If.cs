using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codicional_If
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = int.MinValue;
            Console.WriteLine("Digite um n�mero: ");
            i = int.Parse(Console.ReadLine());

            string msg = string.Empty;  // Poderia ser assim: string msg = "";
            if (i > 10)
            {
                msg = "maior que 10";
            } else { msg = "menor que 10"; } // Escrevi assim porque s� tem uma linha.

            Console.WriteLine("O n�mero digitado � {0}", msg);
            Console.ReadKey();
        }
    }
}
