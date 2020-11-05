namespace FinanceiroDesktop
{
    partial class frmConsultarMovimentoEmpresa
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DGV_contas = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_pesquisar = new System.Windows.Forms.Button();
            this.dtp_final = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.dtp_inicial = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_contas)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.DGV_contas);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.btn_pesquisar);
            this.groupBox2.Controls.Add(this.dtp_final);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.dtp_inicial);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(627, 426);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Contas Cadastradas";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(585, 377);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(36, 24);
            this.textBox1.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(519, 380);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 18);
            this.label1.TabIndex = 12;
            this.label1.Text = "TOTAL :";
            // 
            // DGV_contas
            // 
            this.DGV_contas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_contas.Location = new System.Drawing.Point(9, 105);
            this.DGV_contas.Name = "DGV_contas";
            this.DGV_contas.Size = new System.Drawing.Size(612, 266);
            this.DGV_contas.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Entrada",
            "Saída",
            "TODOS"});
            this.comboBox1.Location = new System.Drawing.Point(150, 26);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(328, 24);
            this.comboBox1.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(138, 18);
            this.label8.TabIndex = 0;
            this.label8.Text = "Selecione a Empresa :";
            // 
            // btn_pesquisar
            // 
            this.btn_pesquisar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_pesquisar.Font = new System.Drawing.Font("Microsoft Tai Le", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pesquisar.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btn_pesquisar.Location = new System.Drawing.Point(493, 17);
            this.btn_pesquisar.Margin = new System.Windows.Forms.Padding(0);
            this.btn_pesquisar.Name = "btn_pesquisar";
            this.btn_pesquisar.Size = new System.Drawing.Size(131, 60);
            this.btn_pesquisar.TabIndex = 11;
            this.btn_pesquisar.Text = "Pesquisar";
            this.btn_pesquisar.UseVisualStyleBackColor = false;
            // 
            // dtp_final
            // 
            this.dtp_final.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_final.Location = new System.Drawing.Point(365, 56);
            this.dtp_final.Name = "dtp_final";
            this.dtp_final.Size = new System.Drawing.Size(113, 24);
            this.dtp_final.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(283, 59);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 18);
            this.label10.TabIndex = 0;
            this.label10.Text = "Data Final :";
            // 
            // dtp_inicial
            // 
            this.dtp_inicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_inicial.Location = new System.Drawing.Point(151, 56);
            this.dtp_inicial.Name = "dtp_inicial";
            this.dtp_inicial.Size = new System.Drawing.Size(113, 24);
            this.dtp_inicial.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(62, 59);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 18);
            this.label9.TabIndex = 0;
            this.label9.Text = "Data Inicial :";
            // 
            // frmConsultarMovimentoEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 443);
            this.Controls.Add(this.groupBox2);
            this.Name = "frmConsultarMovimentoEmpresa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Movimento Empresa";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_contas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView DGV_contas;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_pesquisar;
        private System.Windows.Forms.DateTimePicker dtp_final;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtp_inicial;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}