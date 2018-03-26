using System.Collections.Generic;

namespace ShoppingRural.Model
{
    public partial class Categoria
    {
        public Categoria()
        {
            Marcas = new List<Marca>();
        }

        public int IdCategoria { get; set; }
        public string Nome { get; set; }

        public virtual List<Marca> Marcas { get; set; }
    }
}
