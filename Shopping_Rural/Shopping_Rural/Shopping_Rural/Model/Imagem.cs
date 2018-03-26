
namespace ShoppingRural.Model
{
    public partial class Imagem
    {
        public int IdImagem { get; set; }
        public int IdProduto { get; set; }
        public string Nome { get; set; }

        public virtual Produto Produto { get; set; }
    }
}
