namespace SistemaBiblioteca
{
    partial class Venda
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
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.txtCodFunc = new System.Windows.Forms.TextBox();
            this.dtpDataVenda = new System.Windows.Forms.DateTimePicker();
            this.dataGVProdutos = new System.Windows.Forms.DataGridView();
            this.CodProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Preco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.txtProduto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.numQuantidade = new System.Windows.Forms.NumericUpDown();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnPesquisaProduto = new System.Windows.Forms.Button();
            this.btnPesquisaFuncionario = new System.Windows.Forms.Button();
            this.btnPesquisaCliente = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            this.btSalvar = new System.Windows.Forms.Button();
            this.btEditar = new System.Windows.Forms.Button();
            this.btVoltar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantidade)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 24);
            this.label1.TabIndex = 23;
            this.label1.Text = "Venda";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Cliente:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "CódFuncionário:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Data da venda:";
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Location = new System.Drawing.Point(93, 60);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(474, 20);
            this.txtNomeCliente.TabIndex = 27;
            this.txtNomeCliente.TextChanged += new System.EventHandler(this.TxtNomeCliente_TextChanged);
            this.txtNomeCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNomeCliente_KeyPress);
            // 
            // txtCodFunc
            // 
            this.txtCodFunc.Location = new System.Drawing.Point(93, 114);
            this.txtCodFunc.Name = "txtCodFunc";
            this.txtCodFunc.Size = new System.Drawing.Size(474, 20);
            this.txtCodFunc.TabIndex = 28;
            this.txtCodFunc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCodFunc_KeyPress);
            // 
            // dtpDataVenda
            // 
            this.dtpDataVenda.Location = new System.Drawing.Point(93, 157);
            this.dtpDataVenda.Name = "dtpDataVenda";
            this.dtpDataVenda.Size = new System.Drawing.Size(228, 20);
            this.dtpDataVenda.TabIndex = 29;
            this.dtpDataVenda.UseWaitCursor = true;
            this.dtpDataVenda.Value = new System.DateTime(2019, 6, 17, 0, 0, 0, 0);
            // 
            // dataGVProdutos
            // 
            this.dataGVProdutos.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGVProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodProduto,
            this.Produto,
            this.Preco,
            this.Quantidade,
            this.ValorTotal});
            this.dataGVProdutos.Location = new System.Drawing.Point(93, 289);
            this.dataGVProdutos.Name = "dataGVProdutos";
            this.dataGVProdutos.Size = new System.Drawing.Size(474, 113);
            this.dataGVProdutos.TabIndex = 30;
            // 
            // CodProduto
            // 
            this.CodProduto.Frozen = true;
            this.CodProduto.HeaderText = "CódProduto";
            this.CodProduto.Name = "CodProduto";
            this.CodProduto.ReadOnly = true;
            this.CodProduto.Width = 50;
            // 
            // Produto
            // 
            this.Produto.Frozen = true;
            this.Produto.HeaderText = "Produto";
            this.Produto.Name = "Produto";
            this.Produto.ReadOnly = true;
            this.Produto.Width = 210;
            // 
            // Preco
            // 
            this.Preco.HeaderText = "ValorUnitário";
            this.Preco.Name = "Preco";
            this.Preco.ReadOnly = true;
            this.Preco.Width = 60;
            // 
            // Quantidade
            // 
            this.Quantidade.HeaderText = "QNT.";
            this.Quantidade.Name = "Quantidade";
            this.Quantidade.Width = 50;
            // 
            // ValorTotal
            // 
            this.ValorTotal.HeaderText = "ValorTotal";
            this.ValorTotal.Name = "ValorTotal";
            this.ValorTotal.ReadOnly = true;
            this.ValorTotal.Width = 60;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(426, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 20);
            this.label5.TabIndex = 31;
            this.label5.Text = "Total";
            // 
            // txtProduto
            // 
            this.txtProduto.Location = new System.Drawing.Point(93, 203);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Size = new System.Drawing.Size(474, 20);
            this.txtProduto.TabIndex = 36;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 35;
            this.label6.Text = "Produto:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 254);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 38;
            this.label7.Text = "Quantidade:";
            // 
            // numQuantidade
            // 
            this.numQuantidade.Location = new System.Drawing.Point(93, 251);
            this.numQuantidade.Name = "numQuantidade";
            this.numQuantidade.Size = new System.Drawing.Size(47, 20);
            this.numQuantidade.TabIndex = 41;
            // 
            // btnOk
            // 
            this.btnOk.Image = global::SistemaBiblioteca.Properties.Resources.ok4737;
            this.btnOk.Location = new System.Drawing.Point(576, 236);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(55, 47);
            this.btnOk.TabIndex = 40;
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // btnPesquisaProduto
            // 
            this.btnPesquisaProduto.Image = global::SistemaBiblioteca.Properties.Resources.pesquisar4737;
            this.btnPesquisaProduto.Location = new System.Drawing.Point(573, 183);
            this.btnPesquisaProduto.Name = "btnPesquisaProduto";
            this.btnPesquisaProduto.Size = new System.Drawing.Size(55, 47);
            this.btnPesquisaProduto.TabIndex = 37;
            this.btnPesquisaProduto.UseVisualStyleBackColor = true;
            this.btnPesquisaProduto.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnPesquisaFuncionario
            // 
            this.btnPesquisaFuncionario.Image = global::SistemaBiblioteca.Properties.Resources.pesquisar4737;
            this.btnPesquisaFuncionario.Location = new System.Drawing.Point(573, 92);
            this.btnPesquisaFuncionario.Name = "btnPesquisaFuncionario";
            this.btnPesquisaFuncionario.Size = new System.Drawing.Size(55, 47);
            this.btnPesquisaFuncionario.TabIndex = 34;
            this.btnPesquisaFuncionario.UseVisualStyleBackColor = true;
            this.btnPesquisaFuncionario.Click += new System.EventHandler(this.BtnPesquisaFuncionario_Click);
            // 
            // btnPesquisaCliente
            // 
            this.btnPesquisaCliente.Image = global::SistemaBiblioteca.Properties.Resources.pesquisar4737;
            this.btnPesquisaCliente.Location = new System.Drawing.Point(573, 40);
            this.btnPesquisaCliente.Name = "btnPesquisaCliente";
            this.btnPesquisaCliente.Size = new System.Drawing.Size(55, 47);
            this.btnPesquisaCliente.TabIndex = 33;
            this.btnPesquisaCliente.UseVisualStyleBackColor = true;
            this.btnPesquisaCliente.Click += new System.EventHandler(this.BtnPesquisaCliente_Click);
            this.btnPesquisaCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BtnPesquisaCliente_KeyPress);
            // 
            // button5
            // 
            this.button5.Image = global::SistemaBiblioteca.Properties.Resources.avancar4737;
            this.button5.Location = new System.Drawing.Point(391, 409);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(55, 47);
            this.button5.TabIndex = 22;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // btExcluir
            // 
            this.btExcluir.Image = global::SistemaBiblioteca.Properties.Resources.excluir4737;
            this.btExcluir.Location = new System.Drawing.Point(578, 409);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(55, 47);
            this.btExcluir.TabIndex = 21;
            this.btExcluir.UseVisualStyleBackColor = true;
            // 
            // btSalvar
            // 
            this.btSalvar.Image = global::SistemaBiblioteca.Properties.Resources.salvar4737;
            this.btSalvar.Location = new System.Drawing.Point(511, 409);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(55, 47);
            this.btSalvar.TabIndex = 20;
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.BtSalvar_Click);
            // 
            // btEditar
            // 
            this.btEditar.Image = global::SistemaBiblioteca.Properties.Resources.edit4737;
            this.btEditar.Location = new System.Drawing.Point(449, 409);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(55, 47);
            this.btEditar.TabIndex = 19;
            this.btEditar.UseVisualStyleBackColor = true;
            // 
            // btVoltar
            // 
            this.btVoltar.Image = global::SistemaBiblioteca.Properties.Resources.voltar4737;
            this.btVoltar.Location = new System.Drawing.Point(330, 409);
            this.btVoltar.Name = "btVoltar";
            this.btVoltar.Size = new System.Drawing.Size(55, 47);
            this.btVoltar.TabIndex = 18;
            this.btVoltar.UseVisualStyleBackColor = true;
            this.btVoltar.Click += new System.EventHandler(this.BtVoltar_Click);
            // 
            // Venda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(634, 461);
            this.Controls.Add(this.numQuantidade);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnPesquisaProduto);
            this.Controls.Add(this.txtProduto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnPesquisaFuncionario);
            this.Controls.Add(this.btnPesquisaCliente);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGVProdutos);
            this.Controls.Add(this.dtpDataVenda);
            this.Controls.Add(this.txtCodFunc);
            this.Controls.Add(this.txtNomeCliente);
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
            this.Name = "Venda";
            this.Text = "Venda";
            this.Load += new System.EventHandler(this.Venda_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Venda_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGVProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantidade)).EndInit();
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
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.TextBox txtCodFunc;
        private System.Windows.Forms.DateTimePicker dtpDataVenda;
        private System.Windows.Forms.DataGridView dataGVProdutos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnPesquisaCliente;
        private System.Windows.Forms.Button btnPesquisaFuncionario;
        private System.Windows.Forms.Button btnPesquisaProduto;
        private System.Windows.Forms.TextBox txtProduto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.NumericUpDown numQuantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Preco;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorTotal;
    }
}