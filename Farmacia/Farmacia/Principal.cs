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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void btnInserirCliente_Click(object sender, EventArgs e)
        {
            tela_inserir tela = new tela_inserir();
            tela.Show();
        }

        private void btnCompra_Click(object sender, EventArgs e)
        {
            tela_compra_pagamento tela = new tela_compra_pagamento();

            tela.Show();
          
            
        }

        private void btnclientesemdivida_Click(object sender, EventArgs e)
        {
            Tela_Exibe_Clientes_Devedores tecd = new Tela_Exibe_Clientes_Devedores();
            tecd.Show();
        }

        private void btnPromocoes_Click(object sender, EventArgs e)
        {
            Tela_produtos_promocao tela = new Tela_produtos_promocao();
            tela.Show();
        }

        private void btnDuplicatas_Click(object sender, EventArgs e)
        {
            Tela_duplicatas td = new Tela_duplicatas();
            td.Show();
        }

        private void btnUltimospag_Click(object sender, EventArgs e)
        {
            ultimos_pagamentos up = new ultimos_pagamentos();
            up.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
