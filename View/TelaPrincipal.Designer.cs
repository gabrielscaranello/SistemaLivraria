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
            this.SuspendLayout();
            // 
            // telaPrincipal
            // 
            resources.ApplyResources(this, "$this");
            this.Name = "telaPrincipal";
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
        private System.Windows.Forms.Button btRelatorio;
    }
}

