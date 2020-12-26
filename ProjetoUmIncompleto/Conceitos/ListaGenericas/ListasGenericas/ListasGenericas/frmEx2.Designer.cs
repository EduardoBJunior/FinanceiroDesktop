namespace ListasGenericas
{
    partial class frmEx2
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.lboxPar = new System.Windows.Forms.ListBox();
            this.lboxImpar = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(224, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Adicionar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Digite o Numero:";
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(105, 32);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(100, 20);
            this.txtNum.TabIndex = 2;
            // 
            // lboxPar
            // 
            this.lboxPar.FormattingEnabled = true;
            this.lboxPar.Location = new System.Drawing.Point(25, 116);
            this.lboxPar.Name = "lboxPar";
            this.lboxPar.Size = new System.Drawing.Size(120, 95);
            this.lboxPar.TabIndex = 3;
            // 
            // lboxImpar
            // 
            this.lboxImpar.FormattingEnabled = true;
            this.lboxImpar.Location = new System.Drawing.Point(192, 116);
            this.lboxImpar.Name = "lboxImpar";
            this.lboxImpar.Size = new System.Drawing.Size(120, 95);
            this.lboxImpar.TabIndex = 3;
            // 
            // frmEx2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 450);
            this.Controls.Add(this.lboxImpar);
            this.Controls.Add(this.lboxPar);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "frmEx2";
            this.Text = "frmEx2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.ListBox lboxPar;
        private System.Windows.Forms.ListBox lboxImpar;
    }
}