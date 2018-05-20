using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laco_For
{
    class Program
    {
        static void Main(string[] args)
        {
            // Duas maneiras de se comentar. (Primeira)
            /* 
             *(Segunda)
             
              Numa turma há 12 alunos e a professora quer formar grupos distintos            
              de 3 alunos cada. Pergunta-se: Quantos grupos podem ser formados?
              -------------------------------------------------------------------
              EXERCÍCIO PARA A PRÓXIMA AULA. 
              - Primeiro vamos aprender o laço de repetição For
             
             */
            #region: Cabeçalho;
            
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("\t======================================");
            Console.WriteLine("\tVAMOS IMPRIMIR OS QUADRADOS DE 01 A 08");
            Console.WriteLine("\t======================================");
            Console.WriteLine("");
            Console.WriteLine("");
            
            #endregion

            #region: Região do Laço For;

            for (int i = 1; i <= 8; i++)
            {

                // Utilizando formatação com mais 
                // de um elemento a ser mostrado!
                
                Console.WriteLine("\t  {0}) - O quadrado de {1} é igual a: {2}", i, i, i*i);
                Console.WriteLine();

            }

            #endregion

            #region: Região Rodapé.

            // Aguarda uma tecla ser pressionada!
            Console.WriteLine("");
            Console.WriteLine("\t====================================");
            Console.WriteLine("\tBye, bye...  Tecle algo para sair...");
            Console.WriteLine("\t====================================");
            Console.WriteLine("");
            Console.ReadKey();

            #endregion

        }
    }
}
