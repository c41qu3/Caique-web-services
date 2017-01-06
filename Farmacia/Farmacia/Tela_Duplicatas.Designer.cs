namespace Farmacia
{
    partial class Tela_duplicatas
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
            this.DTVdplicatas = new System.Windows.Forms.DataGridView();
            this.lblCadastro = new System.Windows.Forms.Label();
            this.txtEmpresa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNotafiscal = new System.Windows.Forms.TextBox();
            this.txtduplicatas = new System.Windows.Forms.TextBox();
            this.dtpEmicao = new System.Windows.Forms.DateTimePicker();
            this.dtpVencimento = new System.Windows.Forms.DateTimePicker();
            this.nudValorapagar = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCadastraDuplicata = new System.Windows.Forms.Button();
            this.BtnDeleta = new System.Windows.Forms.Button();
            this.Empresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nota_fiscal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Emissao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vencimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duplicatas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValoraPagar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nudDeleta = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.DTVdplicatas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudValorapagar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDeleta)).BeginInit();
            this.SuspendLayout();
            // 
            // DTVdplicatas
            // 
            this.DTVdplicatas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTVdplicatas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Empresa,
            this.Nota_fiscal,
            this.Emissao,
            this.Vencimento,
            this.Duplicatas,
            this.ValoraPagar,
            this.Codigo});
            this.DTVdplicatas.Location = new System.Drawing.Point(55, 38);
            this.DTVdplicatas.Name = "DTVdplicatas";
            this.DTVdplicatas.Size = new System.Drawing.Size(1249, 348);
            this.DTVdplicatas.TabIndex = 0;
            // 
            // lblCadastro
            // 
            this.lblCadastro.AutoSize = true;
            this.lblCadastro.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCadastro.Location = new System.Drawing.Point(55, 428);
            this.lblCadastro.Name = "lblCadastro";
            this.lblCadastro.Size = new System.Drawing.Size(49, 13);
            this.lblCadastro.TabIndex = 1;
            this.lblCadastro.Text = "Cadastro";
            // 
            // txtEmpresa
            // 
            this.txtEmpresa.Location = new System.Drawing.Point(59, 486);
            this.txtEmpresa.Name = "txtEmpresa";
            this.txtEmpresa.Size = new System.Drawing.Size(135, 20);
            this.txtEmpresa.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(56, 459);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Empresa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(216, 459);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nota fiscal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(343, 459);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Emissão";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(838, 459);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Duplicatas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(1073, 459);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Valor a pagar";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(591, 459);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Vencimento";
            // 
            // txtNotafiscal
            // 
            this.txtNotafiscal.Location = new System.Drawing.Point(219, 486);
            this.txtNotafiscal.Name = "txtNotafiscal";
            this.txtNotafiscal.Size = new System.Drawing.Size(100, 20);
            this.txtNotafiscal.TabIndex = 9;
            // 
            // txtduplicatas
            // 
            this.txtduplicatas.Location = new System.Drawing.Point(841, 486);
            this.txtduplicatas.Name = "txtduplicatas";
            this.txtduplicatas.Size = new System.Drawing.Size(207, 20);
            this.txtduplicatas.TabIndex = 12;
            // 
            // dtpEmicao
            // 
            this.dtpEmicao.Location = new System.Drawing.Point(346, 486);
            this.dtpEmicao.Name = "dtpEmicao";
            this.dtpEmicao.Size = new System.Drawing.Size(212, 20);
            this.dtpEmicao.TabIndex = 14;
            // 
            // dtpVencimento
            // 
            this.dtpVencimento.Location = new System.Drawing.Point(594, 486);
            this.dtpVencimento.Name = "dtpVencimento";
            this.dtpVencimento.Size = new System.Drawing.Size(214, 20);
            this.dtpVencimento.TabIndex = 15;
            // 
            // nudValorapagar
            // 
            this.nudValorapagar.DecimalPlaces = 2;
            this.nudValorapagar.Location = new System.Drawing.Point(1076, 486);
            this.nudValorapagar.Name = "nudValorapagar";
            this.nudValorapagar.Size = new System.Drawing.Size(61, 20);
            this.nudValorapagar.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(56, 548);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Excluir duplicata";
            // 
            // btnCadastraDuplicata
            // 
            this.btnCadastraDuplicata.Location = new System.Drawing.Point(1165, 484);
            this.btnCadastraDuplicata.Name = "btnCadastraDuplicata";
            this.btnCadastraDuplicata.Size = new System.Drawing.Size(139, 20);
            this.btnCadastraDuplicata.TabIndex = 19;
            this.btnCadastraDuplicata.Text = "Cadastrar Duplicata";
            this.btnCadastraDuplicata.UseVisualStyleBackColor = true;
            this.btnCadastraDuplicata.Click += new System.EventHandler(this.btnCadastraDuplicata_Click);
            // 
            // BtnDeleta
            // 
            this.BtnDeleta.Location = new System.Drawing.Point(149, 589);
            this.BtnDeleta.Name = "BtnDeleta";
            this.BtnDeleta.Size = new System.Drawing.Size(124, 23);
            this.BtnDeleta.TabIndex = 20;
            this.BtnDeleta.Text = "Deletar Duplicata";
            this.BtnDeleta.UseVisualStyleBackColor = true;
            this.BtnDeleta.Click += new System.EventHandler(this.BtnDeleta_Click);
            // 
            // Empresa
            // 
            this.Empresa.HeaderText = "Empresa";
            this.Empresa.Name = "Empresa";
            // 
            // Nota_fiscal
            // 
            this.Nota_fiscal.HeaderText = "Nota Fiscal";
            this.Nota_fiscal.Name = "Nota_fiscal";
            // 
            // Emissao
            // 
            this.Emissao.HeaderText = "Emissão";
            this.Emissao.Name = "Emissao";
            // 
            // Vencimento
            // 
            this.Vencimento.HeaderText = "Vencimento";
            this.Vencimento.Name = "Vencimento";
            // 
            // Duplicatas
            // 
            this.Duplicatas.HeaderText = "Duplicatas";
            this.Duplicatas.Name = "Duplicatas";
            // 
            // ValoraPagar
            // 
            this.ValoraPagar.HeaderText = "Valor";
            this.ValoraPagar.Name = "ValoraPagar";
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            // 
            // nudDeleta
            // 
            this.nudDeleta.Location = new System.Drawing.Point(69, 589);
            this.nudDeleta.Name = "nudDeleta";
            this.nudDeleta.Size = new System.Drawing.Size(61, 20);
            this.nudDeleta.TabIndex = 21;
            // 
            // Tela_duplicatas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1362, 741);
            this.Controls.Add(this.nudDeleta);
            this.Controls.Add(this.BtnDeleta);
            this.Controls.Add(this.btnCadastraDuplicata);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.nudValorapagar);
            this.Controls.Add(this.dtpVencimento);
            this.Controls.Add(this.dtpEmicao);
            this.Controls.Add(this.txtduplicatas);
            this.Controls.Add(this.txtNotafiscal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEmpresa);
            this.Controls.Add(this.lblCadastro);
            this.Controls.Add(this.DTVdplicatas);
            this.Name = "Tela_duplicatas";
            this.Text = "Tela_Duplicatas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Tela_duplicatas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DTVdplicatas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudValorapagar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDeleta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DTVdplicatas;
        private System.Windows.Forms.Label lblCadastro;
        private System.Windows.Forms.TextBox txtEmpresa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNotafiscal;
        private System.Windows.Forms.TextBox txtduplicatas;
        private System.Windows.Forms.DateTimePicker dtpEmicao;
        private System.Windows.Forms.DateTimePicker dtpVencimento;
        private System.Windows.Forms.NumericUpDown nudValorapagar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCadastraDuplicata;
        private System.Windows.Forms.Button BtnDeleta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Empresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nota_fiscal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Emissao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vencimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duplicatas;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValoraPagar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.NumericUpDown nudDeleta;
    }
}