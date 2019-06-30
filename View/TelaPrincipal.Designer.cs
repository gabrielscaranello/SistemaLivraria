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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(telaPrincipal));
            this.btVenda = new System.Windows.Forms.Button();
            this.btCadCli = new System.Windows.Forms.Button();
            this.btCadFun = new System.Windows.Forms.Button();
            this.btCadLivros = new System.Windows.Forms.Button();
            this.btControleVenda = new System.Windows.Forms.Button();
            this.btControleCliente = new System.Windows.Forms.Button();
            this.btControleFunc = new System.Windows.Forms.Button();
            this.btControleLivro = new System.Windows.Forms.Button();
            this.pnlTelaInicio = new System.Windows.Forms.Panel();
            this.btnRelatorio = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlTelaInicio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btVenda
            // 
            resources.ApplyResources(this.btVenda, "btVenda");
            this.btVenda.Name = "btVenda";
            this.btVenda.UseVisualStyleBackColor = false;
            this.btVenda.Click += new System.EventHandler(this.BtVenda_Click);
            // 
            // btCadCli
            // 
            resources.ApplyResources(this.btCadCli, "btCadCli");
            this.btCadCli.Name = "btCadCli";
            this.btCadCli.UseVisualStyleBackColor = false;
            this.btCadCli.Click += new System.EventHandler(this.BtCadCli_Click);
            // 
            // btCadFun
            // 
            resources.ApplyResources(this.btCadFun, "btCadFun");
            this.btCadFun.Name = "btCadFun";
            this.btCadFun.UseVisualStyleBackColor = false;
            this.btCadFun.Click += new System.EventHandler(this.Button3_Click);
            // 
            // btCadLivros
            // 
            resources.ApplyResources(this.btCadLivros, "btCadLivros");
            this.btCadLivros.Name = "btCadLivros";
            this.btCadLivros.UseVisualStyleBackColor = false;
            this.btCadLivros.Click += new System.EventHandler(this.BtCadLivros_Click);
            // 
            // btControleVenda
            // 
            resources.ApplyResources(this.btControleVenda, "btControleVenda");
            this.btControleVenda.Name = "btControleVenda";
            this.btControleVenda.UseVisualStyleBackColor = false;
            this.btControleVenda.Click += new System.EventHandler(this.BtControleVenda_Click);
            // 
            // btControleCliente
            // 
            resources.ApplyResources(this.btControleCliente, "btControleCliente");
            this.btControleCliente.Name = "btControleCliente";
            this.btControleCliente.UseVisualStyleBackColor = false;
            this.btControleCliente.Click += new System.EventHandler(this.BtControleCliente_Click);
            // 
            // btControleFunc
            // 
            resources.ApplyResources(this.btControleFunc, "btControleFunc");
            this.btControleFunc.Name = "btControleFunc";
            this.btControleFunc.UseVisualStyleBackColor = false;
            this.btControleFunc.Click += new System.EventHandler(this.BtPesqFunc_Click);
            // 
            // btControleLivro
            // 
            resources.ApplyResources(this.btControleLivro, "btControleLivro");
            this.btControleLivro.Name = "btControleLivro";
            this.btControleLivro.UseVisualStyleBackColor = false;
            this.btControleLivro.Click += new System.EventHandler(this.BtControleLivro_Click);
            // 
            // pnlTelaInicio
            // 
            this.pnlTelaInicio.BackColor = System.Drawing.Color.Transparent;
            this.pnlTelaInicio.Controls.Add(this.btnRelatorio);
            this.pnlTelaInicio.Controls.Add(this.pictureBox1);
            this.pnlTelaInicio.Controls.Add(this.btVenda);
            this.pnlTelaInicio.Controls.Add(this.btControleLivro);
            this.pnlTelaInicio.Controls.Add(this.btCadCli);
            this.pnlTelaInicio.Controls.Add(this.btCadLivros);
            this.pnlTelaInicio.Controls.Add(this.btControleCliente);
            this.pnlTelaInicio.Controls.Add(this.btControleVenda);
            this.pnlTelaInicio.Controls.Add(this.btControleFunc);
            this.pnlTelaInicio.Controls.Add(this.btCadFun);
            resources.ApplyResources(this.pnlTelaInicio, "pnlTelaInicio");
            this.pnlTelaInicio.Name = "pnlTelaInicio";
            this.pnlTelaInicio.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlTelaInicio_Paint);
            // 
            // btnRelatorio
            // 
            resources.ApplyResources(this.btnRelatorio, "btnRelatorio");
            this.btnRelatorio.Name = "btnRelatorio";
            this.btnRelatorio.UseVisualStyleBackColor = true;
            this.btnRelatorio.Click += new System.EventHandler(this.BtnRelatorio_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::SistemaBiblioteca.Properties.Resources.logoLivraria;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // telaPrincipal
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlTelaInicio);
            this.KeyPreview = true;
            this.Name = "telaPrincipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.TelaPrincipal_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TelaPrincipal_KeyDown_1);
            this.pnlTelaInicio.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Panel pnlTelaInicio;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnRelatorio;
    }
}

