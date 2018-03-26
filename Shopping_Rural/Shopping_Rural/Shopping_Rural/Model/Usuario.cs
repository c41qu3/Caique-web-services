using System;
using System.Collections.Generic;

namespace ShoppingRural.Model
{
    public partial class Usuario
    {
       //public Usuario()
       // {
       ///Produtos = new List<Produto>();
       // }

        public int IdUsuario { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Senha { get; set; }
        public string DataCadastro { get; set; }
        public bool Administrador { get; set; }

        //public virtual List<Produto> Produtos { get; set; }
    }
}
