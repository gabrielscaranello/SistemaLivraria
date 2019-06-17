namespace SistemaBiblioteca
{
    partial class telaPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btVenda = new System.Windows.Forms.Button();
            this.btCadCli = new System.Windows.Forms.Button();
            this.btCadFun = new System.Windows.Forms.Button();
            this.btCadLivros = new System.Windows.Forms.Button();
            this.btControleVenda = new System.Windows.Forms.Button();
            this.btControleCliente = new System.Windows.Forms.Button();
            this.btControleFunc = new System.Windows.Forms.Button();
            this.btControleLivro = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btVenda
            // 
            this.btVenda.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVenda.Location = new System.Drawing.Point(60, 164);
            this.btVenda.Name = "btVenda";
            this.btVenda.Size = new System.Drawing.Size(249, 31);
            this.btVenda.TabIndex = 2;
            this.btVenda.Text = "VENDA";
            this.btVenda.UseVisualStyleBackColor = false;
            this.btVenda.Click += new System.EventHandler(this.BtVenda_Click);
            // 
            // btCadCli
            // 
            this.btCadCli.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btCadCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCadCli.Location = new System.Drawing.Point(60, 201);
            this.btCadCli.Name = "btCadCli";
            this.btCadCli.Size = new System.Drawing.Size(249, 31);
            this.btCadCli.TabIndex = 3;
            this.btCadCli.Text = "CADASTRO CLIENTE";
            this.btCadCli.UseVisualStyleBackColor = false;
            this.btCadCli.Click += new System.EventHandler(this.BtCadCli_Click);
            // 
            // btCadFun
            // 
            this.btCadFun.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btCadFun.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCadFun.Location = new System.Drawing.Point(60, 238);
            this.btCadFun.Name = "btCadFun";
            this.btCadFun.Size = new System.Drawing.Size(249, 31);
            this.btCadFun.TabIndex = 4;
            this.btCadFun.Text = "CADASTRO FUNCIONÁRIO";
            this.btCadFun.UseVisualStyleBackColor = false;
            this.btCadFun.Click += new System.EventHandler(this.Button3_Click);
            // 
            // btCadLivros
            // 
            this.btCadLivros.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btCadLivros.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCadLivros.Location = new System.Drawing.Point(60, 275);
            this.btCadLivros.Name = "btCadLivros";
            this.btCadLivros.Size = new System.Drawing.Size(249, 31);
            this.btCadLivros.TabIndex = 5;
            this.btCadLivros.Text = "CADASTRO LIVRO";
            this.btCadLivros.UseVisualStyleBackColor = false;
            this.btCadLivros.Click += new System.EventHandler(this.BtCadLivros_Click);
            // 
            // btControleVenda
            // 
            this.btControleVenda.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btControleVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btControleVenda.Location = new System.Drawing.Point(315, 164);
            this.btControleVenda.Name = "btControleVenda";
            this.btControleVenda.Size = new System.Drawing.Size(249, 31);
            this.btControleVenda.TabIndex = 6;
            this.btControleVenda.Text = "CONTROLE VENDA";
            this.btControleVenda.UseVisualStyleBackColor = false;
            this.btControleVenda.Click += new System.EventHandler(this.BtControleVenda_Click);
            // 
            // btControleCliente
            // 
            this.btControleCliente.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btControleCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btControleCliente.Location = new System.Drawing.Point(315, 201);
            this.btControleCliente.Name = "btControleCliente";
            this.btControleCliente.Size = new System.Drawing.Size(249, 31);
            this.btControleCliente.TabIndex = 7;
            this.btControleCliente.Text = "CONTROLE CLIENTE";
            this.btControleCliente.UseVisualStyleBackColor = false;
            this.btControleCliente.Click += new System.EventHandler(this.BtControleCliente_Click);
            // 
            // btControleFunc
            // 
            this.btControleFunc.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btControleFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btControleFunc.Location = new System.Drawing.Point(315, 238);
            this.btControleFunc.Name = "btControleFunc";
            this.btControleFunc.Size = new System.Drawing.Size(249, 31);
            this.btControleFunc.TabIndex = 8;
            this.btControleFunc.Text = "CONTROLE FUNCIONÁRIO";
            this.btControleFunc.UseVisualStyleBackColor = false;
            this.btControleFunc.Click += new System.EventHandler(this.BtPesqFunc_Click);
            // 
            // btControleLivro
            // 
            this.btControleLivro.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btControleLivro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btControleLivro.Location = new System.Drawing.Point(315, 275);
            this.btControleLivro.Name = "btControleLivro";
            this.btControleLivro.Size = new System.Drawing.Size(249, 31);
            this.btControleLivro.TabIndex = 9;
            this.btControleLivro.Text = "CONTROLE LIVRO";
            this.btControleLivro.UseVisualStyleBackColor = false;
            this.btControleLivro.Click += new System.EventHandler(this.BtControleLivro_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.BackColor = System.Drawing.SystemColors.Info;
            this.groupBox1.Controls.Add(this.btControleLivro);
            this.groupBox1.Controls.Add(this.btCadLivros);
            this.groupBox1.Controls.Add(this.btControleVenda);
            this.groupBox1.Controls.Add(this.btCadFun);
            this.groupBox1.Controls.Add(this.btControleCliente);
            this.groupBox1.Controls.Add(this.btCadCli);
            this.groupBox1.Controls.Add(this.btControleFunc);
            this.groupBox1.Controls.Add(this.btVenda);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox1.Size = new System.Drawing.Size(635, 461);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "BIBLIOTECA";
            this.groupBox1.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // telaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 461);
            this.Controls.Add(this.groupBox1);
            this.KeyPreview = true;
            this.Name = "telaPrincipal";
            this.Text = "Tela Principal";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TelaPrincipal_KeyDown_1);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btVenda;
        private System.Windows.Forms.Button btCadCli;
        private System.Windows.Forms.Button btCadFun;
        private System.Windows.Forms.Button btCadLivros;
        private System.Windows.Forms.Button btControleVenda;
        private System.Windows.Forms.Button btControleCliente;
        private System.Windows.Forms.Button btControleFunc;
        private System.Windows.Forms.Button btControleLivro;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

