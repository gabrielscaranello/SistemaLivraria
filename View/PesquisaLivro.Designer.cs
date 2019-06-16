namespace SistemaBiblioteca
{
    partial class PesquisaLivro
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbCadastrar = new System.Windows.Forms.CheckBox();
            this.cbAtualizar = new System.Windows.Forms.CheckBox();
            this.cbExcluir = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.btPesquisarLivro = new System.Windows.Forms.Button();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.ResultadoPesquisa = new System.Windows.Forms.ListBox();
            this.button5 = new System.Windows.Forms.Button();
            this.btVoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 24);
            this.label1.TabIndex = 23;
            this.label1.Text = "CONTROLE DE LIVROS";
            // 
            // cbCadastrar
            // 
            this.cbCadastrar.AutoSize = true;
            this.cbCadastrar.Checked = true;
            this.cbCadastrar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbCadastrar.Location = new System.Drawing.Point(60, 60);
            this.cbCadastrar.Name = "cbCadastrar";
            this.cbCadastrar.Size = new System.Drawing.Size(71, 17);
            this.cbCadastrar.TabIndex = 24;
            this.cbCadastrar.Text = "Cadastrar";
            this.cbCadastrar.UseVisualStyleBackColor = true;
            // 
            // cbAtualizar
            // 
            this.cbAtualizar.AutoSize = true;
            this.cbAtualizar.Location = new System.Drawing.Point(137, 60);
            this.cbAtualizar.Name = "cbAtualizar";
            this.cbAtualizar.Size = new System.Drawing.Size(66, 17);
            this.cbAtualizar.TabIndex = 25;
            this.cbAtualizar.Text = "Atualizar";
            this.cbAtualizar.UseVisualStyleBackColor = true;
            // 
            // cbExcluir
            // 
            this.cbExcluir.AutoSize = true;
            this.cbExcluir.Location = new System.Drawing.Point(209, 60);
            this.cbExcluir.Name = "cbExcluir";
            this.cbExcluir.Size = new System.Drawing.Size(57, 17);
            this.cbExcluir.TabIndex = 26;
            this.cbExcluir.Text = "Excluir";
            this.cbExcluir.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Título:";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Código:";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(60, 86);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(487, 20);
            this.txtTitulo.TabIndex = 29;
            // 
            // btPesquisarLivro
            // 
            this.btPesquisarLivro.Image = global::SistemaBiblioteca.Properties.Resources.pesquisar4737;
            this.btPesquisarLivro.Location = new System.Drawing.Point(553, 83);
            this.btPesquisarLivro.Name = "btPesquisarLivro";
            this.btPesquisarLivro.Size = new System.Drawing.Size(69, 51);
            this.btPesquisarLivro.TabIndex = 30;
            this.btPesquisarLivro.UseVisualStyleBackColor = true;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(60, 114);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(487, 20);
            this.txtCodigo.TabIndex = 31;
            // 
            // ResultadoPesquisa
            // 
            this.ResultadoPesquisa.FormattingEnabled = true;
            this.ResultadoPesquisa.Location = new System.Drawing.Point(59, 143);
            this.ResultadoPesquisa.Name = "ResultadoPesquisa";
            this.ResultadoPesquisa.Size = new System.Drawing.Size(563, 186);
            this.ResultadoPesquisa.TabIndex = 32;
            // 
            // button5
            // 
            this.button5.Image = global::SistemaBiblioteca.Properties.Resources.avancar4737;
            this.button5.Location = new System.Drawing.Point(561, 406);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(61, 43);
            this.button5.TabIndex = 22;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // btVoltar
            // 
            this.btVoltar.Image = global::SistemaBiblioteca.Properties.Resources.voltar4737;
            this.btVoltar.Location = new System.Drawing.Point(495, 406);
            this.btVoltar.Name = "btVoltar";
            this.btVoltar.Size = new System.Drawing.Size(60, 43);
            this.btVoltar.TabIndex = 18;
            this.btVoltar.UseVisualStyleBackColor = true;
            this.btVoltar.Click += new System.EventHandler(this.BtVoltar_Click);
            // 
            // PesquisaLivro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 461);
            this.Controls.Add(this.ResultadoPesquisa);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.btPesquisarLivro);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbExcluir);
            this.Controls.Add(this.cbAtualizar);
            this.Controls.Add(this.cbCadastrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btVoltar);
            this.KeyPreview = true;
            this.Name = "PesquisaLivro";
            this.Text = "Livro_Controle";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PesquisaLivro_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btVoltar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbCadastrar;
        private System.Windows.Forms.CheckBox cbAtualizar;
        private System.Windows.Forms.CheckBox cbExcluir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Button btPesquisarLivro;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.ListBox ResultadoPesquisa;
    }
}