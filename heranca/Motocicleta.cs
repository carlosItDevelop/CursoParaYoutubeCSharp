using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heranca
{
    class Motocicleta : Automovel
    {
        public Motocicleta()
            : base(2000, "Moto Honda", 23)
        {
            base.Porta = "Sem portas";
            base.Roda = "Aro 10";
            base.Volante = "Guidon";

        }
        public override void MostraObj()
        {
            string cotacao = (Precobom) ? "Bom" : "Caro";
            Console.WriteLine("\n\n");
            Console.WriteLine("\t> {0}: Ano: {1} - {2} - Roda: {3} - Volante: {4} - Preço: {5}", this.Tipo, this.Ano, Porta, Roda, Volante, cotacao);
        }
    }
}
