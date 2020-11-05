namespace FinanceiroDesktop
{
    partial class frmConsultarConta
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
            this.grdMovimento = new System.Windows.Forms.GroupBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.grdContas = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFinal = new System.Windows.Forms.DateTimePicker();
            this.dtpInicial = new System.Windows.Forms.DateTimePicker();
            this.btnPesquisa = new System.Windows.Forms.Button();
            this.cbContas = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grdMovimento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdContas)).BeginInit();
            this.SuspendLayout();
            // 
            // grdMovimento
            // 
            this.grdMovimento.Controls.Add(this.txtTotal);
            this.grdMovimento.Controls.Add(this.label4);
            this.grdMovimento.Controls.Add(this.grdContas);
            this.grdMovimento.Controls.Add(this.label3);
            this.grdMovimento.Controls.Add(this.label2);
            this.grdMovimento.Controls.Add(this.dtpFinal);
            this.grdMovimento.Controls.Add(this.dtpInicial);
            this.grdMovimento.Controls.Add(this.btnPesquisa);
            this.grdMovimento.Controls.Add(this.cbContas);
            this.grdMovimento.Controls.Add(this.label1);
            this.grdMovimento.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdMovimento.Location = new System.Drawing.Point(12, 12);
            this.grdMovimento.Name = "grdMovimento";
            this.grdMovimento.Size = new System.Drawing.Size(589, 392);
            this.grdMovimento.TabIndex = 1;
            this.grdMovimento.TabStop = false;
            this.grdMovimento.Text = "Consultar Contas";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(534, 359);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(45, 24);
            this.txtTotal.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(483, 362);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Total: ";
            // 
            // grdContas
            // 
            this.grdContas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdContas.Location = new System.Drawing.Point(6, 98);
            this.grdContas.Name = "grdContas";
            this.grdContas.Size = new System.Drawing.Size(573, 255);
            this.grdContas.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(268, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Data Final :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Data Inicial :";
            // 
            // dtpFinal
            // 
            this.dtpFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFinal.Location = new System.Drawing.Point(350, 63);
            this.dtpFinal.Name = "dtpFinal";
            this.dtpFinal.Size = new System.Drawing.Size(90, 24);
            this.dtpFinal.TabIndex = 3;
            // 
            // dtpInicial
            // 
            this.dtpInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInicial.Location = new System.Drawing.Point(155, 63);
            this.dtpInicial.Name = "dtpInicial";
            this.dtpInicial.Size = new System.Drawing.Size(90, 24);
            this.dtpInicial.TabIndex = 3;
            // 
            // btnPesquisa
            // 
            this.btnPesquisa.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnPesquisa.Font = new System.Drawing.Font("Microsoft Tai Le", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisa.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPesquisa.Location = new System.Drawing.Point(452, 34);
            this.btnPesquisa.Name = "btnPesquisa";
            this.btnPesquisa.Size = new System.Drawing.Size(96, 41);
            this.btnPesquisa.TabIndex = 2;
            this.btnPesquisa.Text = "Pesquisa";
            this.btnPesquisa.UseVisualStyleBackColor = false;
            // 
            // cbContas
            // 
            this.cbContas.FormattingEnabled = true;
            this.cbContas.Location = new System.Drawing.Point(150, 34);
            this.cbContas.Name = "cbContas";
            this.cbContas.Size = new System.Drawing.Size(290, 24);
            this.cbContas.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selecione a Empresa :";
            // 
            // frmConsultarConta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 414);
            this.Controls.Add(this.grdMovimento);
            this.Name = "frmConsultarConta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Contas Cadastradas";
            this.grdMovimento.ResumeLayout(false);
            this.grdMovimento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdContas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grdMovimento;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView grdContas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFinal;
        private System.Windows.Forms.DateTimePicker dtpInicial;
        private System.Windows.Forms.Button btnPesquisa;
        private System.Windows.Forms.ComboBox cbContas;
        private System.Windows.Forms.Label label1;
    }
}