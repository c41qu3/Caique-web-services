using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Farmacia
{
    public partial class Tela_Exibe_Clientes_Devedores : Form
    {
        public Tela_Exibe_Clientes_Devedores()
        {
            InitializeComponent();
        }

        private void Tela_Exibe_Clientes_Devedores_Load(object sender, EventArgs e)
        {
            PessoaDAL pd = new PessoaDAL();
            List<Divida> lista = new List<Divida>();
            lista = pd.ListarTodasDividas();

            

            //pegando data e ano atual
            DateTime dt = new DateTime();
            dt = DateTime.Now;
            String dataatual = dt.ToShortDateString()+dt.ToShortTimeString();

            String diaatual = (dataatual[0] + "" + "" + dataatual[1]);
            String mesatual = (dataatual[3] + "" + "" + dataatual[4]);
            String anoatual = (dataatual[6] + "" + "" + dataatual[7] + dataatual[8] + dataatual[9]);

            int diaatual1 = int.Parse(diaatual);
            int mesatual1 = int.Parse(mesatual);
            int anoatual1 = int.Parse(anoatual); 

            //criando a lista de códigos e as datas do banco
            String data;
            List<int> listacodigos = new List<int>(); 
            //pegando as pessoas em divida e colocando na lista de codigos
            for (int i = 0; i < lista.Count; i++)
            {
                data = lista[i].Data;
                String dia = data[0] + "" + "" + data[1];
                String mes = data[3]+""+""+data[4];
                String ano = data[6] + "" + "" + data[7]+data[8]+data[9] ;

               int dia1 = int.Parse(dia); 
               int mes1 = int.Parse(mes) ; // conversão para inteiro "O -1 É APENAS PARA TESTES"
               int ano1 = int.Parse(ano) ;

               if ((diaatual1 >= dia1 && (mesatual1 > mes1 || anoatual1 > ano1))|| mes1+2 <= mesatual1 && diaatual1< dia1  )
               {
                   listacodigos.Add(lista[i].Cod_divida);
               }
               if (ano1 < anoatual1) {
                   listacodigos.Add(lista[i].Cod_divida);
               }
            }

            //removendo os repetidos

            listacodigos = listacodigos.Distinct().ToList();

            List<Pessoa> pessoasEmDivida = new List<Pessoa>(); 
            // pegando as pessoas em divida e colocando em outra lista;
            for (int x = 0; x< listacodigos.Count; x++)
            {
                pessoasEmDivida.Add (pd.BuscarPorcod_divida(listacodigos[x]));
               
            }

           //exibindo
           
            for (int x = 0; x < pessoasEmDivida.Count; x++)
            {
                 
                dtvTodasdividas.Rows.Add(new object[] { pessoasEmDivida[x].Nome, pessoasEmDivida[x].Apelido, pessoasEmDivida[x].CPF});
            }


        }

        private void dtvTodasdividas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
