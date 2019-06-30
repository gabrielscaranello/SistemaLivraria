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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtVenda = new System.Windows.Forms.TextBox();
            this.btPesquisarVenda = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.dgvTabVenda = new System.Windows.Forms.DataGridView();
            this.dgvCampoID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItensVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCampoData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvgCampoValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabVenda)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(79, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 29);
            this.label1.TabIndex = 23;
            this.label1.Text = "CONTROLE DE VENDA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 105);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 27;
            this.label2.Text = "Venda:";
            // 
            // txtVenda
            // 
            this.txtVenda.Location = new System.Drawing.Point(80, 105);
            this.txtVenda.Margin = new System.Windows.Forms.Padding(4);
            this.txtVenda.Name = "txtVenda";
            this.txtVenda.Size = new System.Drawing.Size(652, 22);
            this.txtVenda.TabIndex = 28;
            // 
            // btPesquisarVenda
            // 
            this.btPesquisarVenda.Image = global::SistemaBiblioteca.Properties.Resources.pesquisar4737;
            this.btPesquisarVenda.Location = new System.Drawing.Point(741, 81);
            this.btPesquisarVenda.Margin = new System.Windows.Forms.Padding(4);
            this.btPesquisarVenda.Name = "btPesquisarVenda";
            this.btPesquisarVenda.Size = new System.Drawing.Size(81, 52);
            this.btPesquisarVenda.TabIndex = 29;
            this.btPesquisarVenda.UseVisualStyleBackColor = true;
            this.btPesquisarVenda.Click += new System.EventHandler(this.BtPesquisarVenda_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Image = global::SistemaBiblioteca.Properties.Resources.excluir4737;
            this.btnExcluir.Location = new System.Drawing.Point(741, 370);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(4);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(81, 63);
            this.btnExcluir.TabIndex = 22;
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Image = global::SistemaBiblioteca.Properties.Resources.atualizar4737;
            this.btnAtualizar.Location = new System.Drawing.Point(651, 370);
            this.btnAtualizar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(81, 63);
            this.btnAtualizar.TabIndex = 18;
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.BtVoltar_Click);
            // 
            // dgvTabVenda
            // 
            this.dgvTabVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTabVenda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvCampoID,
            this.ItensVenda,
            this.dgvCampoData,
            this.dvgCampoValor});
            this.dgvTabVenda.Location = new System.Drawing.Point(80, 148);
            this.dgvTabVenda.Margin = new System.Windows.Forms.Padding(4);
            this.dgvTabVenda.Name = "dgvTabVenda";
            this.dgvTabVenda.RowHeadersWidth = 51;
            this.dgvTabVenda.Size = new System.Drawing.Size(633, 185);
            this.dgvTabVenda.TabIndex = 30;
            // 
            // dgvCampoID
            // 
            this.dgvCampoID.HeaderText = "ID";
            this.dgvCampoID.MinimumWidth = 6;
            this.dgvCampoID.Name = "dgvCampoID";
            this.dgvCampoID.Width = 150;
            // 
            // ItensVenda
            // 
            this.ItensVenda.HeaderText = "ItensVenda";
            this.ItensVenda.MinimumWidth = 6;
            this.ItensVenda.Name = "ItensVenda";
            this.ItensVenda.ReadOnly = true;
            this.ItensVenda.Width = 125;
            // 
            // dgvCampoData
            // 
            this.dgvCampoData.HeaderText = "Data";
            this.dgvCampoData.MinimumWidth = 6;
            this.dgvCampoData.Name = "dgvCampoData";
            this.dgvCampoData.Width = 150;
            // 
            // dvgCampoValor
            // 
            this.dvgCampoValor.HeaderText = "Valor";
            this.dvgCampoValor.MinimumWidth = 6;
            this.dvgCampoValor.Name = "dvgCampoValor";
            this.dvgCampoValor.Width = 125;
            // 
            // PesquisaVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 438);
            this.Controls.Add(this.dgvTabVenda);
            this.Controls.Add(this.btPesquisarVenda);
            this.Controls.Add(this.txtVenda);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAtualizar);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PesquisaVenda";
            this.Text = "Controle_Venda";
            this.Load += new System.EventHandler(this.PesquisaVenda_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PesquisaVenda_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabVenda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtVenda;
        private System.Windows.Forms.Button btPesquisarVenda;
        private System.Windows.Forms.DataGridView dgvTabVenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCampoID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItensVenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCampoData;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvgCampoValor;
    }
}