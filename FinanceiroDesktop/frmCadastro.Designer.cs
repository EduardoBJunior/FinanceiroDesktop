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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_entrar = new System.Windows.Forms.Button();
            this.txtb_RepetirSenha = new System.Windows.Forms.TextBox();
            this.txtb_Senha = new System.Windows.Forms.TextBox();
            this.tatb_Email = new System.Windows.Forms.TextBox();
            this.textb_nome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_entrar);
            this.groupBox1.Controls.Add(this.txtb_RepetirSenha);
            this.groupBox1.Controls.Add(this.txtb_Senha);
            this.groupBox1.Controls.Add(this.tatb_Email);
            this.groupBox1.Controls.Add(this.textb_nome);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(404, 270);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Faça seu Cadastro";
            // 
            // btn_entrar
            // 
            this.btn_entrar.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_entrar.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_entrar.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btn_entrar.Location = new System.Drawing.Point(283, 214);
            this.btn_entrar.Margin = new System.Windows.Forms.Padding(0);
            this.btn_entrar.Name = "btn_entrar";
            this.btn_entrar.Size = new System.Drawing.Size(101, 42);
            this.btn_entrar.TabIndex = 4;
            this.btn_entrar.Text = "Finalizar";
            this.btn_entrar.UseVisualStyleBackColor = false;
            // 
            // txtb_RepetirSenha
            // 
            this.txtb_RepetirSenha.Location = new System.Drawing.Point(144, 144);
            this.txtb_RepetirSenha.Name = "txtb_RepetirSenha";
            this.txtb_RepetirSenha.PasswordChar = '*';
            this.txtb_RepetirSenha.Size = new System.Drawing.Size(133, 24);
            this.txtb_RepetirSenha.TabIndex = 3;
            // 
            // txtb_Senha
            // 
            this.txtb_Senha.Location = new System.Drawing.Point(144, 109);
            this.txtb_Senha.Name = "txtb_Senha";
            this.txtb_Senha.PasswordChar = '*';
            this.txtb_Senha.Size = new System.Drawing.Size(133, 24);
            this.txtb_Senha.TabIndex = 2;
            // 
            // tatb_Email
            // 
            this.tatb_Email.Location = new System.Drawing.Point(144, 74);
            this.tatb_Email.Name = "tatb_Email";
            this.tatb_Email.Size = new System.Drawing.Size(239, 24);
            this.tatb_Email.TabIndex = 1;
            // 
            // textb_nome
            // 
            this.textb_nome.Location = new System.Drawing.Point(145, 39);
            this.textb_nome.Name = "textb_nome";
            this.textb_nome.Size = new System.Drawing.Size(239, 24);
            this.textb_nome.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "Repetir Senha :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Senha :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "E-mail :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome :";
            // 
            // frmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 294);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Financeiro : Cadastro";
            this.Load += new System.EventHandler(this.frmCadastro_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtb_RepetirSenha;
        private System.Windows.Forms.TextBox txtb_Senha;
        private System.Windows.Forms.TextBox tatb_Email;
        private System.Windows.Forms.TextBox textb_nome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_entrar;
    }
}