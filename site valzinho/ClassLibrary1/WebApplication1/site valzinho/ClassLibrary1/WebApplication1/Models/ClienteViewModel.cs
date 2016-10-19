using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DAL.Persistence;
using DAL.Model;
using System.ComponentModel.DataAnnotations;
using System.Text;
namespace WebApplication2.Models
{
    public class ClienteViewModel
    {
        [Required(ErrorMessage = "*campo obrigatório")]
        public int Codigo { get; set; }
        [Required(ErrorMessage = "*campo obrigatório")]
        public String Modelo { get; set; }
        [Required(ErrorMessage = "*campo obrigatório")]
        public String Km { get; set; }
        [Required(ErrorMessage = "*campo obrigatório")]
        public String Combustivel { get; set; }
        [Required(ErrorMessage = "*campo obrigatório")]
        public String Cambio { get; set; }
        [Required(ErrorMessage = "*campo obrigatório")]
        public String FinalPlaca { get; set; }
        [Required(ErrorMessage = "*campo obrigatório")]
        public String Ano { get; set; }
        [Required(ErrorMessage = "*campo obrigatório")]
        public String Cor { get; set; }
        [Required(ErrorMessage = "*campo obrigatório")]
        public String Preco { get; set; }
        [Required(ErrorMessage = "*campo obrigatório")]
        public HttpPostedFileBase Foto1 { get; set; }
        [Required(ErrorMessage = "*campo obrigatório")]
        public HttpPostedFileBase Foto2 { get; set; }
        [Required(ErrorMessage = "*campo obrigatório")]
        public HttpPostedFileBase Foto3 { get; set; }
        [Required(ErrorMessage = "*campo obrigatório")]
        public HttpPostedFileBase Foto4 { get; set; }
        [Required(ErrorMessage = "*campo obrigatório")]
        public HttpPostedFileBase Foto5 { get; set; }
        [Required(ErrorMessage = "*campo obrigatório")]
        public HttpPostedFileBase Foto6 { get; set; }
        public String Opcao { get; set; }

        public ClienteViewModel()
        {


        }

        
    } 
    public class ClienteViewModelTela{
        [Required(ErrorMessage = "*campo obrigatório")]
        public int Codigo { get; set; }
        [Required(ErrorMessage = "*campo obrigatório")]
        public String Modelo { get; set; }
        [Required(ErrorMessage = "*campo obrigatório")]
        public String Km { get; set; }
        [Required(ErrorMessage = "*campo obrigatório")]
        public String Combustivel { get; set; }
        [Required(ErrorMessage = "*campo obrigatório")]
        public String Cambio { get; set; }
        [Required(ErrorMessage = "*campo obrigatório")]
        public String FinalPlaca { get; set; }
        [Required(ErrorMessage = "*campo obrigatório")]
        public String Ano { get; set; }
        [Required(ErrorMessage = "*campo obrigatório")]
        public String Cor { get; set; }
        [Required(ErrorMessage = "*campo obrigatório")]
        public String Preco { get; set; }
        [Required(ErrorMessage = "*campo obrigatório")]
        public String Opcao1 { get; set; }
        [Required(ErrorMessage = "*campo obrigatório")]
        public String Opcao2 { get; set; }
        [Required(ErrorMessage = "*campo obrigatório")]
        public String Opcao3 { get; set; }
        [Required(ErrorMessage = "*campo obrigatório")]
        public String Opcao4 { get; set; }
        [Required(ErrorMessage = "*campo obrigatório")]
        public String Opcao5 { get; set; }
        [Required(ErrorMessage = "*campo obrigatório")]
        public String Opcao6 { get; set; }
        public String Foto1 { get; set; }
        public String Foto2 { get; set; }
        public String Foto3 { get; set; }
        public String Foto4 { get; set; }
        public String Foto5 { get; set; }
        public String Foto6 { get; set; }

        public ClienteViewModelTela() { 
        
        }
        public ClienteViewModelTela(Carro c) //esse modelo eu uso pra exibir
        {
            Codigo = c.Codigo;
            Modelo = c.Modelo;
            Km = c.Km;
            Combustivel = c.Combustivel;
            Cambio = c.Cambio ;
            FinalPlaca = c.FinalPlaca;
            Ano = c.Ano;
            Cor = c.Cor;
            Preco = c.Preco;
            String[] receptor = c.opcao.Split(',');
            Opcao1 = receptor[0];
            Opcao2 = receptor[1];
            Opcao3 = receptor[2];
            Opcao4 = receptor[3];
            Opcao5 = receptor[4];
            Opcao6 = receptor[5];
            
            string IB1 = Convert.ToBase64String(c.Foto1);
            Foto1 = string.Format("data:image/gif;base64,{0}", IB1);
            string IB2 = Convert.ToBase64String(c.Foto2);
            Foto2 = string.Format("data:image/gif;base64,{0}", IB2);
            string IB3 = Convert.ToBase64String(c.Foto3);
            Foto3 = string.Format("data:image/gif;base64,{0}", IB3);
            string IB4 = Convert.ToBase64String(c.Foto4);
            Foto4 = string.Format("data:image/gif;base64,{0}", IB4);
            string IB5 = Convert.ToBase64String(c.Foto5);
            Foto5 = string.Format("data:image/gif;base64,{0}", IB5);
            string IB6 = Convert.ToBase64String(c.Foto6);
            Foto6 = string.Format("data:image/gif;base64,{0}", IB6);

            //string imageBase64 = Convert.ToBase64String(pessoa.Foto);//conversão pra base 64
            //Foto = string.Format("data:image/gif;base64,{0}", imageBase64);
        }

    }
}
