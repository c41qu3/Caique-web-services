using System;
using System.Collections.Generic;

namespace ShoppingRural.Model
{
    public partial class Produto
    {
        public Produto()
        {
            Anuncios = new List<Anuncio>();
            Imagens = new List<Imagem>();
        }
        public int IdPdotudo { get; set; }
        public int IdModelo { get; set; }
        public int IdUsuario { get; set; }
        public int Ano { get; set; }
        public decimal Valor { get; set; }
        public string Descricao { get; set; }
        public DateTime DataCadastro { get; set; }

        public virtual List<Anuncio> Anuncios { get; set; }
        public virtual List<Imagem> Imagens { get; set; }
        public virtual Modelo Modelo { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
