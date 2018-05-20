using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heranca
{
    public class Automovel
    {

        #region: Variáveis de Instância

        private int ano = int.MinValue;
        private string tipo = string.Empty;
        private int preco = int.MinValue;
        private bool precobom = false;

        #endregion

        public Automovel(int ano, string tipo, int preco) {
            this.tipo = tipo;
            this.ano = ano;
            this.preco = preco;
        }

        // Construtor polimórfico!!!
        public Automovel()
        {
        }

        public virtual void MostraObj()
        {
            Console.WriteLine("\n\n");
            Console.WriteLine("\t Mostrando Objetos: Automóveis - Classe Base (Pai)");
            Console.WriteLine("\t =================================================");
            Console.ReadKey();

        }

        #region: Propriedades do Objeto.

        /// <summary>
        /// propriedade Roda 
        /// (Demostrando Encapsulamento)
        /// </summary>
        public string Roda { get; set; }
        public string Porta { get; set; }
        public string Volante { get; set; }

        public int Ano
        {
            get { return ano; }
            set { ano = value; }
        }

        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        /// <summary>
        /// Regras de negócios encapsuladas!
        /// E método Somente Leitura!!!
        /// </summary>
        public bool Precobom
        {
            get 
            {
                if (preco < 100) precobom = true;
                return precobom; 
            }
        }

        #endregion

    }
}
