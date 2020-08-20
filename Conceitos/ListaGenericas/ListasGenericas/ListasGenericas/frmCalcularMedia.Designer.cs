namespace ListasGenericas
{
    partial class frmCalcularMedia
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
            this.txtn1 = new System.Windows.Forms.TextBox();
            this.txtn2 = new System.Windows.Forms.TextBox();
            this.txtn3 = new System.Windows.Forms.TextBox();
            this.txtn4 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.lboxMedias = new System.Windows.Forms.ListBox();
            this.lblRep = new System.Windows.Forms.Label();
            this.txtRep = new System.Windows.Forms.TextBox();
            this.lbExam = new System.Windows.Forms.Label();
            this.txtExam = new System.Windows.Forms.TextBox();
            this.lblAprov = new System.Windows.Forms.Label();
            this.txtAprov = new System.Windows.Forms.TextBox();
            this.btnVer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtn1
            // 
            this.txtn1.Location = new System.Drawing.Point(76, 59);
            this.txtn1.Name = "txtn1";
            this.txtn1.Size = new System.Drawing.Size(100, 20);
            this.txtn1.TabIndex = 0;
            // 
            // txtn2
            // 
            this.txtn2.Location = new System.Drawing.Point(76, 105);
            this.txtn2.Name = "txtn2";
            this.txtn2.Size = new System.Drawing.Size(100, 20);
            this.txtn2.TabIndex = 0;
            // 
            // txtn3
            // 
            this.txtn3.Location = new System.Drawing.Point(199, 58);
            this.txtn3.Name = "txtn3";
            this.txtn3.Size = new System.Drawing.Size(100, 20);
            this.txtn3.TabIndex = 0;
            // 
            // txtn4
            // 
            this.txtn4.Location = new System.Drawing.Point(199, 105);
            this.txtn4.Name = "txtn4";
            this.txtn4.Size = new System.Drawing.Size(100, 20);
            this.txtn4.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nota 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nota 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(196, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nota 3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(196, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Nota 4";
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(322, 34);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(96, 42);
            this.btnAdicionar.TabIndex = 3;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // lboxMedias
            // 
            this.lboxMedias.FormattingEnabled = true;
            this.lboxMedias.Location = new System.Drawing.Point(76, 168);
            this.lboxMedias.Name = "lboxMedias";
            this.lboxMedias.Size = new System.Drawing.Size(120, 95);
            this.lboxMedias.TabIndex = 4;
            // 
            // lblRep
            // 
            this.lblRep.AutoSize = true;
            this.lblRep.Location = new System.Drawing.Point(327, 193);
            this.lblRep.Name = "lblRep";
            this.lblRep.Size = new System.Drawing.Size(98, 13);
            this.lblRep.TabIndex = 5;
            this.lblRep.Text = "Total Reprovados :";
            this.lblRep.Visible = false;
            // 
            // txtRep
            // 
            this.txtRep.Location = new System.Drawing.Point(432, 193);
            this.txtRep.Name = "txtRep";
            this.txtRep.Size = new System.Drawing.Size(59, 20);
            this.txtRep.TabIndex = 6;
            this.txtRep.Visible = false;
            // 
            // lbExam
            // 
            this.lbExam.AutoSize = true;
            this.lbExam.Location = new System.Drawing.Point(327, 219);
            this.lbExam.Name = "lbExam";
            this.lbExam.Size = new System.Drawing.Size(77, 13);
            this.lbExam.TabIndex = 5;
            this.lbExam.Text = "Total Exames :";
            this.lbExam.Visible = false;
            // 
            // txtExam
            // 
            this.txtExam.Location = new System.Drawing.Point(432, 219);
            this.txtExam.Name = "txtExam";
            this.txtExam.Size = new System.Drawing.Size(59, 20);
            this.txtExam.TabIndex = 6;
            this.txtExam.Visible = false;
            // 
            // lblAprov
            // 
            this.lblAprov.AutoSize = true;
            this.lblAprov.Location = new System.Drawing.Point(327, 245);
            this.lblAprov.Name = "lblAprov";
            this.lblAprov.Size = new System.Drawing.Size(91, 13);
            this.lblAprov.TabIndex = 5;
            this.lblAprov.Text = "Total Aprovados :";
            this.lblAprov.Visible = false;
            // 
            // txtAprov
            // 
            this.txtAprov.Location = new System.Drawing.Point(432, 245);
            this.txtAprov.Name = "txtAprov";
            this.txtAprov.Size = new System.Drawing.Size(59, 20);
            this.txtAprov.TabIndex = 6;
            this.txtAprov.Visible = false;
            // 
            // btnVer
            // 
            this.btnVer.Location = new System.Drawing.Point(322, 89);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(96, 37);
            this.btnVer.TabIndex = 3;
            this.btnVer.Text = "Analizar Notas";
            this.btnVer.UseVisualStyleBackColor = true;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // frmCalcularMedia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtAprov);
            this.Controls.Add(this.lblAprov);
            this.Controls.Add(this.txtExam);
            this.Controls.Add(this.lbExam);
            this.Controls.Add(this.txtRep);
            this.Controls.Add(this.lblRep);
            this.Controls.Add(this.lboxMedias);
            this.Controls.Add(this.btnVer);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtn4);
            this.Controls.Add(this.txtn3);
            this.Controls.Add(this.txtn2);
            this.Controls.Add(this.txtn1);
            this.Name = "frmCalcularMedia";
            this.Text = "frmCalcularMedia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtn1;
        private System.Windows.Forms.TextBox txtn2;
        private System.Windows.Forms.TextBox txtn3;
        private System.Windows.Forms.TextBox txtn4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.ListBox lboxMedias;
        private System.Windows.Forms.Label lblRep;
        private System.Windows.Forms.TextBox txtRep;
        private System.Windows.Forms.Label lbExam;
        private System.Windows.Forms.TextBox txtExam;
        private System.Windows.Forms.Label lblAprov;
        private System.Windows.Forms.TextBox txtAprov;
        private System.Windows.Forms.Button btnVer;
    }
}