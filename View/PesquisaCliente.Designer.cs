namespace SistemaBiblioteca
{
    partial class PesquisaCliente
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
            this.cbCadCli = new System.Windows.Forms.CheckBox();
            this.cbAtuCli = new System.Windows.Forms.CheckBox();
            this.cbExCli = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPesquisarNome = new System.Windows.Forms.TextBox();
            this.btnPesquisa = new System.Windows.Forms.Button();
            this.ResultadoPesquisa = new System.Windows.Forms.ListBox();
            this.button5 = new System.Windows.Forms.Button();
            this.btVoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(222, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 24);
            this.label1.TabIndex = 23;
            this.label1.Text = "Controle De Clientes";
            // 
            // cbCadCli
            // 
            this.cbCadCli.AutoSize = true;
            this.cbCadCli.Checked = true;
            this.cbCadCli.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbCadCli.Location = new System.Drawing.Point(189, 85);
            this.cbCadCli.Name = "cbCadCli";
            this.cbCadCli.Size = new System.Drawing.Size(71, 17);
            this.cbCadCli.TabIndex = 27;
            this.cbCadCli.Text = "Cadastrar";
            this.cbCadCli.UseVisualStyleBackColor = true;
            // 
            // cbAtuCli
            // 
            this.cbAtuCli.AutoSize = true;
            this.cbAtuCli.Location = new System.Drawing.Point(309, 85);
            this.cbAtuCli.Name = "cbAtuCli";
            this.cbAtuCli.Size = new System.Drawing.Size(66, 17);
            this.cbAtuCli.TabIndex = 28;
            this.cbAtuCli.Text = "Atualizar";
            this.cbAtuCli.UseVisualStyleBackColor = true;
            // 
            // cbExCli
            // 
            this.cbExCli.AutoSize = true;
            this.cbExCli.Location = new System.Drawing.Point(450, 85);
            this.cbExCli.Name = "cbExCli";
            this.cbExCli.Size = new System.Drawing.Size(57, 17);
            this.cbExCli.TabIndex = 29;
            this.cbExCli.Text = "Excluir";
            this.cbExCli.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Nome:";
            // 
            // tbPesquisarNome
            // 
            this.tbPesquisarNome.Location = new System.Drawing.Point(73, 131);
            this.tbPesquisarNome.Name = "tbPesquisarNome";
            this.tbPesquisarNome.Size = new System.Drawing.Size(463, 20);
            this.tbPesquisarNome.TabIndex = 31;
            // 
            // btnPesquisa
            // 
            this.btnPesquisa.Location = new System.Drawing.Point(555, 131);
            this.btnPesquisa.Name = "btnPesquisa";
            this.btnPesquisa.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisa.TabIndex = 32;
            this.btnPesquisa.Text = "PESQUISAR";
            this.btnPesquisa.UseVisualStyleBackColor = true;
            this.btnPesquisa.Click += new System.EventHandler(this.Button1_Click);
            // 
            // ResultadoPesquisa
            // 
            this.ResultadoPesquisa.FormattingEnabled = true;
            this.ResultadoPesquisa.Location = new System.Drawing.Point(73, 169);
            this.ResultadoPesquisa.Name = "ResultadoPesquisa";
            this.ResultadoPesquisa.Size = new System.Drawing.Size(557, 173);
            this.ResultadoPesquisa.TabIndex = 33;
            // 
            // button5
            // 
            this.button5.Image = global::SistemaBiblioteca.Properties.Resources.voltar;
            this.button5.Location = new System.Drawing.Point(568, 395);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(62, 43);
            this.button5.TabIndex = 22;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // btVoltar
            // 
            this.btVoltar.Image = global::SistemaBiblioteca.Properties.Resources.avancar;
            this.btVoltar.Location = new System.Drawing.Point(503, 395);
            this.btVoltar.Name = "btVoltar";
            this.btVoltar.Size = new System.Drawing.Size(59, 43);
            this.btVoltar.TabIndex = 18;
            this.btVoltar.UseVisualStyleBackColor = true;
            // 
            // PesquisaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 450);
            this.Controls.Add(this.ResultadoPesquisa);
            this.Controls.Add(this.btnPesquisa);
            this.Controls.Add(this.tbPesquisarNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbExCli);
            this.Controls.Add(this.cbAtuCli);
            this.Controls.Add(this.cbCadCli);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btVoltar);
            this.Name = "PesquisaCliente";
            this.Text = "Cliente_Controle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btVoltar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbCadCli;
        private System.Windows.Forms.CheckBox cbAtuCli;
        private System.Windows.Forms.CheckBox cbExCli;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPesquisarNome;
        private System.Windows.Forms.Button btnPesquisa;
        private System.Windows.Forms.ListBox ResultadoPesquisa;
    }
}