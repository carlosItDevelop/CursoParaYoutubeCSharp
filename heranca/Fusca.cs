using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heranca
{
    /// <summary>
    /// Clase Fusca que herda (Herança) as 
    /// propriedades comuns de automóveis;
    /// </summary>
    class Fusca: Automovel
    {


        public Fusca() : base(1981, "Fusca", 240)             
        {
            base.Porta = "4 portas";
            base.Roda = "Aro 16";
            base.Volante = "Moderno";
        }

        /// <summary>
        /// Método MostraObj (Usando override)
        /// que demonstra polimorfismo!
        /// </summary>
        public override void MostraObj()
        {
            string cotacao = (Precobom) ? "Bom" : "Caro";
            Console.WriteLine("\n\n");
            Console.WriteLine("\t> {0}: Ano: {1} - {2} - Roda: {3} - Volante: {4} - Preço: {5}", this.Tipo, this.Ano, Porta, Roda, Volante, cotacao);
        }

    }
}
