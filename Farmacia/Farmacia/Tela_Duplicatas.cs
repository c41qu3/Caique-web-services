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
    public partial class Tela_duplicatas : Form
    {
        public Tela_duplicatas()
        {
            InitializeComponent();
        }

        private void btnCadastraDuplicata_Click(object sender, EventArgs e)
        {
            if (txtEmpresa.Text.Equals("") || txtNotafiscal.Text.Equals("") || txtduplicatas.Text.Equals("") || nudValorapagar.Text.Equals("") || nudValorapagar.Text.Equals("0,00"))
            {
                MessageBox.Show("Tá faltando preencher algum campo");
                return;
                
            }

            DTVdplicatas.Rows.Clear();
            Duplicata d = new Duplicata();
            d.Empresa = txtEmpresa.Text;
            d.NotaFiscal = txtNotafiscal.Text;
            d.Emissao = dtpEmicao.Text;
            d.Vencimento = dtpVencimento.Text;
            d.Duplicatas = txtduplicatas.Text;
            d.ValoraPagar = Convert.ToDecimal(nudValorapagar.Text);

            PessoaDAL pd = new PessoaDAL();
            pd.gravarDuplicata(d);

            List<Duplicata> lista = pd.ListarTodasAsDuplicatas();

            for (int x = 0; x < lista.Count; x++ )
            {
                DTVdplicatas.Rows.Add(new object[] { lista[x].Empresa,lista[x].NotaFiscal,lista[x].Emissao,lista[x].Vencimento,lista[x].Duplicatas,lista[x].ValoraPagar,lista[x].codigo });
            }

            txtEmpresa.Text = "";
            txtNotafiscal.Text = "";
            txtduplicatas.Text = "";
            nudValorapagar.Text = "";

        }

        private void Tela_duplicatas_Load(object sender, EventArgs e)
        {
            PessoaDAL pd = new PessoaDAL();
            
            List<Duplicata> lista = pd.ListarTodasAsDuplicatas();

            for (int x = 0; x < lista.Count; x++)
            {
                DTVdplicatas.Rows.Add(new object[] { lista[x].Empresa, lista[x].NotaFiscal, lista[x].Emissao, lista[x].Vencimento, lista[x].Duplicatas, lista[x].ValoraPagar,lista[x].codigo });
            }
        }

        private void BtnDeleta_Click(object sender, EventArgs e)
        {
            DTVdplicatas.Rows.Clear();
            PessoaDAL pd1 = new PessoaDAL();
            int x = 0;
            bool saida = false;
            List<Duplicata> lista =pd1.ListarTodasAsDuplicatas();

            if (nudDeleta.Text.Equals("") || nudDeleta.Text.Equals("0"))
            {
                MessageBox.Show("O código não foi digitado.");

                
                for (int i = 0; i < lista.Count; i++)
                {
                    DTVdplicatas.Rows.Add(new object[] { lista[i].Empresa, lista[i].NotaFiscal, lista[i].Emissao, lista[i].Vencimento, lista[i].Duplicatas, lista[i].ValoraPagar, lista[i].codigo });

                }
                return;
            }


            //trecho de proteção para avisar se não existir código
            while (saida == false)
            {
                if (x == lista.Count)
                {
                    MessageBox.Show("esse código não existe");
                    return;
                }
                if (int.Parse(nudDeleta.Text) == lista[x].codigo)
                {
                    saida = true;
                }
                x++;
            }

            //se existir aqui eu deleto
            PessoaDAL pd = new PessoaDAL();
            int Codigo = Convert.ToInt32(nudDeleta.Text);
            pd.DeletaItemDuplicata(Codigo);

            List<Duplicata> lista1 = pd.ListarTodasAsDuplicatas(); // lista depois de deletar
            for (int i = 0; i < lista1.Count; i++)
            {
                DTVdplicatas.Rows.Add(new object[] { lista1[i].Empresa, lista1[i].NotaFiscal, lista1[i].Emissao, lista1[i].Vencimento, lista1[i].Duplicatas, lista1[i].ValoraPagar,lista1[i].codigo });
            
            }

            nudDeleta.Text = "";
        }
    }
}
