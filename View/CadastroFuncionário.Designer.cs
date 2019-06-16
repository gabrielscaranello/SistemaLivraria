namespace SistemaBiblioteca
{
    partial class CadastroFuncionário
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.dtpDataAdm = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.mtxtCPF = new System.Windows.Forms.MaskedTextBox();
            this.mtxtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            this.btSalvar = new System.Windows.Forms.Button();
            this.btEditar = new System.Windows.Forms.Button();
            this.btVoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 24);
            this.label1.TabIndex = 23;
            this.label1.Text = "Cadastro De Funcionário";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(366, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Cargo:";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(350, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Data:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(66, 49);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(294, 20);
            this.txtNome.TabIndex = 27;
            // 
            // txtCargo
            // 
            this.txtCargo.Location = new System.Drawing.Point(410, 49);
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(213, 20);
            this.txtCargo.TabIndex = 28;
            this.txtCargo.TextChanged += new System.EventHandler(this.TbCargo_TextChanged);
            // 
            // dtpDataAdm
            // 
            this.dtpDataAdm.Location = new System.Drawing.Point(389, 126);
            this.dtpDataAdm.Name = "dtpDataAdm";
            this.dtpDataAdm.Size = new System.Drawing.Size(234, 20);
            this.dtpDataAdm.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(196, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "CPF:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "Telefone:";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(66, 87);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(557, 20);
            this.txtEndereco.TabIndex = 35;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 34;
            this.label7.Text = "Endereço:";
            // 
            // mtxtCPF
            // 
            this.mtxtCPF.Location = new System.Drawing.Point(232, 126);
            this.mtxtCPF.Mask = "000,000,000-00";
            this.mtxtCPF.Name = "mtxtCPF";
            this.mtxtCPF.Size = new System.Drawing.Size(88, 20);
            this.mtxtCPF.TabIndex = 36;
            // 
            // mtxtTelefone
            // 
            this.mtxtTelefone.Location = new System.Drawing.Point(66, 126);
            this.mtxtTelefone.Mask = "(00) 00000-0000";
            this.mtxtTelefone.Name = "mtxtTelefone";
            this.mtxtTelefone.Size = new System.Drawing.Size(90, 20);
            this.mtxtTelefone.TabIndex = 37;
            // 
            // button5
            // 
            this.button5.Image = global::SistemaBiblioteca.Properties.Resources.avancar4737;
            this.button5.Location = new System.Drawing.Point(400, 396);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(52, 53);
            this.button5.TabIndex = 22;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // btExcluir
            // 
            this.btExcluir.Image = global::SistemaBiblioteca.Properties.Resources.excluir4737;
            this.btExcluir.Location = new System.Drawing.Point(574, 396);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(49, 53);
            this.btExcluir.TabIndex = 21;
            this.btExcluir.UseVisualStyleBackColor = true;
            // 
            // btSalvar
            // 
            this.btSalvar.Image = global::SistemaBiblioteca.Properties.Resources.salvar4737;
            this.btSalvar.Location = new System.Drawing.Point(515, 396);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(56, 53);
            this.btSalvar.TabIndex = 20;
            this.btSalvar.UseVisualStyleBackColor = true;
            // 
            // btEditar
            // 
            this.btEditar.Image = global::SistemaBiblioteca.Properties.Resources.edit4737;
            this.btEditar.Location = new System.Drawing.Point(458, 396);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(51, 53);
            this.btEditar.TabIndex = 19;
            this.btEditar.UseVisualStyleBackColor = true;
            // 
            // btVoltar
            // 
            this.btVoltar.Image = global::SistemaBiblioteca.Properties.Resources.voltar4737;
            this.btVoltar.Location = new System.Drawing.Point(342, 396);
            this.btVoltar.Name = "btVoltar";
            this.btVoltar.Size = new System.Drawing.Size(52, 53);
            this.btVoltar.TabIndex = 18;
            this.btVoltar.UseVisualStyleBackColor = true;
            // 
            // CadastroFuncionário
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 461);
            this.Controls.Add(this.mtxtTelefone);
            this.Controls.Add(this.mtxtCPF);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpDataAdm);
            this.Controls.Add(this.txtCargo);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.btEditar);
            this.Controls.Add(this.btVoltar);
            this.KeyPreview = true;
            this.Name = "CadastroFuncionário";
            this.Text = "Cadastro_de_Funcionário";
            this.Load += new System.EventHandler(this.CadastroFuncionário_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CadastroFuncionário_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.Button btEditar;
        private System.Windows.Forms.Button btVoltar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCargo;
        private System.Windows.Forms.DateTimePicker dtpDataAdm;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox mtxtCPF;
        private System.Windows.Forms.MaskedTextBox mtxtTelefone;
    }
}