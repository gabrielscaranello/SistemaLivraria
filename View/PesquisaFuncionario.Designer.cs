namespace SistemaBiblioteca
{
    partial class PesquisaFuncionario
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
            this.txtNomeFunc = new System.Windows.Forms.TextBox();
            this.btnPesquisarFunc = new System.Windows.Forms.Button();
            this.ResultadoPesquisa = new System.Windows.Forms.ListBox();
            this.button5 = new System.Windows.Forms.Button();
            this.btVoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(100, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(400, 29);
            this.label1.TabIndex = 23;
            this.label1.Text = "CONTROLE DE FUNCIONÁRIOS";
            // 
            // cbCadastrar
            // 
            this.cbCadastrar.AutoSize = true;
            this.cbCadastrar.Checked = true;
            this.cbCadastrar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbCadastrar.Location = new System.Drawing.Point(81, 84);
            this.cbCadastrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbCadastrar.Name = "cbCadastrar";
            this.cbCadastrar.Size = new System.Drawing.Size(92, 21);
            this.cbCadastrar.TabIndex = 24;
            this.cbCadastrar.Text = "Cadastrar";
            this.cbCadastrar.UseVisualStyleBackColor = true;
            // 
            // cbAtualizar
            // 
            this.cbAtualizar.AutoSize = true;
            this.cbAtualizar.Location = new System.Drawing.Point(317, 84);
            this.cbAtualizar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbAtualizar.Name = "cbAtualizar";
            this.cbAtualizar.Size = new System.Drawing.Size(85, 21);
            this.cbAtualizar.TabIndex = 25;
            this.cbAtualizar.Text = "Atualizar";
            this.cbAtualizar.UseVisualStyleBackColor = true;
            // 
            // cbExcluir
            // 
            this.cbExcluir.AutoSize = true;
            this.cbExcluir.Location = new System.Drawing.Point(667, 82);
            this.cbExcluir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbExcluir.Name = "cbExcluir";
            this.cbExcluir.Size = new System.Drawing.Size(71, 21);
            this.cbExcluir.TabIndex = 26;
            this.cbExcluir.Text = "Excluir";
            this.cbExcluir.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 114);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 27;
            this.label2.Text = "Nome:";
            // 
            // txtNomeFunc
            // 
            this.txtNomeFunc.Location = new System.Drawing.Point(79, 111);
            this.txtNomeFunc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNomeFunc.Name = "txtNomeFunc";
            this.txtNomeFunc.Size = new System.Drawing.Size(663, 22);
            this.txtNomeFunc.TabIndex = 28;
            this.txtNomeFunc.TextChanged += new System.EventHandler(this.TxtNomeFunc_TextChanged);
            // 
            // btnPesquisarFunc
            // 
            this.btnPesquisarFunc.Image = global::SistemaBiblioteca.Properties.Resources.pesquisar4737;
            this.btnPesquisarFunc.Location = new System.Drawing.Point(751, 84);
            this.btnPesquisarFunc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPesquisarFunc.Name = "btnPesquisarFunc";
            this.btnPesquisarFunc.Size = new System.Drawing.Size(79, 52);
            this.btnPesquisarFunc.TabIndex = 29;
            this.btnPesquisarFunc.UseVisualStyleBackColor = true;
            this.btnPesquisarFunc.Click += new System.EventHandler(this.BtnPesquisarFunc_Click);
            // 
            // ResultadoPesquisa
            // 
            this.ResultadoPesquisa.FormattingEnabled = true;
            this.ResultadoPesquisa.ItemHeight = 16;
            this.ResultadoPesquisa.Location = new System.Drawing.Point(77, 143);
            this.ResultadoPesquisa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ResultadoPesquisa.Name = "ResultadoPesquisa";
            this.ResultadoPesquisa.Size = new System.Drawing.Size(751, 212);
            this.ResultadoPesquisa.TabIndex = 30;
            // 
            // button5
            // 
            this.button5.Image = global::SistemaBiblioteca.Properties.Resources.avancar4737;
            this.button5.Location = new System.Drawing.Point(751, 363);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(79, 52);
            this.button5.TabIndex = 22;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // btVoltar
            // 
            this.btVoltar.Image = global::SistemaBiblioteca.Properties.Resources.voltar4737;
            this.btVoltar.Location = new System.Drawing.Point(673, 363);
            this.btVoltar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btVoltar.Name = "btVoltar";
            this.btVoltar.Size = new System.Drawing.Size(79, 52);
            this.btVoltar.TabIndex = 18;
            this.btVoltar.UseVisualStyleBackColor = true;
            this.btVoltar.Click += new System.EventHandler(this.BtVoltar_Click);
            // 
            // PesquisaFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 420);
            this.Controls.Add(this.ResultadoPesquisa);
            this.Controls.Add(this.btnPesquisarFunc);
            this.Controls.Add(this.txtNomeFunc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbExcluir);
            this.Controls.Add(this.cbAtualizar);
            this.Controls.Add(this.cbCadastrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btVoltar);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "PesquisaFuncionario";
            this.Text = "Funcionário Controle";
            this.Load += new System.EventHandler(this.Controle_Funcionário_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PesquisaFuncionario_KeyDown);
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
        private System.Windows.Forms.TextBox txtNomeFunc;
        private System.Windows.Forms.Button btnPesquisarFunc;
        private System.Windows.Forms.ListBox ResultadoPesquisa;
    }
}