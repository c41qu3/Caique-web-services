using System.Collections.Generic;

namespace ShoppingRural.Model
{
    public partial class Marca
    {
        public Marca()
        {
            Modelos = new List<Modelo>();
        }

        public int IdMarca { get; set; }
        public int IdCategoria { get; set; }
        public string Nome { get; set; }

        public virtual List<Modelo> Modelos { get; set; }
        public virtual Categoria Categoria { get; set; }
    }
}
