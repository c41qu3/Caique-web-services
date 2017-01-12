namespace Farmacia
{
    partial class Principal
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
            this.btnInserir = new System.Windows.Forms.Button();
            this.btnCompra = new System.Windows.Forms.Button();
            this.btnclientesemdivida = new System.Windows.Forms.Button();
            this.btnPromocoes = new System.Windows.Forms.Button();
            this.btnDuplicatas = new System.Windows.Forms.Button();
            this.BtnultimosPagamentos = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnInserir
            // 
            this.btnInserir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserir.Location = new System.Drawing.Point(243, 81);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(263, 88);
            this.btnInserir.TabIndex = 0;
            this.btnInserir.Text = "Novo Cliente";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserirCliente_Click);
            // 
            // btnCompra
            // 
            this.btnCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompra.Location = new System.Drawing.Point(608, 81);
            this.btnCompra.Name = "btnCompra";
            this.btnCompra.Size = new System.Drawing.Size(260, 88);
            this.btnCompra.TabIndex = 1;
            this.btnCompra.Text = "compra/pagamento";
            this.btnCompra.UseVisualStyleBackColor = true;
            this.btnCompra.Click += new System.EventHandler(this.btnCompra_Click);
            // 
            // btnclientesemdivida
            // 
            this.btnclientesemdivida.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclientesemdivida.Location = new System.Drawing.Point(951, 81);
            this.btnclientesemdivida.Name = "btnclientesemdivida";
            this.btnclientesemdivida.Size = new System.Drawing.Size(260, 88);
            this.btnclientesemdivida.TabIndex = 3;
            this.btnclientesemdivida.Text = "Auxílio de cobranças";
            this.btnclientesemdivida.UseVisualStyleBackColor = true;
            this.btnclientesemdivida.Click += new System.EventHandler(this.btnclientesemdivida_Click);
            // 
            // btnPromocoes
            // 
            this.btnPromocoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPromocoes.Location = new System.Drawing.Point(246, 202);
            this.btnPromocoes.Name = "btnPromocoes";
            this.btnPromocoes.Size = new System.Drawing.Size(260, 88);
            this.btnPromocoes.TabIndex = 4;
            this.btnPromocoes.Text = "promoções";
            this.btnPromocoes.UseVisualStyleBackColor = true;
            this.btnPromocoes.Click += new System.EventHandler(this.btnPromocoes_Click);
            // 
            // btnDuplicatas
            // 
            this.btnDuplicatas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDuplicatas.Location = new System.Drawing.Point(608, 202);
            this.btnDuplicatas.Name = "btnDuplicatas";
            this.btnDuplicatas.Size = new System.Drawing.Size(260, 88);
            this.btnDuplicatas.TabIndex = 5;
            this.btnDuplicatas.Text = "Duplicatas";
            this.btnDuplicatas.UseVisualStyleBackColor = true;
            this.btnDuplicatas.Click += new System.EventHandler(this.btnDuplicatas_Click);
            // 
            // BtnultimosPagamentos
            // 
            this.BtnultimosPagamentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnultimosPagamentos.Location = new System.Drawing.Point(951, 202);
            this.BtnultimosPagamentos.Name = "BtnultimosPagamentos";
            this.BtnultimosPagamentos.Size = new System.Drawing.Size(260, 88);
            this.BtnultimosPagamentos.TabIndex = 6;
            this.BtnultimosPagamentos.Text = "últimos pagamentos e\r\ninformações úteis\r\n";
            this.BtnultimosPagamentos.UseVisualStyleBackColor = true;
            this.BtnultimosPagamentos.Click += new System.EventHandler(this.btnUltimospag_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnclientesemdivida);
            this.panel1.Controls.Add(this.btnPromocoes);
            this.panel1.Controls.Add(this.btnCompra);
            this.panel1.Controls.Add(this.BtnultimosPagamentos);
            this.panel1.Controls.Add(this.btnInserir);
            this.panel1.Controls.Add(this.btnDuplicatas);
            this.panel1.Location = new System.Drawing.Point(-18, -10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1934, 1063);
            this.panel1.TabIndex = 7;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1916, 1053);
            this.Controls.Add(this.panel1);
            this.Name = "Principal";
            this.Text = "Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button btnCompra;
        private System.Windows.Forms.Button btnclientesemdivida;
        private System.Windows.Forms.Button btnPromocoes;
        private System.Windows.Forms.Button btnDuplicatas;
        private System.Windows.Forms.Button BtnultimosPagamentos;
        private System.Windows.Forms.Panel panel1;
    }
}

