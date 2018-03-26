using System.Collections.Generic;

namespace ShoppingRural.Model
{
    public partial class Modelo
    {
        public Modelo()
        {
            Produtos = new List<Produto>();
        }

        public int IdModelo { get; set; }
        public int IdMarca { get; set; }
        public string Nome { get; set; }

        public virtual List<Produto> Produtos { get; set; }
        public virtual Marca Marca { get; set; }
    }
}
