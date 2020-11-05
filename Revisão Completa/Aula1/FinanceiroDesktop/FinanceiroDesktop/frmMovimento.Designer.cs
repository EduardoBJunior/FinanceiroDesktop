namespace FinanceiroDesktop
{
    partial class frmMovimento
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
            this.grpMovi = new System.Windows.Forms.GroupBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.dtpFinalPes = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpIniPes = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbTpMovPes = new System.Windows.Forms.ComboBox();
            this.grdLancamento = new System.Windows.Forms.DataGridView();
            this.gbLancamento = new System.Windows.Forms.GroupBox();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.cbConta = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtbObservacao = new System.Windows.Forms.TextBox();
            this.cbEmpresa = new System.Windows.Forms.ComboBox();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.cbTipoLanc = new System.Windows.Forms.ComboBox();
            this.dtpDataLancameto = new System.Windows.Forms.DateTimePicker();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpMovi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdLancamento)).BeginInit();
            this.gbLancamento.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpMovi
            // 
            this.grpMovi.Controls.Add(this.btnPesquisar);
            this.grpMovi.Controls.Add(this.dtpFinalPes);
            this.grpMovi.Controls.Add(this.label10);
            this.grpMovi.Controls.Add(this.dtpIniPes);
            this.grpMovi.Controls.Add(this.label9);
            this.grpMovi.Controls.Add(this.label8);
            this.grpMovi.Controls.Add(this.cbTpMovPes);
            this.grpMovi.Controls.Add(this.grdLancamento);
            this.grpMovi.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpMovi.Location = new System.Drawing.Point(12, 291);
            this.grpMovi.Name = "grpMovi";
            this.grpMovi.Size = new System.Drawing.Size(784, 238);
            this.grpMovi.TabIndex = 1;
            this.grpMovi.TabStop = false;
            this.grpMovi.Text = "Lançamentos";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnPesquisar.Location = new System.Drawing.Point(413, 33);
            this.btnPesquisar.Margin = new System.Windows.Forms.Padding(0);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(99, 43);
            this.btnPesquisar.TabIndex = 12;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // dtpFinalPes
            // 
            this.dtpFinalPes.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFinalPes.Location = new System.Drawing.Point(295, 61);
            this.dtpFinalPes.Name = "dtpFinalPes";
            this.dtpFinalPes.Size = new System.Drawing.Size(107, 24);
            this.dtpFinalPes.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(207, 64);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 18);
            this.label10.TabIndex = 9;
            this.label10.Text = "Data Final  :";
            // 
            // dtpIniPes
            // 
            this.dtpIniPes.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpIniPes.Location = new System.Drawing.Point(95, 61);
            this.dtpIniPes.Name = "dtpIniPes";
            this.dtpIniPes.Size = new System.Drawing.Size(106, 24);
            this.dtpIniPes.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 18);
            this.label9.TabIndex = 7;
            this.label9.Text = "Data Inicial :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 18);
            this.label8.TabIndex = 6;
            this.label8.Text = "Tipo Movimento :";
            // 
            // cbTpMovPes
            // 
            this.cbTpMovPes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTpMovPes.FormattingEnabled = true;
            this.cbTpMovPes.Items.AddRange(new object[] {
            "Entrada",
            "Saída",
            "TODOS"});
            this.cbTpMovPes.Location = new System.Drawing.Point(128, 26);
            this.cbTpMovPes.Name = "cbTpMovPes";
            this.cbTpMovPes.Size = new System.Drawing.Size(274, 24);
            this.cbTpMovPes.TabIndex = 1;
            // 
            // grdLancamento
            // 
            this.grdLancamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdLancamento.Location = new System.Drawing.Point(3, 91);
            this.grdLancamento.Name = "grdLancamento";
            this.grdLancamento.Size = new System.Drawing.Size(761, 141);
            this.grdLancamento.TabIndex = 0;
            this.grdLancamento.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdLancamento_CellClick);
            // 
            // gbLancamento
            // 
            this.gbLancamento.Controls.Add(this.txtCod);
            this.gbLancamento.Controls.Add(this.cbConta);
            this.gbLancamento.Controls.Add(this.label6);
            this.gbLancamento.Controls.Add(this.btnSalvar);
            this.gbLancamento.Controls.Add(this.btnExcluir);
            this.gbLancamento.Controls.Add(this.btnCancelar);
            this.gbLancamento.Controls.Add(this.txtbObservacao);
            this.gbLancamento.Controls.Add(this.cbEmpresa);
            this.gbLancamento.Controls.Add(this.cbCategoria);
            this.gbLancamento.Controls.Add(this.cbTipoLanc);
            this.gbLancamento.Controls.Add(this.dtpDataLancameto);
            this.gbLancamento.Controls.Add(this.txtValor);
            this.gbLancamento.Controls.Add(this.label7);
            this.gbLancamento.Controls.Add(this.label5);
            this.gbLancamento.Controls.Add(this.label4);
            this.gbLancamento.Controls.Add(this.label3);
            this.gbLancamento.Controls.Add(this.label2);
            this.gbLancamento.Controls.Add(this.label1);
            this.gbLancamento.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbLancamento.Location = new System.Drawing.Point(12, 12);
            this.gbLancamento.Name = "gbLancamento";
            this.gbLancamento.Size = new System.Drawing.Size(784, 273);
            this.gbLancamento.TabIndex = 2;
            this.gbLancamento.TabStop = false;
            this.gbLancamento.Text = "Dados para Lançamento";
            this.gbLancamento.Enter += new System.EventHandler(this.gbLancamento_Enter);
            // 
            // txtCod
            // 
            this.txtCod.Location = new System.Drawing.Point(629, 38);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(57, 24);
            this.txtCod.TabIndex = 16;
            // 
            // cbConta
            // 
            this.cbConta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbConta.FormattingEnabled = true;
            this.cbConta.Location = new System.Drawing.Point(139, 125);
            this.cbConta.Name = "cbConta";
            this.cbConta.Size = new System.Drawing.Size(575, 24);
            this.cbConta.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(88, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 18);
            this.label6.TabIndex = 13;
            this.label6.Text = "Conta :";
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSalvar.Location = new System.Drawing.Point(453, 229);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(83, 38);
            this.btnSalvar.TabIndex = 10;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.Red;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExcluir.Location = new System.Drawing.Point(631, 229);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(83, 38);
            this.btnExcluir.TabIndex = 11;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.LimeGreen;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancelar.Location = new System.Drawing.Point(542, 229);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(83, 38);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtbObservacao
            // 
            this.txtbObservacao.Location = new System.Drawing.Point(139, 165);
            this.txtbObservacao.Multiline = true;
            this.txtbObservacao.Name = "txtbObservacao";
            this.txtbObservacao.Size = new System.Drawing.Size(575, 58);
            this.txtbObservacao.TabIndex = 5;
            // 
            // cbEmpresa
            // 
            this.cbEmpresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEmpresa.FormattingEnabled = true;
            this.cbEmpresa.Location = new System.Drawing.Point(139, 92);
            this.cbEmpresa.Name = "cbEmpresa";
            this.cbEmpresa.Size = new System.Drawing.Size(191, 24);
            this.cbEmpresa.TabIndex = 4;
            // 
            // cbCategoria
            // 
            this.cbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(139, 55);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(121, 24);
            this.cbCategoria.TabIndex = 4;
            // 
            // cbTipoLanc
            // 
            this.cbTipoLanc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoLanc.FormattingEnabled = true;
            this.cbTipoLanc.Items.AddRange(new object[] {
            "1 - Entrada",
            "2 -  Saída"});
            this.cbTipoLanc.Location = new System.Drawing.Point(325, 52);
            this.cbTipoLanc.Name = "cbTipoLanc";
            this.cbTipoLanc.Size = new System.Drawing.Size(191, 24);
            this.cbTipoLanc.TabIndex = 3;
         
            // 
            // dtpDataLancameto
            // 
            this.dtpDataLancameto.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataLancameto.Location = new System.Drawing.Point(139, 25);
            this.dtpDataLancameto.Name = "dtpDataLancameto";
            this.dtpDataLancameto.Size = new System.Drawing.Size(121, 24);
            this.dtpDataLancameto.TabIndex = 2;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(395, 95);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(121, 24);
            this.txtValor.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(96, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 18);
            this.label7.TabIndex = 0;
            this.label7.Text = "Obs :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(71, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "Empresa :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Categoria :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(345, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Valor :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(283, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tipo :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data :";
            // 
            // frmMovimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 541);
            this.Controls.Add(this.grpMovi);
            this.Controls.Add(this.gbLancamento);
            this.Name = "frmMovimento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLancamento";
            this.Load += new System.EventHandler(this.frmMovimento_Load);
            this.grpMovi.ResumeLayout(false);
            this.grpMovi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdLancamento)).EndInit();
            this.gbLancamento.ResumeLayout(false);
            this.gbLancamento.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpMovi;
        private System.Windows.Forms.DataGridView grdLancamento;
        private System.Windows.Forms.GroupBox gbLancamento;
        private System.Windows.Forms.TextBox txtbObservacao;
        private System.Windows.Forms.ComboBox cbEmpresa;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.DateTimePicker dtpDataLancameto;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.DateTimePicker dtpFinalPes;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtpIniPes;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbTpMovPes;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox cbConta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbTipoLanc;
        private System.Windows.Forms.TextBox txtCod;
    }
}