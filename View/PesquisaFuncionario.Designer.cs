namespace SistemaBiblioteca
{
    partial class PesquisaFuncionario
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
            this.txtNomeFunc = new System.Windows.Forms.TextBox();
            this.btnPesquisarFunc = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btVoltar = new System.Windows.Forms.Button();
            this.dgvPesquisaFunc = new System.Windows.Forms.DataGridView();
            this.dgvID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesquisaFunc)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 24);
            this.label1.TabIndex = 23;
            this.label1.Text = "CONTROLE DE FUNCIONÁRIOS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Nome:";
            // 
            // txtNomeFunc
            // 
            this.txtNomeFunc.Location = new System.Drawing.Point(59, 90);
            this.txtNomeFunc.Name = "txtNomeFunc";
            this.txtNomeFunc.Size = new System.Drawing.Size(498, 20);
            this.txtNomeFunc.TabIndex = 28;
            this.txtNomeFunc.TextChanged += new System.EventHandler(this.TxtNomeFunc_TextChanged);
            // 
            // btnPesquisarFunc
            // 
            this.btnPesquisarFunc.Image = global::SistemaBiblioteca.Properties.Resources.pesquisar4737;
            this.btnPesquisarFunc.Location = new System.Drawing.Point(563, 68);
            this.btnPesquisarFunc.Name = "btnPesquisarFunc";
            this.btnPesquisarFunc.Size = new System.Drawing.Size(59, 42);
            this.btnPesquisarFunc.TabIndex = 29;
            this.btnPesquisarFunc.UseVisualStyleBackColor = true;
            this.btnPesquisarFunc.Click += new System.EventHandler(this.BtnPesquisarFunc_Click);
            // 
            // button5
            // 
            this.button5.Image = global::SistemaBiblioteca.Properties.Resources.avancar4737;
            this.button5.Location = new System.Drawing.Point(563, 295);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(59, 42);
            this.button5.TabIndex = 22;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // btVoltar
            // 
            this.btVoltar.Image = global::SistemaBiblioteca.Properties.Resources.voltar4737;
            this.btVoltar.Location = new System.Drawing.Point(505, 295);
            this.btVoltar.Name = "btVoltar";
            this.btVoltar.Size = new System.Drawing.Size(59, 42);
            this.btVoltar.TabIndex = 18;
            this.btVoltar.UseVisualStyleBackColor = true;
            this.btVoltar.Click += new System.EventHandler(this.BtVoltar_Click);
            // 
            // dgvPesquisaFunc
            // 
            this.dgvPesquisaFunc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPesquisaFunc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvID,
            this.dgvNome});
            this.dgvPesquisaFunc.Location = new System.Drawing.Point(59, 116);
            this.dgvPesquisaFunc.Name = "dgvPesquisaFunc";
            this.dgvPesquisaFunc.Size = new System.Drawing.Size(498, 150);
            this.dgvPesquisaFunc.TabIndex = 30;
            // 
            // dgvID
            // 
            this.dgvID.HeaderText = "ID";
            this.dgvID.Name = "dgvID";
            // 
            // dgvNome
            // 
            this.dgvNome.HeaderText = "Nome";
            this.dgvNome.Name = "dgvNome";
            // 
            // PesquisaFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 341);
            this.Controls.Add(this.dgvPesquisaFunc);
            this.Controls.Add(this.btnPesquisarFunc);
            this.Controls.Add(this.txtNomeFunc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btVoltar);
            this.KeyPreview = true;
            this.Name = "PesquisaFuncionario";
            this.Text = "Funcionário Controle";
            this.Load += new System.EventHandler(this.Controle_Funcionário_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PesquisaFuncionario_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesquisaFunc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btVoltar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNomeFunc;
        private System.Windows.Forms.Button btnPesquisarFunc;
        private System.Windows.Forms.DataGridView dgvPesquisaFunc;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvNome;
    }
}