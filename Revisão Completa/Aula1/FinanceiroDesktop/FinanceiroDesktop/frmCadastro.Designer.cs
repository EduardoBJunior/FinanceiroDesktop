namespace FinanceiroDesktop
{
    partial class frmCadastro
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
            this.grpCad = new System.Windows.Forms.GroupBox();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRepSenha = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpCad.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpCad
            // 
            this.grpCad.Controls.Add(this.btnFinalizar);
            this.grpCad.Controls.Add(this.label5);
            this.grpCad.Controls.Add(this.txtEmail);
            this.grpCad.Controls.Add(this.label3);
            this.grpCad.Controls.Add(this.txtRepSenha);
            this.grpCad.Controls.Add(this.label4);
            this.grpCad.Controls.Add(this.txtSenha);
            this.grpCad.Controls.Add(this.label2);
            this.grpCad.Controls.Add(this.txtNome);
            this.grpCad.Controls.Add(this.label1);
            this.grpCad.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCad.Location = new System.Drawing.Point(0, 0);
            this.grpCad.Name = "grpCad";
            this.grpCad.Size = new System.Drawing.Size(360, 260);
            this.grpCad.TabIndex = 0;
            this.grpCad.TabStop = false;
            this.grpCad.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.BackColor = System.Drawing.Color.LimeGreen;
            this.btnFinalizar.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnFinalizar.Location = new System.Drawing.Point(237, 204);
            this.btnFinalizar.Margin = new System.Windows.Forms.Padding(0);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(91, 31);
            this.btnFinalizar.TabIndex = 4;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = false;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 18);
            this.label5.TabIndex = 2;
            this.label5.Text = "Faça seu Cadastro";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(128, 91);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(161, 24);
            this.txtEmail.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "E-mail :";
            // 
            // txtRepSenha
            // 
            this.txtRepSenha.Location = new System.Drawing.Point(128, 161);
            this.txtRepSenha.Name = "txtRepSenha";
            this.txtRepSenha.Size = new System.Drawing.Size(105, 24);
            this.txtRepSenha.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Repetir Senha :";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(128, 129);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(105, 24);
            this.txtSenha.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Senha :";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(128, 57);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(161, 24);
            this.txtNome.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome :";
            // 
            // frmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 263);
            this.Controls.Add(this.grpCad);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Financeiro : Cadastro ";
            this.grpCad.ResumeLayout(false);
            this.grpCad.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpCad;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRepSenha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnFinalizar;
    }
}