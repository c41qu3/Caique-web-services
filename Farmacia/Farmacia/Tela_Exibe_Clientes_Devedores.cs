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
            List<int> codsummes = new List<int>();
            List<int> codsdoismes = new List<int>();
            //pegando as pessoas em divida e colocando na lista de codigos
            for (int i = 0; i < lista.Count; i++)
            {
                data = lista[i].Data;
                String dia = data[0] + "" + "" + data[1];
                String mes = data[3]+""+""+data[4];
                String ano = data[6] + "" + "" + data[7]+data[8]+data[9] ;

               int dia1 = int.Parse(dia); 
               int mes1 = int.Parse(mes) ; 
               int ano1 = int.Parse(ano) ;

               TimeSpan date = Convert.ToDateTime(diaatual1 + "/" + mesatual1 + "/" + anoatual1) - Convert.ToDateTime(dia1 + "/" + mes1 + "/" + ano1);

               int totalDias = date.Days;

               if ( totalDias > 30 && totalDias < 60 )
               {
                   codsummes.Add(lista[i].Cod_divida); //lista de codigos de devedores de um mês
               }
               if (totalDias >= 60) {
                   codsdoismes.Add(lista[i].Cod_divida); //lista de codigos de devedores de dois meses
               }
            }

            //removendo os repetidos

            codsummes = codsummes.Distinct().ToList();
            codsdoismes = codsdoismes.Distinct().ToList();

            List<Pessoa> pessoas1mes = new List<Pessoa>();
            List<Pessoa> pessoas2meses = new List<Pessoa>();
            // pegando as pessoas em divida e colocando em outra lista;
          
            
            for (int y = 0; y < codsdoismes.Count; y++) //criando lista de pessoas com 2 meses de atraso
            {
                pessoas2meses.Add(pd.BuscarPorcod_divida(codsdoismes[y]));

            }



            List<int> aux = new List<int>();
           
            for (int l = 0; l < codsummes.Count; l++)  //criando lista de pessoas com 1 meses de atraso, e retirando quem deve a mais de 60 do bolo
            {
                bool testa = true;
                for (int y = 0; y < codsdoismes.Count; y++)
                {
                    if (codsummes[l] == codsdoismes[y])
                    {
                        testa = false;
                        break;
                    }
                      
                }
                if (testa == false)
                {

                }
                if (testa == true){
                    pessoas1mes.Add(pd.BuscarPorcod_divida(codsummes[l]));
                }
            }

           


            //exibindo

            for (int z = 0; z < pessoas2meses.Count; z++)
            {
                 
                dtvTodasdividas.Rows.Add(new object[] { pessoas2meses[z].Nome, pessoas2meses[z].Apelido, pessoas2meses[z].CPF});
            }
            for (int a = 0; a < pessoas1mes.Count; a++)
            {
                DgvUmMes.Rows.Add(new object[] { pessoas1mes[a].Nome, pessoas1mes[a].Apelido, pessoas1mes[a].CPF });
            }



        }

        private void dtvTodasdividas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
