namespace FinanceiroDesktop
{
    partial class frmEmpresa
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
            this.gb_gerEmpresa = new System.Windows.Forms.GroupBox();
            this.txtb_codigo = new System.Windows.Forms.TextBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtb_site = new System.Windows.Forms.TextBox();
            this.txtb_endereco = new System.Windows.Forms.TextBox();
            this.txtb_telefone = new System.Windows.Forms.MaskedTextBox();
            this.txtb_nomeEmpresa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DGV_Empresas = new System.Windows.Forms.DataGridView();
            this.gb_gerEmpresa.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Empresas)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_gerEmpresa
            // 
            this.gb_gerEmpresa.Controls.Add(this.txtb_codigo);
            this.gb_gerEmpresa.Controls.Add(this.btnExcluir);
            this.gb_gerEmpresa.Controls.Add(this.btnCancelar);
            this.gb_gerEmpresa.Controls.Add(this.btnSalvar);
            this.gb_gerEmpresa.Controls.Add(this.txtb_site);
            this.gb_gerEmpresa.Controls.Add(this.txtb_endereco);
            this.gb_gerEmpresa.Controls.Add(this.txtb_telefone);
            this.gb_gerEmpresa.Controls.Add(this.txtb_nomeEmpresa);
            this.gb_gerEmpresa.Controls.Add(this.label4);
            this.gb_gerEmpresa.Controls.Add(this.label3);
            this.gb_gerEmpresa.Controls.Add(this.label2);
            this.gb_gerEmpresa.Controls.Add(this.label1);
            this.gb_gerEmpresa.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_gerEmpresa.Location = new System.Drawing.Point(0, 3);
            this.gb_gerEmpresa.Name = "gb_gerEmpresa";
            this.gb_gerEmpresa.Size = new System.Drawing.Size(453, 227);
            this.gb_gerEmpresa.TabIndex = 0;
            this.gb_gerEmpresa.TabStop = false;
            this.gb_gerEmpresa.Text = "Gerenciar Empresa";
            // 
            // txtb_codigo
            // 
            this.txtb_codigo.Location = new System.Drawing.Point(84, 18);
            this.txtb_codigo.Name = "txtb_codigo";
            this.txtb_codigo.Size = new System.Drawing.Size(52, 24);
            this.txtb_codigo.TabIndex = 12;
            this.txtb_codigo.Visible = false;
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.Crimson;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnExcluir.Location = new System.Drawing.Point(120, 177);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(0);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(101, 42);
            this.btnExcluir.TabIndex = 11;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.DarkOrange;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnCancelar.Location = new System.Drawing.Point(232, 177);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(0);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(101, 42);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.LimeGreen;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnSalvar.Location = new System.Drawing.Point(344, 177);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(0);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(101, 42);
            this.btnSalvar.TabIndex = 9;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtb_site
            // 
            this.txtb_site.Location = new System.Drawing.Point(83, 150);
            this.txtb_site.Name = "txtb_site";
            this.txtb_site.Size = new System.Drawing.Size(270, 24);
            this.txtb_site.TabIndex = 1;
            // 
            // txtb_endereco
            // 
            this.txtb_endereco.Location = new System.Drawing.Point(83, 116);
            this.txtb_endereco.Name = "txtb_endereco";
            this.txtb_endereco.Size = new System.Drawing.Size(270, 24);
            this.txtb_endereco.TabIndex = 1;
            // 
            // txtb_telefone
            // 
            this.txtb_telefone.Location = new System.Drawing.Point(83, 82);
            this.txtb_telefone.Mask = "(99) 000000000";
            this.txtb_telefone.Name = "txtb_telefone";
            this.txtb_telefone.Size = new System.Drawing.Size(97, 24);
            this.txtb_telefone.TabIndex = 2;
            this.txtb_telefone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // txtb_nomeEmpresa
            // 
            this.txtb_nomeEmpresa.Location = new System.Drawing.Point(84, 48);
            this.txtb_nomeEmpresa.Name = "txtb_nomeEmpresa";
            this.txtb_nomeEmpresa.Size = new System.Drawing.Size(270, 24);
            this.txtb_nomeEmpresa.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Site :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Endereço: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Telefone :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DGV_Empresas);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 236);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(453, 286);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Empresas Cadastradas";
            // 
            // DGV_Empresas
            // 
            this.DGV_Empresas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Empresas.Location = new System.Drawing.Point(0, 23);
            this.DGV_Empresas.Name = "DGV_Empresas";
            this.DGV_Empresas.Size = new System.Drawing.Size(453, 263);
            this.DGV_Empresas.TabIndex = 0;
            this.DGV_Empresas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Empresas_CellContentClick);
            // 
            // frmEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 523);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gb_gerEmpresa);
            this.MinimizeBox = false;
            this.Name = "frmEmpresa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciar Empresa";
            this.Load += new System.EventHandler(this.frmEmpresa_Load);
            this.gb_gerEmpresa.ResumeLayout(false);
            this.gb_gerEmpresa.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Empresas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_gerEmpresa;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtb_site;
        private System.Windows.Forms.TextBox txtb_endereco;
        private System.Windows.Forms.MaskedTextBox txtb_telefone;
        private System.Windows.Forms.TextBox txtb_nomeEmpresa;
        private System.Windows.Forms.TextBox txtb_codigo;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.DataGridView DGV_Empresas;
    }
}