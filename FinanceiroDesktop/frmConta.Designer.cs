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
            this.gb_CadConta = new System.Windows.Forms.GroupBox();
            this.cb_tipoConta = new System.Windows.Forms.ComboBox();
            this.txtb_codigo = new System.Windows.Forms.TextBox();
            this.btn_Excluir = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.txtb_Saldo = new System.Windows.Forms.TextBox();
            this.txtb_numConta = new System.Windows.Forms.TextBox();
            this.txtb_agencia = new System.Windows.Forms.TextBox();
            this.txtb_nomeBanco = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DGV_contas = new System.Windows.Forms.DataGridView();
            this.gb_CadConta.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_contas)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_CadConta
            // 
            this.gb_CadConta.Controls.Add(this.cb_tipoConta);
            this.gb_CadConta.Controls.Add(this.txtb_codigo);
            this.gb_CadConta.Controls.Add(this.btn_Excluir);
            this.gb_CadConta.Controls.Add(this.btn_cancelar);
            this.gb_CadConta.Controls.Add(this.btn_salvar);
            this.gb_CadConta.Controls.Add(this.txtb_Saldo);
            this.gb_CadConta.Controls.Add(this.txtb_numConta);
            this.gb_CadConta.Controls.Add(this.txtb_agencia);
            this.gb_CadConta.Controls.Add(this.txtb_nomeBanco);
            this.gb_CadConta.Controls.Add(this.label5);
            this.gb_CadConta.Controls.Add(this.label4);
            this.gb_CadConta.Controls.Add(this.label3);
            this.gb_CadConta.Controls.Add(this.label2);
            this.gb_CadConta.Controls.Add(this.label1);
            this.gb_CadConta.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_CadConta.Location = new System.Drawing.Point(3, 6);
            this.gb_CadConta.Name = "gb_CadConta";
            this.gb_CadConta.Size = new System.Drawing.Size(453, 216);
            this.gb_CadConta.TabIndex = 1;
            this.gb_CadConta.TabStop = false;
            this.gb_CadConta.Text = "Conta";
            // 
            // cb_tipoConta
            // 
            this.cb_tipoConta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_tipoConta.FormattingEnabled = true;
            this.cb_tipoConta.Items.AddRange(new object[] {
            "Poupança",
            "Corrente",
            "Salário"});
            this.cb_tipoConta.Location = new System.Drawing.Point(350, 108);
            this.cb_tipoConta.Name = "cb_tipoConta";
            this.cb_tipoConta.Size = new System.Drawing.Size(83, 24);
            this.cb_tipoConta.TabIndex = 3;
            // 
            // txtb_codigo
            // 
            this.txtb_codigo.Location = new System.Drawing.Point(120, 15);
            this.txtb_codigo.Name = "txtb_codigo";
            this.txtb_codigo.Size = new System.Drawing.Size(52, 24);
            this.txtb_codigo.TabIndex = 12;
            this.txtb_codigo.Visible = false;
            // 
            // btn_Excluir
            // 
            this.btn_Excluir.BackColor = System.Drawing.Color.Crimson;
            this.btn_Excluir.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Excluir.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btn_Excluir.Location = new System.Drawing.Point(108, 155);
            this.btn_Excluir.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Excluir.Name = "btn_Excluir";
            this.btn_Excluir.Size = new System.Drawing.Size(101, 42);
            this.btn_Excluir.TabIndex = 11;
            this.btn_Excluir.Text = "Excluir";
            this.btn_Excluir.UseVisualStyleBackColor = false;
            this.btn_Excluir.Click += new System.EventHandler(this.btn_Excluir_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_cancelar.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btn_cancelar.Location = new System.Drawing.Point(220, 155);
            this.btn_cancelar.Margin = new System.Windows.Forms.Padding(0);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(101, 42);
            this.btn_cancelar.TabIndex = 10;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_salvar
            // 
            this.btn_salvar.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_salvar.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salvar.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btn_salvar.Location = new System.Drawing.Point(332, 155);
            this.btn_salvar.Margin = new System.Windows.Forms.Padding(0);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(101, 42);
            this.btn_salvar.TabIndex = 9;
            this.btn_salvar.Text = "Salvar";
            this.btn_salvar.UseVisualStyleBackColor = false;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // txtb_Saldo
            // 
            this.txtb_Saldo.Location = new System.Drawing.Point(120, 111);
            this.txtb_Saldo.Name = "txtb_Saldo";
            this.txtb_Saldo.Size = new System.Drawing.Size(93, 24);
            this.txtb_Saldo.TabIndex = 2;
            // 
            // txtb_numConta
            // 
            this.txtb_numConta.Location = new System.Drawing.Point(350, 78);
            this.txtb_numConta.Name = "txtb_numConta";
            this.txtb_numConta.Size = new System.Drawing.Size(83, 24);
            this.txtb_numConta.TabIndex = 1;
            // 
            // txtb_agencia
            // 
            this.txtb_agencia.Location = new System.Drawing.Point(120, 78);
            this.txtb_agencia.Name = "txtb_agencia";
            this.txtb_agencia.Size = new System.Drawing.Size(93, 24);
            this.txtb_agencia.TabIndex = 0;
            // 
            // txtb_nomeBanco
            // 
            this.txtb_nomeBanco.Location = new System.Drawing.Point(120, 45);
            this.txtb_nomeBanco.Name = "txtb_nomeBanco";
            this.txtb_nomeBanco.Size = new System.Drawing.Size(313, 24);
            this.txtb_nomeBanco.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "Saldo* :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(219, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Numero da Conta* :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(239, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tipo da Conta* : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Agência* :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome do Banco* :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DGV_contas);
            this.groupBox1.Location = new System.Drawing.Point(3, 228);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(453, 250);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Contas Cadastradas";
            // 
            // DGV_contas
            // 
            this.DGV_contas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_contas.Location = new System.Drawing.Point(0, 19);
            this.DGV_contas.Name = "DGV_contas";
            this.DGV_contas.Size = new System.Drawing.Size(453, 225);
            this.DGV_contas.TabIndex = 0;
            // 
            // frmConta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 484);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gb_CadConta);
            this.Name = "frmConta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmConta";
            this.Load += new System.EventHandler(this.frmConta_Load);
            this.gb_CadConta.ResumeLayout(false);
            this.gb_CadConta.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_contas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_CadConta;
        private System.Windows.Forms.TextBox txtb_codigo;
        private System.Windows.Forms.Button btn_Excluir;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.TextBox txtb_agencia;
        private System.Windows.Forms.TextBox txtb_nomeBanco;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_tipoConta;
        private System.Windows.Forms.TextBox txtb_Saldo;
        private System.Windows.Forms.TextBox txtb_numConta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView DGV_contas;
    }
}