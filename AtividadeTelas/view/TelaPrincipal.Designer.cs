namespace AtividadeTelas
{
    partial class tela1
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
            this.label1 = new System.Windows.Forms.Label();
            this.btCadCli = new System.Windows.Forms.Button();
            this.btCadLivro = new System.Windows.Forms.Button();
            this.btCadFuncionário = new System.Windows.Forms.Button();
            this.btRelatorio = new System.Windows.Forms.Button();
            this.btCliente = new System.Windows.Forms.Button();
            this.btVenda = new System.Windows.Forms.Button();
            this.ptbTelaInicial = new System.Windows.Forms.PictureBox();
            this.btLivro = new System.Windows.Forms.Button();
            this.btPesquisaLoc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ptbTelaInicial)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Montserrat Subrayada", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(177, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(497, 71);
            this.label1.TabIndex = 2;
            this.label1.Text = "SISTEMA LIVRARIA";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.UseCompatibleTextRendering = true;
            this.label1.UseMnemonic = false;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btCadCli
            // 
            this.btCadCli.BackColor = System.Drawing.Color.Yellow;
            this.btCadCli.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCadCli.Font = new System.Drawing.Font("Bernard MT Condensed", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCadCli.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btCadCli.Location = new System.Drawing.Point(177, 314);
            this.btCadCli.Name = "btCadCli";
            this.btCadCli.Size = new System.Drawing.Size(151, 23);
            this.btCadCli.TabIndex = 4;
            this.btCadCli.Text = "CADASTRO CLIENTE";
            this.btCadCli.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btCadCli.UseVisualStyleBackColor = false;
            // 
            // btCadLivro
            // 
            this.btCadLivro.BackColor = System.Drawing.Color.Yellow;
            this.btCadLivro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCadLivro.Font = new System.Drawing.Font("Bernard MT Condensed", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCadLivro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btCadLivro.Location = new System.Drawing.Point(177, 358);
            this.btCadLivro.Name = "btCadLivro";
            this.btCadLivro.Size = new System.Drawing.Size(151, 23);
            this.btCadLivro.TabIndex = 5;
            this.btCadLivro.Text = "CADASTRO LIVRO";
            this.btCadLivro.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btCadLivro.UseVisualStyleBackColor = false;
            // 
            // btCadFuncionário
            // 
            this.btCadFuncionário.BackColor = System.Drawing.Color.Yellow;
            this.btCadFuncionário.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCadFuncionário.Font = new System.Drawing.Font("Bernard MT Condensed", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCadFuncionário.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btCadFuncionário.Location = new System.Drawing.Point(177, 398);
            this.btCadFuncionário.Name = "btCadFuncionário";
            this.btCadFuncionário.Size = new System.Drawing.Size(151, 23);
            this.btCadFuncionário.TabIndex = 6;
            this.btCadFuncionário.Text = "CADASTRO FUNCIONÁRIO";
            this.btCadFuncionário.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btCadFuncionário.UseVisualStyleBackColor = false;
            this.btCadFuncionário.Click += new System.EventHandler(this.btCadFuncionário_Click);
            // 
            // btRelatorio
            // 
            this.btRelatorio.BackColor = System.Drawing.Color.Yellow;
            this.btRelatorio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btRelatorio.Font = new System.Drawing.Font("Bernard MT Condensed", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRelatorio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btRelatorio.Location = new System.Drawing.Point(365, 277);
            this.btRelatorio.Name = "btRelatorio";
            this.btRelatorio.Size = new System.Drawing.Size(137, 23);
            this.btRelatorio.TabIndex = 7;
            this.btRelatorio.Text = "RELATÓRIO";
            this.btRelatorio.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btRelatorio.UseVisualStyleBackColor = false;
            // 
            // btCliente
            // 
            this.btCliente.BackColor = System.Drawing.Color.Yellow;
            this.btCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCliente.Font = new System.Drawing.Font("Bernard MT Condensed", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btCliente.Location = new System.Drawing.Point(365, 314);
            this.btCliente.Name = "btCliente";
            this.btCliente.Size = new System.Drawing.Size(137, 23);
            this.btCliente.TabIndex = 8;
            this.btCliente.Text = "PESQUISAR CLIENTE";
            this.btCliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btCliente.UseVisualStyleBackColor = false;
            // 
            // btVenda
            // 
            this.btVenda.BackColor = System.Drawing.Color.Yellow;
            this.btVenda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btVenda.Font = new System.Drawing.Font("Bernard MT Condensed", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVenda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btVenda.Location = new System.Drawing.Point(177, 276);
            this.btVenda.Name = "btVenda";
            this.btVenda.Size = new System.Drawing.Size(151, 23);
            this.btVenda.TabIndex = 3;
            this.btVenda.Text = "VENDAS";
            this.btVenda.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btVenda.UseVisualStyleBackColor = false;
            this.btVenda.Click += new System.EventHandler(this.btLocar_Click);
            // 
            // ptbTelaInicial
            // 
            this.ptbTelaInicial.BackgroundImage = global::AtividadeTelas.Properties.Resources._3408694_stock_vector_back_to_school_education_cartoon_books_seamless_pattern_backgrou;
            this.ptbTelaInicial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ptbTelaInicial.Image = global::AtividadeTelas.Properties.Resources._3408694_stock_vector_back_to_school_education_cartoon_books_seamless_pattern_backgrou;
            this.ptbTelaInicial.Location = new System.Drawing.Point(0, 0);
            this.ptbTelaInicial.Name = "ptbTelaInicial";
            this.ptbTelaInicial.Size = new System.Drawing.Size(677, 450);
            this.ptbTelaInicial.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ptbTelaInicial.TabIndex = 0;
            this.ptbTelaInicial.TabStop = false;
            // 
            // btLivro
            // 
            this.btLivro.BackColor = System.Drawing.Color.Yellow;
            this.btLivro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btLivro.Font = new System.Drawing.Font("Bernard MT Condensed", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLivro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btLivro.Location = new System.Drawing.Point(365, 358);
            this.btLivro.Name = "btLivro";
            this.btLivro.Size = new System.Drawing.Size(137, 23);
            this.btLivro.TabIndex = 9;
            this.btLivro.Text = "PESQUISAR LIVRO";
            this.btLivro.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btLivro.UseVisualStyleBackColor = false;
            // 
            // btPesquisaLoc
            // 
            this.btPesquisaLoc.BackColor = System.Drawing.Color.Yellow;
            this.btPesquisaLoc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btPesquisaLoc.Font = new System.Drawing.Font("Bernard MT Condensed", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPesquisaLoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btPesquisaLoc.Location = new System.Drawing.Point(365, 398);
            this.btPesquisaLoc.Name = "btPesquisaLoc";
            this.btPesquisaLoc.Size = new System.Drawing.Size(137, 23);
            this.btPesquisaLoc.TabIndex = 10;
            this.btPesquisaLoc.Text = "PESQUISAR LOCAÇÃO";
            this.btPesquisaLoc.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btPesquisaLoc.UseVisualStyleBackColor = false;
            // 
            // tela1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 450);
            this.Controls.Add(this.btPesquisaLoc);
            this.Controls.Add(this.btLivro);
            this.Controls.Add(this.btCliente);
            this.Controls.Add(this.btRelatorio);
            this.Controls.Add(this.btCadFuncionário);
            this.Controls.Add(this.btCadLivro);
            this.Controls.Add(this.btCadCli);
            this.Controls.Add(this.btVenda);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ptbTelaInicial);
            this.Name = "tela1";
            this.Text = "Tela Principal";
            ((System.ComponentModel.ISupportInitialize)(this.ptbTelaInicial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ptbTelaInicial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btVenda;
        private System.Windows.Forms.Button btCadCli;
        private System.Windows.Forms.Button btCadLivro;
        private System.Windows.Forms.Button btCadFuncionário;
        private System.Windows.Forms.Button btRelatorio;
        private System.Windows.Forms.Button btCliente;
        private System.Windows.Forms.Button btLivro;
        private System.Windows.Forms.Button btPesquisaLoc;
    }
}

