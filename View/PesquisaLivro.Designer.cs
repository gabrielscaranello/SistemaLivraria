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
            this.label2 = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.btPesquisarLivro = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.dgvTabPesquisaLivros = new System.Windows.Forms.DataGridView();
            this.dgvCampoID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCampoTitulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabPesquisaLivros)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 29);
            this.label1.TabIndex = 23;
            this.label1.Text = "CONTROLE DE LIVROS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 108);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 27;
            this.label2.Text = "Título:";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(80, 106);
            this.txtTitulo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(648, 22);
            this.txtTitulo.TabIndex = 29;
            // 
            // btPesquisarLivro
            // 
            this.btPesquisarLivro.Image = global::SistemaBiblioteca.Properties.Resources.pesquisar4737;
            this.btPesquisarLivro.Location = new System.Drawing.Point(737, 102);
            this.btPesquisarLivro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btPesquisarLivro.Name = "btPesquisarLivro";
            this.btPesquisarLivro.Size = new System.Drawing.Size(92, 63);
            this.btPesquisarLivro.TabIndex = 30;
            this.btPesquisarLivro.UseVisualStyleBackColor = true;
            this.btPesquisarLivro.Click += new System.EventHandler(this.BtPesquisarLivro_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Image = global::SistemaBiblioteca.Properties.Resources.excluir4737;
            this.btnExcluir.Location = new System.Drawing.Point(748, 405);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(81, 60);
            this.btnExcluir.TabIndex = 22;
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.Button5_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Image = global::SistemaBiblioteca.Properties.Resources.atualizar4737;
            this.btnAtualizar.Location = new System.Drawing.Point(660, 405);
            this.btnAtualizar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(80, 60);
            this.btnAtualizar.TabIndex = 18;
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.BtVoltar_Click);
            // 
            // dgvTabPesquisaLivros
            // 
            this.dgvTabPesquisaLivros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTabPesquisaLivros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvCampoID,
            this.dgvCampoTitulo});
            this.dgvTabPesquisaLivros.Location = new System.Drawing.Point(80, 192);
            this.dgvTabPesquisaLivros.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvTabPesquisaLivros.Name = "dgvTabPesquisaLivros";
            this.dgvTabPesquisaLivros.RowHeadersWidth = 51;
            this.dgvTabPesquisaLivros.Size = new System.Drawing.Size(649, 185);
            this.dgvTabPesquisaLivros.TabIndex = 32;
            // 
            // dgvCampoID
            // 
            this.dgvCampoID.HeaderText = "ID";
            this.dgvCampoID.MinimumWidth = 6;
            this.dgvCampoID.Name = "dgvCampoID";
            this.dgvCampoID.Width = 50;
            // 
            // dgvCampoTitulo
            // 
            this.dgvCampoTitulo.HeaderText = "Título";
            this.dgvCampoTitulo.MinimumWidth = 6;
            this.dgvCampoTitulo.Name = "dgvCampoTitulo";
            this.dgvCampoTitulo.Width = 400;
            // 
            // PesquisaLivro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 471);
            this.Controls.Add(this.dgvTabPesquisaLivros);
            this.Controls.Add(this.btPesquisarLivro);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAtualizar);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "PesquisaLivro";
            this.Text = "Livro_Controle";
            this.Load += new System.EventHandler(this.PesquisaLivro_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PesquisaLivro_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabPesquisaLivros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Button btPesquisarLivro;
        private System.Windows.Forms.DataGridView dgvTabPesquisaLivros;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCampoID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCampoTitulo;
    }
}