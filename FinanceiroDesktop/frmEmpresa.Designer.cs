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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtb_nomeEmpresa = new System.Windows.Forms.TextBox();
            this.txtb_telefone = new System.Windows.Forms.MaskedTextBox();
            this.txtb_endereco = new System.Windows.Forms.TextBox();
            this.txtb_site = new System.Windows.Forms.TextBox();
            this.txtb_codigo = new System.Windows.Forms.TextBox();
            this.btn_Excluir = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.DGV_Empresas = new System.Windows.Forms.DataGridView();
            this.gb_gerEmpresa.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Empresas)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_gerEmpresa
            // 
            this.gb_gerEmpresa.Controls.Add(this.txtb_codigo);
            this.gb_gerEmpresa.Controls.Add(this.btn_Excluir);
            this.gb_gerEmpresa.Controls.Add(this.btn_cancelar);
            this.gb_gerEmpresa.Controls.Add(this.btn_salvar);
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
            // txtb_nomeEmpresa
            // 
            this.txtb_nomeEmpresa.Location = new System.Drawing.Point(84, 48);
            this.txtb_nomeEmpresa.Name = "txtb_nomeEmpresa";
            this.txtb_nomeEmpresa.Size = new System.Drawing.Size(270, 24);
            this.txtb_nomeEmpresa.TabIndex = 1;
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
            // txtb_endereco
            // 
            this.txtb_endereco.Location = new System.Drawing.Point(83, 116);
            this.txtb_endereco.Name = "txtb_endereco";
            this.txtb_endereco.Size = new System.Drawing.Size(270, 24);
            this.txtb_endereco.TabIndex = 1;
            // 
            // txtb_site
            // 
            this.txtb_site.Location = new System.Drawing.Point(83, 150);
            this.txtb_site.Name = "txtb_site";
            this.txtb_site.Size = new System.Drawing.Size(270, 24);
            this.txtb_site.TabIndex = 1;
            // 
            // txtb_codigo
            // 
            this.txtb_codigo.Location = new System.Drawing.Point(84, 18);
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
            this.btn_Excluir.Location = new System.Drawing.Point(120, 177);
            this.btn_Excluir.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Excluir.Name = "btn_Excluir";
            this.btn_Excluir.Size = new System.Drawing.Size(101, 42);
            this.btn_Excluir.TabIndex = 11;
            this.btn_Excluir.Text = "Excluir";
            this.btn_Excluir.UseVisualStyleBackColor = false;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_cancelar.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btn_cancelar.Location = new System.Drawing.Point(232, 177);
            this.btn_cancelar.Margin = new System.Windows.Forms.Padding(0);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(101, 42);
            this.btn_cancelar.TabIndex = 10;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = false;
            // 
            // btn_salvar
            // 
            this.btn_salvar.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_salvar.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salvar.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btn_salvar.Location = new System.Drawing.Point(344, 177);
            this.btn_salvar.Margin = new System.Windows.Forms.Padding(0);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(101, 42);
            this.btn_salvar.TabIndex = 9;
            this.btn_salvar.Text = "Salvar";
            this.btn_salvar.UseVisualStyleBackColor = false;
            // 
            // DGV_Empresas
            // 
            this.DGV_Empresas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Empresas.Location = new System.Drawing.Point(0, 23);
            this.DGV_Empresas.Name = "DGV_Empresas";
            this.DGV_Empresas.Size = new System.Drawing.Size(453, 263);
            this.DGV_Empresas.TabIndex = 0;
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
        private System.Windows.Forms.Button btn_Excluir;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.DataGridView DGV_Empresas;
    }
}