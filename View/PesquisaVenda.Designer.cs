namespace SistemaBiblioteca
{
    partial class PesquisaVenda
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
            this.button5 = new System.Windows.Forms.Button();
            this.btVoltar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbCadastrar = new System.Windows.Forms.CheckBox();
            this.cbAtualizar = new System.Windows.Forms.CheckBox();
            this.cbExcluir = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtVenda = new System.Windows.Forms.TextBox();
            this.btPesquisarVenda = new System.Windows.Forms.Button();
            this.Resultados = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // button5
            // 
            this.button5.Image = global::SistemaBiblioteca.Properties.Resources.voltar;
            this.button5.Location = new System.Drawing.Point(560, 355);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(61, 41);
            this.button5.TabIndex = 22;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // btVoltar
            // 
            this.btVoltar.Image = global::SistemaBiblioteca.Properties.Resources.avancar;
            this.btVoltar.Location = new System.Drawing.Point(492, 355);
            this.btVoltar.Name = "btVoltar";
            this.btVoltar.Size = new System.Drawing.Size(62, 41);
            this.btVoltar.TabIndex = 18;
            this.btVoltar.UseVisualStyleBackColor = true;
            this.btVoltar.Click += new System.EventHandler(this.BtVoltar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(214, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 24);
            this.label1.TabIndex = 23;
            this.label1.Text = "CONTROLE DE VENDA";
            // 
            // cbCadastrar
            // 
            this.cbCadastrar.AutoSize = true;
            this.cbCadastrar.Checked = true;
            this.cbCadastrar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbCadastrar.Location = new System.Drawing.Point(164, 89);
            this.cbCadastrar.Name = "cbCadastrar";
            this.cbCadastrar.Size = new System.Drawing.Size(71, 17);
            this.cbCadastrar.TabIndex = 24;
            this.cbCadastrar.Text = "Cadastrar";
            this.cbCadastrar.UseVisualStyleBackColor = true;
            // 
            // cbAtualizar
            // 
            this.cbAtualizar.AutoSize = true;
            this.cbAtualizar.Location = new System.Drawing.Point(286, 89);
            this.cbAtualizar.Name = "cbAtualizar";
            this.cbAtualizar.Size = new System.Drawing.Size(66, 17);
            this.cbAtualizar.TabIndex = 25;
            this.cbAtualizar.Text = "Atualizar";
            this.cbAtualizar.UseVisualStyleBackColor = true;
            // 
            // cbExcluir
            // 
            this.cbExcluir.AutoSize = true;
            this.cbExcluir.Location = new System.Drawing.Point(404, 89);
            this.cbExcluir.Name = "cbExcluir";
            this.cbExcluir.Size = new System.Drawing.Size(57, 17);
            this.cbExcluir.TabIndex = 26;
            this.cbExcluir.Text = "Excluir";
            this.cbExcluir.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Venda:";
            // 
            // txtVenda
            // 
            this.txtVenda.Location = new System.Drawing.Point(64, 130);
            this.txtVenda.Name = "txtVenda";
            this.txtVenda.Size = new System.Drawing.Size(462, 20);
            this.txtVenda.TabIndex = 28;
            // 
            // btPesquisarVenda
            // 
            this.btPesquisarVenda.Location = new System.Drawing.Point(546, 130);
            this.btPesquisarVenda.Name = "btPesquisarVenda";
            this.btPesquisarVenda.Size = new System.Drawing.Size(75, 23);
            this.btPesquisarVenda.TabIndex = 29;
            this.btPesquisarVenda.Text = "PESQUISAR";
            this.btPesquisarVenda.UseVisualStyleBackColor = true;
            // 
            // Resultados
            // 
            this.Resultados.FormattingEnabled = true;
            this.Resultados.Location = new System.Drawing.Point(63, 163);
            this.Resultados.Name = "Resultados";
            this.Resultados.Size = new System.Drawing.Size(558, 186);
            this.Resultados.TabIndex = 30;
            // 
            // PesquisaVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 403);
            this.Controls.Add(this.Resultados);
            this.Controls.Add(this.btPesquisarVenda);
            this.Controls.Add(this.txtVenda);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbExcluir);
            this.Controls.Add(this.cbAtualizar);
            this.Controls.Add(this.cbCadastrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btVoltar);
            this.KeyPreview = true;
            this.Name = "PesquisaVenda";
            this.Text = "Controle_Venda";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PesquisaVenda_KeyDown);
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
        private System.Windows.Forms.TextBox txtVenda;
        private System.Windows.Forms.Button btPesquisarVenda;
        private System.Windows.Forms.ListBox Resultados;
    }
}