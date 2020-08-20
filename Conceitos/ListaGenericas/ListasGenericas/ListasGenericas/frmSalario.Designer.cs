namespace ListasGenericas
{
    partial class frmSalario
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
            this.lstboxSalrio = new System.Windows.Forms.ListBox();
            this.lstboxFiltro = new System.Windows.Forms.ListBox();
            this.txtAumento = new System.Windows.Forms.TextBox();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPes = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnSep = new System.Windows.Forms.Button();
            this.rdMaior = new System.Windows.Forms.RadioButton();
            this.rdMenor = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lstboxSalrio
            // 
            this.lstboxSalrio.FormattingEnabled = true;
            this.lstboxSalrio.Location = new System.Drawing.Point(54, 105);
            this.lstboxSalrio.Name = "lstboxSalrio";
            this.lstboxSalrio.Size = new System.Drawing.Size(152, 95);
            this.lstboxSalrio.TabIndex = 0;
            // 
            // lstboxFiltro
            // 
            this.lstboxFiltro.FormattingEnabled = true;
            this.lstboxFiltro.Location = new System.Drawing.Point(394, 14);
            this.lstboxFiltro.Name = "lstboxFiltro";
            this.lstboxFiltro.Size = new System.Drawing.Size(120, 186);
            this.lstboxFiltro.TabIndex = 1;
            // 
            // txtAumento
            // 
            this.txtAumento.Location = new System.Drawing.Point(106, 48);
            this.txtAumento.Name = "txtAumento";
            this.txtAumento.Size = new System.Drawing.Size(100, 20);
            this.txtAumento.TabIndex = 2;
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(106, 22);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(100, 20);
            this.txtSalario.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Salário";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Aumento";
            // 
            // txtPes
            // 
            this.txtPes.Location = new System.Drawing.Point(250, 41);
            this.txtPes.Name = "txtPes";
            this.txtPes.Size = new System.Drawing.Size(122, 20);
            this.txtPes.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(247, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Pesquise";
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(131, 74);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionar.TabIndex = 6;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnSep
            // 
            this.btnSep.Location = new System.Drawing.Point(260, 97);
            this.btnSep.Name = "btnSep";
            this.btnSep.Size = new System.Drawing.Size(75, 23);
            this.btnSep.TabIndex = 7;
            this.btnSep.Text = "Separar";
            this.btnSep.UseVisualStyleBackColor = true;
            this.btnSep.Click += new System.EventHandler(this.btnSep_Click);
            // 
            // rdMaior
            // 
            this.rdMaior.AutoSize = true;
            this.rdMaior.Location = new System.Drawing.Point(260, 67);
            this.rdMaior.Name = "rdMaior";
            this.rdMaior.Size = new System.Drawing.Size(51, 17);
            this.rdMaior.TabIndex = 8;
            this.rdMaior.TabStop = true;
            this.rdMaior.Text = "Maior";
            this.rdMaior.UseVisualStyleBackColor = true;
            // 
            // rdMenor
            // 
            this.rdMenor.AutoSize = true;
            this.rdMenor.Location = new System.Drawing.Point(317, 67);
            this.rdMenor.Name = "rdMenor";
            this.rdMenor.Size = new System.Drawing.Size(55, 17);
            this.rdMenor.TabIndex = 9;
            this.rdMenor.TabStop = true;
            this.rdMenor.Text = "Menor";
            this.rdMenor.UseVisualStyleBackColor = true;
            // 
            // frmSalario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 290);
            this.Controls.Add(this.rdMenor);
            this.Controls.Add(this.rdMaior);
            this.Controls.Add(this.btnSep);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPes);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.txtAumento);
            this.Controls.Add(this.lstboxFiltro);
            this.Controls.Add(this.lstboxSalrio);
            this.Name = "frmSalario";
            this.Text = "frmSalario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstboxSalrio;
        private System.Windows.Forms.ListBox lstboxFiltro;
        private System.Windows.Forms.TextBox txtAumento;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnSep;
        private System.Windows.Forms.RadioButton rdMaior;
        private System.Windows.Forms.RadioButton rdMenor;
    }
}