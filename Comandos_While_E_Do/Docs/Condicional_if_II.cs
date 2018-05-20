using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condicional_IF_II
{
    class Program
    {
        static void Main(string[] args)
        {

            // Utilizando outro tipo de quebra de linha;
            Console.WriteLine("\n\n");

            // Não precisaria de formatação, mas vamos criar o hábito!!!
            Console.WriteLine("Escolha: ({0}) IF aninhado  -   ({1}) IF na mesma LINHA", 1,2);

            Console.WriteLine("\n\n");

            string escolha = Console.ReadLine();

            // Aqui escolhi duas formas de
            // negação => "!" com Equal() e "!="
            // E também quero apresentar o IF sem as 
            // Chaves, pois só tem uma linha (return).
            if ((!escolha.Equals("1")) && (escolha != "2")) return;

            // APROVEITANDO PARA 
            // CHAMAR O PRIMEIRO MÉTODO
            if (escolha == "1")
            {
                ChamaMetodoPrintMsg("Chamando Metodo (ESCOLHA 1) IF Convencional!");
            } else {
                ChamaMetodoPrintMsg("Chamando Metodo (ESCOLHA 2) IF Convencional!");
            }

            string msg = (escolha == "1") ? "Chamando Metodo (ESCOLHA 1) IF na mesma LINHA (TRUE)!" : "Chamando Metodo (ESCOLHA 2) IF na mesma LINHA (FALSE)!";


            // Aqui chamo o método utilizando 
            //o Operador "?" e com a variável "msg".
            ChamaMetodoPrintMsg(msg);

            Console.WriteLine("\n\n");
            Console.WriteLine("Bye, bye... Tecle algo...");
            Console.ReadKey();


        }


        private static void ChamaMetodoPrintMsg(string msg)
        {
            Console.WriteLine("\n\n");
            Console.WriteLine(msg);
        }




    }
}
