namespace ListaFuncao
{
    partial class frmEx4
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
            this.lbPerg1 = new System.Windows.Forms.Label();
            this.txtResp1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.txtResp2 = new System.Windows.Forms.TextBox();
            this.lbPerg2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbPerg1
            // 
            this.lbPerg1.AutoSize = true;
            this.lbPerg1.Location = new System.Drawing.Point(12, 23);
            this.lbPerg1.Name = "lbPerg1";
            this.lbPerg1.Size = new System.Drawing.Size(504, 13);
            this.lbPerg1.TabIndex = 0;
            this.lbPerg1.Text = "Qual o nome do recurso no qual armazeno temporariamente um valor na memória RAM n" +
    "a programação? ";
            // 
            // txtResp1
            // 
            this.txtResp1.Location = new System.Drawing.Point(48, 55);
            this.txtResp1.Name = "txtResp1";
            this.txtResp1.Size = new System.Drawing.Size(147, 20);
            this.txtResp1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(222, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 20);
            this.button1.TabIndex = 2;
            this.button1.Text = "Avançar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(222, 133);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(75, 20);
            this.btn2.TabIndex = 5;
            this.btn2.Text = "Finalizar";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // txtResp2
            // 
            this.txtResp2.Location = new System.Drawing.Point(48, 134);
            this.txtResp2.Name = "txtResp2";
            this.txtResp2.Size = new System.Drawing.Size(147, 20);
            this.txtResp2.TabIndex = 4;
            // 
            // lbPerg2
            // 
            this.lbPerg2.AutoSize = true;
            this.lbPerg2.Location = new System.Drawing.Point(12, 102);
            this.lbPerg2.Name = "lbPerg2";
            this.lbPerg2.Size = new System.Drawing.Size(301, 13);
            this.lbPerg2.TabIndex = 3;
            this.lbPerg2.Text = "Uma variável do tipo decimal poderá receber um valor inteiro? ";
            // 
            // frmEx4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 319);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.txtResp2);
            this.Controls.Add(this.lbPerg2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtResp1);
            this.Controls.Add(this.lbPerg1);
            this.Name = "frmEx4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEx4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbPerg1;
        private System.Windows.Forms.TextBox txtResp1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.TextBox txtResp2;
        private System.Windows.Forms.Label lbPerg2;
    }
}