namespace ListasGenericas
{
    partial class frmEntradaSaida
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
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxTipo = new System.Windows.Forms.ComboBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ltbxMes = new System.Windows.Forms.ListBox();
            this.ltbxEntrada = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbTGeral = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbxMes = new System.Windows.Forms.ComboBox();
            this.lbxTotalMes = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ltbxSaida = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(230, 63);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionar.TabIndex = 3;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Selecione o Tipo:";
            // 
            // cbxTipo
            // 
            this.cbxTipo.AutoCompleteCustomSource.AddRange(new string[] {
            "Entrada",
            "Saida"});
            this.cbxTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTipo.FormattingEnabled = true;
            this.cbxTipo.Items.AddRange(new object[] {
            "Entrada",
            "Saida"});
            this.cbxTipo.Location = new System.Drawing.Point(124, 35);
            this.cbxTipo.Name = "cbxTipo";
            this.cbxTipo.Size = new System.Drawing.Size(100, 21);
            this.cbxTipo.TabIndex = 1;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(124, 64);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 20);
            this.txtValor.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Valor :";
            // 
            // ltbxMes
            // 
            this.ltbxMes.FormattingEnabled = true;
            this.ltbxMes.Location = new System.Drawing.Point(12, 150);
            this.ltbxMes.Name = "ltbxMes";
            this.ltbxMes.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.ltbxMes.Size = new System.Drawing.Size(120, 95);
            this.ltbxMes.TabIndex = 4;
            // 
            // ltbxEntrada
            // 
            this.ltbxEntrada.FormattingEnabled = true;
            this.ltbxEntrada.Location = new System.Drawing.Point(152, 150);
            this.ltbxEntrada.Name = "ltbxEntrada";
            this.ltbxEntrada.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.ltbxEntrada.Size = new System.Drawing.Size(120, 95);
            this.ltbxEntrada.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mes";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(143, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Entrada";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(291, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Saida";
            // 
            // lbTGeral
            // 
            this.lbTGeral.AutoSize = true;
            this.lbTGeral.Location = new System.Drawing.Point(462, 265);
            this.lbTGeral.Name = "lbTGeral";
            this.lbTGeral.Size = new System.Drawing.Size(94, 13);
            this.lbTGeral.TabIndex = 6;
            this.lbTGeral.Text = "O Valor Geral é : 0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Selecione o Mes:";
            // 
            // cbxMes
            // 
            this.cbxMes.AutoCompleteCustomSource.AddRange(new string[] {
            "Entrada",
            "Saida"});
            this.cbxMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMes.FormattingEnabled = true;
            this.cbxMes.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbxMes.Items.AddRange(new object[] {
            "Janeiro",
            "Fevereiro",
            "Março",
            "Abril",
            "Maio",
            "Junho",
            "Julho",
            "Agosto",
            "Setembro",
            "Outubro",
            "Novembro",
            "Dezembro"});
            this.cbxMes.Location = new System.Drawing.Point(124, 5);
            this.cbxMes.Name = "cbxMes";
            this.cbxMes.Size = new System.Drawing.Size(100, 21);
            this.cbxMes.TabIndex = 0;
            // 
            // lbxTotalMes
            // 
            this.lbxTotalMes.FormattingEnabled = true;
            this.lbxTotalMes.Location = new System.Drawing.Point(436, 150);
            this.lbxTotalMes.Name = "lbxTotalMes";
            this.lbxTotalMes.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lbxTotalMes.Size = new System.Drawing.Size(120, 95);
            this.lbxTotalMes.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(433, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Total Mes";
            // 
            // ltbxSaida
            // 
            this.ltbxSaida.FormattingEnabled = true;
            this.ltbxSaida.Location = new System.Drawing.Point(294, 150);
            this.ltbxSaida.Name = "ltbxSaida";
            this.ltbxSaida.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.ltbxSaida.Size = new System.Drawing.Size(120, 95);
            this.ltbxSaida.TabIndex = 4;
            // 
            // frmEntradaSaida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 287);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbxTotalMes);
            this.Controls.Add(this.lbTGeral);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ltbxSaida);
            this.Controls.Add(this.ltbxEntrada);
            this.Controls.Add(this.ltbxMes);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.cbxMes);
            this.Controls.Add(this.cbxTipo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdicionar);
            this.Name = "frmEntradaSaida";
            this.Text = "frmEntradaSaida";
           
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxTipo;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox ltbxMes;
        private System.Windows.Forms.ListBox ltbxEntrada;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbTGeral;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbxMes;
        private System.Windows.Forms.ListBox lbxTotalMes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox ltbxSaida;
    }
}