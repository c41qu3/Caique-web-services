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
    public partial class Tela_produtos_promocao : Form
    {
        public Tela_produtos_promocao()
        {
            InitializeComponent();
        }

        private void btncadastrar_Click(object sender, EventArgs e)
        {
            if ((txtNome.Text).Equals("") || (nudPrecoCompra.Text).Equals("") || (nudPrecoVenda.Text).Equals(""))
            {
                MessageBox.Show("tá faltando algum dado");
                return;
            }

            Promocao p = new Promocao();

            p.Nome = txtNome.Text;
            p.precoCompra = Decimal.Parse(nudPrecoCompra.Text);
            p.precoVenda = Decimal.Parse(nudPrecoVenda.Text);

            
            PessoaDAL pd = new PessoaDAL();
            pd.gravarPromocao(p);

            dataGridView1.Rows.Clear();

            PessoaDAL pd1 = new PessoaDAL();
            List<Promocao> lista = pd.ListarTodasAsPromocoes();

            for (int i = 0; i < lista.Count; i++)
            {
                dataGridView1.Rows.Add(new object[] { lista[i].Nome, lista[i].precoCompra, lista[i].precoVenda, lista[i].Codigo });
                
            }

            txtNome.Text = "";
            nudPrecoCompra.Text = "";
            nudPrecoVenda.Text = "";

        }

        private void Tela_produtos_promocao_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            PessoaDAL pd = new PessoaDAL();
            List<Promocao> lista = pd.ListarTodasAsPromocoes();

            for (int i = 0; i < lista.Count; i++)
            {
                dataGridView1.Rows.Add(new object[] { lista[i].Nome, lista[i].precoCompra, lista[i].precoVenda, lista[i].Codigo });

            }
        }

        private void nudPrecoCompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)'.')
            {
                e.Handled = true;
            }
        }

        private void nudPrecoVenda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)'.')
            {
                e.Handled = true;
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
           PessoaDAL pd = new PessoaDAL();
           List<Promocao> lista = pd.ListarTodasAsPromocoes();
           
            int x = 0;
            bool saida =false;
            if(nudCod_deleta.Text.Equals("")){
                MessageBox.Show("O código não foi digitado.");
                return;
            }

          
           //trecho de proteção para avisar se não existir código
           while(saida == false){
               if (x == lista.Count) {
                   MessageBox.Show("esse código não existe");
                   return;
               }
               if (int.Parse(nudCod_deleta.Text) == lista[x].Codigo  )
               {
                   saida = true;
               }
               x++;     
           }

            //deletando
           int Codigo = int.Parse(nudCod_deleta.Text);
          
           pd.DeletaItemPromocao(Codigo);

           List<Promocao> lista1 = pd.ListarTodasAsPromocoes();
            //relistagem           
           dataGridView1.Rows.Clear(); 
           
            for (int i = 0; i < lista1.Count; i++)
           {
              dataGridView1.Rows.Add(new object[] { lista1[i].Nome, lista1[i].precoCompra, lista1[i].precoVenda, lista1[i].Codigo });
               
           }

            nudCod_deleta.Text = "";
        }
    }
}
