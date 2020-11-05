namespace FinanceiroDesktop
{
    partial class frmConta
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
            this.gbGerConta = new System.Windows.Forms.GroupBox();
            this.cbTipoConta = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtbSaldoAtual = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNumeroConta = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbAgencia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbNomeBanco = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbCod = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.grdContaCadastrada = new System.Windows.Forms.DataGridView();
            this.gbGerConta.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdContaCadastrada)).BeginInit();
            this.SuspendLayout();
            // 
            // gbGerConta
            // 
            this.gbGerConta.Controls.Add(this.cbTipoConta);
            this.gbGerConta.Controls.Add(this.label6);
            this.gbGerConta.Controls.Add(this.txtbSaldoAtual);
            this.gbGerConta.Controls.Add(this.label5);
            this.gbGerConta.Controls.Add(this.txtNumeroConta);
            this.gbGerConta.Controls.Add(this.label4);
            this.gbGerConta.Controls.Add(this.txtbAgencia);
            this.gbGerConta.Controls.Add(this.label3);
            this.gbGerConta.Controls.Add(this.txtbNomeBanco);
            this.gbGerConta.Controls.Add(this.label2);
            this.gbGerConta.Controls.Add(this.txtbCod);
            this.gbGerConta.Controls.Add(this.label1);
            this.gbGerConta.Controls.Add(this.btnSalvar);
            this.gbGerConta.Controls.Add(this.btnExcluir);
            this.gbGerConta.Controls.Add(this.btnCancelar);
            this.gbGerConta.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbGerConta.Location = new System.Drawing.Point(0, -1);
            this.gbGerConta.Name = "gbGerConta";
            this.gbGerConta.Size = new System.Drawing.Size(461, 175);
            this.gbGerConta.TabIndex = 0;
            this.gbGerConta.TabStop = false;
            this.gbGerConta.Text = "Gerenciar Conta";
            // 
            // cbTipoConta
            // 
            this.cbTipoConta.FormattingEnabled = true;
            this.cbTipoConta.Items.AddRange(new object[] {
            "Poupança",
            "Corrente"});
            this.cbTipoConta.Location = new System.Drawing.Point(343, 74);
            this.cbTipoConta.Name = "cbTipoConta";
            this.cbTipoConta.Size = new System.Drawing.Size(100, 24);
            this.cbTipoConta.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(286, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "Tipo* :";
            // 
            // txtbSaldoAtual
            // 
            this.txtbSaldoAtual.Location = new System.Drawing.Point(134, 99);
            this.txtbSaldoAtual.Name = "txtbSaldoAtual";
            this.txtbSaldoAtual.Size = new System.Drawing.Size(100, 24);
            this.txtbSaldoAtual.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "Saldo Atual* :";
            // 
            // txtNumeroConta
            // 
            this.txtNumeroConta.Location = new System.Drawing.Point(134, 73);
            this.txtNumeroConta.Name = "txtNumeroConta";
            this.txtNumeroConta.Size = new System.Drawing.Size(132, 24);
            this.txtNumeroConta.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "Numero da Conta* :";
            // 
            // txtbAgencia
            // 
            this.txtbAgencia.Location = new System.Drawing.Point(343, 47);
            this.txtbAgencia.Name = "txtbAgencia";
            this.txtbAgencia.Size = new System.Drawing.Size(100, 24);
            this.txtbAgencia.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(268, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "Agência* :";
            // 
            // txtbNomeBanco
            // 
            this.txtbNomeBanco.Location = new System.Drawing.Point(134, 47);
            this.txtbNomeBanco.Name = "txtbNomeBanco";
            this.txtbNomeBanco.Size = new System.Drawing.Size(132, 24);
            this.txtbNomeBanco.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nome do Banco* :";
            // 
            // txtbCod
            // 
            this.txtbCod.Location = new System.Drawing.Point(134, 21);
            this.txtbCod.Name = "txtbCod";
            this.txtbCod.Size = new System.Drawing.Size(33, 24);
            this.txtbCod.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "Codigo : ";
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSalvar.Location = new System.Drawing.Point(372, 131);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(83, 38);
            this.btnSalvar.TabIndex = 6;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.Red;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExcluir.Location = new System.Drawing.Point(194, 131);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(83, 38);
            this.btnExcluir.TabIndex = 9;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.DarkOrange;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancelar.Location = new System.Drawing.Point(283, 131);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(83, 38);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.grdContaCadastrada);
            this.groupBox2.Location = new System.Drawing.Point(5, 180);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(456, 238);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Contas Cadastradas";
            // 
            // grdContaCadastrada
            // 
            this.grdContaCadastrada.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdContaCadastrada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdContaCadastrada.Location = new System.Drawing.Point(12, 19);
            this.grdContaCadastrada.MultiSelect = false;
            this.grdContaCadastrada.Name = "grdContaCadastrada";
            this.grdContaCadastrada.ReadOnly = true;
            this.grdContaCadastrada.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdContaCadastrada.Size = new System.Drawing.Size(438, 213);
            this.grdContaCadastrada.TabIndex = 0;
            this.grdContaCadastrada.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdContaCadastrada_CellClick);
            // 
            // frmConta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 421);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbGerConta);
            this.Name = "frmConta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciar Conta";
            this.Load += new System.EventHandler(this.frmConta_Load);
            this.gbGerConta.ResumeLayout(false);
            this.gbGerConta.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdContaCadastrada)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbGerConta;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridView grdContaCadastrada;
        private System.Windows.Forms.ComboBox cbTipoConta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtbSaldoAtual;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNumeroConta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbAgencia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbNomeBanco;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbCod;
        private System.Windows.Forms.Label label1;
    }
}