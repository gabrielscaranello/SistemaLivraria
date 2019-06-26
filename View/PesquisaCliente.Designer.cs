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
            this.label2 = new System.Windows.Forms.Label();
            this.txtPesquisarNome = new System.Windows.Forms.TextBox();
            this.btnPesquisa = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btVoltar = new System.Windows.Forms.Button();
            this.dgvTabCliente = new System.Windows.Forms.DataGridView();
            this.dgvNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tgvNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(69, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 24);
            this.label1.TabIndex = 23;
            this.label1.Text = "Controle De Clientes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Nome:";
            // 
            // txtPesquisarNome
            // 
            this.txtPesquisarNome.Location = new System.Drawing.Point(56, 90);
            this.txtPesquisarNome.Name = "txtPesquisarNome";
            this.txtPesquisarNome.Size = new System.Drawing.Size(501, 20);
            this.txtPesquisarNome.TabIndex = 31;
            // 
            // btnPesquisa
            // 
            this.btnPesquisa.Image = global::SistemaBiblioteca.Properties.Resources.pesquisar4737;
            this.btnPesquisa.Location = new System.Drawing.Point(563, 69);
            this.btnPesquisa.Name = "btnPesquisa";
            this.btnPesquisa.Size = new System.Drawing.Size(62, 41);
            this.btnPesquisa.TabIndex = 32;
            this.btnPesquisa.UseVisualStyleBackColor = true;
            this.btnPesquisa.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button5
            // 
            this.button5.Image = global::SistemaBiblioteca.Properties.Resources.avancar4737;
            this.button5.Location = new System.Drawing.Point(575, 305);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(50, 43);
            this.button5.TabIndex = 22;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // btVoltar
            // 
            this.btVoltar.Image = global::SistemaBiblioteca.Properties.Resources.atualizar4737;
            this.btVoltar.Location = new System.Drawing.Point(515, 305);
            this.btVoltar.Name = "btVoltar";
            this.btVoltar.Size = new System.Drawing.Size(54, 43);
            this.btVoltar.TabIndex = 18;
            this.btVoltar.UseVisualStyleBackColor = true;
            // 
            // dgvTabCliente
            // 
            this.dgvTabCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTabCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvNome,
            this.tgvNome});
            this.dgvTabCliente.Location = new System.Drawing.Point(54, 148);
            this.dgvTabCliente.Name = "dgvTabCliente";
            this.dgvTabCliente.Size = new System.Drawing.Size(503, 150);
            this.dgvTabCliente.TabIndex = 33;
            // 
            // dgvNome
            // 
            this.dgvNome.HeaderText = "ID";
            this.dgvNome.Name = "dgvNome";
            this.dgvNome.Width = 50;
            // 
            // tgvNome
            // 
            this.tgvNome.HeaderText = "Nome";
            this.tgvNome.Name = "tgvNome";
            this.tgvNome.Width = 410;
            // 
            // PesquisaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 359);
            this.Controls.Add(this.dgvTabCliente);
            this.Controls.Add(this.btnPesquisa);
            this.Controls.Add(this.txtPesquisarNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btVoltar);
            this.KeyPreview = true;
            this.Name = "PesquisaCliente";
            this.Text = "Cliente_Controle";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PesquisaCliente_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btVoltar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPesquisarNome;
        private System.Windows.Forms.Button btnPesquisa;
        private System.Windows.Forms.DataGridView dgvTabCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn tgvNome;
    }
}