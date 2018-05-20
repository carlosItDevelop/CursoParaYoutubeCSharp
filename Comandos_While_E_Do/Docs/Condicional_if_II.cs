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

            // N�o precisaria de formata��o, mas vamos criar o h�bito!!!
            Console.WriteLine("Escolha: ({0}) IF aninhado  -   ({1}) IF na mesma LINHA", 1,2);

            Console.WriteLine("\n\n");

            string escolha = Console.ReadLine();

            // Aqui escolhi duas formas de
            // nega��o => "!" com Equal() e "!="
            // E tamb�m quero apresentar o IF sem as 
            // Chaves, pois s� tem uma linha (return).
            if ((!escolha.Equals("1")) && (escolha != "2")) return;

            // APROVEITANDO PARA 
            // CHAMAR O PRIMEIRO M�TODO
            if (escolha == "1")
            {
                ChamaMetodoPrintMsg("Chamando Metodo (ESCOLHA 1) IF Convencional!");
            } else {
                ChamaMetodoPrintMsg("Chamando Metodo (ESCOLHA 2) IF Convencional!");
            }

            string msg = (escolha == "1") ? "Chamando Metodo (ESCOLHA 1) IF na mesma LINHA (TRUE)!" : "Chamando Metodo (ESCOLHA 2) IF na mesma LINHA (FALSE)!";


            // Aqui chamo o m�todo utilizando 
            //o Operador "?" e com a vari�vel "msg".
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
