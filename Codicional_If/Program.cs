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
            Console.WriteLine("Digite um número: ");
            i = int.Parse(Console.ReadLine());

            string msg = string.Empty;  // Poderia ser assim: string msg = "";
            if (i > 10)
            {
                msg = "maior que 10";
            } else { msg = "menor que 10"; }

            Console.WriteLine("O número digitado é {0}", msg);
            Console.ReadKey();
        }
    }
}
