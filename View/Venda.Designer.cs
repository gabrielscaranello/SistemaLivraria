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
            this.button5 = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            this.btSalvar = new System.Windows.Forms.Button();
            this.btEditar = new System.Windows.Forms.Button();
            this.btVoltar = new System.Windows.Forms.Button();
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
            this.btnPesquisaCliente = new System.Windows.Forms.Button();
            this.btnPesquisaFuncionario = new System.Windows.Forms.Button();
            this.btnPesquisaProduto = new System.Windows.Forms.Button();
            this.txtProduto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.numQuantidade = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantidade)).BeginInit();
            this.SuspendLayout();
            // 
            // button5
            // 
            this.button5.Image = global::SistemaBiblioteca.Properties.Resources.voltar;
            this.button5.Location = new System.Drawing.Point(277, 352);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 66);
            this.button5.TabIndex = 22;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // btExcluir
            // 
            this.btExcluir.Image = global::SistemaBiblioteca.Properties.Resources.LIXO;
            this.btExcluir.Location = new System.Drawing.Point(520, 352);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(75, 66);
            this.btExcluir.TabIndex = 21;
            this.btExcluir.UseVisualStyleBackColor = true;
            // 
            // btSalvar
            // 
            this.btSalvar.Image = global::SistemaBiblioteca.Properties.Resources.SALV;
            this.btSalvar.Location = new System.Drawing.Point(439, 352);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(75, 66);
            this.btSalvar.TabIndex = 20;
            this.btSalvar.UseVisualStyleBackColor = true;
            // 
            // btEditar
            // 
            this.btEditar.Image = global::SistemaBiblioteca.Properties.Resources.EDIT;
            this.btEditar.Location = new System.Drawing.Point(358, 352);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(75, 66);
            this.btEditar.TabIndex = 19;
            this.btEditar.UseVisualStyleBackColor = true;
            // 
            // btVoltar
            // 
            this.btVoltar.Image = global::SistemaBiblioteca.Properties.Resources.avancar;
            this.btVoltar.Location = new System.Drawing.Point(196, 352);
            this.btVoltar.Name = "btVoltar";
            this.btVoltar.Size = new System.Drawing.Size(75, 66);
            this.btVoltar.TabIndex = 18;
            this.btVoltar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 24);
            this.label1.TabIndex = 23;
            this.label1.Text = "Venda";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Cliente:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "CódFuncionário:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Data da venda:";
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Location = new System.Drawing.Point(139, 102);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(375, 20);
            this.txtNomeCliente.TabIndex = 27;
            // 
            // txtCodFunc
            // 
            this.txtCodFunc.Location = new System.Drawing.Point(139, 142);
            this.txtCodFunc.Name = "txtCodFunc";
            this.txtCodFunc.Size = new System.Drawing.Size(375, 20);
            this.txtCodFunc.TabIndex = 28;
            // 
            // dtpDataVenda
            // 
            this.dtpDataVenda.Location = new System.Drawing.Point(139, 67);
            this.dtpDataVenda.Name = "dtpDataVenda";
            this.dtpDataVenda.Size = new System.Drawing.Size(228, 20);
            this.dtpDataVenda.TabIndex = 29;
            // 
            // dataGVProdutos
            // 
            this.dataGVProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodProduto,
            this.Produto,
            this.Preco,
            this.Quantidade,
            this.ValorTotal});
            this.dataGVProdutos.Location = new System.Drawing.Point(52, 220);
            this.dataGVProdutos.Name = "dataGVProdutos";
            this.dataGVProdutos.Size = new System.Drawing.Size(543, 126);
            this.dataGVProdutos.TabIndex = 30;
            // 
            // CodProduto
            // 
            this.CodProduto.Frozen = true;
            this.CodProduto.HeaderText = "CódProduto";
            this.CodProduto.Name = "CodProduto";
            this.CodProduto.ReadOnly = true;
            // 
            // Produto
            // 
            this.Produto.Frozen = true;
            this.Produto.HeaderText = "Produto";
            this.Produto.Name = "Produto";
            this.Produto.ReadOnly = true;
            // 
            // Preco
            // 
            this.Preco.HeaderText = "ValorUnitário";
            this.Preco.Name = "Preco";
            this.Preco.ReadOnly = true;
            // 
            // Quantidade
            // 
            this.Quantidade.HeaderText = "Quantidade";
            this.Quantidade.Name = "Quantidade";
            // 
            // ValorTotal
            // 
            this.ValorTotal.HeaderText = "ValorTotal";
            this.ValorTotal.Name = "ValorTotal";
            this.ValorTotal.ReadOnly = true;
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
            // btnPesquisaCliente
            // 
            this.btnPesquisaCliente.Location = new System.Drawing.Point(520, 100);
            this.btnPesquisaCliente.Name = "btnPesquisaCliente";
            this.btnPesquisaCliente.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisaCliente.TabIndex = 33;
            this.btnPesquisaCliente.Text = "Pesquisar";
            this.btnPesquisaCliente.UseVisualStyleBackColor = true;
            this.btnPesquisaCliente.Click += new System.EventHandler(this.BtnPesquisaCliente_Click);
            // 
            // btnPesquisaFuncionario
            // 
            this.btnPesquisaFuncionario.Location = new System.Drawing.Point(520, 142);
            this.btnPesquisaFuncionario.Name = "btnPesquisaFuncionario";
            this.btnPesquisaFuncionario.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisaFuncionario.TabIndex = 34;
            this.btnPesquisaFuncionario.Text = "Pesquisar";
            this.btnPesquisaFuncionario.UseVisualStyleBackColor = true;
            this.btnPesquisaFuncionario.Click += new System.EventHandler(this.BtnPesquisaFuncionario_Click);
            // 
            // btnPesquisaProduto
            // 
            this.btnPesquisaProduto.Location = new System.Drawing.Point(321, 185);
            this.btnPesquisaProduto.Name = "btnPesquisaProduto";
            this.btnPesquisaProduto.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisaProduto.TabIndex = 37;
            this.btnPesquisaProduto.Text = "Pesquisar";
            this.btnPesquisaProduto.UseVisualStyleBackColor = true;
            this.btnPesquisaProduto.Click += new System.EventHandler(this.Button1_Click);
            // 
            // txtProduto
            // 
            this.txtProduto.Location = new System.Drawing.Point(139, 185);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Size = new System.Drawing.Size(176, 20);
            this.txtProduto.TabIndex = 36;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(83, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 35;
            this.label6.Text = "Produto:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(427, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 38;
            this.label7.Text = "Quantidade:";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(564, 183);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(31, 23);
            this.btnOk.TabIndex = 40;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // numQuantidade
            // 
            this.numQuantidade.Location = new System.Drawing.Point(498, 186);
            this.numQuantidade.Name = "numQuantidade";
            this.numQuantidade.Size = new System.Drawing.Size(38, 20);
            this.numQuantidade.TabIndex = 41;
            // 
            // Venda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 430);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn CodProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Preco;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnPesquisaCliente;
        private System.Windows.Forms.Button btnPesquisaFuncionario;
        private System.Windows.Forms.Button btnPesquisaProduto;
        private System.Windows.Forms.TextBox txtProduto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.NumericUpDown numQuantidade;
    }
}