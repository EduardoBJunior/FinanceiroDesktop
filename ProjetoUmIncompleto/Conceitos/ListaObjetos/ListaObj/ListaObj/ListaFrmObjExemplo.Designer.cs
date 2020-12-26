namespace ListaObj
{
    partial class ListaFrmObjExemplo
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
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIdade = new System.Windows.Forms.TextBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.grdRes = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNomePesq = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPesqIdade = new System.Windows.Forms.TextBox();
            this.btnPesq = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdRes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome : ";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(118, 29);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(171, 20);
            this.txtNome.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Endereco :";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(118, 59);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(171, 20);
            this.txtEndereco.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Idade :";
            // 
            // txtIdade
            // 
            this.txtIdade.Location = new System.Drawing.Point(118, 97);
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.Size = new System.Drawing.Size(62, 20);
            this.txtIdade.TabIndex = 2;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(214, 94);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionar.TabIndex = 3;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // grdRes
            // 
            this.grdRes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdRes.Location = new System.Drawing.Point(12, 233);
            this.grdRes.Name = "grdRes";
            this.grdRes.ReadOnly = true;
            this.grdRes.Size = new System.Drawing.Size(372, 150);
            this.grdRes.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Pesquisa Nome :";
            // 
            // txtNomePesq
            // 
            this.txtNomePesq.Location = new System.Drawing.Point(118, 152);
            this.txtNomePesq.Name = "txtNomePesq";
            this.txtNomePesq.Size = new System.Drawing.Size(164, 20);
            this.txtNomePesq.TabIndex = 4;
            this.txtNomePesq.TextChanged += new System.EventHandler(this.txtNomePesq_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Maior que a idade :";
            // 
            // txtPesqIdade
            // 
            this.txtPesqIdade.Location = new System.Drawing.Point(118, 189);
            this.txtPesqIdade.Name = "txtPesqIdade";
            this.txtPesqIdade.Size = new System.Drawing.Size(62, 20);
            this.txtPesqIdade.TabIndex = 2;
            // 
            // btnPesq
            // 
            this.btnPesq.Location = new System.Drawing.Point(202, 186);
            this.btnPesq.Name = "btnPesq";
            this.btnPesq.Size = new System.Drawing.Size(121, 23);
            this.btnPesq.TabIndex = 3;
            this.btnPesq.Text = "Pesquisar idade";
            this.btnPesq.UseVisualStyleBackColor = true;
            this.btnPesq.Click += new System.EventHandler(this.btnPesq_Click);
            // 
            // ListaFrmObjExemplo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 450);
            this.Controls.Add(this.txtNomePesq);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.grdRes);
            this.Controls.Add(this.btnPesq);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.txtPesqIdade);
            this.Controls.Add(this.txtIdade);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ListaFrmObjExemplo";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.grdRes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIdade;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.DataGridView grdRes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNomePesq;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPesqIdade;
        private System.Windows.Forms.Button btnPesq;
    }
}

