using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class Carro
    {
        public int Codigo { get; set; }
        public String Modelo { get; set; }
        public String Km { get; set; }
        public String Combustivel { get; set; }
        public String Cambio { get; set; }
        public String FinalPlaca { get; set; }
        public String Ano { get; set; }
        public String Cor { get; set; }
        public String Preco { get; set; }
        public byte[] Foto1 { get; set; }
        public byte[] Foto2 { get; set; }
        public byte[] Foto3 { get; set; }
        public byte[] Foto4 { get; set; }
        public byte[] Foto5 { get; set; }
        public byte[] Foto6 { get; set; }
        public String opcao { get; set; }
    }
}
