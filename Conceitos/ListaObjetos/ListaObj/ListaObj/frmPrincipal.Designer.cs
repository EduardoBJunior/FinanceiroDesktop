namespace ListaObj
{
    partial class frmPrincipal
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
            this.btnLstObjeto = new System.Windows.Forms.Button();
            this.btnEx1 = new System.Windows.Forms.Button();
            this.btnEx2 = new System.Windows.Forms.Button();
            this.btnEx3 = new System.Windows.Forms.Button();
            this.btnCrud = new System.Windows.Forms.Button();
            this.btnCrude2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLstObjeto
            // 
            this.btnLstObjeto.Location = new System.Drawing.Point(152, 13);
            this.btnLstObjeto.Name = "btnLstObjeto";
            this.btnLstObjeto.Size = new System.Drawing.Size(126, 42);
            this.btnLstObjeto.TabIndex = 0;
            this.btnLstObjeto.Text = "Exemplo List Objeto";
            this.btnLstObjeto.UseVisualStyleBackColor = true;
            this.btnLstObjeto.Click += new System.EventHandler(this.btnLstObjeto_Click);
            // 
            // btnEx1
            // 
            this.btnEx1.Location = new System.Drawing.Point(152, 61);
            this.btnEx1.Name = "btnEx1";
            this.btnEx1.Size = new System.Drawing.Size(126, 42);
            this.btnEx1.TabIndex = 1;
            this.btnEx1.Text = "ex1";
            this.btnEx1.UseVisualStyleBackColor = true;
            this.btnEx1.Click += new System.EventHandler(this.btnEx1_Click);
            // 
            // btnEx2
            // 
            this.btnEx2.Location = new System.Drawing.Point(152, 109);
            this.btnEx2.Name = "btnEx2";
            this.btnEx2.Size = new System.Drawing.Size(126, 42);
            this.btnEx2.TabIndex = 2;
            this.btnEx2.Text = "Ex2";
            this.btnEx2.UseVisualStyleBackColor = true;
            this.btnEx2.Click += new System.EventHandler(this.btnEx2_Click);
            // 
            // btnEx3
            // 
            this.btnEx3.Location = new System.Drawing.Point(152, 157);
            this.btnEx3.Name = "btnEx3";
            this.btnEx3.Size = new System.Drawing.Size(126, 42);
            this.btnEx3.TabIndex = 3;
            this.btnEx3.Text = "EX3";
            this.btnEx3.UseVisualStyleBackColor = true;
            this.btnEx3.Click += new System.EventHandler(this.btnEx3_Click);
            // 
            // btnCrud
            // 
            this.btnCrud.Location = new System.Drawing.Point(152, 205);
            this.btnCrud.Name = "btnCrud";
            this.btnCrud.Size = new System.Drawing.Size(126, 51);
            this.btnCrud.TabIndex = 4;
            this.btnCrud.Text = "CrudEx1";
            this.btnCrud.UseVisualStyleBackColor = true;
            this.btnCrud.Click += new System.EventHandler(this.btnCrud_Click);
            // 
            // btnCrude2
            // 
            this.btnCrude2.Location = new System.Drawing.Point(152, 258);
            this.btnCrude2.Name = "btnCrude2";
            this.btnCrude2.Size = new System.Drawing.Size(126, 51);
            this.btnCrude2.TabIndex = 5;
            this.btnCrude2.Text = "CrudEx2";
            this.btnCrude2.UseVisualStyleBackColor = true;
            this.btnCrude2.Click += new System.EventHandler(this.btnCrude2_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 340);
            this.Controls.Add(this.btnCrude2);
            this.Controls.Add(this.btnCrud);
            this.Controls.Add(this.btnEx3);
            this.Controls.Add(this.btnEx2);
            this.Controls.Add(this.btnEx1);
            this.Controls.Add(this.btnLstObjeto);
            this.Name = "frmPrincipal";
            this.Text = "frmPrincipal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLstObjeto;
        private System.Windows.Forms.Button btnEx1;
        private System.Windows.Forms.Button btnEx2;
        private System.Windows.Forms.Button btnEx3;
        private System.Windows.Forms.Button btnCrud;
        private System.Windows.Forms.Button btnCrude2;
    }
}