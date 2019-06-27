namespace SistemaBiblioteca
{
    partial class TelaVenda
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
            this.dgvTabProdutos = new System.Windows.Forms.DataGridView();
            this.dgvCampoCodProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCampoProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCampoPreco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCampoQnt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCampoValorTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.txtProduto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.numQuantidade = new System.Windows.Forms.NumericUpDown();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnPesquisaProduto = new System.Windows.Forms.Button();
            this.btnPesquisaFuncionario = new System.Windows.Forms.Button();
            this.btnPesquisaCliente = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantidade)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 29);
            this.label1.TabIndex = 23;
            this.label1.Text = "Venda";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 24;
            this.label2.Text = "Cliente:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 144);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 17);
            this.label3.TabIndex = 25;
            this.label3.Text = "CódFuncionário:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 193);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 17);
            this.label4.TabIndex = 26;
            this.label4.Text = "Data da venda:";
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Location = new System.Drawing.Point(124, 74);
            this.txtNomeCliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(631, 22);
            this.txtNomeCliente.TabIndex = 27;
            this.txtNomeCliente.TextChanged += new System.EventHandler(this.TxtNomeCliente_TextChanged);
            this.txtNomeCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNomeCliente_KeyPress);
            // 
            // txtCodFunc
            // 
            this.txtCodFunc.Location = new System.Drawing.Point(124, 140);
            this.txtCodFunc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCodFunc.Name = "txtCodFunc";
            this.txtCodFunc.Size = new System.Drawing.Size(631, 22);
            this.txtCodFunc.TabIndex = 28;
            this.txtCodFunc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCodFunc_KeyPress);
            // 
            // dtpDataVenda
            // 
            this.dtpDataVenda.Location = new System.Drawing.Point(124, 193);
            this.dtpDataVenda.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpDataVenda.Name = "dtpDataVenda";
            this.dtpDataVenda.Size = new System.Drawing.Size(303, 22);
            this.dtpDataVenda.TabIndex = 29;
            this.dtpDataVenda.UseWaitCursor = true;
            this.dtpDataVenda.Value = new System.DateTime(2019, 6, 17, 0, 0, 0, 0);
            // 
            // dgvTabProdutos
            // 
            this.dgvTabProdutos.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvTabProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTabProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvCampoCodProduto,
            this.dgvCampoProduto,
            this.dgvCampoPreco,
            this.dgvCampoQnt,
            this.dgvCampoValorTotal});
            this.dgvTabProdutos.Location = new System.Drawing.Point(124, 356);
            this.dgvTabProdutos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvTabProdutos.Name = "dgvTabProdutos";
            this.dgvTabProdutos.RowHeadersWidth = 51;
            this.dgvTabProdutos.Size = new System.Drawing.Size(632, 139);
            this.dgvTabProdutos.TabIndex = 30;
            // 
            // dgvCampoCodProduto
            // 
            this.dgvCampoCodProduto.Frozen = true;
            this.dgvCampoCodProduto.HeaderText = "CódProduto";
            this.dgvCampoCodProduto.MinimumWidth = 6;
            this.dgvCampoCodProduto.Name = "dgvCampoCodProduto";
            this.dgvCampoCodProduto.ReadOnly = true;
            this.dgvCampoCodProduto.Width = 50;
            // 
            // dgvCampoProduto
            // 
            this.dgvCampoProduto.Frozen = true;
            this.dgvCampoProduto.HeaderText = "Produto";
            this.dgvCampoProduto.MinimumWidth = 6;
            this.dgvCampoProduto.Name = "dgvCampoProduto";
            this.dgvCampoProduto.ReadOnly = true;
            this.dgvCampoProduto.Width = 200;
            // 
            // dgvCampoPreco
            // 
            this.dgvCampoPreco.HeaderText = "ValorUnitário";
            this.dgvCampoPreco.MinimumWidth = 6;
            this.dgvCampoPreco.Name = "dgvCampoPreco";
            this.dgvCampoPreco.ReadOnly = true;
            this.dgvCampoPreco.Width = 70;
            // 
            // dgvCampoQnt
            // 
            this.dgvCampoQnt.HeaderText = "Qnt";
            this.dgvCampoQnt.MinimumWidth = 6;
            this.dgvCampoQnt.Name = "dgvCampoQnt";
            this.dgvCampoQnt.Width = 50;
            // 
            // dgvCampoValorTotal
            // 
            this.dgvCampoValorTotal.HeaderText = "ValorTotal";
            this.dgvCampoValorTotal.MinimumWidth = 6;
            this.dgvCampoValorTotal.Name = "dgvCampoValorTotal";
            this.dgvCampoValorTotal.ReadOnly = true;
            this.dgvCampoValorTotal.Width = 70;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(568, 26);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 25);
            this.label5.TabIndex = 31;
            this.label5.Text = "Total";
            // 
            // txtProduto
            // 
            this.txtProduto.Location = new System.Drawing.Point(124, 250);
            this.txtProduto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Size = new System.Drawing.Size(631, 22);
            this.txtProduto.TabIndex = 36;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(53, 254);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 17);
            this.label6.TabIndex = 35;
            this.label6.Text = "Produto:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 313);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 17);
            this.label7.TabIndex = 38;
            this.label7.Text = "Quantidade:";
            // 
            // numQuantidade
            // 
            this.numQuantidade.Location = new System.Drawing.Point(124, 309);
            this.numQuantidade.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numQuantidade.Name = "numQuantidade";
            this.numQuantidade.Size = new System.Drawing.Size(63, 22);
            this.numQuantidade.TabIndex = 41;
            // 
            // btnOk
            // 
            this.btnOk.Image = global::SistemaBiblioteca.Properties.Resources.ok4737;
            this.btnOk.Location = new System.Drawing.Point(768, 290);
            this.btnOk.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(73, 58);
            this.btnOk.TabIndex = 40;
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // btnPesquisaProduto
            // 
            this.btnPesquisaProduto.Image = global::SistemaBiblioteca.Properties.Resources.pesquisar4737;
            this.btnPesquisaProduto.Location = new System.Drawing.Point(764, 225);
            this.btnPesquisaProduto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPesquisaProduto.Name = "btnPesquisaProduto";
            this.btnPesquisaProduto.Size = new System.Drawing.Size(73, 58);
            this.btnPesquisaProduto.TabIndex = 37;
            this.btnPesquisaProduto.UseVisualStyleBackColor = true;
            this.btnPesquisaProduto.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnPesquisaFuncionario
            // 
            this.btnPesquisaFuncionario.Image = global::SistemaBiblioteca.Properties.Resources.pesquisar4737;
            this.btnPesquisaFuncionario.Location = new System.Drawing.Point(764, 113);
            this.btnPesquisaFuncionario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPesquisaFuncionario.Name = "btnPesquisaFuncionario";
            this.btnPesquisaFuncionario.Size = new System.Drawing.Size(73, 58);
            this.btnPesquisaFuncionario.TabIndex = 34;
            this.btnPesquisaFuncionario.UseVisualStyleBackColor = true;
            this.btnPesquisaFuncionario.Click += new System.EventHandler(this.BtnPesquisaFuncionario_Click);
            // 
            // btnPesquisaCliente
            // 
            this.btnPesquisaCliente.Image = global::SistemaBiblioteca.Properties.Resources.pesquisar4737;
            this.btnPesquisaCliente.Location = new System.Drawing.Point(764, 49);
            this.btnPesquisaCliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPesquisaCliente.Name = "btnPesquisaCliente";
            this.btnPesquisaCliente.Size = new System.Drawing.Size(73, 58);
            this.btnPesquisaCliente.TabIndex = 33;
            this.btnPesquisaCliente.UseVisualStyleBackColor = true;
            this.btnPesquisaCliente.Click += new System.EventHandler(this.BtnPesquisaCliente_Click);
            this.btnPesquisaCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BtnPesquisaCliente_KeyPress);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Image = global::SistemaBiblioteca.Properties.Resources.excluir4737;
            this.btnExcluir.Location = new System.Drawing.Point(771, 503);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(73, 58);
            this.btnExcluir.TabIndex = 21;
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Image = global::SistemaBiblioteca.Properties.Resources.salvar4737;
            this.btnSalvar.Location = new System.Drawing.Point(681, 503);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(73, 58);
            this.btnSalvar.TabIndex = 20;
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Image = global::SistemaBiblioteca.Properties.Resources.edit4737;
            this.btnEditar.Location = new System.Drawing.Point(599, 503);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(73, 58);
            this.btnEditar.TabIndex = 19;
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // TelaVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(845, 567);
            this.Controls.Add(this.numQuantidade);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnPesquisaProduto);
            this.Controls.Add(this.txtProduto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnPesquisaFuncionario);
            this.Controls.Add(this.btnPesquisaCliente);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvTabProdutos);
            this.Controls.Add(this.dtpDataVenda);
            this.Controls.Add(this.txtCodFunc);
            this.Controls.Add(this.txtNomeCliente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnEditar);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "TelaVenda";
            this.Text = "Venda";
            this.Load += new System.EventHandler(this.Venda_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Venda_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantidade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.TextBox txtCodFunc;
        private System.Windows.Forms.DateTimePicker dtpDataVenda;
        private System.Windows.Forms.DataGridView dgvTabProdutos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnPesquisaCliente;
        private System.Windows.Forms.Button btnPesquisaFuncionario;
        private System.Windows.Forms.Button btnPesquisaProduto;
        private System.Windows.Forms.TextBox txtProduto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.NumericUpDown numQuantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCampoCodProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCampoProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCampoPreco;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCampoQnt;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCampoValorTotal;
    }
}