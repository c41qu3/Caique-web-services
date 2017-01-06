namespace Farmacia
{
    partial class Tela_produtos_promocao
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precodecompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precodevenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblcadastro = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblprecocompra = new System.Windows.Forms.Label();
            this.lblprecovenda = new System.Windows.Forms.Label();
            this.nudPrecoCompra = new System.Windows.Forms.NumericUpDown();
            this.nudPrecoVenda = new System.Windows.Forms.NumericUpDown();
            this.btncadastrar = new System.Windows.Forms.Button();
            this.lblDeleta = new System.Windows.Forms.Label();
            this.nudCod_deleta = new System.Windows.Forms.NumericUpDown();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecoCompra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecoVenda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCod_deleta)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nome,
            this.Precodecompra,
            this.precodevenda,
            this.Codigo});
            this.dataGridView1.Location = new System.Drawing.Point(256, 54);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(802, 228);
            this.dataGridView1.TabIndex = 0;
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            // 
            // Precodecompra
            // 
            this.Precodecompra.HeaderText = "preço de compra";
            this.Precodecompra.Name = "Precodecompra";
            // 
            // precodevenda
            // 
            this.precodevenda.HeaderText = "preço de venda";
            this.precodevenda.Name = "precodevenda";
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(291, 370);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(184, 20);
            this.txtNome.TabIndex = 1;
            // 
            // lblcadastro
            // 
            this.lblcadastro.AutoSize = true;
            this.lblcadastro.ForeColor = System.Drawing.Color.White;
            this.lblcadastro.Location = new System.Drawing.Point(253, 315);
            this.lblcadastro.Name = "lblcadastro";
            this.lblcadastro.Size = new System.Drawing.Size(48, 13);
            this.lblcadastro.TabIndex = 4;
            this.lblcadastro.Text = "cadastro";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNome.Location = new System.Drawing.Point(288, 344);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(33, 13);
            this.lblNome.TabIndex = 5;
            this.lblNome.Text = "nome";
            // 
            // lblprecocompra
            // 
            this.lblprecocompra.AutoSize = true;
            this.lblprecocompra.ForeColor = System.Drawing.SystemColors.Control;
            this.lblprecocompra.Location = new System.Drawing.Point(556, 344);
            this.lblprecocompra.Name = "lblprecocompra";
            this.lblprecocompra.Size = new System.Drawing.Size(87, 13);
            this.lblprecocompra.TabIndex = 6;
            this.lblprecocompra.Text = "preço de compra";
            // 
            // lblprecovenda
            // 
            this.lblprecovenda.AutoSize = true;
            this.lblprecovenda.ForeColor = System.Drawing.SystemColors.Control;
            this.lblprecovenda.Location = new System.Drawing.Point(702, 344);
            this.lblprecovenda.Name = "lblprecovenda";
            this.lblprecovenda.Size = new System.Drawing.Size(82, 13);
            this.lblprecovenda.TabIndex = 7;
            this.lblprecovenda.Text = "preço de venda";
            // 
            // nudPrecoCompra
            // 
            this.nudPrecoCompra.DecimalPlaces = 2;
            this.nudPrecoCompra.Location = new System.Drawing.Point(559, 371);
            this.nudPrecoCompra.Name = "nudPrecoCompra";
            this.nudPrecoCompra.Size = new System.Drawing.Size(64, 20);
            this.nudPrecoCompra.TabIndex = 8;
            this.nudPrecoCompra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nudPrecoCompra_KeyPress);
            // 
            // nudPrecoVenda
            // 
            this.nudPrecoVenda.DecimalPlaces = 2;
            this.nudPrecoVenda.Location = new System.Drawing.Point(705, 371);
            this.nudPrecoVenda.Name = "nudPrecoVenda";
            this.nudPrecoVenda.Size = new System.Drawing.Size(64, 20);
            this.nudPrecoVenda.TabIndex = 9;
            this.nudPrecoVenda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nudPrecoVenda_KeyPress);
            // 
            // btncadastrar
            // 
            this.btncadastrar.Location = new System.Drawing.Point(828, 367);
            this.btncadastrar.Name = "btncadastrar";
            this.btncadastrar.Size = new System.Drawing.Size(131, 23);
            this.btncadastrar.TabIndex = 10;
            this.btncadastrar.Text = "cadastrar promoção";
            this.btncadastrar.UseVisualStyleBackColor = true;
            this.btncadastrar.Click += new System.EventHandler(this.btncadastrar_Click);
            // 
            // lblDeleta
            // 
            this.lblDeleta.AutoSize = true;
            this.lblDeleta.ForeColor = System.Drawing.Color.White;
            this.lblDeleta.Location = new System.Drawing.Point(253, 424);
            this.lblDeleta.Name = "lblDeleta";
            this.lblDeleta.Size = new System.Drawing.Size(87, 13);
            this.lblDeleta.TabIndex = 11;
            this.lblDeleta.Text = "excluir promoção";
            // 
            // nudCod_deleta
            // 
            this.nudCod_deleta.Location = new System.Drawing.Point(291, 486);
            this.nudCod_deleta.Name = "nudCod_deleta";
            this.nudCod_deleta.Size = new System.Drawing.Size(64, 20);
            this.nudCod_deleta.TabIndex = 12;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(379, 483);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(131, 23);
            this.btnExcluir.TabIndex = 13;
            this.btnExcluir.Text = "Deletar Promoção";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(288, 452);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Pro Favor, Digite o código do produto a ser deletado";
            // 
            // Tela_produtos_promocao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1362, 741);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.nudCod_deleta);
            this.Controls.Add(this.lblDeleta);
            this.Controls.Add(this.btncadastrar);
            this.Controls.Add(this.nudPrecoVenda);
            this.Controls.Add(this.nudPrecoCompra);
            this.Controls.Add(this.lblprecovenda);
            this.Controls.Add(this.lblprecocompra);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblcadastro);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Tela_produtos_promocao";
            this.Text = "Tela_produtos_promocao";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Tela_produtos_promocao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecoCompra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecoVenda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCod_deleta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precodecompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn precodevenda;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblcadastro;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblprecocompra;
        private System.Windows.Forms.Label lblprecovenda;
        private System.Windows.Forms.NumericUpDown nudPrecoCompra;
        private System.Windows.Forms.NumericUpDown nudPrecoVenda;
        private System.Windows.Forms.Button btncadastrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.Label lblDeleta;
        private System.Windows.Forms.NumericUpDown nudCod_deleta;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Label label1;
    }
}