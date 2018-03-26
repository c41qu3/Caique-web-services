using System;
using System.Collections.Generic;

namespace ShoppingRural.Model
{
    public partial class Anuncio
    {
        public int IdAnuncio { get; set; }
        public int IdProduto { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime? DataFim { get; set; }
        public bool Permanente { get; set; }

        public virtual Produto Produto { get; set; }
    }
}
