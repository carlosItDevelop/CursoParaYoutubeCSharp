using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            // Esta instância tem o intuito 
            // de mostrar polimorfismo no método
            Automovel auto = new Automovel();
            auto.MostraObj();

            Fusca fusca = new Fusca();
            fusca.MostraObj();
            
            Chevete chev = new Chevete();
            chev.MostraObj();

            Motocicleta moto = new Motocicleta();
            moto.MostraObj();

            Console.ReadKey();

        }

    }
}
