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
    public partial class tela_compra_pagamento : Form
    {
        public tela_compra_pagamento()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            PessoaDAL pd = new PessoaDAL();
            String nome = txtBuscaNome.Text;
            List<Pessoa> p = new List<Pessoa>();
            p = pd.ListarPessoas(nome);


            if (p.Count==0 ) {
                MessageBox.Show("não existem clientes com essa letra no nome");
                return;
            }

            for (int i = 0; i < p.Count; i++)
            {
                dataGridView1.Rows.Add(new object[] { p[i].Nome, p[i].Endereco, p[i].Apelido, p[i].CPF, p[i].RG, p[i].DataNasc, p[i].Telefone, p[i].Tipo, p[i].Observacao, p[i].Cod_divida });
            }

            txtBuscaNome.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            PessoaDAL pd = new PessoaDAL();
            String Apelido = txtBuscaApelido.Text;
            List<Pessoa> p = new List<Pessoa>();
            p = pd.ListarPessoasporApelido(Apelido);


            if (p.Count == 0)
            {
                MessageBox.Show("não existem clientes com essa letra no Apelido");
                return;
            }

            for (int i = 0; i < p.Count; i++)
            {
                dataGridView1.Rows.Add(new object[] { p[i].Nome, p[i].Endereco, p[i].Apelido, p[i].CPF, p[i].RG, p[i].DataNasc, p[i].Telefone, p[i].Tipo, p[i].Observacao, p[i].Cod_divida });
            }
            txtBuscaApelido.Text = "";
        }

        private void tela_compra_pagamento_Load(object sender, EventArgs e)
        {
            DateTime dt = new DateTime();
            dt = DateTime.Now;

            lblhora.Text = dt.ToShortDateString()+dt.ToShortTimeString();


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CelldoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            DTVdividas.Rows.Clear(); 
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                lblnome.Text = row.Cells["Nome"].Value.ToString();
                lblendereco.Text = row.Cells["Endereco"].Value.ToString();
                lblapelido.Text = row.Cells["Apelido"].Value.ToString();
                lblCPF.Text = row.Cells["CPF"].Value.ToString();
                lblRG.Text = row.Cells["RG"].Value.ToString();
                lbliDataNasc.Text = row.Cells["DataNasc"].Value.ToString();
                lblCodigo.Text = row.Cells["Codigo"].Value.ToString();
                lblTipo.Text = row.Cells["Tipo"].Value.ToString();
                
            }

            lblJuros.Text = "-";

            PessoaDAL pd = new PessoaDAL();
            int cod = Convert.ToInt32(lblCodigo.Text);
            Divida d = new Divida();

            List<Divida> lista = new List<Divida>();
            lista = pd.ListarDividas(Convert.ToInt32(lblCodigo.Text));


            Decimal valortot = new Decimal();
            DateTime menordata = Convert.ToDateTime("9/9/9999");//serve para calcular os juros
            Decimal valorJuros = new Decimal(); //serve para calcular os juros
            for (int i = 0; i < lista.Count; i++)
            {
                DTVdividas.Rows.Add(new object[] { lista[i].Quantidade, lista[i].Produto, lista[i].Data, lista[i].Comprador, lista[i].preco,lista[i].Cod_deleta });
                valortot = (valortot) + (lista[i].preco);
                String dia = (lista[i].Data)[0] + "" + "" + (lista[i].Data)[1];
                String mes = (lista[i].Data)[3] + "" + "" + (lista[i].Data)[4];
                String ano = (lista[i].Data)[6] + "" + "" + (lista[i].Data)[7] + (lista[i].Data)[8] + (lista[i].Data)[9];

                int dia1 = int.Parse(dia);
                int mes1 = int.Parse(mes); // conversão para inteiro "O -1 É APENAS PARA TESTES"
                int ano1 = int.Parse(ano);

                String diaatual = (lblhora.Text[0]+""+""+lblhora.Text[1]);
                String mesatual = (lblhora.Text[3]+""+""+lblhora.Text[4]);
                String anoatual = (lblhora.Text[6]+""+""+lblhora.Text[7] + lblhora.Text[8] + lblhora.Text[9]);

                int diaatual1 = int.Parse(diaatual);
                int mesatual1 = int.Parse(mesatual);
                int anoatual1 = int.Parse(anoatual);

                TimeSpan date = Convert.ToDateTime(diaatual1+"/"+mesatual1+"/"+anoatual1) - Convert.ToDateTime(dia1+"/"+mes1+"/"+ano1);

                int totalDias = date.Days;
                if ( totalDias > 30 && totalDias < 60) {
                    DTVdividas.Rows[i].Cells[2].Style.BackColor = Color.Yellow;
                    valorJuros = (valorJuros) + (lista[i].preco); //CALCULA SÓ O SOMATORIO DAS DIVIDAS ATRASADAS
                }
                if ( totalDias >= 60)
                {
                    DTVdividas.Rows[i].Cells[2].Style.BackColor = Color.Red;
                    valorJuros = (valorJuros) + (lista[i].preco); //CALCULA SÓ O SOMATORIO DAS DIVIDAS ATRASADAS
                }
                if (Convert.ToDateTime(dia1 + "/" + mes1 + "/" + ano1) < menordata)
                {
                    menordata = Convert.ToDateTime(dia1 + "/" + mes1 + "/" + ano1);
                }

               
            }
            DateTime dt = new DateTime();//
            dt = DateTime.Now;//
            TimeSpan dateJuros = dt - Convert.ToDateTime(menordata);// cálculo dos juros baseado na menor data em porcentagem
            int totalDiasJuros = dateJuros.Days; //quantidade a ser contada juros
            if (totalDiasJuros > 30)
            {
                int diaspagos = totalDiasJuros - 30;
                double porcentagemdejuros = (diaspagos * 0.33);

                double juros = Convert.ToDouble(valorJuros) * (porcentagemdejuros / 100);

                lblJuros.Text = Convert.ToString(juros);
            }


            lblsaldodevedor.Text = Convert.ToString(valortot);

            lblQuantidade.Visible = true;
            lblproduto.Visible = true;
            lblcomprador.Visible = true;
            lblpreco.Visible = true;
            nudQuantidade.Visible = true;
            txtProduto.Visible = true;
            txtComprador.Visible = true;
            nudPreco.Visible = true;
            btnVenda.Visible = true;
            lblPagamento.Visible = true;
            lblDeletartabela.Visible = true;
            nudPagamento.Visible = true;
            nudDeletaItem.Visible = true;
            btnPagamento.Visible = true;
            btnDeletarItem.Visible = true;
        }

        private void DataGridView1_RowHeaderMouseDoubleClick(Object sender, DataGridViewCellMouseEventArgs e)
        {
          
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnVenda_Click(object sender, EventArgs e)
        {
            if ((nudPreco.Text).Equals("")  || (nudQuantidade.Text).Equals("")||(txtProduto.Text).Equals("") || (txtComprador.Text).Equals("") )
            {
                MessageBox.Show("tá faltando algum dado");
                return;
            }

            Divida d1 = new Divida();
            d1.Cod_divida = Convert.ToInt32(lblCodigo.Text);
            d1.Quantidade = Convert.ToInt32(nudQuantidade.Text);
            d1.Produto = txtProduto.Text;
            d1.Data = lblhora.Text;
            d1.Comprador = txtComprador.Text;

            d1.preco = Decimal.Parse(nudPreco.Text);

           

            PessoaDAL pd = new PessoaDAL();
            pd.gravarDivida(d1);
            MessageBox.Show("venda concretizada");
            nudQuantidade.Text = "";
            txtProduto.Text = "";
            txtComprador.Text = "";
            nudPreco.Text = "";

            DTVdividas.Rows.Clear();

            PessoaDAL pd1 = new PessoaDAL();
            int cod = Convert.ToInt32(lblCodigo.Text);
            

            List<Divida> lista = new List<Divida>();
            lista = pd.ListarDividas(Convert.ToInt32(lblCodigo.Text));

            Decimal valortot = new Decimal();
            DateTime menordata = Convert.ToDateTime("9/9/9999");
            Decimal valorJuros = new Decimal(); //serve para calcular os juros
            for (int i = 0; i < lista.Count; i++)
            {
                DTVdividas.Rows.Add(new object[] { lista[i].Quantidade, lista[i].Produto, lista[i].Data, lista[i].Comprador, lista[i].preco,lista[i].Cod_deleta });
                valortot = (valortot) + (lista[i].preco);

                String dia = (lista[i].Data)[0] + "" + "" + (lista[i].Data)[1];
                String mes = (lista[i].Data)[3] + "" + "" + (lista[i].Data)[4];
                String ano = (lista[i].Data)[6] + "" + "" + (lista[i].Data)[7] + (lista[i].Data)[8] + (lista[i].Data)[9];

                int dia1 = int.Parse(dia);
                int mes1 = int.Parse(mes); // conversão para inteiro "O -1 É APENAS PARA TESTES"
                int ano1 = int.Parse(ano);

                String diaatual = (lblhora.Text[0] + "" + "" + lblhora.Text[1]);
                String mesatual = (lblhora.Text[3] + "" + "" + lblhora.Text[4]);
                String anoatual = (lblhora.Text[6] + "" + "" + lblhora.Text[7] + lblhora.Text[8] + lblhora.Text[9]);

                int diaatual1 = int.Parse(diaatual);
                int mesatual1 = int.Parse(mesatual);
                int anoatual1 = int.Parse(anoatual);


                TimeSpan date = Convert.ToDateTime(diaatual1+"/"+mesatual1+"/"+anoatual1) - Convert.ToDateTime(dia1+"/"+mes1+"/"+ano1);

                int totalDias = date.Days;
                if (totalDias >= 30 && totalDias < 60)
                {
                    DTVdividas.Rows[i].Cells[2].Style.BackColor = Color.Yellow;
                    valorJuros = (valorJuros) + (lista[i].preco); //CALCULA SÓ O SOMATORIO DAS DIVIDAS ATRASADAS
                }
                if (totalDias >= 60)
                {
                    DTVdividas.Rows[i].Cells[2].Style.BackColor = Color.Red;
                    valorJuros = (valorJuros) + (lista[i].preco); //CALCULA SÓ O SOMATORIO DAS DIVIDAS ATRASADAS
                }
                if (Convert.ToDateTime(dia1 + "/" + mes1 + "/" + ano1) < menordata) {
                    menordata = Convert.ToDateTime(dia1 + "/" + mes1 + "/" + ano1);
                }
               
                /*
                if ((diaatual1 >= dia1 && mes1 + 1 == mesatual1) || (mes1 + 2 == mesatual1 && diaatual1 < dia1))
                {
                    DTVdividas.Rows[i].Cells[2].Style.BackColor = Color.Yellow;
                }

                if ((diaatual1 >= dia1 && (mesatual1 >= mes1 + 2)) || (mesatual1 >= mes1 + 3 && diaatual1 < dia1))
                {

                    DTVdividas.Rows[i].Cells[2].Style.BackColor = Color.Red;
                }
                if (ano1 < anoatual1)
                {
                    DTVdividas.Rows[i].Cells[2].Style.BackColor = Color.Red;
                }*/
            }
            DateTime dt = new DateTime();//
            dt = DateTime.Now;//
            TimeSpan dateJuros = dt - Convert.ToDateTime(menordata);// cálculo dos juros baseado na menor data
            int totalDiasJuros = dateJuros.Days;//
            if (totalDiasJuros > 30) {
                int diaspagos = totalDiasJuros - 30;
                double porcentagemdejuros = (diaspagos * 0.33);

                double juros = Convert.ToDouble(valorJuros) * (porcentagemdejuros/100);

                lblJuros.Text = Convert.ToString(juros);
            }

            lblsaldodevedor.Text = Convert.ToString(valortot);
        }

        private void lblTipo_Click(object sender, EventArgs e)
        {

        }
        
        private void txtPreco_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void lblquant_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnPagamento_Click(object sender, EventArgs e)
        {
            if (nudPagamento.Text.Equals("") || nudPagamento.Text.Equals("0,00"))
            {
                MessageBox.Show("o pagamento não foi digitado ou é igual a 0");
                return;
            }
            Divida d = new Divida ();
            d.Cod_divida = int.Parse(lblCodigo.Text);
            d.Quantidade = 1;
            d.Produto = "resto";
            d.Data = Convert.ToString(lblhora.Text);
            d.Comprador = lblnome.Text;
            d.preco =Decimal.Subtract( Decimal.Parse(lblsaldodevedor.Text), ( Decimal.Parse(nudPagamento.Text)));

             PessoaDAL pd = new PessoaDAL();

            


            if (Decimal.Parse(nudPagamento.Text) > Decimal.Parse(lblsaldodevedor.Text)) {
                MessageBox.Show("o pagamento é maior que a dívida");
                return;
            }
            //inserindo na lixeira

            for (int a = 0; a < (DTVdividas.Rows.Count) - 1; a++)
            {       
                Lixo lixo = new Lixo();
                lixo.Nome_Cliente = lblnome.Text;
                lixo.Produto = DTVdividas.Rows[a].Cells[1].Value.ToString();
                lixo.Data_Pagamento = lblhora.Text;
                lixo.Valor_Pago = Convert.ToDecimal(DTVdividas.Rows[a].Cells[4].Value.ToString()); ;

                pd.gravarlixo(lixo);   
                
            }
            //------------------------------------------------------------------------------------------------------------

            pd.DeletaDividasDoCliente(d.Cod_divida);
            pd.gravarDivida(d);

            MessageBox.Show("pagamento efetuado com sucesso!");

            
            
            //relistar
            DTVdividas.Rows.Clear();

            List<Divida> lista = new List<Divida>();
            lista = pd.ListarDividas(Convert.ToInt32(lblCodigo.Text));

            Decimal valortot = new Decimal();

            if (d.preco == 0) //trecho para não ter um registro "RESTO" de 0
            {
                pd.DeletaDividasDoCliente(d.Cod_divida);
                MessageBox.Show("o cliente pagou todas as suas dívidas");
                nudPagamento.Text = "";
                return;
            }

            for (int i = 0; i < lista.Count; i++) //relistagem
            {
                DTVdividas.Rows.Add(new object[] { lista[i].Quantidade, lista[i].Produto, lista[i].Data, lista[i].Comprador, lista[i].preco, lista[i].Cod_deleta });
                valortot = (valortot) + (lista[i].preco);
            }

            lblsaldodevedor.Text = Convert.ToString(valortot);
            nudPagamento.Text = "";


        }

        private void nudPagamento_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void nudPagamento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)'.')
            {
                e.Handled = true;
            }
        }

        private void btnDeletarItem_Click(object sender, EventArgs e)
        {
            //trecho de proteção
            PessoaDAL pd1 = new PessoaDAL();
            List<Divida> lista = new List<Divida>();
            lista = pd1.ListarDividas(Convert.ToInt32(lblCodigo.Text));

            if (lista.Count == 0 || nudDeletaItem.Text.Equals("")) {
                MessageBox.Show("Esse código não é de nenhuma dívida acima, por favor digite novamente o CÓDIGO PARA DELETAR do item desejado");
                return;
            }

            int x = 0;
            bool l = false;
            
                while(l == false)
                {
                    if (lista[x].Cod_deleta == int.Parse(nudDeletaItem.Text))
                    {
                        l = true;
                    }
                    else {
                        x++;
                        if (x == lista.Count) {
                            MessageBox.Show("O CODIGO DIGITADO NÃO CORRESPONDE A NENHUMA DIVIDA DESSE CLIENTE LISTADO ACIMA");
                            return;
                        }
                    } 
                }

                //inserindo na lixeira
                
                for (int a = 0; a <(DTVdividas.Rows.Count)-1; a++ )
                {
                     
                    if (int.Parse(DTVdividas.Rows[a].Cells[5].Value.ToString()) == int.Parse(nudDeletaItem.Text))
                    {

                    Lixo lixo = new Lixo();
                    lixo.Nome_Cliente = lblnome.Text;
                    lixo.Produto = DTVdividas.Rows[a].Cells[1].Value.ToString();
                    lixo.Data_Pagamento = lblhora.Text;
                    lixo.Valor_Pago = Convert.ToDecimal( DTVdividas.Rows[a].Cells[4].Value.ToString());

                    pd1.gravarlixo(lixo);
                    }
                }
                //------------------------------------------------------------------------------------------------------------

            
            //começo
            int Cod_deleta = int.Parse(nudDeletaItem.Text);
            PessoaDAL pd = new PessoaDAL();
            pd.DeletaItem(Cod_deleta);

            lista = pd.ListarDividas(Convert.ToInt32(lblCodigo.Text));
            //relistar
            DTVdividas.Rows.Clear();
            

            Decimal valortot = new Decimal();
            DateTime menordata = Convert.ToDateTime("9/9/9999");
            Decimal valorJuros = new Decimal(); //serve para calcular os juros

            for (int i = 0; i < lista.Count; i++)
            {
                DTVdividas.Rows.Add(new object[] { lista[i].Quantidade, lista[i].Produto, lista[i].Data, lista[i].Comprador, lista[i].preco, lista[i].Cod_deleta });
                valortot = (valortot) + (lista[i].preco);

                String dia = (lista[i].Data)[0] + "" + "" + (lista[i].Data)[1];
                String mes = (lista[i].Data)[3] + "" + "" + (lista[i].Data)[4];
                String ano = (lista[i].Data)[6] + "" + "" + (lista[i].Data)[7] + (lista[i].Data)[8] + (lista[i].Data)[9];

                int dia1 = int.Parse(dia);
                int mes1 = int.Parse(mes); // conversão para inteiro "O -1 É APENAS PARA TESTES"
                int ano1 = int.Parse(ano);

                String diaatual = (lblhora.Text[0] + "" + "" + lblhora.Text[1]);
                String mesatual = (lblhora.Text[3] + "" + "" + lblhora.Text[4]);
                String anoatual = (lblhora.Text[6] + "" + "" + lblhora.Text[7] + lblhora.Text[8] + lblhora.Text[9]);

                int diaatual1 = int.Parse(diaatual);
                int mesatual1 = int.Parse(mesatual);
                int anoatual1 = int.Parse(anoatual);

                TimeSpan date = Convert.ToDateTime(diaatual1+"/"+mesatual1+"/"+anoatual1) - Convert.ToDateTime(dia1+"/"+mes1+"/"+ano1);

                int totalDias = date.Days;
                if (totalDias >= 30 && totalDias < 60)
                {
                    DTVdividas.Rows[i].Cells[2].Style.BackColor = Color.Yellow;
                    valorJuros = (valorJuros) + (lista[i].preco); //CALCULA SÓ O SOMATORIO DAS DIVIDAS ATRASADAS
                }
                if (totalDias >= 60)
                {
                    DTVdividas.Rows[i].Cells[2].Style.BackColor = Color.Red;
                    valorJuros = (valorJuros) + (lista[i].preco); //CALCULA SÓ O SOMATORIO DAS DIVIDAS ATRASADAS
                }
                 if (Convert.ToDateTime(dia1 + "/" + mes1 + "/" + ano1) < menordata) { // cálculo do juro
                    menordata = Convert.ToDateTime(dia1 + "/" + mes1 + "/" + ano1);
                }
               
            }
            DateTime dt = new DateTime();//
            dt = DateTime.Now;//
            TimeSpan dateJuros = dt - Convert.ToDateTime(menordata);// cálculo dos juros baseado na menor data
            int totalDiasJuros = dateJuros.Days;//
            if (totalDiasJuros > 30)
            {
                int diaspagos = totalDiasJuros - 30;
                double porcentagemdejuros = (diaspagos * 0.33);

                double juros = Convert.ToDouble(valorJuros) * (porcentagemdejuros / 100);

                lblJuros.Text = Convert.ToString(juros);
            }
            lblsaldodevedor.Text = Convert.ToString(valortot);
            nudDeletaItem.Text = "";

             
        }

        private void nudPreco_ValueChanged(object sender, EventArgs e)
        {

        }

        private void nudDeletaTabela_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)'.')
            {
                e.Handled = true;
            }
        }

        private void nudPreco_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)'.')
            {
                e.Handled = true;
            }
        }

        private void nudDeletaItem_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscaCpf_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            PessoaDAL pd = new PessoaDAL();
            String CPF = txtBuscaCPF.Text;
            List<Pessoa> p = new List<Pessoa>();
            p = pd.ListarPessoasporcpf(CPF);


            if (p.Count == 0)
            {
                MessageBox.Show("não existem clientes com esse digito no CPF");
                return;
            }

            for (int i = 0; i < p.Count; i++)
            {
                dataGridView1.Rows.Add(new object[] { p[i].Nome, p[i].Endereco, p[i].Apelido, p[i].CPF, p[i].RG, p[i].DataNasc, p[i].Telefone, p[i].Tipo, p[i].Observacao, p[i].Cod_divida });
            }
            txtBuscaCPF.Text = "";
        }

        private void tela_compra_pagamento_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        
    }
}
