using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estrutura_De_Selecao_Switch
{
    class Program
    {

        // Usando #region para organiza��o do c�digo e melhor 
        // visualiza��o quando o projeto for crescendo !!!
        #region: �rea do M�todo Main;

        static void Main(string[] args)
        {
            string StrMes = string.Empty;
            string flag = "";

            // Primeira forma que escolhi para fazer 
            // a compara��o de igualdade com nega��o!
            while (!flag.ToUpper().Equals("SAIR"))
            {

                Console.WriteLine("Digite um N�mero ou Sair para encerrar o programa: ");

                flag = Console.ReadLine();

                switch (flag)
                {
                    case "1":
                        StrMes = "Janeiro";
                        break;
                    case "2":
                        StrMes = "Fevereiro";
                        break;
                    case "3":
                        StrMes = "Mar�o";
                        break;
                    case "4":
                        StrMes = "Abril";
                        break;
                    case "5":
                        StrMes = "Maio";
                        break;
                    case "6":
                        StrMes = "Junho";
                        break;
                    case "7":
                        StrMes = "Julho";
                        break;
                    case "8":
                        StrMes = "Agosto";
                        break;
                    case "9":
                        StrMes = "Setembro";
                        break;
                    case "10":
                        StrMes = "Outubro";
                        break;
                    case "11":
                        StrMes = "Novembro";
                        break;
                    case "12":
                        StrMes = "Dezembro";
                        break;
                    default:
                        // Segunda forma que escolhi para fazer a nega��o! 
                        if (flag.ToUpper() != "SAIR") { StrMes = "Inv�lido!"; }
                        // Pode ser Sair, SAIR, SAir, SaIr, sair, SaiR... Tudo se resolve com o m�todo .ToUpper().              
                        break;

                }

                Console.WriteLine("M�s escolhido � {0}", StrMes);

                // Linha em branco para espa�ar!
                Console.WriteLine();
                Console.WriteLine();

            }

            // Mensagem de despedida;
            Console.WriteLine("Bye, Bye... Tecle algo...");

            // Aguarda uma tecla ser pressionada 
            // para fechar o programa!
            Console.ReadKey();

        }

        #endregion: Fim da �rea do M�todo Main;

    }
}
