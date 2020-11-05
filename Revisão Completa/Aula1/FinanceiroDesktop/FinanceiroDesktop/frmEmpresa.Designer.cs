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
            this.gboxEmpresa = new System.Windows.Forms.GroupBox();
            this.txtMaskTelefone = new System.Windows.Forms.MaskedTextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSite = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbEndereco = new System.Windows.Forms.TextBox();
            this.txtbNome = new System.Windows.Forms.TextBox();
            this.txtbCod = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grdEmpresaCadastrada = new System.Windows.Forms.DataGridView();
            this.gboxEmpresa.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdEmpresaCadastrada)).BeginInit();
            this.SuspendLayout();
            // 
            // gboxEmpresa
            // 
            this.gboxEmpresa.Controls.Add(this.txtMaskTelefone);
            this.gboxEmpresa.Controls.Add(this.btnSalvar);
            this.gboxEmpresa.Controls.Add(this.btnExcluir);
            this.gboxEmpresa.Controls.Add(this.btnCancelar);
            this.gboxEmpresa.Controls.Add(this.label5);
            this.gboxEmpresa.Controls.Add(this.label4);
            this.gboxEmpresa.Controls.Add(this.label3);
            this.gboxEmpresa.Controls.Add(this.label2);
            this.gboxEmpresa.Controls.Add(this.txtSite);
            this.gboxEmpresa.Controls.Add(this.label1);
            this.gboxEmpresa.Controls.Add(this.txtbEndereco);
            this.gboxEmpresa.Controls.Add(this.txtbNome);
            this.gboxEmpresa.Controls.Add(this.txtbCod);
            this.gboxEmpresa.Location = new System.Drawing.Point(0, 0);
            this.gboxEmpresa.Name = "gboxEmpresa";
            this.gboxEmpresa.Size = new System.Drawing.Size(396, 202);
            this.gboxEmpresa.TabIndex = 0;
            this.gboxEmpresa.TabStop = false;
            this.gboxEmpresa.Text = "Gerenciar Empresas";
            // 
            // txtMaskTelefone
            // 
            this.txtMaskTelefone.Location = new System.Drawing.Point(69, 77);
            this.txtMaskTelefone.Mask = "(99) 0 0000-0000";
            this.txtMaskTelefone.Name = "txtMaskTelefone";
            this.txtMaskTelefone.Size = new System.Drawing.Size(143, 20);
            this.txtMaskTelefone.TabIndex = 2;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSalvar.Location = new System.Drawing.Point(307, 158);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(83, 38);
            this.btnSalvar.TabIndex = 5;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.Red;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExcluir.Location = new System.Drawing.Point(129, 158);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(83, 38);
            this.btnExcluir.TabIndex = 7;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.LimeGreen;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancelar.Location = new System.Drawing.Point(214, 158);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(83, 38);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Site :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Endereço :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Telefone :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome :";
            // 
            // txtSite
            // 
            this.txtSite.Location = new System.Drawing.Point(69, 126);
            this.txtSite.Name = "txtSite";
            this.txtSite.Size = new System.Drawing.Size(142, 20);
            this.txtSite.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Codigo :";
            this.label1.Visible = false;
            // 
            // txtbEndereco
            // 
            this.txtbEndereco.Location = new System.Drawing.Point(69, 101);
            this.txtbEndereco.Name = "txtbEndereco";
            this.txtbEndereco.Size = new System.Drawing.Size(142, 20);
            this.txtbEndereco.TabIndex = 3;
            // 
            // txtbNome
            // 
            this.txtbNome.Location = new System.Drawing.Point(69, 51);
            this.txtbNome.Name = "txtbNome";
            this.txtbNome.Size = new System.Drawing.Size(142, 20);
            this.txtbNome.TabIndex = 1;
            // 
            // txtbCod
            // 
            this.txtbCod.Location = new System.Drawing.Point(69, 26);
            this.txtbCod.Name = "txtbCod";
            this.txtbCod.Size = new System.Drawing.Size(37, 20);
            this.txtbCod.TabIndex = 0;
            this.txtbCod.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grdEmpresaCadastrada);
            this.groupBox1.Location = new System.Drawing.Point(0, 209);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(396, 236);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Empresas Cadastradas";
            // 
            // grdEmpresaCadastrada
            // 
            this.grdEmpresaCadastrada.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdEmpresaCadastrada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdEmpresaCadastrada.Location = new System.Drawing.Point(3, 16);
            this.grdEmpresaCadastrada.MultiSelect = false;
            this.grdEmpresaCadastrada.Name = "grdEmpresaCadastrada";
            this.grdEmpresaCadastrada.ReadOnly = true;
            this.grdEmpresaCadastrada.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdEmpresaCadastrada.Size = new System.Drawing.Size(383, 209);
            this.grdEmpresaCadastrada.TabIndex = 0;
            this.grdEmpresaCadastrada.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdEmpresaCadastrada_CellClick);
            this.grdEmpresaCadastrada.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdEmpresaCadastrada_CellContentClick);
            // 
            // frmEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 446);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gboxEmpresa);
            this.Name = "frmEmpresa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciar Empresas";
            this.Load += new System.EventHandler(this.frmEmpresa_Load);
            this.gboxEmpresa.ResumeLayout(false);
            this.gboxEmpresa.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdEmpresaCadastrada)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gboxEmpresa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbEndereco;
        private System.Windows.Forms.TextBox txtbNome;
        private System.Windows.Forms.TextBox txtbCod;
        private System.Windows.Forms.MaskedTextBox txtMaskTelefone;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSite;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView grdEmpresaCadastrada;
    }
}