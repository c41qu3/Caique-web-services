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
    public partial class tela_inserir : Form
    {
        public tela_inserir()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pessoa p = new Pessoa();
            p.Nome = txtNome.Text;
            p.Endereco = txtendereco.Text;
            p.Apelido = txtApelido.Text;
            p.CPF = txtCpf.Text;
            p.RG = txtRG.Text;
            p.DataNasc = txtDatanasc.Text;
            p.Telefone = txtTelefone.Text;
            p.Tipo = txtTipo.Text;
            p.Observacao = txtObservacao.Text;

            if (p.Nome.Equals("") || p.Endereco.Equals("") || p.Apelido.Equals("") || p.CPF.Equals("") ||p.RG.Equals("") || p.DataNasc.Equals("") || p.Telefone.Equals("") || p.Tipo.Equals("") || p.Observacao.Equals(""))
                {
                    MessageBox.Show("algum elemento faltando");
                    return; 
                }
            

            PessoaDAL pd = new PessoaDAL();
            pd.gravar(p);
           
            txtNome.Text = "";
            txtendereco.Text = "";
            txtApelido.Text ="";
            txtCpf.Text ="";
            txtRG.Text = "";
            txtDatanasc.Text = "";
            txtTelefone.Text = "";
            txtTipo.Text = "";
            txtObservacao.Text = "";

            MessageBox.Show ("cliente cadastrado com sucesso");
        }

        private void lblalgumvazio_Click(object sender, EventArgs e)
        {

        }

        private void tela_Inserir_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
             dataGridView1.Rows.Clear();
            PessoaDAL pd = new PessoaDAL();
            String nome = txtNomeBusca.Text;
            List<Pessoa> p = new List<Pessoa>();
            p = pd.ListarPessoas(nome);


            if (p.Count == 0 || txtNomeBusca.Text.Equals(""))
            {
                MessageBox.Show("não existem clientes com essa letra no nome");
                return;
            }

            for (int i = 0; i < p.Count; i++)
            {
                dataGridView1.Rows.Add(new object[] { p[i].Nome, p[i].Endereco, p[i].Apelido, p[i].CPF, p[i].RG, p[i].DataNasc, p[i].Telefone, p[i].Tipo, p[i].Observacao, p[i].Cod_divida });
            }

            txtNomeBusca.Text = "";
        
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                txtatnome.Text = row.Cells["Nome"].Value.ToString();
                txtatend.Text = row.Cells["Endereco"].Value.ToString();
                txtatapelido.Text = row.Cells["Apelido"].Value.ToString();
                txtatcpf.Text = row.Cells["CPF"].Value.ToString();
                txtatRG.Text = row.Cells["RG"].Value.ToString();
                txtatDN.Text = row.Cells["DataNasc"].Value.ToString();
                txtatTel.Text = row.Cells["Telefone"].Value.ToString();
                txtattipo.Text = row.Cells["Tipo"].Value.ToString();
                txtatobs.Text = row.Cells["Observacao"].Value.ToString();
                lblCodigo_update.Text = row.Cells["Codigo"].Value.ToString();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           Pessoa p = new Pessoa();
           p.Nome = txtatnome.Text ;
           p.Endereco = txtatend.Text; 
           p.Apelido = txtatapelido.Text;
           p.CPF = txtatcpf.Text ;
           p.RG = txtatRG.Text ;
           p.DataNasc = txtatDN.Text; 
           p.Telefone = txtatTel.Text;
           p.Tipo = txtattipo.Text ;
           p.Observacao = txtatobs.Text;
           p.Cod_divida = Convert.ToInt32(lblCodigo_update.Text);
           if (lblCodigo_update.Equals("0")|| p.Nome.Equals("") || p.Endereco.Equals("") || p.Apelido.Equals("") || p.DataNasc.Equals("") || p.CPF.Equals("") || p.RG.Equals("") || p.Telefone.Equals("") || p.Tipo.Equals("") || p.Observacao.Equals(""))
           {
               MessageBox.Show("tá falando algum dado, ou voçê não clicou em nenhum cliente na busca acima");
               return;
           }
           PessoaDAL pd = new PessoaDAL();
           pd.UpdatePessoa(p);

           MessageBox.Show("Cliente atualizado com sucesso");

           txtatnome.Text = "";
           txtatend.Text = "";
           txtatapelido.Text = "";
           txtatcpf.Text = "";
           txtatRG.Text = "";
           txtatDN.Text = "";
           txtatTel.Text = "";
           txtattipo.Text = "";
           txtatobs.Text = "";
           lblCodigo_update.Text = "0";

        }
    }
}
