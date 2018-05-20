using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estrutura_De_Selecao_Switch
{
    class Program
    {

        // Usando #region para organização do código e melhor 
        // visualização quando o projeto for crescendo !!!
        #region: Área do Método Main;

        static void Main(string[] args)
        {
            string StrMes = string.Empty;
            string flag = "";

            // Primeira forma que escolhi para fazer 
            // a comparação de igualdade com negação!
            while (!flag.ToUpper().Equals("SAIR"))
            {

                Console.WriteLine("Digite um Número ou Sair para encerrar o programa: ");

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
                        StrMes = "Março";
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
                        // Segunda forma que escolhi para fazer a negação! 
                        if (flag.ToUpper() != "SAIR") { StrMes = "Inválido!"; }
                        // Pode ser Sair, SAIR, SAir, SaIr, sair, SaiR... Tudo se resolve com o método .ToUpper().              
                        break;

                }

                Console.WriteLine("Mês escolhido é {0}", StrMes);

                // Linha em branco para espaçar!
                Console.WriteLine();
                Console.WriteLine();

            }

            // Mensagem de despedida;
            Console.WriteLine("Bye, Bye... Tecle algo...");

            // Aguarda uma tecla ser pressionada 
            // para fechar o programa!
            Console.ReadKey();

        }

        #endregion: Fim da Área do Método Main;

    }
}
