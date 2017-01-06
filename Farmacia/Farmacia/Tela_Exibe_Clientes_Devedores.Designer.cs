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
            ((System.ComponentModel.ISupportInitialize)(this.dtvTodasdividas)).BeginInit();
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
            this.dtvTodasdividas.Location = new System.Drawing.Point(39, 12);
            this.dtvTodasdividas.Name = "dtvTodasdividas";
            this.dtvTodasdividas.Size = new System.Drawing.Size(1288, 693);
            this.dtvTodasdividas.TabIndex = 0;
            this.dtvTodasdividas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtvTodasdividas_CellContentClick);
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
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
            // Tela_Exibe_Clientes_Devedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1354, 733);
            this.Controls.Add(this.dtvTodasdividas);
            this.Name = "Tela_Exibe_Clientes_Devedores";
            this.Text = "Tela_Exibe_Clientes_Devedores";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Tela_Exibe_Clientes_Devedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtvTodasdividas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtvTodasdividas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apelido;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPF;
    }
}