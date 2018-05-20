using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heranca
{
    class Chevete : Automovel
    {
        public Chevete() :base(1996, "Chevete", 83){
            base.Porta = "2 portas";
            base.Roda = "Aro 14";
            base.Volante = "Encapado";
        }
        public override void MostraObj()
        {
            string cotacao = (Precobom) ? "Bom" : "Caro";
            Console.WriteLine("\n\n");
            Console.WriteLine("\t> {0}: Ano: {1} - {2} - Roda: {3} - Volante: {4} - Preço: {5}", this.Tipo, this.Ano, Porta, Roda, Volante, cotacao);
        }

    }
}
