namespace Farmacia
{
    partial class Tela_Exibe_Clientes_Devedores
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
            this.dtvTodasdividas = new System.Windows.Forms.DataGridView();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apelido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.DgvUmMes = new System.Windows.Forms.DataGridView();
            this.Nome1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apelido1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cpf1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtvTodasdividas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvUmMes)).BeginInit();
            this.SuspendLayout();
            // 
            // dtvTodasdividas
            // 
            this.dtvTodasdividas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.dtvTodasdividas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvTodasdividas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nome,
            this.Apelido,
            this.CPF});
            this.dtvTodasdividas.Location = new System.Drawing.Point(35, 53);
            this.dtvTodasdividas.Name = "dtvTodasdividas";
            this.dtvTodasdividas.Size = new System.Drawing.Size(404, 652);
            this.dtvTodasdividas.TabIndex = 0;
            this.dtvTodasdividas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtvTodasdividas_CellContentClick);
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.Width = 160;
            // 
            // Apelido
            // 
            this.Apelido.HeaderText = "Apelido";
            this.Apelido.Name = "Apelido";
            // 
            // CPF
            // 
            this.CPF.HeaderText = "CPF";
            this.CPF.Name = "CPF";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(40, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(377, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Clientes que devem a mais de 60 dias";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // DgvUmMes
            // 
            this.DgvUmMes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.DgvUmMes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvUmMes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nome1,
            this.Apelido1,
            this.Cpf1});
            this.DgvUmMes.Location = new System.Drawing.Point(701, 53);
            this.DgvUmMes.Name = "DgvUmMes";
            this.DgvUmMes.Size = new System.Drawing.Size(426, 652);
            this.DgvUmMes.TabIndex = 2;
            // 
            // Nome1
            // 
            this.Nome1.HeaderText = "Nome";
            this.Nome1.Name = "Nome1";
            this.Nome1.Width = 160;
            // 
            // Apelido1
            // 
            this.Apelido1.HeaderText = "Apelido";
            this.Apelido1.Name = "Apelido1";
            // 
            // Cpf1
            // 
            this.Cpf1.HeaderText = "CPF";
            this.Cpf1.Name = "Cpf1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(696, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(377, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Clientes que devem a mais de 30 dias";
            // 
            // Tela_Exibe_Clientes_Devedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(1354, 733);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DgvUmMes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtvTodasdividas);
            this.Name = "Tela_Exibe_Clientes_Devedores";
            this.Text = "Tela_Exibe_Clientes_Devedores";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Tela_Exibe_Clientes_Devedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtvTodasdividas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvUmMes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtvTodasdividas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apelido;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DgvUmMes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apelido1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cpf1;
        private System.Windows.Forms.Label label2;
    }
}