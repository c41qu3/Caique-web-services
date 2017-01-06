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
    public partial class ultimos_pagamentos : Form
    {
        public ultimos_pagamentos()
        {
            InitializeComponent();
        }

        private void ultimos_pagamentos_Load(object sender, EventArgs e)
        {
            PessoaDAL pd = new PessoaDAL();
            List<Lixo> l = pd.ListarLixo();


            for (int i = 0; i < l.Count; i++)
            {
                dataGridView1.Rows.Add(new object[] { l[i].Nome_Cliente,l[i].Produto, l[i].Data_Pagamento,l[i].Valor_Pago, l[i].Cod_Lixeira });
            }
            Decimal soma = pd.SomaDividas();
            

            lblquantomedevem.Text = Convert.ToString(soma);
            ///////////////////////////////////////////////////////////////////////////////////// somantorio de dividas no dia
            DateTime dt1 = new DateTime();
            dt1 = DateTime.Now;
            String data1 = dt1.ToString();
            Decimal somatoriodia = 0;
            Decimal somatoriomes = 0;
            for (int i = 0; i < (dataGridView1.Rows.Count) - 1; i++)
            {
                if ((dataGridView1.Rows[i].Cells[2].Value.ToString())[0].Equals(data1[0]) && (dataGridView1.Rows[i].Cells[2].Value.ToString())[1].Equals(data1[1]) && (dataGridView1.Rows[i].Cells[2].Value.ToString())[3].Equals(data1[3]) && (dataGridView1.Rows[i].Cells[2].Value.ToString())[4].Equals(data1[4]) && (dataGridView1.Rows[i].Cells[2].Value.ToString())[6].Equals(data1[6]) && (dataGridView1.Rows[i].Cells[2].Value.ToString())[7].Equals(data1[7]) && (dataGridView1.Rows[i].Cells[2].Value.ToString())[8].Equals(data1[8]) && (dataGridView1.Rows[i].Cells[2].Value.ToString())[9].Equals(data1[9]))// pegando as datas de hoje 
                {
                    somatoriodia = somatoriodia + Convert.ToDecimal(dataGridView1.Rows[i].Cells[3].Value.ToString());

                }
            }
            lblquantomepagaramhje.Text =Convert.ToString(somatoriodia);

            for (int i = 0; i < (dataGridView1.Rows.Count) - 1; i++)
            {
                if ( (dataGridView1.Rows[i].Cells[2].Value.ToString())[3].Equals(data1[3]) && (dataGridView1.Rows[i].Cells[2].Value.ToString())[4].Equals(data1[4]) && (dataGridView1.Rows[i].Cells[2].Value.ToString())[6].Equals(data1[6]) && (dataGridView1.Rows[i].Cells[2].Value.ToString())[7].Equals(data1[7]) && (dataGridView1.Rows[i].Cells[2].Value.ToString())[8].Equals(data1[8]) && (dataGridView1.Rows[i].Cells[2].Value.ToString())[9].Equals(data1[9]))// pegando as datas de hoje 
                {
                    somatoriomes = somatoriomes + Convert.ToDecimal(dataGridView1.Rows[i].Cells[3].Value.ToString());

                }
            }
            lblmepagaramessemes.Text = Convert.ToString(somatoriomes);

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
          

            dataGridView2.Rows.Clear();
            DateTime dt = new DateTime();
            dt =DateTime.Parse(dtpData.Text);
            String data = dt.ToShortDateString();

         
            List<Lixo> lixos = new List<Lixo>();
            for (int i = 0; i < (dataGridView1.Rows.Count)-1; i++)
            {
                if ((dataGridView1.Rows[i].Cells[2].Value.ToString())[0].Equals(data[0]) && (dataGridView1.Rows[i].Cells[2].Value.ToString())[1].Equals(data[1]) && (dataGridView1.Rows[i].Cells[2].Value.ToString())[3].Equals(data[3]) && (dataGridView1.Rows[i].Cells[2].Value.ToString())[4].Equals(data[4]) && (dataGridView1.Rows[i].Cells[2].Value.ToString())[6].Equals(data[6]) && (dataGridView1.Rows[i].Cells[2].Value.ToString())[7].Equals(data[7]) && (dataGridView1.Rows[i].Cells[2].Value.ToString())[8].Equals(data[8]) && (dataGridView1.Rows[i].Cells[2].Value.ToString())[9].Equals(data[9]))
                {
                    Lixo l = new Lixo();
                    l.Nome_Cliente = (dataGridView1.Rows[i].Cells[0].Value.ToString());
                    l.Produto = (dataGridView1.Rows[i].Cells[1].Value.ToString());
                    l.Data_Pagamento = (dataGridView1.Rows[i].Cells[2].Value.ToString());
                    l.Valor_Pago = Convert.ToDecimal(dataGridView1.Rows[i].Cells[3].Value.ToString());
                    l.Cod_Lixeira = Convert.ToInt32(dataGridView1.Rows[i].Cells[4].Value.ToString());
                    lixos.Add(l);
                    
                }
                

            }
                for (int x = 0;  x< lixos.Count; x++)
                {
                    dataGridView2.Rows.Add(new object[] { lixos[x].Nome_Cliente, lixos[x].Produto, lixos[x].Data_Pagamento, lixos[x].Valor_Pago, lixos[x].Cod_Lixeira });
                }
            

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
