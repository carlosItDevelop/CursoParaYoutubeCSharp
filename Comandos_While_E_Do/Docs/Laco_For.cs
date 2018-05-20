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
             
              Numa turma h� 12 alunos e a professora quer formar grupos distintos            
              de 3 alunos cada. Pergunta-se: Quantos grupos podem ser formados?
              -------------------------------------------------------------------
              EXERC�CIO PARA A PR�XIMA AULA. 
              - Primeiro vamos aprender o la�o de repeti��o For
             
             */
            #region: Cabe�alho;
            
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("\t======================================");
            Console.WriteLine("\tVAMOS IMPRIMIR OS QUADRADOS DE 01 A 08");
            Console.WriteLine("\t======================================");
            Console.WriteLine("");
            Console.WriteLine("");
            
            #endregion

            #region: Regi�o do La�o For;

            for (int i = 1; i <= 8; i++)
            {

                // Utilizando formata��o com mais 
                // de um elemento a ser mostrado!
                
                Console.WriteLine("\t  {0}) - O quadrado de {1} � igual a: {2}", i, i, i*i);
                Console.WriteLine();

            }

            #endregion

            #region: Regi�o Rodap�.

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
